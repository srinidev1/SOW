#pragma checksum "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0e4f4b77b947da0bf3125ca57996342f6bab01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuration_ConfigValues), @"mvc.1.0.view", @"/Views/Configuration/ConfigValues.cshtml")]
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
#line 1 "C:\Learn\SOWWeb\SOWWeb\Views\_ViewImports.cshtml"
using SOWWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Learn\SOWWeb\SOWWeb\Views\_ViewImports.cshtml"
using SOWWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0e4f4b77b947da0bf3125ca57996342f6bab01", @"/Views/Configuration/ConfigValues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b19610671f3629326ceafdf0a327a1642ee93f", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuration_ConfigValues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SOWWeb.Models.LookupsVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h2 style=\"padding-bottom:5px;\">");
#nullable restore
#line 8 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
                                       Write(Model[i].LookupKey);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th style=""width:20%"">Lookup Id</th>
                        <th style=""width:50%"">Lookup Code</th>
                        <th style=""width:25%"">Lookup Value</th>
                    </tr>
                </thead>
                <tbody>
                    ");
#nullable restore
#line 18 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
               Write(Html.HiddenFor(m => m[i].LookupKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
                     for (int j = 0; j < Model[i].Values.Count; j++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 23 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
                           Write(Html.DisplayFor(m => m[i].Values[j].LookupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 26 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
                           Write(Html.DisplayFor(m => m[i].Values[j].LookupCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 29 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
                           Write(Html.DisplayFor(m => m[i].Values[j].LookupValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 32 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>     \r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Learn\SOWWeb\SOWWeb\Views\Configuration\ConfigValues.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SOWWeb.Models.LookupsVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
