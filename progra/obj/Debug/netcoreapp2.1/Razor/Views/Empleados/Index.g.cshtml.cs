#pragma checksum "C:\Users\Clase\Desktop\progra\Views\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059486c52fa40abeb782eeafa077be7a00380102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Index), @"mvc.1.0.view", @"/Views/Empleados/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/Index.cshtml", typeof(AspNetCore.Views_Empleados_Index))]
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
#line 1 "C:\Users\Clase\Desktop\progra\Views\_ViewImports.cshtml"
using progra;

#line default
#line hidden
#line 2 "C:\Users\Clase\Desktop\progra\Views\_ViewImports.cshtml"
using progra.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"059486c52fa40abeb782eeafa077be7a00380102", @"/Views/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65eba4c681e522bf23346ee7cd956b4e945c49e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Empleado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 37, true);
            WriteLiteral("\r\n<h1>Listado de Empleados</h1>\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Clase\Desktop\progra\Views\Empleados\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(93, 16, true);
            WriteLiteral("    <h2>Nombre: ");
            EndContext();
            BeginContext(110, 11, false);
#line 8 "C:\Users\Clase\Desktop\progra\Views\Empleados\Index.cshtml"
           Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(121, 35, true);
            WriteLiteral("</h2>\r\n    <h2>Fecha Contratacion: ");
            EndContext();
            BeginContext(157, 22, false);
#line 9 "C:\Users\Clase\Desktop\progra\Views\Empleados\Index.cshtml"
                       Write(item.FechaContratacion);

#line default
#line hidden
            EndContext();
            BeginContext(179, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 10 "C:\Users\Clase\Desktop\progra\Views\Empleados\Index.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
