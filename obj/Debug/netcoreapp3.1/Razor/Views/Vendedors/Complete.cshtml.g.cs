#pragma checksum "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Complete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "573264b087f2e27a125bf869065885a08a6dd7a0e4116433785303233d23b9a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendedors_Complete), @"mvc.1.0.view", @"/Views/Vendedors/Complete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"573264b087f2e27a125bf869065885a08a6dd7a0e4116433785303233d23b9a6", @"/Views/Vendedors/Complete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c02652416cce87a206ac9dceeea9208221f83488042d0ff348f983b8a6cbf56b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Vendedors_Complete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendedor>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Complete.cshtml"
  
    ViewData["Title"] = "Complete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-center alert alert-success\">Registro Completado</h1>\n<div class=\"alert alert-secondary\">\n    <h3>Gracias ");
#nullable restore
#line 8 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Complete.cshtml"
           Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" por registrarte como vendedor, por el momento estaremos revisando tu solicitud y en la brevedad se te notificar&aacute; si es aceptada.</h3>
    <h3>En caso de ser aceptada, al ingresar a la pagina tendr&aacute;s la opci&oacute;n de ver un panel de administraci&oacute;n de tus ventas (<a class=""btn btn-outline-warning"">Panel <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-server"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path fill-rule=""evenodd"" d=""M1.333 2.667C1.333 1.194 4.318 0 8 0s6.667 1.194 6.667 2.667V4C14.665 5.474 11.68 6.667 8 6.667 4.318 6.667 1.333 5.473 1.333 4V2.667zm0 3.667v3C1.333 10.805 4.318 12 8 12c3.68 0 6.665-1.193 6.667-2.665V6.334c-.43.32-.931.58-1.458.79C11.81 7.684 9.967 8 8 8c-1.967 0-3.81-.317-5.21-.876a6.508 6.508 0 0 1-1.457-.79zm13.334 5.334c-.43.319-.931.578-1.458.789-1.4.56-3.242.876-5.209.876-1.967 0-3.81-.316-5.21-.876a6.51 6.51 0 0 1-1.457-.79v1.666C1.333 14.806 4.318 16 8 16s6.667-1.194 6.667-2.667v-1.665z"" />
</svg></a>), donde podr&aacut");
            WriteLiteral(@"e;s ver tus productos puestos a la venta, si deseas retirarlos, modificarlos o cambiar alguna caracteristica, as&iacute; mismo podr&aacute;s ver el dinero que has juntado con tus productos vendidos y cuales ya vendiste.</h3>
    <h3>Antes de hacer cualquier anuncio como vendedor en Componentes Mexica S.A de C.V. tienes la obligaci&oacute;n de leer el aviso para vendedores que lo puedes encontrar ya sea en tu panel de control o en el apartado de m&aacute;s en el men&uacute; principal.</h3>
    <h3>De ante mano agradecemos tu preferencia.</h3>
    <h3>Tu id: ");
#nullable restore
#line 14 "/mnt/External/Codigos/ComponentesMexica/Views/Vendedors/Complete.cshtml"
          Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", es importante que guardes esta id por si tienes un problema, poderte ayudar rapidamente, igualmente la encontrar&aacute;s en tu panel de ventas.</h3>\n    <h4>En caso de ser negada puedes solicitar una aclaraci&oacute;n.</h4>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573264b087f2e27a125bf869065885a08a6dd7a0e4116433785303233d23b9a67110", async() => {
                WriteLiteral("Salir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendedor> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
