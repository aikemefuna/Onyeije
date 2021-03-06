#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e55b22be834f3c0e30db8356362fcca29014dcae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_IntermediateCourses), @"mvc.1.0.view", @"/Views/Courses/IntermediateCourses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/IntermediateCourses.cshtml", typeof(AspNetCore.Views_Courses_IntermediateCourses))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e55b22be834f3c0e30db8356362fcca29014dcae", @"/Views/Courses/IntermediateCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361c2e507cd7abae36a5b99e3282ed4bac615644", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_IntermediateCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnyeijeIgboAcademy.Models.Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/onyeijemedia/logo12.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CourseDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
  
    ViewData["Title"] = "Mazi Ifeanyi Nwosu Igbo Academy | Intermediate Courses";
    Layout = "~/Views/Shared/_FrontEndLayout.cshtml";

#line default
#line hidden
            BeginContext(199, 1290, true);
            WriteLiteral(@"
<section id=""hero_in"" class=""courses"">
    <div class=""wrapper"">
        <div class=""container"">
            <h1 class=""fadeInUp""><span></span>Intermediate courses</h1>
        </div>
    </div>
</section>
<!--/hero_in-->
<div class=""filters_listing sticky_horizontal"">
    <div class=""container"">
        <ul class=""clearfix"">
            <li>
                <div class=""switch-field"">
                    <input type=""radio"" id=""all"" name=""listing_filter"" value=""all"" onclick=""all()"">
                    <label for=""all"">All</label>
                    <input type=""radio"" id=""beginner"" name=""listing_filter"" value=""popular"" onclick=""beginner()"">
                    <label for=""beginner"">Beginner</label>
                    <input type=""radio"" id=""intermediate"" name=""listing_filter"" value=""latest"" checked onclick=""intermediate()"">
                    <label for=""intermediate"">Intermediate</label>
                    <input type=""radio"" id=""advanced"" name=""listing_filter"" value=""advanced"" oncl");
            WriteLiteral(@"ick=""advanced()"">
                    <label for=""advanced"">Advanced</label>
                </div>
            </li>

        </ul>
    </div>
    <!-- /container -->
</div>
<!-- /filters -->

<div class=""container margin_60_35"">
    <div class=""row"">
");
            EndContext();
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
         if (Model.Count() > 0)
        {
            

#line default
#line hidden
#line 41 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
             foreach (var course in Model)
            {

#line default
#line hidden
            BeginContext(1592, 258, true);
            WriteLiteral(@"                <div class=""col-xl-4 col-lg-6 col-md-6"">
                    <div class=""box_grid wow"">
                        <figure class=""block-reveal"">
                            <div class=""block-horizzontal""></div>

                            ");
            EndContext();
            BeginContext(1850, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e55b22be834f3c0e30db8356362fcca29014dcae7869", async() => {
                BeginContext(1936, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e55b22be834f3c0e30db8356362fcca29014dcae8133", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                                                                                    WriteLiteral(course.CourseId);

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
            BeginContext(2009, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                             if (course.IsFree == true)
                            {

#line default
#line hidden
            BeginContext(2099, 63, true);
            WriteLiteral("                                <div class=\"price\">FREE</div>\r\n");
            EndContext();
#line 52 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2258, 51, true);
            WriteLiteral("                                <div class=\"price\">");
            EndContext();
            BeginContext(2310, 11, false);
#line 55 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                                              Write(course.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(2321, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 56 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                            }

#line default
#line hidden
            BeginContext(2360, 250, true);
            WriteLiteral("\r\n                            <div class=\"preview\"><span>Preview course</span></div>\r\n                        </figure>\r\n                        <div class=\"wrapper\">\r\n                            <small>Title</small>\r\n                            <h3>");
            EndContext();
            BeginContext(2611, 18, false);
#line 62 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                           Write(course.CourseTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2629, 38, true);
            WriteLiteral("</h3>\r\n                            <p>");
            EndContext();
            BeginContext(2668, 18, false);
#line 63 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                          Write(course.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2686, 123, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <ul>\r\n                            <li><pre>Course Duration:  ");
            EndContext();
            BeginContext(2810, 16, false);
#line 66 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                                                  Write(ViewBag.duration);

#line default
#line hidden
            EndContext();
            BeginContext(2826, 47, true);
            WriteLiteral("</pre></li>\r\n\r\n                            <li>");
            EndContext();
            BeginContext(2873, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e55b22be834f3c0e30db8356362fcca29014dcae14814", async() => {
                BeginContext(2959, 10, true);
                WriteLiteral("Enroll now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                                                                                        WriteLiteral(course.CourseId);

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
            BeginContext(2973, 90, true);
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 72 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
            }

#line default
#line hidden
#line 72 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(3114, 66, true);
            WriteLiteral("            <h2>O nweghi ihe oge a biko lee ma ghaa emechaa</h2>\r\n");
            EndContext();
#line 77 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
        }

#line default
#line hidden
            BeginContext(3191, 141, true);
            WriteLiteral("\r\n\r\n        <!-- /box_grid -->\r\n\r\n    </div>\r\n    <!-- /row -->\r\n\r\n</div>\r\n<script>\r\n         function all() {\r\n            location.href = \'");
            EndContext();
            BeginContext(3333, 31, false);
#line 88 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                        Write(Url.Action("Courses","Courses"));

#line default
#line hidden
            EndContext();
            BeginContext(3364, 90, true);
            WriteLiteral("\';\r\n          }\r\n</script>\r\n<script>\r\n    function beginner() {\r\n        location.href = \'");
            EndContext();
            BeginContext(3455, 39, false);
#line 93 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                    Write(Url.Action("BeginnerCourses","Courses"));

#line default
#line hidden
            EndContext();
            BeginContext(3494, 96, true);
            WriteLiteral("\';\r\n    }\r\n</script>\r\n\r\n<script>\r\n      function intermediate() {\r\n            location.href = \'");
            EndContext();
            BeginContext(3591, 43, false);
#line 99 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                        Write(Url.Action("IntermediateCourses","Courses"));

#line default
#line hidden
            EndContext();
            BeginContext(3634, 99, true);
            WriteLiteral("\';\r\n        }\r\n</script>\r\n\r\n<script>\r\n         function advanced() {\r\n            location.href = \'");
            EndContext();
            BeginContext(3734, 39, false);
#line 105 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Courses\IntermediateCourses.cshtml"
                        Write(Url.Action("AdvancedCourses","Courses"));

#line default
#line hidden
            EndContext();
            BeginContext(3773, 24, true);
            WriteLiteral("\';\r\n        }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnyeijeIgboAcademy.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
