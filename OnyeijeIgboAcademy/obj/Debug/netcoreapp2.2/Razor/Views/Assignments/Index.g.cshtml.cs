#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f89ba1cfea56aaf640334c22cec2aaf6925d0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assignments_Index), @"mvc.1.0.view", @"/Views/Assignments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Assignments/Index.cshtml", typeof(AspNetCore.Views_Assignments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f89ba1cfea56aaf640334c22cec2aaf6925d0a", @"/Views/Assignments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361c2e507cd7abae36a5b99e3282ed4bac615644", @"/Views/_ViewImports.cshtml")]
    public class Views_Assignments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnyeijeIgboAcademy.Models.Assignment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Assignments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Topics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-neutral"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 527, true);
            WriteLiteral(@"

<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">Assignments</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(675, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f89ba1cfea56aaf640334c22cec2aaf6925d0a8102", async() => {
                BeginContext(733, 27, true);
                WriteLiteral("<i class=\"fas fa-home\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(764, 63, true);
            WriteLiteral("</li>\r\n                            <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(827, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f89ba1cfea56aaf640334c22cec2aaf6925d0a9765", async() => {
                BeginContext(879, 17, true);
                WriteLiteral("Create Assignment");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(900, 268, true);
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Assignments</li>
                        </ol>
                    </nav>
                </div>
                <div class=""col-lg-6 col-5 text-right"">
                    ");
            EndContext();
            BeginContext(1168, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f89ba1cfea56aaf640334c22cec2aaf6925d0a11626", async() => {
                BeginContext(1246, 12, true);
                WriteLiteral("Create Topic");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1262, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1284, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f89ba1cfea56aaf640334c22cec2aaf6925d0a13316", async() => {
                BeginContext(1363, 13, true);
                WriteLiteral("Create Course");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1380, 357, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container-fluid mt--6"">
    <!-- Table -->
    <div class=""row"">
        <div class=""col"">

            <div class=""card"">
                <!-- Card header -->
                <div class=""card-header"">
                    <h3 class=""mb-0"">Modules</h3>
");
            EndContext();
            BeginContext(1976, 1080, true);
            WriteLiteral(@"                </div>
                <div class=""table-responsive py-4"">
                    <table class=""table table-flush"" id=""datatable-buttons"">
                        <thead class=""thead-light"">
                            <tr>
                                <th>Description</th>
                                <th>Title</th>
                                <th>Status</th>
                                <th>Course</th>
                                <th>Date Created</th>

                                <th></th>

                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Description</th>
                                <th>Title</th>
                                <th>Status</th>
                                <th>Course</th>
                                <th>Date Created</th>
                                <th></th>
                            </tr>
           ");
            WriteLiteral("             </tfoot>\r\n                        <tbody>\r\n");
            EndContext();
#line 70 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(3145, 72, true);
            WriteLiteral("                            <tr>\r\n                                <td>  ");
            EndContext();
            BeginContext(3218, 46, false);
#line 73 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3264, 45, true);
            WriteLiteral("</td>\r\n                                <td>  ");
            EndContext();
            BeginContext(3310, 40, false);
#line 74 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(3350, 49, true);
            WriteLiteral("</td>\r\n\r\n\r\n                                <td>\r\n");
            EndContext();
#line 78 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                     if (item.IsEnabled == true)
                                    {

#line default
#line hidden
            BeginContext(3504, 385, true);
            WriteLiteral(@"                                        <button class=""btn btn-success"">
                                            <span class=""btn-label"">
                                                <i class=""nc-icon nc-check-2""></i>
                                            </span>
                                            Enabled
                                        </button>
");
            EndContext();
#line 86 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4009, 349, true);
            WriteLiteral(@"                                        <button class=""btn btn-pinterest"">
                                            <span class=""btn-label"">
                                                <i class=""nc-icon nc-simple-remove""></i>
                                            </span> Disabled
                                        </button>
");
            EndContext();
#line 94 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4397, 77, true);
            WriteLiteral("                                </td>\r\n                                <td>  ");
            EndContext();
            BeginContext(4475, 54, false);
#line 96 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Courses.CourseTitle));

#line default
#line hidden
            EndContext();
            BeginContext(4529, 45, true);
            WriteLiteral("</td>\r\n                                <td>  ");
            EndContext();
            BeginContext(4575, 46, false);
#line 97 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(4621, 584, true);
            WriteLiteral(@"</td>


                                <td class=""text-right"">
                                    <div class=""dropdown"">
                                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""fas fa-ellipsis-v""></i>
                                        </a>
                                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                                            ");
            EndContext();
            BeginContext(5205, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f89ba1cfea56aaf640334c22cec2aaf6925d0a21188", async() => {
                BeginContext(5282, 6, true);
                WriteLiteral("Update");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                                                                         WriteLiteral(item.AssignmentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5292, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5450, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(5494, 353, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f89ba1cfea56aaf640334c22cec2aaf6925d0a23827", async() => {
                BeginContext(5597, 93, true);
                WriteLiteral("\r\n                                                <button class=\"dropdown-item\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5690, "\"", 5777, 12);
                WriteAttributeValue("", 5700, "return", 5700, 6, true);
                WriteAttributeValue(" ", 5706, "confirm(\'Are", 5707, 13, true);
                WriteAttributeValue(" ", 5719, "you", 5720, 4, true);
                WriteAttributeValue(" ", 5723, "sure", 5724, 5, true);
                WriteAttributeValue(" ", 5728, "you", 5729, 4, true);
                WriteAttributeValue(" ", 5732, "want", 5733, 5, true);
                WriteAttributeValue(" ", 5737, "to", 5738, 3, true);
                WriteAttributeValue(" ", 5740, "delete", 5741, 7, true);
                WriteAttributeValue(" ", 5747, "the", 5748, 4, true);
                WriteAttributeValue(" ", 5751, "Assignments", 5752, 12, true);
#line 109 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
WriteAttributeValue(" ", 5763, item.Title, 5764, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 5775, "\')", 5775, 2, true);
                EndWriteAttribute();
                BeginContext(5778, 62, true);
                WriteLiteral(">Delete</button>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                                                                                                                   WriteLiteral(item.AssignmentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5847, 170, true);
            WriteLiteral("\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 116 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Assignments\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(6048, 146, true);
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnyeijeIgboAcademy.Models.Assignment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
