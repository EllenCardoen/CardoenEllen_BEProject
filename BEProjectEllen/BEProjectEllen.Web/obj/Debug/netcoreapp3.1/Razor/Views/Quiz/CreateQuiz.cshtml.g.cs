#pragma checksum "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0439416fc7561a4d2de146e994e79b95c919d012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_CreateQuiz), @"mvc.1.0.view", @"/Views/Quiz/CreateQuiz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0439416fc7561a4d2de146e994e79b95c919d012", @"/Views/Quiz/CreateQuiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d266a980cdb4f139f5c5780083ceaa3ca86ff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_CreateQuiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BEProjectEllen.Core.Quiz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateQuiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
  
    ViewData["Title"] = "CreateQuiz";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"c-title\">CreateQuiz</h1>\r\n\r\n    <div class=\"c-form\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0439416fc7561a4d2de146e994e79b95c919d0125751", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0439416fc7561a4d2de146e994e79b95c919d0126021", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 12 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group c-group-size\">\r\n                <label class=\"control-label\">Quiz Title</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0439416fc7561a4d2de146e994e79b95c919d0127860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 15 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0439416fc7561a4d2de146e994e79b95c919d0129483", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 17 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Difficulty</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0439416fc7561a4d2de146e994e79b95c919d01211315", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 22 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DifficultyId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.DifficultyId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n");
#nullable restore
#line 25 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
             for (int i = 0; i < 10; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 962, "\"", 986, 3);
                WriteAttributeValue("", 968, "question[", 968, 9, true);
#nullable restore
#line 28 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 977, i, 977, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 979, "]-title", 979, 7, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\">Question</label>\r\n                    <input");
                BeginWriteAttribute("name", " name=\"", 1054, "\"", 1080, 3);
                WriteAttributeValue("", 1061, "Questions[", 1061, 10, true);
#nullable restore
#line 29 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1071, i, 1071, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1073, "].Title", 1073, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1081, "\"", 1104, 3);
                WriteAttributeValue("", 1086, "question[", 1086, 9, true);
#nullable restore
#line 29 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1095, i, 1095, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1097, "]-title", 1097, 7, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-large\" placeholder=\"Question\" />\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1267, "\"", 1294, 3);
                WriteAttributeValue("", 1273, "question[", 1273, 9, true);
#nullable restore
#line 33 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1282, i, 1282, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1284, "]-ImageUrl", 1284, 10, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\">ImageUrl</label>\r\n                    <input");
                BeginWriteAttribute("name", " name=\"", 1362, "\"", 1391, 3);
                WriteAttributeValue("", 1369, "Questions[", 1369, 10, true);
#nullable restore
#line 34 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1379, i, 1379, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1381, "].ImageUrl", 1381, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1392, "\"", 1418, 3);
                WriteAttributeValue("", 1397, "question[", 1397, 9, true);
#nullable restore
#line 34 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1406, i, 1406, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1408, "]-ImageUrl", 1408, 10, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-large\" placeholder=\"ImageUrl for question\" />\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1594, "\"", 1618, 3);
                WriteAttributeValue("", 1600, "question[", 1600, 9, true);
#nullable restore
#line 38 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1609, i, 1609, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1611, "]-score", 1611, 7, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\">Score for question</label>\r\n                    <input");
                BeginWriteAttribute("name", " name=\"", 1696, "\"", 1722, 3);
                WriteAttributeValue("", 1703, "Questions[", 1703, 10, true);
#nullable restore
#line 39 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1713, i, 1713, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1715, "].Score", 1715, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1723, "\"", 1746, 3);
                WriteAttributeValue("", 1728, "question[", 1728, 9, true);
#nullable restore
#line 39 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 1737, i, 1737, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1739, "]-score", 1739, 7, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-large\" placeholder=\"Score\" />\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"c-form-choices\">\r\n");
#nullable restore
#line 43 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
                     for (int y = 0; y < 4; y++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group c-form-choices\">\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 2056, "\"", 2084, 4);
                WriteAttributeValue("", 2062, "questions-", 2062, 10, true);
#nullable restore
#line 46 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2072, i, 2072, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2074, "-choice-", 2074, 8, true);
#nullable restore
#line 46 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2082, y, 2082, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\"></label>\r\n                            <input");
                BeginWriteAttribute("name", " name=\"", 2152, "\"", 2196, 5);
                WriteAttributeValue("", 2159, "Questions[", 2159, 10, true);
#nullable restore
#line 47 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2169, i, 2169, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2171, "].Choices[", 2171, 10, true);
#nullable restore
#line 47 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2181, y, 2181, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2183, "].Description", 2183, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2197, "\"", 2224, 4);
                WriteAttributeValue("", 2202, "questions-", 2202, 10, true);
#nullable restore
#line 47 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2212, i, 2212, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2214, "-choice-", 2214, 8, true);
#nullable restore
#line 47 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2222, y, 2222, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" value=\"Answer\" />\r\n                        </div>\r\n");
#nullable restore
#line 49 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
                WriteLiteral("                <div class=\"c-form-choices\">\r\n");
#nullable restore
#line 53 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
                     for (int y = 0; y < 4; y++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group c-form-choices\">\r\n                            <label");
                BeginWriteAttribute("for", " for=\"", 2565, "\"", 2590, 4);
                WriteAttributeValue("", 2571, "choice-", 2571, 7, true);
#nullable restore
#line 56 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2578, i, 2578, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2580, "-choice-", 2580, 8, true);
#nullable restore
#line 56 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2588, y, 2588, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\"></label>\r\n                            <input");
                BeginWriteAttribute("name", " name=\"", 2658, "\"", 2699, 5);
                WriteAttributeValue("", 2665, "Questions[", 2665, 10, true);
#nullable restore
#line 57 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2675, i, 2675, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2677, "].Choices[", 2677, 10, true);
#nullable restore
#line 57 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2687, y, 2687, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2689, "].ImageUrl", 2689, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2700, "\"", 2727, 4);
                WriteAttributeValue("", 2705, "questions-", 2705, 10, true);
#nullable restore
#line 57 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2715, i, 2715, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2717, "-choice-", 2717, 8, true);
#nullable restore
#line 57 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
WriteAttributeValue("", 2725, y, 2725, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" value=\"Optional ImageUrl\" />\r\n                        </div>\r\n");
#nullable restore
#line 59 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 61 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0439416fc7561a4d2de146e994e79b95c919d01227675", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 74 "D:\Desktop\School\Backend\CardoenEllen_BEProject\BEProjectEllen\BEProjectEllen.Web\Views\Quiz\CreateQuiz.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BEProjectEllen.Core.Quiz> Html { get; private set; }
    }
}
#pragma warning restore 1591
