#pragma checksum "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18b933b259fcc1944ba5d2f6c260fa8b5bd239d75baf146317148d5e74e3f750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendedors_Details), @"mvc.1.0.view", @"/Views/Vendedors/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/mnt/External/Codigos/ComponentesMexica/Views/_ViewImports.cshtml"
using ComponentesMexica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/External/Codigos/ComponentesMexica/Views/_ViewImports.cshtml"
using ComponentesMexica.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/External/Codigos/ComponentesMexica/Views/_ViewImports.cshtml"
using ComponentesMexica.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/External/Codigos/ComponentesMexica/Views/_ViewImports.cshtml"
using ComponentesMexica.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"18b933b259fcc1944ba5d2f6c260fa8b5bd239d75baf146317148d5e74e3f750", @"/Views/Vendedors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c02652416cce87a206ac9dceeea9208221f83488042d0ff348f983b8a6cbf56b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Vendedors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComponentesMexica.Data.Models.Vendedor>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Vendedor</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.INE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.INE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagenINE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.ImagenINE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 56 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 59 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 62 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Calificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 65 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.Calificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 68 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 71 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 74 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TerminosYCondiciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 77 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Details.cshtml"
       Write(Html.DisplayFor(model => model.TerminosYCondiciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18b933b259fcc1944ba5d2f6c260fa8b5bd239d75baf146317148d5e74e3f75010773", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComponentesMexica.Data.Models.Vendedor> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
