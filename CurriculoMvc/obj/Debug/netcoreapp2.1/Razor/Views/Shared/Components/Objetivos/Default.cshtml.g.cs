#pragma checksum "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\Objetivos\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f6950a5b7e2c9407b1ec96b971dc6e461c9635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Objetivos_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Objetivos/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Objetivos/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Objetivos_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f6950a5b7e2c9407b1ec96b971dc6e461c9635", @"/Views/Shared/Components/Objetivos/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26118e554aecec14fa0f5ed32869f11d4a7c7edf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Objetivos_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CurriculoMvc.Models.Objetivo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Objetivos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\Objetivos\Default.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
            BeginContext(80, 94, true);
            WriteLiteral("    <li class=\"collection-item row\">\n        <div class=\"valign-wrapper col s10\">\n            ");
            EndContext();
            BeginContext(175, 44, false);
#line 7 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\Objetivos\Default.cshtml"
       Write(Html.DisplayFor(modelItem => item.Descrição));

#line default
#line hidden
            EndContext();
            BeginContext(219, 64, true);
            WriteLiteral("\n        </div>\n\n        <div class=\"col s2 right\">\n            ");
            EndContext();
            BeginContext(283, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f6950a5b7e2c9407b1ec96b971dc6e461c96355363", async() => {
                BeginContext(408, 34, true);
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
#line 11 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\Objetivos\Default.cshtml"
                                                              WriteLiteral(item.ObjetivoId);

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
            BeginContext(446, 15, true);
            WriteLiteral("\n            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 461, "\"", 513, 4);
            WriteAttributeValue("", 471, "ExibirModal(", 471, 12, true);
#line 12 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\Objetivos\Default.cshtml"
WriteAttributeValue("", 483, item.ObjetivoId, 483, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 499, ",", 499, 1, true);
            WriteAttributeValue(" ", 500, "\'Objetivos\')", 501, 13, true);
            EndWriteAttribute();
            BeginContext(514, 119, true);
            WriteLiteral(" class=\"btn-floating btn-small red darken-4\"><i class=\"material-icons\">delete_forever</i></a>\n        </div>\n    </li>\n");
            EndContext();
#line 15 "C:\Users\Matheus Trindade\Documents\Repositories\CurriculoMvc\CurriculoMvc\Views\Shared\Components\Objetivos\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CurriculoMvc.Models.Objetivo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
