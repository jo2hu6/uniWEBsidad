#pragma checksum "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a6bb380f7e6907e9b694468f9242a5c0da1470"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_DetalleCursoLogout), @"mvc.1.0.view", @"/Views/Curso/DetalleCursoLogout.cshtml")]
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
#line 1 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\_ViewImports.cshtml"
using Uniwebsidad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\_ViewImports.cshtml"
using Uniwebsidad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a6bb380f7e6907e9b694468f9242a5c0da1470", @"/Views/Curso/DetalleCursoLogout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b9a026bb969f9b7752353c67391ac4d670d188", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_DetalleCursoLogout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DetalleCurso.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a6bb380f7e6907e9b694468f9242a5c0da14703605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<h1 style=\"color:white\">Curso de ");
#nullable restore
#line 4 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
                            Write(ViewBag.Curso.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>


<table class=""table table-borderless"" style=""color:white"">
    <thead>
        <tr>
            <th>Nombre del curso</th>
            <th>Fecha de creaci&oacute;n</th>
            <th>Creador</th>
        </tr>
    </thead>
    <tbody>

        <tr>
            <td>");
#nullable restore
#line 18 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
           Write(ViewBag.Curso.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 19 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
           Write(ViewBag.Curso.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
           Write(ViewBag.Usuario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n\n    </tbody>\n</table>\n\n<ul class=\"youtube_videos\">\n");
#nullable restore
#line 27 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
     foreach (var item in @ViewBag.Videos)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <iframe class=\"youtube\"");
            BeginWriteAttribute("id", " id=\"", 698, "\"", 713, 1);
#nullable restore
#line 30 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
WriteAttributeValue("", 703, item.Link, 703, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=\"", 739, "\"", 785, 2);
            WriteAttributeValue("", 745, "https://www.youtube.com/embed/", 745, 30, true);
#nullable restore
#line 30 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
WriteAttributeValue("", 775, item.Link, 775, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\n");
#nullable restore
#line 31 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniWEBsidad-master\Uniwebsidad\Views\Curso\DetalleCursoLogout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n\r\n<a href=\'javascript:history.go(-1)\' class=\"btn btn-info\"><i class=\"fas fa-long-arrow-alt-left\"></i> Regresar</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
