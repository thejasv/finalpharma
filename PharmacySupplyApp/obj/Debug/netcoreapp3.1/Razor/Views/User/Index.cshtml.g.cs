#pragma checksum "D:\safe\PharmacySupplyApp\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6172530c3bcc03a0dbaf28fba6a38645401653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#nullable restore
#line 1 "D:\safe\PharmacySupplyApp\Views\_ViewImports.cshtml"
using PharmacySupplyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\safe\PharmacySupplyApp\Views\_ViewImports.cshtml"
using PharmacySupplyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\safe\PharmacySupplyApp\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Razor.Language.Intermediate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6172530c3bcc03a0dbaf28fba6a38645401653", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f7d2b9a9dd05595eaebdc7474da09f691e9df7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\safe\PharmacySupplyApp\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container border my-5"">
    <div class=""row p-5"">
        <div class=""col-12 justify-content-center""><h3>Schedule Representative Meeting</h3></div>
        <div class=""col-12""><p>You can schedule meeting between medical representatives and doctors for the next 5 working days</p></div>
        <div class=""col-12"">");
#nullable restore
#line 10 "D:\safe\PharmacySupplyApp\Views\User\Index.cshtml"
                       Write(Html.ActionLink("Schedule Meeting", "Index", "Schedule", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    </div>
</div>
<div class=""container border my-5"">
    <div class=""row p-5"">
        <div class=""col-12 justify-content-center""><h3>Get Supply</h3></div>
        <div class=""col-12""><p>You can get the supply that need to be distributed to  pharmacies based on demand provided and stock available</p></div>
        <div class=""col-12"">");
#nullable restore
#line 17 "D:\safe\PharmacySupplyApp\Views\User\Index.cshtml"
                       Write(Html.ActionLink("Supply Medicine", "Index", "Demand", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n</div>\n\n");
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
