#pragma checksum "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\Shared\ErrorMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5fb9365c51e9453dd640362919d6834b7842a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorMessage), @"mvc.1.0.view", @"/Views/Shared/ErrorMessage.cshtml")]
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
#line 1 "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\_ViewImports.cshtml"
using ExceptionsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\_ViewImports.cshtml"
using ExceptionsDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5fb9365c51e9453dd640362919d6834b7842a5f", @"/Views/Shared/ErrorMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37804d93ad67a92094f19f14d6bf41a9e8321e1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exception>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\Shared\ErrorMessage.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Custom Error occured.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n\r\n<p><strong>Message: </strong><code>");
#nullable restore
#line 10 "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\Shared\ErrorMessage.cshtml"
                              Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n<p><strong>StackTrace: </strong><code>");
#nullable restore
#line 11 "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\Shared\ErrorMessage.cshtml"
                                 Write(Model.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n<p><strong>Source: </strong><code>");
#nullable restore
#line 12 "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\Shared\ErrorMessage.cshtml"
                             Write(Model.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n<p><strong>GetBaseException: </strong><code>");
#nullable restore
#line 13 "C:\Ankit Patel\Lectures\RajBatch\ExceptionsDemo\ExceptionsDemo\Views\Shared\ErrorMessage.cshtml"
                                       Write(Model.GetBaseException());

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exception> Html { get; private set; }
    }
}
#pragma warning restore 1591
