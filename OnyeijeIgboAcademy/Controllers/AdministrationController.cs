
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnyeijeIgboAcademy.Models;
using OnyeijeIgboAcademy.ViewModel;
using OnyeijeIgboAcademy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Controllers
{
    [Authorize(Roles = "GlobalAdmin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;

        }


        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
       
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string Id)
        {
            // var role = await  _roleManager.FindByIdAsync(TempData["roleId"].ToString());
            var role = await _roleManager.FindByIdAsync(Id);
            if (role == null)
            {
                ViewBag.Errormessage = $"Role with {Id}  cannot be found";
                return View("NotFound");
            }
            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel editRoleView)
        {
            // var role = await  _roleManager.FindByIdAsync(TempData["roleId"].ToString());
            var role = await _roleManager.FindByIdAsync(editRoleView.Id);
            if (role == null)
            {
                ViewBag.Errormessage = $"Role with {editRoleView.Id}  cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = editRoleView.RoleName;
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(role);
        }
        [HttpGet]
        public IActionResult FindRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FindRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.Errormessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }
            TempData["roleId"] = role.Id;
            return RedirectToAction("EditRole", new { role.Id });
        }
        [HttpGet]

        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.Errormessage = $"Role with {roleId}  cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();
            foreach (var user in _userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    Username = user.UserName
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }
                model.Add(userRoleViewModel);
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.Errormessage = $"User with {id}  cannot be found";
                return View("NotFound");
            }
            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);
            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.UserName,
                PhoneNumber = user.PhoneNumber,

                Claims = userClaims.Select(c => c.Type + " : " +  c.Value).ToList(),
                Roles = userRoles
            };


            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel viewModel)
        {

            var user = await _userManager.FindByIdAsync(viewModel.Id);
            if (user == null)
            {
                ViewBag.Errormessage = $"User with {viewModel.Id}  cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = viewModel.Email;
                user.UserName = viewModel.Username;
                user.PhoneNumber = viewModel.PhoneNumber;
                user.FirstName = viewModel.FirstName;
                user.LastName = viewModel.LastName;


                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.Errormessage = $"Role with {roleId}  cannot be found";
                return View("NotFound");
            }
            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {

                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }

                else
                {
                    continue;
                }
                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }
            return RedirectToAction("EditRole", new { Id = roleId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.Errormessage = $"Role with {id}  cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListUsers");
            }
        }
        [HttpPost]
        [Authorize(Policy = "DeleteRolePolicy" )]
        public async Task<IActionResult> DeleteRole(string id)
        {

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.Errormessage = $"Role with {id}  cannot be found";
                return View("NotFound");
            }
            else
            {
                try
                {
                    var result = await _roleManager.DeleteAsync(role);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListRoles");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View("ListRoles");

                }
                catch (Exception ex)
                {
                    ViewBag.ErrorTitle = $"Sorry the role name {role.Name} is in use";
                    ViewBag.ErrorMessage = $" {role.Name} cannot be deleted becase theres are at least one user in this role, consider removing users from the role before deleting role.";
                    return View("Error", ex);
                }
            }
        }
        [HttpGet]
        [Authorize (Policy = "EditRolePolicy")]
        public async Task<IActionResult> ManageUserRoles(string id)
        {

            ViewBag.userId = id;
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.Errormessage = $"user with {id}  cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRolesVM>();
            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new UserRolesVM
                {
                    RoleId = role.Id,
                    RoleNames = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.IsSelected = true;
                }
                else
                {
                    userRolesViewModel.IsSelected = false;
                }
                model.Add(userRolesViewModel);
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> ManageUserRoles(List<UserRolesVM> model, string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.Errormessage = $"user with {id}  cannot be found";
                return View("NotFound");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user from roles");
                return View(model);
            }
            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.IsSelected).Select(y => y.RoleNames));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add user to selected  roles");
                return View(model);
            }



            return RedirectToAction("EditUser", new { Id = id });
        }

        public async Task<IActionResult> ManageUserClaims(string userId)
        {
            ViewBag.userId = userId;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.Errormessage = $"user with {userId}  cannot be found";
                return View("NotFound");
            }

            var existingClaims = await _userManager.GetClaimsAsync(user);
            var model = new UserClaimsViewModel
            {
                UserId = userId
            };

            foreach (Claim claim in ClaimsStore.AllClaims)
            {
                UserClaim userClaim = new UserClaim
                {
                    ClaimType = claim.Type
                };

                if (existingClaims.Any(c => c.Type == claim.Type && c.Value == "true"))
                {
                    userClaim.IsSelected = true;
                }
                model.Claims.Add(userClaim);
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ManageUserClaims(UserClaimsViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                ViewBag.Errormessage = $"user with {model.UserId}  cannot be found";
                return View("NotFound");
            }

            var claims = await _userManager.GetClaimsAsync(user);
            var result = await _userManager.RemoveClaimsAsync(user, claims);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user from claims");
                return View(model);
            }
            result = await _userManager.AddClaimsAsync(user, model.Claims.Select(c => new Claim(c.ClaimType, c.IsSelected ? "true" : "false")));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected claims  to selected  user");
                return View(model);
            }
            return RedirectToAction("EditUser", new { Id = model.UserId });

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

            
    }

}
