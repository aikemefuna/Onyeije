using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnyeijeIgboAcademy.DbContexts;
using OnyeijeIgboAcademy.Models;
using OnyeijeIgboAcademy.ViewModel;
using OnyeijeIgboAcademy.ViewModels;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace OnyeijeIgboAcademy.Controllers
{


    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        
        private readonly ILogger<AccountController> _logger;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
         
            ILogger<AccountController> logger, ApplicationDbContext context
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        
            _logger = logger;
            _context = context;
        }



        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            RegisterViewModel model = new RegisterViewModel
            {
                
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {

                    FirstName = viewModel.FullName,
                    UserName = viewModel.Email,
                    Email = viewModel.Email,
                    Declaration = viewModel.Privacy

                };
                var result = await _userManager.CreateAsync(user, viewModel.Password);


                if (result.Succeeded)
                {
                  
                 
                    var token = await  _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confrimationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);

                    var apiKey = "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";
                    var client = new SendGridClient(apiKey);
                    var from = new EmailAddress("noreply@maziifeanyinwosuigboacademy.com", "Mazi Ifeanyi Nwosu igbo Academy");
                    var subject = "Confirm your Email";
                    var to = new EmailAddress(user.Email, user.FullName);
                    var plainTextContent = $"Please click on the link below to confirm your email {confrimationLink} ";
                    var htmlContent = $"<strong>Please click on the button  link below to confirm your email</strong><br /> <hr /> {confrimationLink}";
                    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                    var response = await client.SendEmailAsync(msg);

                    _logger.Log(LogLevel.Warning, confrimationLink);
                    _logger.LogInformation("User created a new account with password.");

                    await _userManager.AddToRoleAsync(user, "Student");
                    ViewBag.Success = "Yes";
                  
                    return RedirectToAction("RegisterSuccess",new { email = user.Email});
                }
                foreach (var error in result.Errors)
                {
                    ViewBag.Success = "No";
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                foreach (var error in result.Errors)
                {
                    ViewBag.Success = "No";
                    ModelState.AddModelError("", error.Description);
                }
            }
            ViewBag.Success = "No";


            viewModel.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            return View(viewModel);
        }

      
        [AllowAnonymous]
        public async Task<IActionResult> CreatedUser(string id)
        {
            await Task.Delay(1500);
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", new { logout = "?"});
        }



        [AllowAnonymous]
        public async Task<IActionResult> Login(string k, string returnUrl, string s, string f, string e, string email, string d, string g, string z, string passreset, string logout )
        {
            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            if ((s == null && f == null && e == null && email ==  null && d == null && g == null && z == null && passreset == null && k == null && logout == null))
            {
                ViewBag.FirstLogin = 1;
            }
            if (s != null)
            {
                ViewBag.SessionExpired = "Yes";
            }
            if (e != null)
            {
                ViewBag.NotLoggedIn = "Yes";
            }
            if (email != null)
            {
                ViewBag.RegisterSuccess = "Yes";
                ViewBag.Email = email;
            }
            if (d != null)
            {
                ViewBag.currentUserEmail = d;
                ViewBag.StudentNotFound = "Yes";
            }
            if (f != null)
            {
                ViewBag.NotAuthenticated = "Yes";

            }
            if (g != null)
            {
                ViewBag.EmailConfirmed = "Yes";
            }
            if (z != null)
            {
                ViewBag.LoginAgain = "Yes";
            }

            if (passreset != null)
            {
                ViewBag.passreset = "Yes";
            }
            if (k != null)
            {
                ViewBag.EmailC = "Yes";
            }
            if (k != null)
            {
                ViewBag.EmailC = "Yes";
            }
            if (logout != null)
            {
                ViewBag.logout = 1;
            }
            return View(model);
        }

        public IActionResult RedirectToLogin (string returnUrl)
        {
           return RedirectToAction("Login", new { k = "?", returnUrl = returnUrl });
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel viewModel, string returnUrl)
        {
            viewModel.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                
                var user = await _userManager.FindByEmailAsync(viewModel.Email);
                if (user == null)
                {
                    var newuser = new ApplicationUser
                    {

                       
                        UserName = viewModel.Email,
                        Email = viewModel.Email,
                      
                       

                    };
                    var newuserresult = await _userManager.CreateAsync(newuser, viewModel.Password);


                    if (newuserresult.Succeeded)
                    {


                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(newuser);
                        var confrimationLink = Url.Action("ConfirmEmail", "Account", new { userId = newuser.Id, token = token, returnUrl = returnUrl }, Request.Scheme);

                        var apiKey = "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";
                        var client = new SendGridClient(apiKey);
                        var from = new EmailAddress("noreply@maziifeanyinwosuigboacademy.com", "Mazi Ifeanyi Nwosu igbo Academy");
                        var subject = "Confirm your Email";
                        var to = new EmailAddress(newuser.Email, newuser.FullName);
                        var plainTextContent = $"Please click on the link below to confirm your email Your Login Details are as follows  Email: {newuser.Email}  Password: {viewModel.Password} {confrimationLink} ";
                        var htmlContent = $"<strong>Welcome to Mazi Ifeanyi Nwosu Igbo Academy <br /> Your Login Details are as follows <br /> Email: {newuser.Email} <br /> Password: {viewModel.Password} <br /> Please click on the button  link below to confirm your email</strong><br /> <hr /> {confrimationLink}";
                        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                        var response = await client.SendEmailAsync(msg);

                        _logger.Log(LogLevel.Warning, confrimationLink);
                        _logger.LogInformation("User created a new account with password.");

                        await _userManager.AddToRoleAsync(newuser, "Student");
                        ViewBag.Success = "Yes";

                        return RedirectToAction("Login", new { email = newuser.Email, returnUrl = returnUrl });
                    }
                    foreach (var error in newuserresult.Errors)
                    {
                        ViewBag.Success = "No";
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    foreach (var error in newuserresult.Errors)
                    {
                        ViewBag.Success = "No";
                        ModelState.AddModelError("", error.Description);
                    }
                }
                if (user != null && !user.EmailConfirmed && (await _userManager.CheckPasswordAsync(user, viewModel.Password)))
                {
                    ModelState.AddModelError(string.Empty, "Email not confirmed yet");
                    return View(viewModel);
                }
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
                if (result.Succeeded)
                {
                    HttpContext.Session.SetString("currentUser", user.Email);

                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {

                        return Redirect(returnUrl);
                    }
                    else
                    {
                       
                        if (await _userManager.IsInRoleAsync(user, "GlobalAdmin"))
                        {
                            return RedirectToAction("AdminDashboard", "Dashboard");
                        }
                        else  
                        {
                            return RedirectToAction("StudentDashboard", "Dashboard");
                        }

                       
                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(viewModel);
        }

        [AcceptVerbs("Get", "Post")]

        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"email {email} is already in use");
            }
        }






        [AllowAnonymous]
        [HttpGet]
      
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {

            var RedirectUrl = Url.Action("ExternalLoginCallBack", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, RedirectUrl);
            return new ChallengeResult(provider, properties);

        }

        [AllowAnonymous]
        public async  Task<IActionResult> ExternalLoginCallBack(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider : {remoteError}");
                return RedirectToAction("Login", model);
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login information.");
                return RedirectToAction("Login", model);
            }
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            ApplicationUser user = null;

            if (email != null)
            {
                user = await _userManager.FindByEmailAsync(email);
                if (user != null && !user.EmailConfirmed)
                {
                    ModelState.AddModelError(string.Empty, "Email not confirmed yet");
                    return RedirectToAction("Login", model);
                }
            }

            var signInresult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (signInresult.Succeeded)
            {
                return RedirectToAction("StudentDashboard", "Dashboard");
            }

            else
            {
                if (email != null)
                {

                    if (user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email),

                        };
                        await _userManager.CreateAsync(user);
                        await _userManager.AddToRoleAsync(user, "Student");

                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var confrimationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);
                        var apiKey = "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";
                        var client = new SendGridClient(apiKey);
                        var from = new EmailAddress("noreply@maziifeanyinwosuigboacademy.com", "Mazi Ifeanyi Nwosu igbo Academy");
                        var subject = "Confirm your Email";
                        var to = new EmailAddress(user.Email, user.FullName);
                        var plainTextContent = $"Please click on the link below to confirm your email {confrimationLink} ";
                        var htmlContent = $"<strong>Please click on the button  link below to confirm your email</strong><br /> <hr /> {confrimationLink}";
                        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                        var response = await client.SendEmailAsync(msg);

                        _logger.Log(LogLevel.Warning, confrimationLink);
                        _logger.LogInformation("User created a new account with password.");

                        await _userManager.AddToRoleAsync(user, "Student");
                        ViewBag.RegisteredSuccess = "Yes";
                        return RedirectToAction("Login", new { email = email });

                    }
                    await _userManager.AddLoginAsync(user, info);
                    HttpContext.Session.SetString("currentUser", user.Email);
                    return RedirectToAction("Login");
                    
                }

                ViewBag.ErrorTitle = $"Email claim not recieved from : {info.LoginProvider}";
                ViewBag.ErrorMessage = $"Please contact support@onyeijeschool.com";
              return View("Error");
            }



        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token, string returnUrl)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Index", "HomeAts");
            }
            var user = await  _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage($"User with the id{userId} can not be found");
            }

           var result =  await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                var student = new Student
                {
                    StudentEmail = user.Email,
                    
                };
                _context.Student.Add(student);
               await  _context.SaveChangesAsync();
                ViewBag.returnUrl = returnUrl;
                return View();
            }
            ViewBag.ErrorTitle = "Email cannot be confirmed, contact support";
            return View("Error");
        }

      
        public IActionResult RegisterSuccess(string email)
        {
            if (email != null)
            {
                ViewBag.Email = email;
            }
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword ()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login", new {  z = "?"});
                }
                var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                      
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
                await _signInManager.RefreshSignInAsync(user);

                if (await _userManager.IsInRoleAsync(user, "GlobalAdmin"))
                {
                    return RedirectToAction("AdminDashboard","Dashboard", new { newp = "?" });
                }
                else
                {
                    return RedirectToAction("StudentDashboard", "Dashboard" ,new { newp = "?" });
                }
               
                
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword(string prs)
        {
            if (prs != null)
            {
                ViewBag.PasswordResetSuccess = "Yes";
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null && await _userManager.IsEmailConfirmedAsync(user))
                {
                    var token = await  _userManager.GeneratePasswordResetTokenAsync(user);
                    var passwordresetLink = Url.Action("ResetPassword", "Account", new { email = model.Email, token = token }, Request.Scheme);

                    var apiKey = "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";
                    var client = new SendGridClient(apiKey);
                    var from = new EmailAddress("noreply@maziifeanyinwosuigboacademy.com", "Mazi Ifeanyi Nwosu igbo Academy");
                    var subject = "Password Reset";
                    var to = new EmailAddress(user.Email, user.FullName);
                    var plainTextContent = $"Please click on the link below to reset your Password {passwordresetLink} ";
                    var htmlContent = $"<strong>Please click on the link below to reset your Password</strong><br /> <hr /> {passwordresetLink}";
                    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                    var response = await client.SendEmailAsync(msg);

                   
                    return RedirectToAction("ForgotPassword", new { prs = "?"});
                }
                return RedirectToAction("ForgotPassword", new { prs = "?" });
            }
            return View(model);
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword (string email, string token)
        {
            if (email == null || token == null)
            {
                ModelState.AddModelError("", "Invalid Password reset token");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login", new { passreset = "passwordresetsuccess" });
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
                return RedirectToAction("Login", new { passreset = "passwordresetsuccess" });
            }
            return View(model);
        }
    }
}