#pragma checksum "K:\ComponentesMexica\Views\Seller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9053e1d02dcf3167d8759ba0622d6e1980a586bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_Index), @"mvc.1.0.view", @"/Views/Seller/Index.cshtml")]
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
#line 1 "K:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "K:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "K:\ComponentesMexica\Views\_ViewImports.cshtml"
using ComponentesMexica.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9053e1d02dcf3167d8759ba0622d6e1980a586bc", @"/Views/Seller/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ada35e380beb1115a541822cd18f9bd30ae969", @"/Views/_ViewImports.cshtml")]
    public class Views_Seller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendedor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Retire", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SecondHands", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""myModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">x</button>
                </div>
            </div>
            <div class=""modal-body"">
                <div id=""modal-content"">
                    Consulta aqu&iacute; tus datos:
                    <ul>
                        <li typeof=""sqare"">id: ");
#nullable restore
#line 17 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                          Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li typeof=\"sqare\">Nombre: ");
#nullable restore
#line 18 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                              Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li typeof=\"sqare\">Apellidos: ");
#nullable restore
#line 19 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                                 Write(Model.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li typeof=\"sqare\">Estado: ");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                                    if (Model.Active)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <p class=""text-success"">Activo <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-emoji-laughing"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
    <path fill-rule=""evenodd"" d=""M12.331 9.5a1 1 0 0 1 0 1A4.998 4.998 0 0 1 8 13a4.998 4.998 0 0 1-4.33-2.5A1 1 0 0 1 4.535 9h6.93a1 1 0 0 1 .866.5z"" />
    <path d=""M7 6.5c0 .828-.448 0-1 0s-1 .828-1 0S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 0-1 0s-1 .828-1 0S9.448 5 10 5s1 .672 1 1.5z"" />
</svg></p>");
#nullable restore
#line 25 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
          }
                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <p class=""text-danger"">Inactivo <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-emoji-frown"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
    <path fill-rule=""evenodd"" d=""M4.285 12.433a.5.5 0 0 0 .683-.183A3.498 3.498 0 0 1 8 10.5c1.295 0 2.426.703 3.032 1.75a.5.5 0 0 0 .866-.5A4.498 4.498 0 0 0 8 9.5a4.5 4.5 0 0 0-3.898 2.25.5.5 0 0 0 .183.683z"" />
    <path d=""M7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 1.5-1 1.5s-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5z"" />
</svg></p>");
#nullable restore
#line 30 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li typeof=\"sqare\">Calificaci&oacute;n: ");
#nullable restore
#line 31 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                                           Write(Model.Calificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-suit-heart-fill text-danger"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path d=""M4 1c2.21 0 4 1.755 4 3.92C8 2.755 9.79 1 12 1s4 1.755 4 3.92c0 3.263-3.234 4.414-7.608 9.608a.513.513 0 0 1-.784 0C3.234 9.334 0 8.183 0 4.92 0 2.755 1.79 1 4 1z"" />
</svg>
");
#nullable restore
#line 34 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                         if (Model.Calificacion > 10000) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-reception-4 text-success"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
        <path d=""M0 11.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-2zm4-3a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v5a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-5zm4-3a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v8a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-8zm4-3a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v11a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-11z"" />
    </svg> ");
#nullable restore
#line 37 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
           } else if (Model.Calificacion > 5000 && Model.Calificacion <= 10000) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-reception-3 text-primary"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path d=""M0 11.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-2zm4-3a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v5a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-5zm4-3a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v8a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-8zm4 8a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5z"" />
</svg>");
#nullable restore
#line 39 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
      } else if (Model.Calificacion > 2500 && Model.Calificacion <= 5000) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-reception-2 text-secondary"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path d=""M0 11.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-2zm4-3a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v5a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-5zm4 5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm4 0a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5z"" />
</svg>");
#nullable restore
#line 41 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
      } else if (Model.Calificacion > 1000 && Model.Calificacion <= 2500) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-reception-1 text-warning"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path d=""M0 11.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1-.5-.5v-2zm4 2a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm4 0a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm4 0a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5z"" />
</svg>");
#nullable restore
#line 43 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
      } else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-reception-0 text-danger"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
    <path d=""M0 13.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm4 0a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm4 0a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5zm4 0a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 0 1h-2a.5.5 0 0 1-.5-.5z"" />
