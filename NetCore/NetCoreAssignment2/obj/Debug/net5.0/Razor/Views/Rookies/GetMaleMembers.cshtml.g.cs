#pragma checksum "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c7df390e796070576e6fa36bfff578885b01f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_GetMaleMembers), @"mvc.1.0.view", @"/Views/Rookies/GetMaleMembers.cshtml")]
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
#line 1 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
using NetCoreAssignment2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c7df390e796070576e6fa36bfff578885b01f4", @"/Views/Rookies/GetMaleMembers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee03dcf19ee289de9146bdf781c0f07f5240a23", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Rookies_GetMaleMembers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
  
    ViewData["Title"] = "GetMaleMembers";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Male Members</h1>
<hr/>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">First Name</th>
            <th scope=""col"">Last Name</th>
            <th scope=""col"">Gender</th>
            <th scope=""col"">Dob</th>
            <th scope=""col"">Phone Number</th>
            <th scope=""col"">Birth Place</th>
            <th scope=""col"">Graduated</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 27 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 28 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
                Write(item.Gender == true ? "Male" : "Female");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 32 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
               Write(item.Dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
               Write(item.BirthPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
               Write(item.IsGraduated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "E:\Study\EliteMinhTu\EliteMinhTu\NetCore\NetCoreAssignment2\Views\Rookies\GetMaleMembers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
