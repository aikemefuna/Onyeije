#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "707105eb142769f9aaf167724aa7b3fc84048a8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_StudentDashboard), @"mvc.1.0.view", @"/Views/Dashboard/StudentDashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/StudentDashboard.cshtml", typeof(AspNetCore.Views_Dashboard_StudentDashboard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\_ViewImports.cshtml"
using OnyeijeIgboAcademy;

#line default
#line hidden
#line 2 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\_ViewImports.cshtml"
using OnyeijeIgboAcademy.Models;

#line default
#line hidden
#line 4 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707105eb142769f9aaf167724aa7b3fc84048a8b", @"/Views/Dashboard/StudentDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361c2e507cd7abae36a5b99e3282ed4bac615644", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_StudentDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-neutral"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyCourses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml"
  
    ViewData["Title"] = "StudentDashboard";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
            BeginContext(108, 913, true);
            WriteLiteral(@"<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">Dashboard</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Dashboard</li>
                        </ol>
                    </nav>
                </div>
                <div class=""col-md-6 col-5 text-right"">
                    ");
            EndContext();
            BeginContext(1021, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707105eb142769f9aaf167724aa7b3fc84048a8b6406", async() => {
                BeginContext(1108, 14, true);
                WriteLiteral("Update Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1126, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 24 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml"
             if (ViewBag.PasswordChanged == "Yes")
            {

#line default
#line hidden
            BeginContext(1239, 503, true);
            WriteLiteral(@"                <div class=""alert round bg-primary alert-icon-left alert-arrow-left alert-dismissible mb-2"" role=""alert"">
                    <span class=""alert-icon""><i class=""la la-thumbs-o-up""></i></span>
                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                    Congratulations!! your password has been updated succefully
                </div>
");
            EndContext();
#line 33 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(1757, 545, true);
            WriteLiteral(@"            <!-- Card stats -->
            <div class=""row"">
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card card-stats"">
                        <!-- Card body -->
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0"">Courses Subscribed</h5>
                                    <span class=""h2 font-weight-bold mb-0"">");
            EndContext();
            BeginContext(2303, 25, false);
#line 43 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml"
                                                                      Write(ViewBag.CoursesSubscribed);

#line default
#line hidden
            EndContext();
            BeginContext(2328, 505, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-gradient-red text-white rounded-circle shadow"">
                                        <i class=""ni ni-active-40""></i>
                                    </div>
                                </div>
                            </div>
                            <p class=""mt-3 mb-0 text-sm"">
                                ");
            EndContext();
            BeginContext(2833, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707105eb142769f9aaf167724aa7b3fc84048a8b10743", async() => {
                BeginContext(2884, 37, true);
                WriteLiteral("<span class=\"text-nowrap\">View</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2925, 592, true);
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card card-stats"">
                        <!-- Card body -->
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title text-uppercase text-muted mb-0"">Progress </h5>
                                    <span class=""h2 font-weight-bold mb-0"">");
            EndContext();
            BeginContext(3518, 26, false);
#line 64 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml"
                                                                      Write(ViewBag.ProgressPercentage);

#line default
#line hidden
            EndContext();
            BeginContext(3544, 1160, true);
            WriteLiteral(@" %</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-gradient-orange text-white rounded-circle shadow"">
                                        <i class=""ni ni-chart-pie-35""></i>
                                    </div>
                                </div>
                            </div>
                            <p class=""mt-3 mb-0 text-sm"">
                                <a><span class=""text-nowrap"">Congrats</span></a>
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card card-stats"">
                        <!-- Card body -->
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-");
            WriteLiteral("title text-uppercase text-muted mb-0\">Completed Topics</h5>\r\n                                    <span class=\"h2 font-weight-bold mb-0\">");
            EndContext();
            BeginContext(4705, 23, false);
#line 85 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml"
                                                                      Write(ViewBag.CompletedTopics);

#line default
#line hidden
            EndContext();
            BeginContext(4728, 1154, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-gradient-green text-white rounded-circle shadow"">
                                        <i class=""ni ni-money-coins""></i>
                                    </div>
                                </div>
                            </div>
                            <p class=""mt-3 mb-0 text-sm"">
                                <a><span class=""text-nowrap"">Great!</span></a>
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card card-stats"">
                        <!-- Card body -->
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h5 class=""card-title ");
            WriteLiteral("text-uppercase text-muted mb-0\">Completed Topics</h5>\r\n                                    <span class=\"h2 font-weight-bold mb-0\">");
            EndContext();
            BeginContext(5883, 23, false);
#line 106 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Dashboard\StudentDashboard.cshtml"
                                                                      Write(ViewBag.CompletedTopics);

#line default
#line hidden
            EndContext();
            BeginContext(5906, 1030, true);
            WriteLiteral(@"</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-gradient-green text-white rounded-circle shadow"">
                                        <i class=""ni ni-money-coins""></i>
                                    </div>
                                </div>
                            </div>
                            <p class=""mt-3 mb-0 text-sm"">
                                <a><span class=""text-nowrap"">Great!</span></a>
                            </p>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<!-- Page content -->
<div class=""container-fluid mt--12"">

    <!-- Footer -->

</div>

<script>
        window.setTimeout(function () {
            $("".alert"").fadeTo(1000, 0).slideUp(1000, function () {
                $(this).remove();
            });
        }, 12000);
</s");
            WriteLiteral("cript>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