</svg>");
#nullable restore
#line 45 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 52 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
 if (ViewBag.Nomina != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""myModal2"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <div>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">x</button>
                    </div>
                </div>
                <div class=""modal-body"">
                    <div id=""modal-content"">
                        Tienes unas ganancias totales de <span class=""text-success"">$");
#nullable restore
#line 64 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                                                                Write(ViewBag.Nomina.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>.
                        En caso de ser un monto mayor a <span class=""text-success"">$3000</span> el deposito puede ser en 48 horas o menos, en caso contrario podr&aacute; tardar un poco m&aacute;s.
                        Si deseas retirarlo da click en el boton ""Retirar"" y podr&aacute;s realizar el proceso de retiro de dinero.
                        <h4 class=""font-weight-bold"">Referencia de retiro: </h4>
                        <p>");
#nullable restore
#line 68 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                      Write(ViewBag.Nomina.Referencia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <h5 class=""font-weight-bold"">Recomendaciones para retirar</h5>
                        <ul typeof=""square"">
                            <li>Usa una cuenta de Paypal o Mercado Pago para poder realizar un deposito m&aacute;s efectivo.</li>
                            <li>En caso de solicitar en cuenta bancaria, puede tardar un poco m&aacute;s tu solicitud.</li>
                            <li>En caso de ser por CLABE el deposito tardar&aacute; dependiendo la cantidad y el banco a depositar.</li>
                        </ul>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9053e1d02dcf3167d8759ba0622d6e1980a586bc15344", async() => {
                WriteLiteral(@"
                            Retirar
                            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-emoji-laughing"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                                <path fill-rule=""evenodd"" d=""M12.331 9.5a1 1 0 0 1 0 1A4.998 4.998 0 0 1 8 13a4.998 4.998 0 0 1-4.33-2.5A1 1 0 0 1 4.535 9h6.93a1 1 0 0 1 .866.5z"" />
                                <path d=""M7 6.5c0 .828-.448 0-1 0s-1 .828-1 0S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 0-1 0s-1 .828-1 0S9.448 5 10 5s1 .672 1 1.5z"" />
                            </svg>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Sellerid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                                                                       WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Sellerid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Sellerid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Sellerid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                                                                                                     WriteLiteral(ViewBag.Nomina.Referencia);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RefPago"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RefPago", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RefPago"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 88 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <div class=""btn-group"">
        <a href=""#myModal"" class=""btn btn-outline-info"" data-toggle=""modal"">
            Mi informaci&oacute;n
            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-toggles"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                <path fill-rule=""evenodd"" d=""M4.5 9a3.5 3.5 0 1 0 0 7h7a3.5 3.5 0 1 0 0-7h-7zm7 6a2.5 2.5 0 1 0 0-5 2.5 2.5 0 0 0 0 5zm-7-14a2.5 2.5 0 1 0 0 5 2.5 2.5 0 0 0 0-5zm2.45 0A3.49 3.49 0 0 1 8 3.5 3.49 3.49 0 0 1 6.95 6h4.55a2.5 2.5 0 0 0 0-5H6.95zM4.5 0h7a3.5 3.5 0 1 1 0 7h-7a3.5 3.5 0 1 1 0-7z"" />
            </svg>
        </a>
        <a class=""btn btn-outline-success"" data-toggle=""modal"" href=""#myModal2"">
            Mis ganancias:
            <span>
                <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-cash-stack"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                    <path d=""M14 3H1a1 1 0 0 1 1-1h12a1 1 0 0 1 1 1h-1z"" />
                    <path fill-ru");
            WriteLiteral(@"le=""evenodd"" d=""M15 5H1v8h14V5zM1 4a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H1z"" />
                    <path d=""M13 5a2 2 0 0 0 2 2V5h-2zM3 5a2 2 0 0 1-2 2V5h2zm10 8a2 2 0 0 1 2-2v2h-2zM3 13a2 2 0 0 0-2-2v2h2zm7-4a2 2 0 1 1-4 0 2 2 0 0 1 4 0z"" />
                </svg>
");
#nullable restore
#line 105 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                 if (ViewBag.Nomina != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
               Write(ViewBag.Nomina.Total);

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                                         
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>0.0</span>\r\n");
#nullable restore
#line 112 "K:\ComponentesMexica\Views\Seller\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </span>
        </a>
    </div>
    <div class=""card"">
        <h5 class=""card-header"">Mis productos</h5>
        <div class=""card-body"">
            <h5 class=""card-title"">Apartado para ver tus productos</h5>
            <p class=""card-text"">En este apartado podr&aacute;s ver tus productos publicados y en este apartado podrás desde pausar la publicaci&oacute;n, hasta modificarla o crear una nueva.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9053e1d02dcf3167d8759ba0622d6e1980a586bc22159", async() => {
                WriteLiteral("Ver");
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
            WriteLiteral(@"
        </div>
    </div>
    <div class=""card"">
        <h5 class=""card-header"">Featured</h5>
        <div class=""card-body"">
            <h5 class=""card-title"">Special title treatment</h5>
            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
    </div>
    <div class=""card"">
        <h5 class=""card-header"">Featured</h5>
        <div class=""card-body"">
            <h5 class=""card-title"">Special title treatment</h5>
            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>
    </div>
    <div class=""card"">
        <h5 class=""card-header"">Featured</h5>
        <div class=""card-body"">
            <h5 class=""card-title"">Special title treatment</h5>
            <p class=""card-text"">With supporting text below as a natural lead-in ");
            WriteLiteral("to additional content.</p>\r\n            <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendedor> Html { get; private set; }
    }
}
#pragma warning restore 1591
