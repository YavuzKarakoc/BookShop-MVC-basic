#pragma checksum "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "177118b3a61391a015df8669336435d64f29b009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Detail), @"mvc.1.0.view", @"/Views/Book/Detail.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\_ViewImports.cshtml"
using BookShopMvcBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\_ViewImports.cshtml"
using BookShopMvcBasic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\_ViewImports.cshtml"
using BookShopMvcBasic.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177118b3a61391a015df8669336435d64f29b009", @"/Views/Book/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0dfb0aa06dbfbb60a3654238716a491ebb2cec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaveCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CommentDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-4\" style=\"display:flex; justify-content:center;\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 195, "", 220, 1);
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
WriteAttributeValue("", 200, ViewBag.Book.ImgUrl, 200, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:500px; width:400px;\" class=\"card-img-top\" alt=\"...\">\r\n            </div>\r\n\r\n            <div class=\"col-8\">\r\n                <div>\r\n                    <h4 class=\"card-title\">Kitap Adı : ");
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                                                  Write(ViewBag.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5 class=\"card-text\">Yazar Adı : ");
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                                                 Write(ViewBag.Book.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                     foreach (var kategori in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 class=\"card-text\">Türü : ");
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                                                Write(kategori.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n");
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                     foreach (var satici in ViewBag.Sellers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 class=\"card-text\">Satıcı : ");
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                                                  Write(satici.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n");
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"card-title\">Fiyatı :");
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                                              Write(ViewBag.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h3>\r\n                </div>\r\n                <div>\r\n                    <div class=\"form-floating\">\r\n                        <h4>Yorumlar</h4>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177118b3a61391a015df8669336435d64f29b0097907", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "177118b3a61391a015df8669336435d64f29b0098193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                                               WriteLiteral(ViewBag.Book.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <input type=\"text\" class=\"form-control\" style=\"width:500px; height:35px;\" name=\"Comment\">\r\n\r\n                            <input type=\"submit\" name=\"name\" value=\"Ekle\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <ul class=\"list-group\">\r\n");
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                             foreach (var yorum in ViewBag.Book.Comments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item\" style=\"width:500px\">\r\n                                    ");
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                               Write(yorum.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177118b3a61391a015df8669336435d64f29b00912889", async() => {
                WriteLiteral("\r\n                                    <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1877, "\"", 1894, 1);
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
WriteAttributeValue("", 1885, yorum.Id, 1885, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177118b3a61391a015df8669336435d64f29b00913631", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-trash-can\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\BookShopMvcBasic\BookShopMvcBasic\Views\Book\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaveCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591