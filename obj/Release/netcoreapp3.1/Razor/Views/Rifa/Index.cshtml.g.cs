#pragma checksum "K:\ComponentesMexica\Views\Rifa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6ee1c86eab00c7ca95901a8cd607cb92c35cbec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rifa_Index), @"mvc.1.0.view", @"/Views/Rifa/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ee1c86eab00c7ca95901a8cd607cb92c35cbec", @"/Views/Rifa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ada35e380beb1115a541822cd18f9bd30ae969", @"/Views/_ViewImports.cshtml")]
    public class Views_Rifa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rifas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
  
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
                    Estas a punto de registrarte para poder ganar un producto a coste m&iacute;nimo, donde lo &uacute;nico que lo determina es tu suerte.
                    Si deseas informaci&oacute;n m&aacute;s detallada visita <a>aqu&iacute;</a>.
                    Por el momento si ya conoces el funcionamiento de la misma o no, no te preocupes, solo tendr&aacute;s que registrar ciertos datos y listo, estar&aacute;s participando.
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6ee1c86eab00c7ca95901a8cd607cb92c35cbec5107", async() => {
                WriteLiteral("Participar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        </div>
    </div>
</div>
<h1>Bienvenido a la secci&oacute;n de rifas</h1>
<h3>Donde puedes ser ganador de un gran premio por un bajo coste</h3>
<h3 class=""alert alert-success"">Si te interesa participar y ser un posible ganador, da click en el bot&oacute;n registrarse, justamente debajo de este mensaje.</h3>
");
#nullable restore
#line 27 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">\r\n        <h2>No hay rifas activas o la rifa activa ha finalizado</h2>\r\n    </div>\r\n");
#nullable restore
#line 32 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
     if (Model.Tickets == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h4 class=""alert alert-danger"">
            Ya no qued&aacute;n tickets disponibles
            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-emoji-frown"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                <path fill-rule=""evenodd"" d=""M4.285 12.433a.5.5 0 0 0 .683-.183A3.498 3.498 0 0 1 8 10.5c1.295 0 2.426.703 3.032 1.75a.5.5 0 0 0 .866-.5A4.498 4.498 0 0 0 8 9.5a4.5 4.5 0 0 0-3.898 2.25.5.5 0 0 0 .183.683z"" />
                <path d=""M7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 1.5-1 1.5s-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5z"" />
            </svg>    
        </h4>
");
#nullable restore
#line 46 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <a href=""#myModal"" class=""btn btn-outline-success"" data-toggle=""modal"">
            Registrarme
            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-emoji-laughing"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                <path fill-rule=""evenodd"" d=""M12.331 9.5a1 1 0 0 1 0 1A4.998 4.998 0 0 1 8 13a4.998 4.998 0 0 1-4.33-2.5A1 1 0 0 1 4.535 9h6.93a1 1 0 0 1 .866.5z"" />
                <path d=""M7 6.5c0 .828-.448 0-1 0s-1 .828-1 0S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 0-1 0s-1 .828-1 0S9.448 5 10 5s1 .672 1 1.5z"" />
            </svg>
        </a>
");
#nullable restore
#line 57 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-lg-8 col-md-6 col-sm-12\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 3306, "\"", 3351, 2);
            WriteAttributeValue("", 3312, "./UploadImages/", 3312, 15, true);
#nullable restore
#line 61 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
WriteAttributeValue("", 3327, Model.Componente.Imagen, 3327, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 63 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
                                      Write(Model.Componente.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
                                                              Write(Model.Componente.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Quedan ");
#nullable restore
#line 64 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
                                           Write(Model.Tickets);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" tickets</p>
                    <p class=""card-text"">En cuanto se compren todos los tickets se notificar&aacute; a todos los participantes y se confirmar&aacute; el d&iacute;a y hora de selecci&oacute;n del ganador.</p>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-6 col-sm-12"">
");
#nullable restore
#line 70 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
             if (Model.Tickets == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <h2>D&iacute;a que se anunciar&aacute; el ganador.</h2>\r\n                    <h4 class=\"font-weight-bold\">");
#nullable restore
#line 74 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
                                            Write(ViewBag.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n");
#nullable restore
#line 76 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 79 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\nvar end = new Date(\'");
#nullable restore
#line 81 "K:\ComponentesMexica\Views\Rifa\Index.cshtml"
               Write(ViewBag.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');

    var _second = 1000;
    var _minute = _second * 60;
    var _hour = _minute * 60;
    var _day = _hour * 24;
    var timer;

    function showRemaining() {
        var now = new Date();
        var distance = end - now;
        if (distance < 0) {

            clearInterval(timer);
            document.getElementById('countdown').innerHTML = 'EXPIRED!';

            return;
        }
        var days = Math.floor(distance / _day);
        var hours = Math.floor((distance % _day) / _hour);
        var minutes = Math.floor((distance % _hour) / _minute);
        var seconds = Math.floor((distance % _minute) / _second);

        document.getElementById('countdown').innerHTML = days + ' dias, ';
        document.getElementById('countdown').innerHTML += hours + ' horas, ';
        document.getElementById('countdown').innerHTML += minutes + ' minutos y ';
        document.getElementById('countdown').innerHTML += seconds + ' segundos';
    }

    timer = setInterval(showRemaining");
            WriteLiteral(", 1000);\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rifas> Html { get; private set; }
    }
}
#pragma warning restore 1591