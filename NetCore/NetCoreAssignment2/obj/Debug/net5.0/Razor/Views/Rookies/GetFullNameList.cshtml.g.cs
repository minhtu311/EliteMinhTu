#pragma checksum "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetFullNameList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d1dceec758e05b9a0c5e243524c06d2ef7ca63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_GetFullNameList), @"mvc.1.0.view", @"/Views/Rookies/GetFullNameList.cshtml")]
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
#line 1 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\_ViewImports.cshtml"
using NetCoreAssignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\_ViewImports.cshtml"
using NetCoreAssignment2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d1dceec758e05b9a0c5e243524c06d2ef7ca63", @"/Views/Rookies/GetFullNameList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee03dcf19ee289de9146bdf781c0f07f5240a23", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Rookies_GetFullNameList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetFullNameList.cshtml"
  
    ViewData["Title"] = "GetFullNameList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Full Name List</h1>\r\n<hr />\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Full name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 15 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetFullNameList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetFullNameList.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 20 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetFullNameList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
