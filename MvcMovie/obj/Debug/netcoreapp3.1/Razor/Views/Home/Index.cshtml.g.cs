#pragma checksum "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7db6c1e8b2dd0c82d4df88334f019ae6a7fa9ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7db6c1e8b2dd0c82d4df88334f019ae6a7fa9ad", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/download.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("225"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("225"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TMDBDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   <div>\r\n                <h1 style=\"margin-top:10%;margin-bottom: 5%\">Movie Bee let\'s you:</h1>\r\n                <div class=\"row\">\r\n                    <div class=\"column\" style=\"background-color:#aaa;\">\r\n\t\t            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7db6c1e8b2dd0c82d4df88334f019ae6a7fa9ad5699", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p>Review Your Favourite movies with a like</p>\r\n                    </div>\r\n                    <div class=\"column\" style=\"background-color:#bbb;\">\r\n\t\t            <img src=\"images/share_android-512.jpg\" width=\"225\" height=\"225\"");
            BeginWriteAttribute("alt", " alt=\"", 693, "\"", 699, 0);
            EndWriteAttribute();
            WriteLiteral(@"/>
                    <p> Write And Share Reviews</p>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""column"" style=""background-color:#ccc;"">
                    <img src=""images/download1.jpg"" width=""225"" height=""225""");
            BeginWriteAttribute("alt", " alt=\"", 995, "\"", 1001, 0);
            EndWriteAttribute();
            WriteLiteral(@"/>
                    <p>Rate Each Film on a five-star scale</p>
                    </div>
                    <div class=""column"" style=""background-color:#ddd;"">
                    <img src=""images/recommended-icon-line-label-recommended-vector-28138175.jpg"" width=""225"" height=""225""");
            BeginWriteAttribute("alt", " alt=\"", 1293, "\"", 1299, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                    <p>Get List of Recommended movies For you</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
 if (ViewData["isError"] == "false")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <section class=\"product-images\">\r\n");
#nullable restore
#line 36 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
             if (ViewData["isRecommended"] == "true")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"containers-feature\">\r\n\r\n                    <h1 style=\"margin-top: 7%;margin-bottom: 7%;\">Recommended Movies for you</h1>\r\n");
#nullable restore
#line 41 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                     foreach (var item in Model.Item4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <section class=\"fatured\" style=\"margin-bottom: 30px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7db6c1e8b2dd0c82d4df88334f019ae6a7fa9ad9497", async() => {
                WriteLiteral("<img class=\"product-img\"");
                BeginWriteAttribute("src", "\r\n                                    src=\"", 2059, "\"", 2183, 1);
#nullable restore
#line 45 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 2102, Url.Content(String.Format("{0}{1}", ViewData["baseImageUrl"], item.poster_path)), 2102, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                                    alt=\"", 2184, "\"", 2238, 1);
#nullable restore
#line 46 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 2227, item.title, 2227, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n                        </section>\r\n");
#nullable restore
#line 48 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"containers-feature\">\r\n                    <h1 style=\"margin-top: 30%;margin-bottom: 7%;\">Top Rated Movies</h1>\r\n");
#nullable restore
#line 52 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                     foreach (var item in Model.Item1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <section class=\"fatured\" style=\"margin-bottom: 30px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7db6c1e8b2dd0c82d4df88334f019ae6a7fa9ad13522", async() => {
                WriteLiteral("<img class=\"product-img\"");
                BeginWriteAttribute("src", "\r\n                                    src=\"", 2758, "\"", 2882, 1);
#nullable restore
#line 56 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 2801, Url.Content(String.Format("{0}{1}", ViewData["baseImageUrl"], item.poster_path)), 2801, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                                    alt=\"", 2883, "\"", 2937, 1);
#nullable restore
#line 57 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 2926, item.title, 2926, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n                        </section>\r\n");
#nullable restore
#line 59 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"containers-feature\">\r\n                    <h1 style=\"margin-top: 30%;margin-bottom: 7%;\">Popular Movies</h1>\r\n");
#nullable restore
#line 64 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                     foreach (var item in Model.Item2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <section class=\"fatured\" style=\"margin-bottom: 30px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7db6c1e8b2dd0c82d4df88334f019ae6a7fa9ad17550", async() => {
                WriteLiteral("<img class=\"product-img\"");
                BeginWriteAttribute("src", "\r\n                                    src=\"", 3457, "\"", 3581, 1);
#nullable restore
#line 68 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 3500, Url.Content(String.Format("{0}{1}", ViewData["baseImageUrl"], item.poster_path)), 3500, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                                    alt=\"", 3582, "\"", 3636, 1);
#nullable restore
#line 69 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 3625, item.title, 3625, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n                        </section>\r\n");
#nullable restore
#line 71 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"containers-feature\">\r\n                    <h1 style=\"margin-top: 30%;margin-bottom: 7%;\">Upcoming Movies</h1>\r\n");
#nullable restore
#line 76 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                     foreach (var item in Model.Item3)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <section class=\"fatured\" style=\"margin-bottom: 30px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7db6c1e8b2dd0c82d4df88334f019ae6a7fa9ad21579", async() => {
                WriteLiteral("<img class=\"product-img\"");
                BeginWriteAttribute("src", "\r\n                                    src=\"", 4157, "\"", 4281, 1);
#nullable restore
#line 80 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 4200, Url.Content(String.Format("{0}{1}", ViewData["baseImageUrl"], item.poster_path)), 4200, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                                    alt=\"", 4282, "\"", 4336, 1);
#nullable restore
#line 81 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
WriteAttributeValue("", 4325, item.title, 4325, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n                        </section>\r\n");
#nullable restore
#line 83 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 86 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
                         
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 127 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
         
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"margin-top: 9%;margin-bottom: 7%;\">Problem Occured while fetching data.</h3>\r\n");
#nullable restore
#line 132 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
