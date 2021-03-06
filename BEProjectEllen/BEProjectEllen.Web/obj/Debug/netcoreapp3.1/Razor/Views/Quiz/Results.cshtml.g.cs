#pragma checksum "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "129a5fc17161131a7706bdfcee40097a5f9aa0db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Results), @"mvc.1.0.view", @"/Views/Quiz/Results.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129a5fc17161131a7706bdfcee40097a5f9aa0db", @"/Views/Quiz/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d266a980cdb4f139f5c5780083ceaa3ca86ff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BEProjectEllen.Core.UserQuiz>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
  
    ViewData["Title"] = "Results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"c-board\">\r\n\r\n    <h1>Results</h1>\r\n\r\n\r\n\r\n    ");
#nullable restore
#line 13 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
Write(await Component.InvokeAsync("HighScore", new { QuizId = Model.QuizId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Title</th>
                <th scope=""col"">CORRECT?</th>
                <th scope=""col"">SCORE</th>
                <th scope=""col"">Image</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 28 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
             foreach (var userChoice in Model.UserChoices)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 33 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
                   Write(userChoice.Choice.Question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <td> ");
#nullable restore
#line 35 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
                    Write(userChoice.Choice.IsCorrect);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 36 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
                   Write(userChoice.Choice.Question.ScoreValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 38 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
                         if (userChoice.Choice.ImageUrl != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"c-choiceImage\"");
            BeginWriteAttribute("src", " src=\"", 1034, "\"", 1067, 1);
#nullable restore
#line 40 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
WriteAttributeValue("", 1040, userChoice.Choice.ImageUrl, 1040, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1068, "\"", 1113, 3);
            WriteAttributeValue("", 1074, "Image", 1074, 5, true);
            WriteAttributeValue(" ", 1079, "of", 1080, 3, true);
#nullable restore
#line 40 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
WriteAttributeValue(" ", 1082, userChoice.Choice.Description, 1083, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 41 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\Results.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BEProjectEllen.Core.UserQuiz> Html { get; private set; }
    }
}
#pragma warning restore 1591
