#pragma checksum "D:\safe\PharmacySupplyApp\Views\Shared\Unauthorized.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2938d5e1c005ddd966316559db49379a8613144c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Unauthorized), @"mvc.1.0.view", @"/Views/Shared/Unauthorized.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2938d5e1c005ddd966316559db49379a8613144c", @"/Views/Shared/Unauthorized.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f7d2b9a9dd05595eaebdc7474da09f691e9df7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Unauthorized : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\safe\PharmacySupplyApp\Views\Shared\Unauthorized.cshtml"
  
    ViewData["Title"] = "Unauthorized";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"jumbotron\" style=\"height: 100vh\">\n    <div class=\"container\">\n        <div class=\"card text-center\">\n            <h1>Unauthorized</h1>\n            <h4>You are not authorized to view this page</h4>\n        </div>\n    </div>\n</div>\n");
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
