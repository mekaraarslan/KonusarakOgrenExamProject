#pragma checksum "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8e3187473df80c883d858d9d17f44b0ef722761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_List), @"mvc.1.0.view", @"/Views/Exam/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exam/List.cshtml", typeof(AspNetCore.Views_Exam_List))]
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
#line 1 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
using KonusarakOgrenExamProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3187473df80c883d858d9d17f44b0ef722761", @"/Views/Exam/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4e09b19b8e16ed6545f5bfc2355a4324ab8d22", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Exam>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Exam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
  
    ViewData["Title"] = "Sınavlar";

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(124, 92, true);
                WriteLiteral("\r\n\r\n    <style>\r\n        .examList {\r\n            margin-top: 5%;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(219, 28, true);
            WriteLiteral("\r\n<div class=\"examList\">\r\n\r\n");
            EndContext();
#line 19 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
     if (Model != null)
    {
        if (Model.Count > 0)
        {

#line default
#line hidden
            BeginContext(320, 399, true);
            WriteLiteral(@"            <table class=""table table-sm table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"">Sınav No</th>
                        <th scope=""col"">Başlık</th>
                        <th scope=""col"">Tarih</th>
                        <th scope=""col"">İşlem</th>
                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 34 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
                     foreach (var exam in Model)
                    {

#line default
#line hidden
            BeginContext(792, 98, true);
            WriteLiteral("                        <tr style=\"cursor:pointer;\">\r\n                            <th scope=\"row\">");
            EndContext();
            BeginContext(891, 11, false);
#line 37 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
                                       Write(exam.ExamId);

#line default
#line hidden
            EndContext();
            BeginContext(902, 38, true);
            WriteLiteral("</th>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 940, "\"", 1026, 3);
            WriteAttributeValue("", 950, "window.location.href=\'", 950, 22, true);
#line 38 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
WriteAttributeValue("", 972, Url.Action("ExamPage","Exam",new { id=exam.ExamId }), 972, 53, false);

#line default
#line hidden
            WriteAttributeValue("", 1025, "\'", 1025, 1, true);
            EndWriteAttribute();
            BeginContext(1027, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1029, 10, false);
#line 38 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
                                                                                                                  Write(exam.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1079, 16, false);
#line 39 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
                           Write(exam.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 38, true);
            WriteLiteral("</td>\r\n                            <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1133, "\"", 1169, 3);
            WriteAttributeValue("", 1143, "RemoveExam(", 1143, 11, true);
#line 40 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
WriteAttributeValue("", 1154, exam.ExamId, 1154, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1168, ")", 1168, 1, true);
            EndWriteAttribute();
            BeginContext(1170, 255, true);
            WriteLiteral(">\r\n                                <a>\r\n                                    <i style=\"color:red;\" class=\"fa fa-trash-o fa-2x\" aria-hidden=\"true\"></i>\r\n                                </a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
                    }

#line default
#line hidden
            BeginContext(1448, 50, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 50 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1534, 235, true);
            WriteLiteral("            <div class=\"jumbotron\">\r\n                <h1 class=\"display-4\">Kayıtlı sınav bulunmuyor!</h1>\r\n                <p class=\"lead\">Yeni bir sınav eklemek için aşağıda bulunan \"Sınav Ekle\" butonuna basınız.</p>\r\n                ");
            EndContext();
            BeginContext(1769, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "935f55101c734f88a3625f44731f3161", async() => {
                BeginContext(1856, 10, true);
                WriteLiteral("Sınav Ekle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1870, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 58 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(1927, 219, true);
            WriteLiteral("        <div class=\"jumbotron\">\r\n            <h1 class=\"display-4\">Kayıtlı sınav bulunmuyor!</h1>\r\n            <p class=\"lead\">Yeni bir sınav eklemek için aşağıda bulunan \"Sınav Ekle\" butonuna basınız.</p>\r\n            ");
            EndContext();
            BeginContext(2146, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42fcd55a09d54cd88713f7382350b3e5", async() => {
                BeginContext(2233, 10, true);
                WriteLiteral("Sınav Ekle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2247, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 67 "C:\Users\MK-PC12\Desktop\AYIKLA\EXAM PROJECT\KonusarakOgrenExamProject\KonusarakOgrenExamProject\Views\Exam\List.cshtml"
    }

#line default
#line hidden
            BeginContext(2272, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2299, 648, true);
                WriteLiteral(@"
    <script>
        function RemoveExam(examId) {
            Swal.fire({
                title: '',
                text: ""Sınav kalıcı olarak silinecek. Onaylıyor musunuz?"",
                icon: 'question',
                showCancelButton: true,
                cancelButtonText: ""Hayır"",
                confirmButtonColor: '#d33',
                cancelButtonColor: '#3085d6',
                confirmButtonText: 'Evet, Sil!'
            }).then((result) => {
                if (result.value) {
                    window.location.href = '/Exam/Remove/' + examId;
                }
            })
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(2950, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
