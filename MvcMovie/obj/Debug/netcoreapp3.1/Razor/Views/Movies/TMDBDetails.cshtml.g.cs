#pragma checksum "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b954d7f91ad5eb5d3d00ba2c2d1a6fb9b0708fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_TMDBDetails), @"mvc.1.0.view", @"/Views/Movies/TMDBDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b954d7f91ad5eb5d3d00ba2c2d1a6fb9b0708fb", @"/Views/Movies/TMDBDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_TMDBDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TMDBDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Rating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/rating.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
      
    ViewData["Title"] = "Movie Details";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h1 class=\"my-4\">");
#nullable restore
#line 8 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                Write(Model.movieDetails.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-6\">\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 226, "\"", 327, 1);
#nullable restore
#line 12 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
WriteAttributeValue("", 232, Url.Content(String.Format("{0}{1}", ViewData["baseImageUrl"], Model.movieDetails.poster_path)), 232, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 328, "\"", 359, 1);
#nullable restore
#line 12 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
WriteAttributeValue("", 334, Model.movieDetails.title, 334, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n\r\n        <div class=\"col-md-6\">\r\n            <h3 class=\"my-3\">Storyline</h3>\r\n");
#nullable restore
#line 17 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
             if (Model.movieDetails.overview != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>");
#nullable restore
#line 18 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
            Write(Model.movieDetails.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
#nullable restore
#line 18 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                                  }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Sorry! Summary not present at the moment.</p>\r\n");
#nullable restore
#line 22 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"my-3\">Other Details</h3>\r\n            <ul>\r\n                <li>Release Date: ");
#nullable restore
#line 25 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                             Write(Model.movieDetails.release_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Rating: ");
#nullable restore
#line 26 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                       Write(Model.movieDetails.vote_average);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Genre: ");
#nullable restore
#line 27 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                            foreach (var item in Model.movieDetails.genres)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 29 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                 Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 29 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                       ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Running Time: ");
#nullable restore
#line 31 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                             Write(Model.movieDetails.runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</li>\r\n            </ul>\r\n        </div>\r\n\r\n    </div>\r\n    <br /><br />\r\n\r\n    <h3 class=\"my-4\">Similar Movies</h1>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 40 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
         foreach (var item in Model.similarMovies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <section class=\"fatured\" style=\"margin-bottom: 30px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b954d7f91ad5eb5d3d00ba2c2d1a6fb9b0708fb10526", async() => {
                WriteLiteral("<img class=\"product-img\"");
                BeginWriteAttribute("src", "\r\n                            src=\"", 1490, "\"", 1606, 1);
#nullable restore
#line 44 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
WriteAttributeValue("", 1525, Url.Content(String.Format("{0}{1}", ViewData["baseImageUrl"], item.poster_path)), 1525, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                            alt=\"", 1607, "\"", 1653, 1);
#nullable restore
#line 45 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
WriteAttributeValue("", 1642, item.title, 1642, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
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
            WriteLiteral("\r\n                </section>\r\n");
#nullable restore
#line 47 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <br /><br />\r\n    <div>\r\n        <section class=\"content-item\">\r\n\r\n            <div class=\"container\">\r\n\r\n                <div class=\"span6\" style=\"float: none; margin: \'0 auto\'\" ; }}>\r\n");
#nullable restore
#line 57 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                     if (ViewData["isLogin"] == "true")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b954d7f91ad5eb5d3d00ba2c2d1a6fb9b0708fb14328", async() => {
                WriteLiteral("\r\n                                <h3 class=\"pull-left\">Rate or Review Movie</h3>\r\n                                <div class=\"form-group\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b954d7f91ad5eb5d3d00ba2c2d1a6fb9b0708fb14770", async() => {
                    WriteLiteral("<h4>Rating</h4>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 63 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.review.Rating);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <div >\r\n                                        <span class=\"rating\">\r\n");
#nullable restore
#line 66 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                             for (int i = 1; i <= 5; i++)
                                            {
                                                var starClass = "star setStar";
                                                if (Model.review.Rating == 6 - i)
                                                {
                                                    starClass += " active";
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <span data-value=\"");
#nullable restore
#line 73 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                                              Write(6 - i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"");
                BeginWriteAttribute("class", " class=\"", 3026, "\"", 3044, 1);
#nullable restore
#line 73 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
WriteAttributeValue("", 3034, starClass, 3034, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>\r\n");
#nullable restore
#line 74 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </span>\r\n                                    </div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b954d7f91ad5eb5d3d00ba2c2d1a6fb9b0708fb18262", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 77 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.review.Rating);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <h4>Review</h4>
                                <fieldset>
                                    <div class=""row"">
                                        <textarea class=""form-control"" style=""font-family: cursive;font-size: 20px;color: red;"" id=""review"" name=""review"" placeholder=""Your Review""");
                BeginWriteAttribute("required", "\r\n                                        required=\"", 3665, "\"", 3717, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                    </div>
                                </fieldset>
                                <button type=""submit"" class=""btn btn-primary pull-right"">
                                    Submit
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2063, "/Movies/CreateReview?movieId=", 2063, 29, true);
#nullable restore
#line 60 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
AddHtmlAttributeValue("", 2092, Model.movieDetails.id, 2092, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 91 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3 style=\"margin-top: 9%;margin-bottom: 7%;\">Login or Signup to give a review</h3>\r\n");
#nullable restore
#line 95 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 97 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                     if (ViewData["hasReviews"] == "true")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>User Reviews</h3>\r\n");
#nullable restore
#line 100 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                         foreach (var item in Model.movieReviews)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"media\">\r\n                                <div class=\"media-body\">\r\n                                    <h4 class=\"media-heading\">");
#nullable restore
#line 104 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                                         Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <label>Rating</label>\r\n                                    <div>\r\n                                        <span class=\"rating\">\r\n");
#nullable restore
#line 108 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                             for (int i = 1; i <= 5; i++)
                                            {
                                                var starClass = "star";
                                                if (item.Rating == 6 - i)
                                                {
                                                    starClass += " active";
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span data-value=\"");
#nullable restore
#line 115 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                                              Write(6 - i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 5377, "\"", 5395, 1);
#nullable restore
#line 115 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
WriteAttributeValue("", 5385, starClass, 5385, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n");
#nullable restore
#line 116 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </span>\r\n                                    </div>\r\n                                    <p>");
#nullable restore
#line 119 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                  Write(item.MovieReview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <ul class=\"list-unstyled list-inline media-detail pull-left\">\r\n                                        <li>Date: ");
#nullable restore
#line 121 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                                             Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 125 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\srina\Downloads\MvcMovie\MvcMovie\Views\Movies\TMDBDetails.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b954d7f91ad5eb5d3d00ba2c2d1a6fb9b0708fb27649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies> Html { get; private set; }
    }
}
#pragma warning restore 1591
