#pragma checksum "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08505bbee73aeb6dce5f26cd4291eb044ab125f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculos_PDF), @"mvc.1.0.view", @"/Views/Curriculos/PDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curriculos/PDF.cshtml", typeof(AspNetCore.Views_Curriculos_PDF))]
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
#line 1 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\_ViewImports.cshtml"
using CurriculoMvc;

#line default
#line hidden
#line 2 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\_ViewImports.cshtml"
using CurriculoMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08505bbee73aeb6dce5f26cd4291eb044ab125f0", @"/Views/Curriculos/PDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26118e554aecec14fa0f5ed32869f11d4a7c7edf", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculos_PDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CurriculoMvc.ViewModels.CurriculoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(74, 24, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(98, 360, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08505bbee73aeb6dce5f26cd4291eb044ab125f04571", async() => {
                BeginContext(104, 299, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Currículo</title>
    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
    ");
                EndContext();
                BeginContext(403, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08505bbee73aeb6dce5f26cd4291eb044ab125f05262", async() => {
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
                EndContext();
                BeginContext(450, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(458, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(459, 1280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08505bbee73aeb6dce5f26cd4291eb044ab125f07387", async() => {
                BeginContext(465, 57, true);
                WriteLiteral("\n\n    <h5>Objetivos</h5>\n    <hr />\n    <p>\n        <ul>\n");
                EndContext();
#line 21 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
             foreach (var item in Model.Objetivos)
            {

#line default
#line hidden
                BeginContext(587, 41, true);
                WriteLiteral("                <li>\n                    ");
                EndContext();
                BeginContext(629, 14, false);
#line 24 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
               Write(item.Descrição);

#line default
#line hidden
                EndContext();
                BeginContext(643, 23, true);
                WriteLiteral("\n                </li>\n");
                EndContext();
#line 26 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
            }

#line default
#line hidden
                BeginContext(680, 90, true);
                WriteLiteral("        </ul>\n    </p>\n\n    <h5>Formações Acadêmicas</h5>\n    <hr />\n    <p>\n        <ul>\n");
                EndContext();
#line 34 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
             foreach (var item in Model.FormacoesAcademicas)
            {

#line default
#line hidden
                BeginContext(845, 41, true);
                WriteLiteral("                <li>\n                    ");
                EndContext();
                BeginContext(887, 19, false);
#line 37 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
               Write(item.TipoCurso.Tipo);

#line default
#line hidden
                EndContext();
                BeginContext(906, 4, true);
                WriteLiteral(" em ");
                EndContext();
                BeginContext(911, 14, false);
#line 37 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
                                       Write(item.NomeCurso);

#line default
#line hidden
                EndContext();
                BeginContext(925, 22, true);
                WriteLiteral(",\n                    ");
                EndContext();
                BeginContext(948, 16, false);
#line 38 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
               Write(item.Instituicao);

#line default
#line hidden
                EndContext();
                BeginContext(964, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(967, 14, false);
#line 38 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
                                  Write(item.AnoInicio);

#line default
#line hidden
                EndContext();
                BeginContext(981, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(985, 11, false);
#line 38 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
                                                    Write(item.AnoFim);

#line default
#line hidden
                EndContext();
                BeginContext(996, 23, true);
                WriteLiteral("\n                </li>\n");
                EndContext();
#line 40 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
            }

#line default
#line hidden
                BeginContext(1033, 96, true);
                WriteLiteral("        </ul>\n    </p>\n\n    <h5>Experiências Profissionais</h5>\n    <hr />\n    <p>\n        <ul>\n");
                EndContext();
#line 48 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
             foreach (var item in Model.ExperienciasProfissionais)
            {

#line default
#line hidden
                BeginContext(1210, 41, true);
                WriteLiteral("                <li>\n                    ");
                EndContext();
                BeginContext(1252, 10, false);
#line 51 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
               Write(item.Cargo);

#line default
#line hidden
                EndContext();
                BeginContext(1262, 4, true);
                WriteLiteral(" em ");
                EndContext();
                BeginContext(1267, 16, false);
#line 51 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
                              Write(item.NomeEmpresa);

#line default
#line hidden
                EndContext();
                BeginContext(1283, 23, true);
                WriteLiteral(" .\n                    ");
                EndContext();
                BeginContext(1307, 14, false);
#line 52 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
               Write(item.AnoInicio);

#line default
#line hidden
                EndContext();
                BeginContext(1321, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1325, 11, false);
#line 52 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
                                 Write(item.AnoFim);

#line default
#line hidden
                EndContext();
                BeginContext(1336, 48, true);
                WriteLiteral("\n                    <br />\n                    ");
                EndContext();
                BeginContext(1385, 24, false);
#line 54 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
               Write(item.DescricaoAtividades);

#line default
#line hidden
                EndContext();
                BeginContext(1409, 23, true);
                WriteLiteral("\n                </li>\n");
                EndContext();
#line 56 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
            }

#line default
#line hidden
                BeginContext(1446, 77, true);
                WriteLiteral("        </ul>\n    </p>\n\n    <h5>Idiomas</h5>\n    <hr />\n    <p>\n        <ul>\n");
                EndContext();
#line 64 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
             foreach (var item in Model.Idiomas)
            {

#line default
#line hidden
                BeginContext(1586, 41, true);
                WriteLiteral("                <li>\n                    ");
                EndContext();
                BeginContext(1628, 9, false);
#line 67 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
               Write(item.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1637, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1641, 10, false);
#line 67 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
                            Write(item.Nivel);

#line default
#line hidden
                EndContext();
                BeginContext(1651, 43, true);
                WriteLiteral("                    \n                </li>\n");
                EndContext();
#line 69 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Curriculos\PDF.cshtml"
            }

#line default
#line hidden
                BeginContext(1708, 24, true);
                WriteLiteral("        </ul>\n    </p>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1739, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurriculoMvc.ViewModels.CurriculoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
