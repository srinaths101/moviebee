#pragma checksum "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfb81f8daaccaf3acc1ae48e4a5b982fd40e02ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchMovie), @"mvc.1.0.view", @"/Views/Home/SearchMovie.cshtml")]
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
#line 1 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb81f8daaccaf3acc1ae48e4a5b982fd40e02ad", @"/Views/Home/SearchMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TMDBMovie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TMDBDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
  
  ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
 if (ViewData["isData"] == "true")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h1 style=\"margin-top: 9%;margin-bottom: 7%;\">Search Results for ");
#nullable restore
#line 9 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
                                                              Write(ViewData["searchStr"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <section class=\"fatured\" style=\"margin-bottom: 30px;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfb81f8daaccaf3acc1ae48e4a5b982fd40e02ad4813", async() => {
                WriteLiteral("<img class=\"product-img\"");
                BeginWriteAttribute("src", "\r\n            src=\"", 445, "\"", 545, 1);
#nullable restore
#line 15 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
WriteAttributeValue("", 464, Url.Content(String.Format("{0}{1}", ViewData["baseImageUrl"], item.poster_path)), 464, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 546, "\"", 563, 1);
#nullable restore
#line 15 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
WriteAttributeValue("", 552, item.title, 552, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
                                                              WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </section>\r\n");
#nullable restore
#line 17 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n");
#nullable restore
#line 20 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3 style=\"margin-top: 9%;margin-bottom: 7%;\">");
#nullable restore
#line 23 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
                                           Write(ViewData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 24 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\SearchMovie.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br /><br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TMDBMovie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
