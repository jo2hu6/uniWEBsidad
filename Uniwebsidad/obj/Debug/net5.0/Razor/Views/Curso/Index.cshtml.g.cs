#pragma checksum "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74fa9b6797a76dbc381e65a65e7d0625fbdc7015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
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
#line 1 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\_ViewImports.cshtml"
using Uniwebsidad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\_ViewImports.cshtml"
using Uniwebsidad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74fa9b6797a76dbc381e65a65e7d0625fbdc7015", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b9a026bb969f9b7752353c67391ac4d670d188", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    img .zoom {
        width: 90%;
    }

        img .zoom:hover {
            width: 95%;
        }

    .active, .collapsible:hover {
        background-color: #555;
    }

    h4 .card-title:hover {
        text-decoration: none;
        width: 50%;
    }

    .content {
        padding: 0 18px;
        display: none;
        overflow: hidden;
        background-color: #f1f1f1;
    }

    .zoom {
        transition: transform .2s;
    }

        .zoom:hover {
            transform: scale(1.1);
        }
</style>

<h1 class=""p-4 text-white text-center"">Mi Lista</h1>

<div class=""row"">
    <div class=""container"">
        <div class=""card-deck"">
");
#nullable restore
#line 41 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
             if (ViewBag.Cantidad != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                 foreach (var item in @ViewBag.MisCursos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4"">
                        <div class=""card text-white bg-secondary mb-3"" style=""max-width: 18rem;"">
                            <img class="" card-img-top zoom"" src=""https://strategyco.es/wp-content/uploads/2020/10/Imagen-BlogStrategyco-202010A-JB.jpg"" />
                            <div class=""card-header text-center"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 1191, "\"", 1229, 2);
            WriteAttributeValue("", 1198, "/Curso/DetalleCurso?Id=", 1198, 23, true);
#nullable restore
#line 49 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
WriteAttributeValue("", 1221, item.Id, 1221, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4 class=\"text-white\">");
#nullable restore
#line 49 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                                                                                            Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n                            </div>\n                            <div class=\"card-body\">\n                                <label>");
#nullable restore
#line 52 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                                  Write(ViewBag.Categorias[@item.Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                            </div>\n                            <div class=\"card-footer text-center\">\n                                <a class=\"btn btn-danger\" title=\"Eliminar curso\"");
            BeginWriteAttribute("href", " href=\"", 1621, "\"", 1662, 2);
            WriteAttributeValue("", 1628, "/Curso/desagregarCurso?Id=", 1628, 26, true);
#nullable restore
#line 55 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
WriteAttributeValue("", 1654, item.Id, 1654, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""far fa-trash-alt""></i></a>
                                <a class=""btn btn-info"" title=""Me gustó el curso"" href=#><i class=""fas fa-thumbs-up""></i></a>
                                <a class=""btn btn-info"" title=""No me gustó el curso"" href=#><i class=""fas fa-thumbs-down""></i></a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 61 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n\n");
#nullable restore
#line 67 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
 if (ViewBag.Cantidad == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2 class=""text-white text-center"" style=""position:absolute;left:50%;top:50%;transform: translateX(-50%) translateY(-50%)"">Tu lista esta vacia</h2>
    <h5 class=""text-white text-center"" style=""position:absolute;left:50%;top:53%;transform: translateX(-50%) translateY(-50%)"">Agrega cursos en Inicio!</h5>
");
#nullable restore
#line 71 "D:\JOSUE\UPN\9no ciclo\CALIDAD Y PRUEBAS DE SOFTWARE\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    var coll = document.getElementsByClassName(""collapsible"");
    var i;

    for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener(""click"", function () {
            this.classList.toggle(""active"");
            var content = this.nextElementSibling;
            if (content.style.display === ""block"") {
                content.style.display = ""none"";
            } else {
                content.style.display = ""block"";
            }
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
