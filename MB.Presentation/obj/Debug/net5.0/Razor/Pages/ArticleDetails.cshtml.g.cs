#pragma checksum "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5ee33cd83db50da71728801217c5cd17499726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MB.Presentation.Pages.Pages_ArticleDetails), @"mvc.1.0.razor-page", @"/Pages/ArticleDetails.cshtml")]
namespace MB.Presentation.Pages
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
#line 1 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\_ViewImports.cshtml"
using MB.Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:long}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5ee33cd83db50da71728801217c5cd17499726", @"/Pages/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b38da4bac3d71ec8f91441de6278c54c63798384", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArticleDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ArticleDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("prev-post text-left d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("next-post text-right d-flex align-items-center justify-content-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("commenting-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
  
    var previousArticle = Model.Article.Id - 1;
    var nextArticle = Model.Article.Id + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"post blog-post col-lg-12\">\r\n    <div class=\"container\">\r\n        <div class=\"post-single\">\r\n            <div class=\"post-thumbnail\"><img");
            BeginWriteAttribute("src", " src=\"", 319, "\"", 345, 1);
#nullable restore
#line 10 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 325, Model.Article.Image, 325, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 346, "\"", 372, 1);
#nullable restore
#line 10 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 352, Model.Article.Title, 352, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 373, "\"", 401, 1);
#nullable restore
#line 10 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 381, Model.Article.Title, 381, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></div>\r\n            <div class=\"post-details\">\r\n                <div class=\"post-meta d-flex justify-content-between\">\r\n                    <div class=\"category\"><a href=\"#\">");
#nullable restore
#line 13 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                                                 Write(Model.Article.ArticleCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><a href=\"#\">Financial</a></div>\r\n                </div>\r\n                <h1>");
#nullable restore
#line 15 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<a href=""#""><i class=""fa fa-bookmark-o""></i></a></h1>
                <div class=""post-footer d-flex align-items-center flex-column flex-sm-row"">
                    <div class=""d-flex align-items-center flex-wrap"">
                        <div class=""date""><i class=""icon-clock""></i> ");
#nullable restore
#line 18 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                                                                Write(Model.Article.LasTimeSinceCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <div class=""views""><i class=""icon-eye""></i> 500</div>
                        <div class=""comments meta-last""><i class=""icon-comment""></i>12</div>
                    </div>
                </div>
                <div class=""post-body"">
                    <p class=""lead"">");
#nullable restore
#line 24 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                               Write(Model.Article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    ");
#nullable restore
#line 26 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"post-tags\"><a href=\"#\" class=\"tag\">#");
#nullable restore
#line 28 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                                                           Write(Model.Article.ArticleCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                <div class=\"posts-nav d-flex justify-content-between align-items-stretch flex-column flex-md-row\">\r\n");
#nullable restore
#line 30 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                     if (previousArticle != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5ee33cd83db50da71728801217c5cd1749972610949", async() => {
                WriteLiteral(@"
                            <div class=""icon prev""><i class=""fa fa-angle-left""></i></div>
                            <div class=""text"">
                                <strong class=""text-primary"">Previous Post </strong>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                                                         WriteLiteral(previousArticle);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                     if (Model.Article.Id < Model.LastArticle.Id)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5ee33cd83db50da71728801217c5cd1749972614007", async() => {
                WriteLiteral(@"
                            <div class=""text"">
                                <strong class=""text-primary"">Next Post </strong>
                            </div>
                            <div class=""icon next""><i class=""fa fa-angle-right"">   </i></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                                                         WriteLiteral(nextArticle);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Peyman\source\repos\MasterBlogger\MB.Presentation\Pages\ArticleDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""post-comments"">
                <header>
                    <h3 class=""h6"">Post Comments<span class=""no-of-comments"">(3)</span></h3>
                </header>
                <div class=""comment"">
                    <div class=""comment-header d-flex justify-content-between"">
                        <div class=""user d-flex align-items-center"">
                            <div class=""image"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed5ee33cd83db50da71728801217c5cd1749972617263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                            <div class=""title""><strong>Jabi Hernandiz</strong><span class=""date"">May 2016</span></div>
                        </div>
                    </div>
                    <div class=""comment-body"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                    </div>
                </div>
                <div class=""comment"">
                    <div class=""comment-header d-flex justify-content-between"">
                        <div class=""user d-flex align-items-center"">
                            <div class=""image""><img src=""img/user.svg"" alt=""..."" class=""img-fluid rounded-circle""></div>
                            <div class=""title""><strong>Nikolas</strong><span class=""date"">May 2016</span></div>
                        </div>
                    </div>
                    <div class=""comment-body"">
                     ");
            WriteLiteral(@"   <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                    </div>
                </div>
                <div class=""comment"">
                    <div class=""comment-header d-flex justify-content-between"">
                        <div class=""user d-flex align-items-center"">
                            <div class=""image""><img src=""img/user.svg"" alt=""..."" class=""img-fluid rounded-circle""></div>
                            <div class=""title""><strong>John Doe</strong><span class=""date"">May 2016</span></div>
                        </div>
                    </div>
                    <div class=""comment-body"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam.</p>
                    </div>
                </div>
            </div>
            <div class=");
            WriteLiteral("\"add-comment\">\r\n                <header>\r\n                    <h3 class=\"h6\">Leave a reply</h3>\r\n                </header>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5ee33cd83db50da71728801217c5cd1749972620767", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""form-group col-md-6"">
                            <input type=""text"" name=""username"" id=""username"" placeholder=""Name"" class=""form-control"">
                        </div>
                        <div class=""form-group col-md-6"">
                            <input type=""email"" name=""username"" id=""useremail"" placeholder=""Email Address (will not be published)"" class=""form-control"">
                        </div>
                        <div class=""form-group col-md-12"">
                            <textarea name=""usercomment"" id=""usercomment"" placeholder=""Type your comment"" class=""form-control""></textarea>
                        </div>
                        <div class=""form-group col-md-12"">
                            <button type=""submit"" class=""btn btn-secondary"">Submit Comment</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.Pages.ArticleDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.Pages.ArticleDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.Pages.ArticleDetailsModel>)PageContext?.ViewData;
        public MB.Presentation.Pages.ArticleDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591