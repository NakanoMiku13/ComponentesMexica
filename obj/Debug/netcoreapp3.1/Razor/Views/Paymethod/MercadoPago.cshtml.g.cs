#pragma checksum "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fe02b4a575c3c114119676212853f54a129fe85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paymethod_MercadoPago), @"mvc.1.0.view", @"/Views/Paymethod/MercadoPago.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe02b4a575c3c114119676212853f54a129fe85", @"/Views/Paymethod/MercadoPago.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ada35e380beb1115a541822cd18f9bd30ae969", @"/Views/_ViewImports.cshtml")]
    public class Views_Paymethod_MercadoPago : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MercadoPagoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Fase2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
  
    ViewData["Title"] = "MercadoPago";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>MercadoPago</h1>\r\n<div class=\"row\" id=\"data\">\r\n    <div class=\"col-12\">\r\n        <h4 class=\"mb-3\">Datos Personales</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe02b4a575c3c114119676212853f54a129fe854448", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label>Nombre</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"firstName\" placeholder=\"Tu Nombre\" readonly");
                BeginWriteAttribute("value", " value=\"", 476, "\"", 503, 1);
#nullable restore
#line 13 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 484, Model.Order.Nombre, 484, 19, false);

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
                BeginWriteAttribute("value", " value=\"", 882, "\"", 912, 1);
#nullable restore
#line 20 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 890, Model.Order.Apellidos, 890, 22, false);

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
                BeginWriteAttribute("value", " value=\"", 1322, "\"", 1349, 1);
#nullable restore
#line 29 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 1330, Model.Order.Numero, 1330, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label>Metodo de pago</label>\r\n                    <input readonly class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1531, "\"", 1562, 1);
#nullable restore
#line 33 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 1539, Model.Order.MetodoPago, 1539, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"address\">Direcci&oacute;n</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"address\" placeholder=\"1234 Main St\" readonly");
                BeginWriteAttribute("value", " value=\"", 1811, "\"", 1841, 1);
#nullable restore
#line 38 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 1819, Model.Order.Direccion, 1819, 22, false);

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
                BeginWriteAttribute("value", " value=\"", 2198, "\"", 2225, 1);
#nullable restore
#line 46 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 2206, Model.Order.Estado, 2206, 19, false);

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
                BeginWriteAttribute("value", " value=\"", 2566, "\"", 2589, 1);
#nullable restore
#line 53 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 2574, Model.Order.CP, 2574, 15, false);

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
                BeginWriteAttribute("value", " value=\"", 2937, "\"", 2965, 1);
#nullable restore
#line 60 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
WriteAttributeValue("", 2945, Model.Order.Colonia, 2945, 20, false);

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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script src=\"https://www.mercadopago.com.mx/integrations/v1/web-payment-checkout.js\"\r\n        data-public-key=\"APP_USR-ef3ae39a-a787-48dd-ab7e-e0ce2d90f45d\"\r\n        data-transaction-amount=\"");
#nullable restore
#line 71 "D:\ComponentesMexica\Views\Paymethod\MercadoPago.cshtml"
                            Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n        data-button-label=\"Comprar\">\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MercadoPagoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
