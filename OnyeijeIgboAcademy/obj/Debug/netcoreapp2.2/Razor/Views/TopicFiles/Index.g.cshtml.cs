#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c959f3bce164a106e7c5632a7ee77c25d94fa42f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TopicFiles_Index), @"mvc.1.0.view", @"/Views/TopicFiles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TopicFiles/Index.cshtml", typeof(AspNetCore.Views_TopicFiles_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c959f3bce164a106e7c5632a7ee77c25d94fa42f", @"/Views/TopicFiles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361c2e507cd7abae36a5b99e3282ed4bac615644", @"/Views/_ViewImports.cshtml")]
    public class Views_TopicFiles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnyeijeIgboAcademy.Models.TopicFiles>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TopicFiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Topics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-neutral"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TopiFiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 625, true);
            WriteLiteral(@"
<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">Files</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
                            <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(773, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c959f3bce164a106e7c5632a7ee77c25d94fa42f7881", async() => {
                BeginContext(824, 18, true);
                WriteLiteral("Upload Topic Files");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 262, true);
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Files</li>
                        </ol>
                    </nav>
                </div>
                <div class=""col-lg-6 col-5 text-right"">
                    ");
            EndContext();
            BeginContext(1108, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c959f3bce164a106e7c5632a7ee77c25d94fa42f9738", async() => {
                BeginContext(1185, 19, true);
                WriteLiteral("View list of Topics");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1208, 433, true);
            WriteLiteral(@"
                    <a href=""#"" class=""btn btn-sm btn-neutral"">Filters</a>
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
                    <h3 class=""mb-0"">Courses</h3>
");
            EndContext();
            BeginContext(1880, 793, true);
            WriteLiteral(@"                </div>
                <div class=""table-responsive py-4"">
                    <table class=""table table-flush"" id=""datatable-buttons"">
                        <thead class=""thead-light"">
                            <tr>
                                <th>File Name</th>
                                <th>Topic</th>
                                <th>Date Created</th>

                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>File Names</th>
                                <th>Topic</th>
                                <th>Date Created</th>
                            </tr>
                        </tfoot>
                        <tbody>
");
            EndContext();
#line 62 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2762, 167, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n\r\n                                       \r\n                                            ");
            EndContext();
            BeginContext(2930, 43, false);
#line 68 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(2973, 130, true);
            WriteLiteral("\r\n                                     \r\n                                    </td>\r\n\r\n\r\n                                    <td>  ");
            EndContext();
            BeginContext(3104, 46, false);
#line 73 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Topic.Title));

#line default
#line hidden
            EndContext();
            BeginContext(3150, 49, true);
            WriteLiteral("</td>\r\n                                    <td>  ");
            EndContext();
            BeginContext(3200, 46, false);
#line 74 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(3246, 645, true);
            WriteLiteral(@"</td>
                                   
                                    <td class=""text-right"">
                                        <div class=""dropdown"">
                                            <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                <i class=""fas fa-ellipsis-v""></i>
                                            </a>
                                            <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                                                ");
            EndContext();
            BeginContext(3891, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c959f3bce164a106e7c5632a7ee77c25d94fa42f15352", async() => {
                BeginContext(3958, 6, true);
                WriteLiteral("Update");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

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
            BeginContext(3968, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4121, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(4169, 367, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c959f3bce164a106e7c5632a7ee77c25d94fa42f17987", async() => {
                BeginContext(4260, 97, true);
                WriteLiteral("\r\n                                                    <button class=\"dropdown-item\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4357, "\"", 4462, 14);
                WriteAttributeValue("", 4367, "return", 4367, 6, true);
                WriteAttributeValue(" ", 4373, "confirm(\'Are", 4374, 13, true);
                WriteAttributeValue(" ", 4386, "you", 4387, 4, true);
                WriteAttributeValue(" ", 4390, "sure", 4391, 5, true);
                WriteAttributeValue(" ", 4395, "you", 4396, 4, true);
                WriteAttributeValue(" ", 4399, "want", 4400, 5, true);
                WriteAttributeValue(" ", 4404, "to", 4405, 3, true);
                WriteAttributeValue(" ", 4407, "delete", 4408, 7, true);
                WriteAttributeValue(" ", 4414, "the", 4415, 4, true);
                WriteAttributeValue(" ", 4418, "File", 4419, 5, true);
#line 85 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
WriteAttributeValue(" ", 4423, item.FileName, 4424, 14, false);

#line default
#line hidden
                WriteAttributeValue(" ", 4438, "for", 4439, 4, true);
#line 85 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
WriteAttributeValue(" ", 4442, item.Topic.Title, 4443, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 4460, "\')", 4460, 2, true);
                EndWriteAttribute();
                BeginContext(4463, 66, true);
                WriteLiteral(">Delete</button>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
                                                                                                                     WriteLiteral(item.Id);

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
            BeginContext(4536, 186, true);
            WriteLiteral("\r\n\r\n                                            </div>\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 92 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\TopicFiles\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4753, 146, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnyeijeIgboAcademy.Models.TopicFiles>> Html { get; private set; }
    }
}
#pragma warning restore 1591
