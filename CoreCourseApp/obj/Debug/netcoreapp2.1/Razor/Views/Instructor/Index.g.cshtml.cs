#pragma checksum "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Instructor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bdb019131ac0c02ab5402a4f1096fb9047b973f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_Index), @"mvc.1.0.view", @"/Views/Instructor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructor/Index.cshtml", typeof(AspNetCore.Views_Instructor_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdb019131ac0c02ab5402a4f1096fb9047b973f", @"/Views/Instructor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd73c61bc28b3a0d54a6ceb7289693570c3e36b", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Instructor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Instructor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(73, 87, true);
            WriteLiteral("\r\n<div class=\"m-4\">\r\n    <div class=\"bg-success text-white p-4\">Instructor List</div>\r\n");
            EndContext();
#line 8 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Instructor\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(201, 66, true);
            WriteLiteral("        <div class=\"bg-primary text-white p-2 mt-3\">\r\n            ");
            EndContext();
            BeginContext(268, 9, false);
#line 11 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Instructor\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(277, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 13 "C:\Users\Can\Desktop\CoreCourseApp\CoreCourseApp\Views\Instructor\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(302, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Instructor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
