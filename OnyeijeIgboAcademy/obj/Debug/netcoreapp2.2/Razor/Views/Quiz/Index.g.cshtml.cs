#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcf137ec2752d0c4215014c925f0dd5da9bb9b1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quiz/Index.cshtml", typeof(AspNetCore.Views_Quiz_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf137ec2752d0c4215014c925f0dd5da9bb9b1f", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361c2e507cd7abae36a5b99e3282ed4bac615644", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnyeijeIgboAcademy.Models.Questions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Topics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTopicQuiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 528, true);
            WriteLiteral(@"
<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0""> Question Bank</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(673, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcf137ec2752d0c4215014c925f0dd5da9bb9b1f7276", async() => {
                BeginContext(731, 27, true);
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
            BeginContext(762, 63, true);
            WriteLiteral("</li>\r\n                            <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(825, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcf137ec2752d0c4215014c925f0dd5da9bb9b1f8939", async() => {
                BeginContext(871, 6, true);
                WriteLiteral("Topics");
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
            BeginContext(881, 531, true);
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Question Bank</li>
                        </ol>
                    </nav>
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
                    <h3 class=""mb-0"">Topics</h3>
");
            EndContext();
            BeginContext(1651, 1156, true);
            WriteLiteral(@"                </div>
                <div class=""table-responsive py-4"">
                    <table class=""table table-flush"" id=""datatable-buttons"">
                        <thead class=""thead-light"">
                            <tr>

                                <th> Question</th>
                                <th> Course</th>
                               
                                <th>Module</th>
                                <th>Topic</th>

                                <th>Correct Answer</th>


                                <th></th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>

                                <th> Question</th>
                                <th> Course</th>
                             
                                <th>Module</th>
                                <th>Topic</th>

                                <th>Correct Answer</th>

             ");
            WriteLiteral("                   <th></th>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
            EndContext();
#line 75 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2896, 74, true);
            WriteLiteral("                            <tr>\r\n\r\n                                <td>  ");
            EndContext();
            BeginContext(2971, 23, false);
#line 79 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                                 Write(Html.Raw(item.Question));

#line default
#line hidden
            EndContext();
            BeginContext(2994, 82, true);
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                   ");
            EndContext();
            BeginContext(3077, 14, false);
#line 82 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                              Write(ViewBag.course);

#line default
#line hidden
            EndContext();
            BeginContext(3091, 156, true);
            WriteLiteral(" <br />\r\n                                  \r\n                                </td>\r\n                                <td>\r\n                                  ");
            EndContext();
            BeginContext(3248, 14, false);
#line 86 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                             Write(ViewBag.module);

#line default
#line hidden
            EndContext();
            BeginContext(3262, 86, true);
            WriteLiteral(" <br />\r\n                                </td>\r\n                                <td>  ");
            EndContext();
            BeginContext(3349, 46, false);
#line 88 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Topic.Title));

#line default
#line hidden
            EndContext();
            BeginContext(3395, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3477, 46, false);
#line 90 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.RightAnswer));

#line default
#line hidden
            EndContext();
            BeginContext(3523, 618, true);
            WriteLiteral(@"
                                </td>


                                <td class=""text-right"">
                                    <div class=""dropdown"">
                                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""fas fa-ellipsis-v""></i>
                                        </a>
                                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                                            ");
            EndContext();
            BeginContext(4141, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcf137ec2752d0c4215014c925f0dd5da9bb9b1f15729", async() => {
                BeginContext(4222, 6, true);
                WriteLiteral("Update");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                                                                                                  WriteLiteral(item.QuestId);

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
            BeginContext(4232, 90, true);
            WriteLiteral("\r\n                                          \r\n                                            ");
            EndContext();
            BeginContext(4322, 338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcf137ec2752d0c4215014c925f0dd5da9bb9b1f18311", async() => {
                BeginContext(4413, 93, true);
                WriteLiteral("\r\n                                                <button class=\"dropdown-item\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4506, "\"", 4590, 12);
                WriteAttributeValue("", 4516, "return", 4516, 6, true);
                WriteAttributeValue(" ", 4522, "confirm(\'Are", 4523, 13, true);
                WriteAttributeValue(" ", 4535, "you", 4536, 4, true);
                WriteAttributeValue(" ", 4539, "sure", 4540, 5, true);
                WriteAttributeValue(" ", 4544, "you", 4545, 4, true);
                WriteAttributeValue(" ", 4548, "want", 4549, 5, true);
                WriteAttributeValue(" ", 4553, "to", 4554, 3, true);
                WriteAttributeValue(" ", 4556, "delete", 4557, 7, true);
                WriteAttributeValue(" ", 4563, "the", 4564, 4, true);
                WriteAttributeValue(" ", 4567, "Topic", 4568, 6, true);
#line 103 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
WriteAttributeValue(" ", 4573, item.Question, 4574, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 4588, "\')", 4588, 2, true);
                EndWriteAttribute();
                BeginContext(4591, 62, true);
                WriteLiteral(">Delete</button>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                                                                                                            WriteLiteral(item.QuestId);

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
            BeginContext(4660, 170, true);
            WriteLiteral("\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 110 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Quiz\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4861, 146, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnyeijeIgboAcademy.Models.Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591