#pragma checksum "C:\Users\pmelech\source\repos\Nextech\Nextech\Views\HackerNews\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab97bed395c1159c8f84484d60bc29deb46dea11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HackerNews_Index), @"mvc.1.0.view", @"/Views/HackerNews/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab97bed395c1159c8f84484d60bc29deb46dea11", @"/Views/HackerNews/Index.cshtml")]
    public class Views_HackerNews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessLogic.Service_Contracts.NewsStory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pmelech\source\repos\Nextech\Nextech\Views\HackerNews\Index.cshtml"
  
    ViewData["Title"] = "Hacker News";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Top Stories</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\pmelech\source\repos\Nextech\Nextech\Views\HackerNews\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            WriteLiteral("\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 580, "\"", 601, 1);
#nullable restore
#line 27 "C:\Users\pmelech\source\repos\Nextech\Nextech\Views\HackerNews\Index.cshtml"
WriteAttributeValue("", 587, item.StoryURL, 587, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\pmelech\source\repos\Nextech\Nextech\Views\HackerNews\Index.cshtml"
                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> by ");
#nullable restore
#line 27 "C:\Users\pmelech\source\repos\Nextech\Nextech\Views\HackerNews\Index.cshtml"
                                                       Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\pmelech\source\repos\Nextech\Nextech\Views\HackerNews\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessLogic.Service_Contracts.NewsStory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
