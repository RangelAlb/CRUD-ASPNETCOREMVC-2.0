#pragma checksum "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94298a49392698526199739872c1b635fd692293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Index.cshtml", typeof(AspNetCore.Views_Usuarios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94298a49392698526199739872c1b635fd692293", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "403adc21f3b844d59d91b1e9d3b8869c", async() => {
                BeginContext(147, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(161, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(254, 38, false);
#line 16 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 40, false);
#line 19 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(388, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(444, 41, false);
#line 22 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(485, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(541, 40, false);
#line 25 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(581, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(699, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(748, 37, false);
#line 34 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(785, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(841, 39, false);
#line 37 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(880, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(936, 40, false);
#line 40 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(976, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 43 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
                 if (item.Tipo == 1)
                {

#line default
#line hidden
            BeginContext(1072, 50, true);
            WriteLiteral("                    <label>Administrador</label>\r\n");
            EndContext();
#line 46 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
                }
                else if (item.Tipo == 2)
                {

#line default
#line hidden
            BeginContext(1202, 44, true);
            WriteLiteral("                    <label>Técnico</label>\r\n");
            EndContext();
#line 50 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
                }
                else if (item.Tipo == 3)
                {

#line default
#line hidden
            BeginContext(1326, 51, true);
            WriteLiteral("                    <label>Usuário Normal</label>\r\n");
            EndContext();
#line 54 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1396, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1450, 78, false);
#line 57 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1549, 84, false);
#line 58 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1654, 82, false);
#line 59 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 62 "C:\Users\Rangel\Documents\Cursos\Crud AspNet Core\WebApplication1\WebApplication1\Views\Usuarios\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1775, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
