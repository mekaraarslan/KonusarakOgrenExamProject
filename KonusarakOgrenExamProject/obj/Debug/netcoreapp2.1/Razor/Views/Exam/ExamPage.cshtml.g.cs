#pragma checksum "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0462c41896094f7e6a2b1c3a4b2a84c50755f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_ExamPage), @"mvc.1.0.view", @"/Views/Exam/ExamPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exam/ExamPage.cshtml", typeof(AspNetCore.Views_Exam_ExamPage))]
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
#line 1 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
using KonusarakOgrenExamProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0462c41896094f7e6a2b1c3a4b2a84c50755f4a", @"/Views/Exam/ExamPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4e09b19b8e16ed6545f5bfc2355a4324ab8d22", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_ExamPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Exam/Js/ExamPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
  
    ViewData["Title"] = "Sınav";

#line default
#line hidden
            BeginContext(97, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(115, 207, true);
                WriteLiteral("\r\n\r\n    <style>\r\n        a {\r\n            cursor: pointer;\r\n        }\r\n\r\n        .question{\r\n            margin-top:5vh\r\n        }\r\n        .question a{\r\n            margin-top:1vh\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(325, 55, true);
            WriteLiteral("\r\n<div style=\"margin-top: 10vh\" class=\"exam mx-auto\">\r\n");
            EndContext();
#line 25 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(412, 78, true);
            WriteLiteral("        <div id=\"examMessage\"></div>\r\n        <input type=\"hidden\" id=\"examId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 490, "\"", 513, 1);
#line 28 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 498, Model.ExamId, 498, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(514, 43, true);
            WriteLiteral(" />\r\n        <h1 style=\"text-align:center\">");
            EndContext();
            BeginContext(558, 11, false);
#line 29 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(569, 60, true);
            WriteLiteral("</h1>\r\n        <p style=\"text-align:center;margin-top:5vh;\">");
            EndContext();
            BeginContext(630, 13, false);
#line 30 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(643, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 32 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
         for (int i = 0; i < Model.ExamQuestions.Count; i++)
        {

#line default
#line hidden
            BeginContext(724, 160, true);
            WriteLiteral("            <div class=\"row\" style=\"margin-top:7vh;\">\r\n                <div class=\"col-xs-12 col-sm-12 col-md-6 col-lg-6 question\">\r\n                    <h4><b>");
            EndContext();
            BeginContext(886, 37, false);
#line 36 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                       Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(924, 6, true);
            WriteLiteral(")</b> ");
            EndContext();
            BeginContext(931, 31, false);
#line 36 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                                    Write(Model.ExamQuestions[i].Question);

#line default
#line hidden
            EndContext();
            BeginContext(962, 31, true);
            WriteLiteral("</h4>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 993, "\"", 1047, 2);
            WriteAttributeValue("", 998, "listGroup", 998, 9, true);
#line 37 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 1007, Model.ExamQuestions[i].QuestionNumber, 1007, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1048, 177, true);
            WriteLiteral(" class=\"list-group\">\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"A\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(1227, 37, false);
#line 40 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1265, 11, true);
            WriteLiteral("\"><b>A)</b>");
            EndContext();
            BeginContext(1277, 30, false);
#line 40 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                                                  Write(Model.ExamQuestions[i].AnswerA);

#line default
#line hidden
            EndContext();
            BeginContext(1307, 163, true);
            WriteLiteral("</a>\r\n\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"B\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(1472, 37, false);
#line 44 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 11, true);
            WriteLiteral("\"><b>B)</b>");
            EndContext();
            BeginContext(1522, 30, false);
#line 44 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                                                  Write(Model.ExamQuestions[i].AnswerB);

#line default
#line hidden
            EndContext();
            BeginContext(1552, 163, true);
            WriteLiteral("</a>\r\n\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"C\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(1717, 37, false);
#line 48 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1755, 42, true);
            WriteLiteral("\">\r\n                            <b>C)</b> ");
            EndContext();
            BeginContext(1798, 30, false);
#line 49 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i].AnswerC);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 189, true);
            WriteLiteral("\r\n                        </a>\r\n\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"D\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(2019, 37, false);
#line 54 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2057, 42, true);
            WriteLiteral("\">\r\n                            <b>D)</b> ");
            EndContext();
            BeginContext(2100, 30, false);
#line 55 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i].AnswerD);

#line default
#line hidden
            EndContext();
            BeginContext(2130, 191, true);
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-xs-12 col-sm-12 col-md-6 col-lg-6 question\">\r\n                    <h4><b>");
            EndContext();
            BeginContext(2323, 41, false);
#line 61 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                       Write(Model.ExamQuestions[i + 1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2365, 6, true);
            WriteLiteral(")</b> ");
            EndContext();
            BeginContext(2372, 35, false);
#line 61 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                                                        Write(Model.ExamQuestions[i + 1].Question);

#line default
#line hidden
            EndContext();
            BeginContext(2407, 31, true);
            WriteLiteral("</h4>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2438, "\"", 2494, 2);
            WriteAttributeValue("", 2443, "listGroup", 2443, 9, true);
#line 62 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 2452, Model.ExamQuestions[i+1].QuestionNumber, 2452, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2495, 177, true);
            WriteLiteral(" class=\"list-group\">\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"A\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(2674, 39, false);
#line 65 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2714, 42, true);
            WriteLiteral("\">\r\n                            <b>A)</b> ");
            EndContext();
            BeginContext(2757, 34, false);
#line 66 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerA);

#line default
#line hidden
            EndContext();
            BeginContext(2791, 189, true);
            WriteLiteral("\r\n                        </a>\r\n\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"B\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(2982, 39, false);
#line 71 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3022, 42, true);
            WriteLiteral("\">\r\n                            <b>B)</b> ");
            EndContext();
            BeginContext(3065, 34, false);
#line 72 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerB);

#line default
#line hidden
            EndContext();
            BeginContext(3099, 189, true);
            WriteLiteral("\r\n                        </a>\r\n\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"C\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(3290, 39, false);
#line 77 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3330, 42, true);
            WriteLiteral("\">\r\n                            <b>C)</b> ");
            EndContext();
            BeginContext(3373, 34, false);
#line 78 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerC);

#line default
#line hidden
            EndContext();
            BeginContext(3407, 189, true);
            WriteLiteral("\r\n                        </a>\r\n\r\n                        <a class=\"list-group-item list-group-item-action\"\r\n                           data-answer=\"D\"\r\n                           data-id=\"");
            EndContext();
            BeginContext(3598, 39, false);
#line 83 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                Write(Model.ExamQuestions[i+1].QuestionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3638, 42, true);
            WriteLiteral("\">\r\n                            <b>D)</b> ");
            EndContext();
            BeginContext(3681, 34, false);
#line 84 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
                                 Write(Model.ExamQuestions[i + 1].AnswerD);

#line default
#line hidden
            EndContext();
            BeginContext(3715, 136, true);
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3851, "\"", 3865, 1);
#line 89 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
WriteAttributeValue("", 3859, i++, 3859, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3866, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 90 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
        }

#line default
#line hidden
            BeginContext(3884, 277, true);
            WriteLiteral(@"        <div class=""form-row"">
            <div class=""form-group col-md-4 mx-auto"">
                <input type=""button"" class=""btn btn-success col-12 btn-lg mx-auto"" style=""margin-top:5vh;"" id=""btnExamControl"" value=""Sınavı Tamamla"" />
            </div>
        </div>
");
            EndContext();
#line 97 "C:\Users\MK-PC12\source\repos\mekaraarslan\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\ExamPage.cshtml"
    }

#line default
#line hidden
            BeginContext(4168, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4195, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(4203, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe42307a43d242e2a01813058d265eff", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4256, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
