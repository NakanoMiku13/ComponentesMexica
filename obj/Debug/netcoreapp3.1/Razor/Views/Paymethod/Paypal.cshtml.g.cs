#pragma checksum "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae708b901f21b69b0492249a5dfd40fdba69006b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paymethod_Paypal), @"mvc.1.0.view", @"/Views/Paymethod/Paypal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae708b901f21b69b0492249a5dfd40fdba69006b", @"/Views/Paymethod/Paypal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ada35e380beb1115a541822cd18f9bd30ae969", @"/Views/_ViewImports.cshtml")]
    public class Views_Paymethod_Paypal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Fase2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
  
    ViewData["Title"] = "Paypal";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Paypal</h1>
<script src=""https://www.paypal.com/sdk/js?client-id=AbOhaEymTIqt9WvgswEg9zsUV_A1tCrXoxJ2ChbadL5t27oOrIw1cvwrHtobbQ14JB6ZkkaUNtn4xTta&currency=MXN"">
    // Required. Replace SB_CLIENT_ID with your sandbox client ID.
</script>
<div class=""row"" id=""data"">
    <div class=""col-12"">
        <h4 class=""mb-3"">Datos Personales</h4>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae708b901f21b69b0492249a5dfd40fdba69006b5715", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label>Nombre</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"firstName\" placeholder=\"Tu Nombre\" readonly");
                BeginWriteAttribute("value", " value=\"", 680, "\"", 701, 1);
#nullable restore
#line 16 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 688, Model.Nombre, 688, 13, false);

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
                BeginWriteAttribute("value", " value=\"", 1080, "\"", 1104, 1);
#nullable restore
#line 23 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 1088, Model.Apellidos, 1088, 16, false);

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
                BeginWriteAttribute("value", " value=\"", 1514, "\"", 1535, 1);
#nullable restore
#line 32 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 1522, Model.Numero, 1522, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label>Metodo de pago</label>\r\n                    <input readonly class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1717, "\"", 1742, 1);
#nullable restore
#line 36 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 1725, Model.MetodoPago, 1725, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"address\">Direcci&oacute;n</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"address\" placeholder=\"1234 Main St\" readonly");
                BeginWriteAttribute("value", " value=\"", 1991, "\"", 2015, 1);
#nullable restore
#line 41 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 1999, Model.Direccion, 1999, 16, false);

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
                BeginWriteAttribute("value", " value=\"", 2372, "\"", 2393, 1);
#nullable restore
#line 49 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 2380, Model.Estado, 2380, 13, false);

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
                BeginWriteAttribute("value", " value=\"", 2734, "\"", 2751, 1);
#nullable restore
#line 56 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 2742, Model.CP, 2742, 9, false);

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
                BeginWriteAttribute("value", " value=\"", 3099, "\"", 3121, 1);
#nullable restore
#line 63 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
WriteAttributeValue("", 3107, Model.Colonia, 3107, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <div class=\"invalid-feedback\">\r\n                        Seleccione uno.\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div id=\"salir\" style=\"display:none;\">\r\n    <dialog id=\"dialog\" class=\"border\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae708b901f21b69b0492249a5dfd40fdba69006b13042", async() => {
                WriteLiteral("Salir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</dialog>
</div>

<div id=""paypal-button-container"" class=""row"" style=""align-items:center;""></div>
<script>
    var datas = document.getElementById('myModal');
    paypal.Buttons({
        createOrder: function (data, actions) {
            // This function sets up the details of the transaction, including the amount and line item details.
            return actions.order.create({
                purchase_units: [{
                    amount: {
                        value: '");
#nullable restore
#line 85 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
                           Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                        description:\'");
#nullable restore
#line 86 "D:\ComponentesMexica\Views\Paymethod\Paypal.cshtml"
                                Write(Model.RefPago);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                    }
                }],
            });
        },
        onApprove: function (data, actions) {
            // This function captures the funds from the transaction.
            return actions.order.capture().then(function (details) {
                // This function shows a transaction success message to your buyer.
                
                alert('Se ha completado tu pago');
                let data = document.getElementById('data');
                let div = document.getElementById('salir');
                let pay = document.getElementById('paypal-button-container');
                data.style.display = 'none';
                pay.style.display = 'none';
                div.style.display = 'block';
                document.getElementById('dialog').showModal();
            });
        }
    }).render('#paypal-button-container');
  //This function displays Smart Payment Buttons on your web page.
</script>");
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
