#pragma checksum "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb49c55e01b4e8d9e036b5afc2c6c2f61dc4682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paymethod_Deposito), @"mvc.1.0.view", @"/Views/Paymethod/Deposito.cshtml")]
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
#line 1 "D:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb49c55e01b4e8d9e036b5afc2c6c2f61dc4682", @"/Views/Paymethod/Deposito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ada35e380beb1115a541822cd18f9bd30ae969", @"/Views/_ViewImports.cshtml")]
    public class Views_Paymethod_Deposito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Fase2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
  
    ViewData["Title"] = "Deposito";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Deposito</h1>\r\n<h2>Importe a pagar: $");
#nullable restore
#line 7 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
                 Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<h2>A la cuenta de Banorte: 4915 6654 9019 0770</h2>
<h2 class=""alert alert-warning"">
    <svg width=""1.0625em"" height=""1em"" viewBox=""0 0 17 16"" class=""bi bi-exclamation-triangle"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
        <path fill-rule=""evenodd"" d=""M7.938 2.016a.146.146 0 0 0-.054.057L1.027 13.74a.176.176 0 0 0-.002.183c.016.03.037.05.054.06.015.01.034.017.066.017h13.713a.12.12 0 0 0 .066-.017.163.163 0 0 0 .055-.06.176.176 0 0 0-.003-.183L8.12 2.073a.146.146 0 0 0-.054-.057A.13.13 0 0 0 8.002 2a.13.13 0 0 0-.064.016zm1.044-.45a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566z"" />
        <path d=""M7.002 12a1 1 0 1 1 2 0 1 1 0 0 1-2 0zM7.1 5.995a.905.905 0 1 1 1.8 0l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995z"" />
    </svg>
    Importante colocar como referencia el siguiente dato: <span class=""font-weight-bold"">");
#nullable restore
#line 14 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
                                                                                    Write(Model.RefPago);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
</h2>
<h2>Esto con el fin de que se pueda validar tu pago, en caso de no colocarla no se podr&aacute; validar el pago de la misma.</h2>
<h4>El pago se podr&aacute; ser validado dentro de las siguientes 48 horas despues del dep&oacute;sito.</h4>
<div class=""row"" id=""data"">
    <div class=""col-12"">
        <h4 class=""mb-3"">Datos Personales</h4>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb49c55e01b4e8d9e036b5afc2c6c2f61dc46827195", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label>Nombre</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"firstName\" placeholder=\"Tu Nombre\" readonly");
                BeginWriteAttribute("value", " value=\"", 1683, "\"", 1704, 1);
#nullable restore
#line 25 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 1691, Model.Nombre, 1691, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""lastName"">Apellidos</label>
                    <input type=""text"" class=""form-control"" id=""lastName"" placeholder=""Tus apellidos"" readonly");
                BeginWriteAttribute("value", " value=\"", 2083, "\"", 2107, 1);
#nullable restore
#line 32 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 2091, Model.Apellidos, 2091, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""invalid-feedback"">
                        Valid last name is required.
                    </div>
                </div>
            </div>
            <div class=""row form-group"">
                <div class=""col-md-6 mb-3"">
                    <label>N&uacute;mero</label>
                    <input readonly class=""form-control"" placeholder=""Tu numero de celular""");
                BeginWriteAttribute("value", " value=\"", 2517, "\"", 2538, 1);
#nullable restore
#line 41 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 2525, Model.Numero, 2525, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label>Metodo de pago</label>\r\n                    <input readonly class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2720, "\"", 2745, 1);
#nullable restore
#line 45 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 2728, Model.MetodoPago, 2728, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"address\">Direcci&oacute;n</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"address\" placeholder=\"1234 Main St\" readonly");
                BeginWriteAttribute("value", " value=\"", 2994, "\"", 3018, 1);
#nullable restore
#line 50 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 3002, Model.Direccion, 3002, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""invalid-feedback"">
                    Por favor coloca tu direcci&oacute;n para poder realizar la entrega.
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-5 mb-3"">
                    <label for=""country"">Estado</label>
                    <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 3375, "\"", 3396, 1);
#nullable restore
#line 58 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 3383, Model.Estado, 3383, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly class=""form-control"" />
                    <div class=""invalid-feedback"">
                        Please select a valid country.
                    </div>
                </div>
                <div class=""col-md-4 mb-3"">
                    <label for=""state"">Codigo Postal</label>
                    <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 3737, "\"", 3754, 1);
#nullable restore
#line 65 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 3745, Model.CP, 3745, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly class=""form-control"" />
                    <div class=""invalid-feedback"">
                        Seleccione uno.
                    </div>
                </div>
                <div class=""col-md-3 mb-3"">
                    <label for=""zip"">Colonia</label>
                    <input type=""text"" readonly class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 4102, "\"", 4124, 1);
#nullable restore
#line 72 "D:\ComponentesMexica\Views\Paymethod\Deposito.cshtml"
WriteAttributeValue("", 4110, Model.Colonia, 4110, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"invalid-feedback\">\r\n                        Seleccione uno.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb49c55e01b4e8d9e036b5afc2c6c2f61dc468214454", async() => {
                WriteLiteral("Salir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
