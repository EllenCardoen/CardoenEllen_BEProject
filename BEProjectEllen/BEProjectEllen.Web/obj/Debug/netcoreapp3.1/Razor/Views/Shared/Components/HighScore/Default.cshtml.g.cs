#pragma checksum "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85e6eba183757341dfd0feabb3a9af4980f67d91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HighScore_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HighScore/Default.cshtml")]
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
#line 1 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\_ViewImports.cshtml"
using BEProjectEllen.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\_ViewImports.cshtml"
using BEProjectEllen.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e6eba183757341dfd0feabb3a9af4980f67d91", @"/Views/Shared/Components/HighScore/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d266a980cdb4f139f5c5780083ceaa3ca86ff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HighScore_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BEProjectEllen.Core.UserQuiz>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/silver-cup.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("c-cup__item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/gold-cup.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("c-cup__item c-cup__item--gold "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/bronze-cup.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
  
    var list = Model.ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"c-scoreboard\">\r\n        <div class=\"c-cups\">\r\n            <div class=\"c-cup\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85e6eba183757341dfd0feabb3a9af4980f67d915559", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div>\r\n");
#nullable restore
#line 12 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                      
                        if (list.Count > 1)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                       Write(list[1].User.Email.Split("@")[0]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                                                             ;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"c-cup\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85e6eba183757341dfd0feabb3a9af4980f67d917722", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div>");
#nullable restore
#line 21 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                Write(list[0].User.Email.Split("@")[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n\r\n\r\n            <div class=\"c-cup\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85e6eba183757341dfd0feabb3a9af4980f67d919251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div>\r\n");
#nullable restore
#line 28 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                      
                        if (list.Count > 2)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                       Write(list[2].User.Email.Split("@")[0]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                                                             ;

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 36 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
         if (list.Count > 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""c-highscore-entries"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">EMAIL</th>
                            <th scope=""col"">DATE</th>
                            <th scope=""col"">SCORE</th>
                        </tr>
                    </thead>
                    <tbody>


");
#nullable restore
#line 51 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                         for (int i = 3; i < list.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 54 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                                Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td> ");
#nullable restore
#line 55 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                                Write(list[i].User.UserName.Split("@")[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>  ");
#nullable restore
#line 56 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                                 Write(list[i].Timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                               Write(list[i].EndScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n                </div>\r\n");
#nullable restore
#line 65 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Shared\Components\HighScore\Default.cshtml"
                }



                

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n        </div>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BEProjectEllen.Core.UserQuiz>> Html { get; private set; }
    }
}
#pragma warning restore 1591
