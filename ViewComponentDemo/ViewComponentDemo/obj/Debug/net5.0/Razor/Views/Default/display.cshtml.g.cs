#pragma checksum "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d341249c25d28aefb1fa708b5aaae4b6038cc277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_display), @"mvc.1.0.view", @"/Views/Default/display.cshtml")]
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
#line 1 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\_ViewImports.cshtml"
using ViewComponentDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\_ViewImports.cshtml"
using ViewComponentDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d341249c25d28aefb1fa708b5aaae4b6038cc277", @"/Views/Default/display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65f0f9f40fb7e8677959e8b12c64ba5752c06356", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewComponentDemo.EDM.Tblemployee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
  
    ViewData["Title"] = "display";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function AddEmp() {
        $.ajax({
            url: ""/Default/Create"",
            success: function (data) {
                $(""#mybody"").html(data);
                $(""#myModal"").modal('show');
            }
        });
    }
</script>

<h1>display</h1>

<p>
    <button type=""button"" class=""btn btn-info"" onclick=""AddEmp();"">Create New</button>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 28 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.EmpId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.StateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Hobbies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayNameFor(model => model.Profileimg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 70 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmpId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.StateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hobbies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.DisplayFor(modelItem => item.Profileimg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 113 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 114 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 117 "C:\Ankit Patel\Lectures\RajBatch\ViewComponentDemo\ViewComponentDemo\Views\Default\display.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewComponentDemo.EDM.Tblemployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
