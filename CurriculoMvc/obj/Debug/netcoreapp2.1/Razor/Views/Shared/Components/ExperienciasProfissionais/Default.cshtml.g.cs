#pragma checksum "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a159497eccaf6237a14f8ee05456eb81648351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienciasProfissionais_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienciasProfissionais/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ExperienciasProfissionais/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ExperienciasProfissionais_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a159497eccaf6237a14f8ee05456eb81648351", @"/Views/Shared/Components/ExperienciasProfissionais/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26118e554aecec14fa0f5ed32869f11d4a7c7edf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ExperienciasProfissionais_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CurriculoMvc.Models.ExperienciaProfissional>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ExperienciasProfissionais", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating btn-small blue darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(96, 94, true);
            WriteLiteral("    <li class=\"collection-item row\">\n        <div class=\"valign-wrapper col s10\">\n            ");
            EndContext();
            BeginContext(191, 40, false);
#line 7 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
       Write(Html.DisplayFor(modelItem => item.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(231, 4, true);
            WriteLiteral(" em ");
            EndContext();
            BeginContext(236, 46, false);
#line 7 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.NomeEmpresa));

#line default
#line hidden
            EndContext();
            BeginContext(282, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(296, 44, false);
#line 8 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
       Write(Html.DisplayFor(modelItem => item.AnoInicio));

#line default
#line hidden
            EndContext();
            BeginContext(340, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(344, 41, false);
#line 8 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.AnoFim));

#line default
#line hidden
            EndContext();
            BeginContext(385, 64, true);
            WriteLiteral("\n        </div>\n\n        <div class=\"col s2 right\">\n            ");
            EndContext();
            BeginContext(449, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46a159497eccaf6237a14f8ee05456eb816483516885", async() => {
                BeginContext(605, 34, true);
                WriteLiteral("<i class=\"material-icons\">edit</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
                                                                              WriteLiteral(item.ExperienciaProfissionalId);

#line default
#line hidden
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
            EndContext();
            BeginContext(643, 15, true);
            WriteLiteral("\n            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 658, "\"", 741, 4);
            WriteAttributeValue("", 668, "ExibirModal(", 668, 12, true);
#line 13 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
WriteAttributeValue("", 680, item.ExperienciaProfissionalId, 680, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 711, ",", 711, 1, true);
            WriteAttributeValue(" ", 712, "\'ExperienciasProfissionais\')", 713, 29, true);
            EndWriteAttribute();
            BeginContext(742, 119, true);
            WriteLiteral(" class=\"btn-floating btn-small red darken-4\"><i class=\"material-icons\">delete_forever</i></a>\n        </div>\n    </li>\n");
            EndContext();
#line 16 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\ExperienciasProfissionais\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CurriculoMvc.Models.ExperienciaProfissional>> Html { get; private set; }
    }
}
#pragma warning restore 1591
