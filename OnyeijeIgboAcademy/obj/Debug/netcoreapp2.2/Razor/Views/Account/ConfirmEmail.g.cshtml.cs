#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b19bb98c366a5d05aa2d104e68f0c012a90294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConfirmEmail), @"mvc.1.0.view", @"/Views/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ConfirmEmail.cshtml", typeof(AspNetCore.Views_Account_ConfirmEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b19bb98c366a5d05aa2d104e68f0c012a90294", @"/Views/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361c2e507cd7abae36a5b99e3282ed4bac615644", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "RegisterSuccess";
    Layout = "_FrontEndLayout";
    var returnUrl = ViewBag.returnUrl;

#line default
#line hidden
            BeginContext(134, 650, true);
            WriteLiteral(@"<section id=""hero_in"" class=""cart_section"">
    <div class=""wrapper"">
        <div class=""container"">
            <div class=""bs-wizard clearfix"">
                <center>
                    <h5 class=""text-center""></h5>
                </center>
                 <div id=""confirm"">
                <h4>Email Confirmation Successful</h4>
                <pre>Email Confirmed Successfully<i>You will be redirected in </i>       <span id=""counter"">      10</span> second(s)</pre>
            </div>
            </div>
            <!-- End bs-wizard -->
           
        </div>
    </div>
</section>






<input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 784, "\"", 802, 1);
#line 34 "C:\Users\ROYALDOT\source\repos\OnyeijeIgboAcademy\OnyeijeIgboAcademy\Views\Account\ConfirmEmail.cshtml"
WriteAttributeValue("", 792, returnUrl, 792, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(803, 508, true);
            WriteLiteral(@" id=""returnUrl"" />

<script type=""text/javascript"">
    function countdown() {
      var returnUrl = $('#returnUrl').val();
        var i = document.getElementById('counter');
        if (parseInt(i.innerHTML) <= 0) {
            location.href = 'RedirectToLogin' + '?' + ""returnUrl"" + '=' + returnUrl;
        }
        if (parseInt(i.innerHTML) != 0) {
            i.innerHTML = parseInt(i.innerHTML) - 1;
        }
    }
    setInterval(function () { countdown(); }, 1000);
</script>



");
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
