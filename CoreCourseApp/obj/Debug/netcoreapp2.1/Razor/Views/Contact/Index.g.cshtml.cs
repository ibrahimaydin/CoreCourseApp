#pragma checksum "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ccff633784b8e50faaaadc3788fe687fcdd452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
#line 1 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\_ViewImports.cshtml"
using CoreCourseApp;

#line default
#line hidden
#line 2 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\_ViewImports.cshtml"
using CoreCourseApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ccff633784b8e50faaaadc3788fe687fcdd452", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd73c61bc28b3a0d54a6ceb7289693570c3e36b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Contact\Index.cshtml"
 foreach(var item in Model)
 {

#line default
#line hidden
            BeginContext(105, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(123, 10, false);
#line 9 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Contact\Index.cshtml"
   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(133, 31, true);
            WriteLiteral(" <br/>\r\n        <hr/>\r\n        ");
            EndContext();
            BeginContext(165, 10, false);
#line 11 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Contact\Index.cshtml"
   Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(175, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 13 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Contact\Index.cshtml"
 }

#line default
#line hidden
            BeginContext(191, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591