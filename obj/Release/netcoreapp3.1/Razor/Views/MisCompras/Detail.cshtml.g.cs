#pragma checksum "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed12a11419c35737b3eaec7074a44471e700ba9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MisCompras_Detail), @"mvc.1.0.view", @"/Views/MisCompras/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed12a11419c35737b3eaec7074a44471e700ba9f", @"/Views/MisCompras/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ada35e380beb1115a541822cd18f9bd30ae969", @"/Views/_ViewImports.cshtml")]
    public class Views_MisCompras_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ComponentesMexica.Data.Models.OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Detalles de compra</h1>
<table class=""table table-responsive"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""row"">Producto</th>
            <th scope=""row"">Caracter&iacute;sticas</th>
            <th scope=""row"">Cantidad</th>
            <th scope=""row"">Precio Unitario</th>
            <th scope=""row"">Costo Total</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
         foreach (var item in Model)
        {
            if (item.Componente != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Componente.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Componente.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                           Write(item.Componente.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                    Write(item.Componente.Formato);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                   if (item.Componente.Capacidad != 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>, ");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                           Write(item.Componente.Capacidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                      if (item.Componente.Socket!=null) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                                                           Write(item.Componente.Socket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 20 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-success\">");
#nullable restore
#line 22 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                        Write(item.Componente.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td class=""text-success"">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-cash-stack"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M14 3H1a1 1 0 0 1 1-1h12a1 1 0 0 1 1 1h-1z"" />
                            <path fill-rule=""evenodd"" d=""M15 5H1v8h14V5zM1 4a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H1z"" />
                            <path d=""M13 5a2 2 0 0 0 2 2V5h-2zM3 5a2 2 0 0 1-2 2V5h2zm10 8a2 2 0 0 1 2-2v2h-2zM3 13a2 2 0 0 0-2-2v2h2zm7-4a2 2 0 1 1-4 0 2 2 0 0 1 4 0z"" />
                        </svg> 
                        ");
#nullable restore
#line 29 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
            }
            if (item.Software != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 36 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Software.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>No aplica</td>\r\n                    <td>");
#nullable restore
#line 38 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-success\">");
#nullable restore
#line 39 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                        Write(item.Software.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td class=""text-success"">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-cash-stack"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M14 3H1a1 1 0 0 1 1-1h12a1 1 0 0 1 1 1h-1z"" />
                            <path fill-rule=""evenodd"" d=""M15 5H1v8h14V5zM1 4a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H1z"" />
                            <path d=""M13 5a2 2 0 0 0 2 2V5h-2zM3 5a2 2 0 0 1-2 2V5h2zm10 8a2 2 0 0 1 2-2v2h-2zM3 13a2 2 0 0 0-2-2v2h2zm7-4a2 2 0 1 1-4 0 2 2 0 0 1 4 0z"" />
                        </svg> 
                        ");
#nullable restore
#line 46 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
            }
            if (item.secondHand != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 53 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.secondHand.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.secondHand.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 54 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                           Write(item.secondHand.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-success\">");
#nullable restore
#line 56 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                        Write(item.secondHand.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td class=""text-success"">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-cash-stack"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M14 3H1a1 1 0 0 1 1-1h12a1 1 0 0 1 1 1h-1z"" />
                            <path fill-rule=""evenodd"" d=""M15 5H1v8h14V5zM1 4a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H1z"" />
                            <path d=""M13 5a2 2 0 0 0 2 2V5h-2zM3 5a2 2 0 0 1-2 2V5h2zm10 8a2 2 0 0 1 2-2v2h-2zM3 13a2 2 0 0 0-2-2v2h2zm7-4a2 2 0 1 1-4 0 2 2 0 0 1 4 0z"" />
                        </svg> 
                        ");
#nullable restore
#line 63 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
            }
            if (item.PCMR != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 70 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.PCMR.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.PCMR.CPU);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                  Write(item.PCMR.Cooler);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                     Write(item.PCMR.Mobo);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                      Write(item.PCMR.GPU);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                      Write(item.PCMR.PCU);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                     Write(item.PCMR.SSDM2);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                       Write(item.PCMR.Almacenamiento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                  Write(item.PCMR.AlmacenamientoSecu);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                 Write(item.PCMR.Case);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                                  Write(item.PCMR.RAM);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                                                  Write(item.PCMR.RAM1);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                                                                   Write(item.PCMR.RAM2);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                                                                                                                                                                                                                                    Write(item.PCMR.RAM3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 72 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                   Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-success\">");
#nullable restore
#line 73 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                                        Write(item.PCMR.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td class=""text-success"">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-cash-stack"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M14 3H1a1 1 0 0 1 1-1h12a1 1 0 0 1 1 1h-1z"" />
                            <path fill-rule=""evenodd"" d=""M15 5H1v8h14V5zM1 4a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H1z"" />
                            <path d=""M13 5a2 2 0 0 0 2 2V5h-2zM3 5a2 2 0 0 1-2 2V5h2zm10 8a2 2 0 0 1 2-2v2h-2zM3 13a2 2 0 0 0-2-2v2h2zm7-4a2 2 0 1 1-4 0 2 2 0 0 1 4 0z"" />
                        </svg> ");
#nullable restore
#line 79 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
                          Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "K:\ComponentesMexica\Views\MisCompras\Detail.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ComponentesMexica.Data.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
