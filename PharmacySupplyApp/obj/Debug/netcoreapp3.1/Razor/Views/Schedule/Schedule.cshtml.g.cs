#pragma checksum "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f182e1b971a04ab996b5a43a16324fb4ed9fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_Schedule), @"mvc.1.0.view", @"/Views/Schedule/Schedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f182e1b971a04ab996b5a43a16324fb4ed9fa3", @"/Views/Schedule/Schedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f7d2b9a9dd05595eaebdc7474da09f691e9df7", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_Schedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmacySupplyApp.Models.RepSchedule>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
  
    ViewData["Title"] = "Schedule";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table table-bordered table-hover mt-5\">\n    <thead  class=\"table-success\">\n        <tr>\n            <th>\n                ");
#nullable restore
#line 11 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.RepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 14 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 17 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.TreatingAilment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.Medicine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.MeetingSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.DateOfMeeting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 34 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 37 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.RepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.TreatingAilment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.Medicine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.MeetingSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 52 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfMeeting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 58 "D:\safe\PharmacySupplyApp\Views\Schedule\Schedule.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmacySupplyApp.Models.RepSchedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591