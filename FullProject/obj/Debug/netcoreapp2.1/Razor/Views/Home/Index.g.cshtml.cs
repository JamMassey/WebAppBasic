#pragma checksum "/Users/demibrooke/Projects/Please/WorkPlease/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4ad62ebef233415f8beae57518f33f1a6b7bf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/demibrooke/Projects/Please/WorkPlease/Views/_ViewImports.cshtml"
using WorkPlease;

#line default
#line hidden
#line 2 "/Users/demibrooke/Projects/Please/WorkPlease/Views/_ViewImports.cshtml"
using WorkPlease.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4ad62ebef233415f8beae57518f33f1a6b7bf6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8ca8c388304d332f90c83758da847d7f7fc90a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkPlease.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/demibrooke/Projects/Please/WorkPlease/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(76, 19, true);
            WriteLiteral("<h2>Index</h2>\r\n<p>");
            EndContext();
            BeginContext(96, 14, false);
#line 6 "/Users/demibrooke/Projects/Please/WorkPlease/Views/Home/Index.cshtml"
Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(110, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(112, 14, false);
#line 6 "/Users/demibrooke/Projects/Please/WorkPlease/Views/Home/Index.cshtml"
              Write(Model.Password);

#line default
#line hidden
            EndContext();
            BeginContext(126, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkPlease.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
