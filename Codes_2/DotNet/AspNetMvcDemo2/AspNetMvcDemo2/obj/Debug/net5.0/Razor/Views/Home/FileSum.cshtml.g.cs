#pragma checksum "D:\Tiedostot\SARANEN_CODE_BOOTCAMP_Pohjanmaa\Codes_2\DotNet\AspNetMvcDemo2\AspNetMvcDemo2\Views\Home\FileSum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cded152122f6c558eca0486d344c1dafee8867e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FileSum), @"mvc.1.0.view", @"/Views/Home/FileSum.cshtml")]
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
#line 1 "D:\Tiedostot\SARANEN_CODE_BOOTCAMP_Pohjanmaa\Codes_2\DotNet\AspNetMvcDemo2\AspNetMvcDemo2\Views\_ViewImports.cshtml"
using AspNetMvcDemo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tiedostot\SARANEN_CODE_BOOTCAMP_Pohjanmaa\Codes_2\DotNet\AspNetMvcDemo2\AspNetMvcDemo2\Views\_ViewImports.cshtml"
using AspNetMvcDemo2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cded152122f6c558eca0486d344c1dafee8867e1", @"/Views/Home/FileSum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3c636b2edcd447dd6b6ba465469e6c97f553e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FileSum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tiedostot\SARANEN_CODE_BOOTCAMP_Pohjanmaa\Codes_2\DotNet\AspNetMvcDemo2\AspNetMvcDemo2\Views\Home\FileSum.cshtml"
  
    ViewData["Title"] = "File Sum";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\Tiedostot\SARANEN_CODE_BOOTCAMP_Pohjanmaa\Codes_2\DotNet\AspNetMvcDemo2\AspNetMvcDemo2\Views\Home\FileSum.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>This is sum of numbers from Numbers.txt: ");
#nullable restore
#line 6 "D:\Tiedostot\SARANEN_CODE_BOOTCAMP_Pohjanmaa\Codes_2\DotNet\AspNetMvcDemo2\AspNetMvcDemo2\Views\Home\FileSum.cshtml"
                                       Write(ViewBag.CalculatedSum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
