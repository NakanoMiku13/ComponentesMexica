#pragma checksum "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e2561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Info), @"mvc.1.0.view", @"/Views/Productos/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e2561", @"/Views/Productos/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c02652416cce87a206ac9dceeea9208221f83488042d0ff348f983b8a6cbf56b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Productos_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCMR>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
  
    ViewData["Title"] = Model.Nombre;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .imgs{
        height:250px;
        width: 250px;
    }
</style>
<h1>Informaci&oacute;n</h1>
<table class=""table-responsive"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Componente</th>
            <th scope=""col"">Marca</th>
            <th scope=""col"">Modelo</th>
            <th scope=""col"">Descripci&oacute;n</th>
            <th scope=""col"">Extra</th>
            <th scope=""col"">Imagen</th>

        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">CPU</th>
            <td>");
#nullable restore
#line 27 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.CPU.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 28 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.CPU.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 29 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.CPU.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Socket: ");
#nullable restore
#line 30 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                   Write(ViewBag.CPU.Socket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e25615593", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 784, "~/UploadImages/", 784, 15, true);
#nullable restore
#line 31 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 799, ViewBag.CPU.Imagen, 799, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th scope=\"row\">GPU</th>\n            <td>");
#nullable restore
#line 35 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.GPU.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 36 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.GPU.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 37 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.GPU.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Formato: ");
#nullable restore
#line 38 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                    Write(ViewBag.GPU.Formato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e25618201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1109, "~/UploadImages/", 1109, 15, true);
#nullable restore
#line 39 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 1124, ViewBag.GPU.Imagen, 1124, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th scope=\"row\">Mother Board</th>\n            <td>");
#nullable restore
#line 43 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.Mobo.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 44 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.Mobo.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 45 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.Mobo.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Formato: ");
#nullable restore
#line 46 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                    Write(ViewBag.Mobo.Formato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e256110826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1446, "~/UploadImages/", 1446, 15, true);
#nullable restore
#line 47 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 1461, ViewBag.Mobo.Imagen, 1461, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th scope=\"row\">RAM</th>\n            <td>");
#nullable restore
#line 51 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.RAM.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 52 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.RAM.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 53 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.RAM.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Capacidad: ");
#nullable restore
#line 54 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                      Write(ViewBag.RAM.Capacidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e256113449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1778, "~/UploadImages/", 1778, 15, true);
#nullable restore
#line 55 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 1793, ViewBag.RAM.Imagen, 1793, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th scope=\"row\">Fuente de poder</th>\n            <td>");
#nullable restore
#line 59 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.PSU.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 60 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.PSU.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 61 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.PSU.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Wattage: ");
#nullable restore
#line 62 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                    Write(ViewBag.PSU.Wattage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" W</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e256116076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2116, "~/UploadImages/", 2116, 15, true);
#nullable restore
#line 63 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 2131, ViewBag.PSU.Imagen, 2131, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th scope=\"row\">Almacenamiento</th>\n            <td>");
#nullable restore
#line 67 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.HDD.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 68 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.HDD.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 69 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.HDD.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Capacidad: ");
#nullable restore
#line 70 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                      Write(ViewBag.HDD.Capacidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e256118709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2458, "~/UploadImages/", 2458, 15, true);
#nullable restore
#line 71 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 2473, ViewBag.HDD.Imagen, 2473, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th scope=\"row\">Almacenamiento Secundario</th>\n            <td>");
#nullable restore
#line 75 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.HDD2.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 76 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.HDD2.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 77 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.HDD2.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Capacidad: ");
#nullable restore
#line 78 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                      Write(ViewBag.HDD2.Capacidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e256121357", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2815, "~/UploadImages/", 2815, 15, true);
#nullable restore
#line 79 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 2830, ViewBag.HDD2.Imagen, 2830, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <th scope=\"row\">Gabinete</th>\n            <td>");
#nullable restore
#line 83 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.Case.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 84 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.Case.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 85 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
           Write(ViewBag.Case.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>Formato: ");
#nullable restore
#line 86 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
                    Write(ViewBag.Case.Formato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f0fdcbb6af4658a44f6f90e3d6b1a9028bcc650b2f96905ffee627c46e256123980", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3150, "~/UploadImages/", 3150, 15, true);
#nullable restore
#line 87 "/mnt/External/Codigos/ComponentesMexica/Views/Productos/Info.cshtml"
AddHtmlAttributeValue("", 3165, ViewBag.Case.Imagen, 3165, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n        </tr>\n    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCMR> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
