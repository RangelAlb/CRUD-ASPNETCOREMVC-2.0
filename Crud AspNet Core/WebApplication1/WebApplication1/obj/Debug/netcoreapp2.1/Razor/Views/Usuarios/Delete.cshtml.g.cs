#pragma checksum "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0d899421f91ccf0c9031a56592ba86f1c725e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Delete), @"mvc.1.0.view", @"/Views/Usuarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Delete.cshtml", typeof(AspNetCore.Views_Usuarios_Delete))]
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
#line 1 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0d899421f91ccf0c9031a56592ba86f1c725e0f", @"/Views/Usuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(252, 38, false);
#line 15 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(290, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(334, 34, false);
#line 18 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(412, 40, false);
#line 21 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(452, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(496, 36, false);
#line 24 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(532, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(576, 41, false);
#line 27 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(617, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(661, 37, false);
#line 30 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(742, 40, false);
#line 33 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(782, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
            BeginContext(870, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
             if (Model.Tipo == 1)
            {

#line default
#line hidden
            BeginContext(922, 46, true);
            WriteLiteral("                <label>Administrador</label>\r\n");
            EndContext();
#line 41 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
            }
        else if (Model.Tipo == 2)
            {

#line default
#line hidden
            BeginContext(1033, 40, true);
            WriteLiteral("                <label>Técnico</label>\r\n");
            EndContext();
#line 45 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
            }
        else if (Model.Tipo == 3)
            {

#line default
#line hidden
            BeginContext(1138, 47, true);
            WriteLiteral("                <label>Usuário Normal</label>\r\n");
            EndContext();
#line 49 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Delete.cshtml"
            }

#line default
#line hidden
            BeginContext(1200, 36, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1236, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ada04d85a915476faa5139405e9ba6da", async() => {
                BeginContext(1262, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1346, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766df5c2bf2a424b9c1abd4c77cb4b75", async() => {
                    BeginContext(1368, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1384, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1397, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591