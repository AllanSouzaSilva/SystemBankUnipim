#pragma checksum "C:\Users\AllanSouza\OneDrive\Documentos\SystemBankUnipim\Systembankunipim\Systembankunipim\Views\Relatorio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33378d2f59a945d4f8db3235b233570106dfa9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorio_Index), @"mvc.1.0.view", @"/Views/Relatorio/Index.cshtml")]
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
#line 1 "C:\Users\AllanSouza\OneDrive\Documentos\SystemBankUnipim\Systembankunipim\Systembankunipim\Views\_ViewImports.cshtml"
using Systembankunipim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AllanSouza\OneDrive\Documentos\SystemBankUnipim\Systembankunipim\Systembankunipim\Views\_ViewImports.cshtml"
using Systembankunipim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33378d2f59a945d4f8db3235b233570106dfa9a", @"/Views/Relatorio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b50efbbf8c0ba1f0939802adece55c5e06a176c", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h1 class=""display-4"">Relatório de lucros</h1>
<hr />
<!--  POor questões de muitos problemas com a interação com o banco não conseguimos implementar o relatório com os dados do banco   
    e isso poderia implicar diretamente no prazo de entrega e fizemos algo ficticio para não deixarmos de fora 
    -->
<table class=""table table-dark"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Lançamentos</th>
            <th scope=""col"">Lançamentos</th>
            <th scope=""col"">Total de Lucros</th>

        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>222.00</td>
            <td>220.00</td>
            <td>5445.00</td>

        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>456.00</td>
            <td>775.00</td>
            <td>3500.00</td>

        </tr>
        <tr>
            <th scope=""row"">3</th>
            <td>234.00</td>
            <td>434.00</td>
       ");
            WriteLiteral(@"     <td>2500.00</td>

        </tr>
        <tr>
            <th scope=""row"">4</th>
            <td>123.00</td>
            <td>345.00</td>
            <td>1020.00</td>

        </tr>
        <tr>
            <th scope=""row"">5</th>
            <td>212.00</td>
            <td>340.00</td>
            <td>5601.00</td>
        </tr>
        <tr>
            <th scope=""row"">6</th>
            <td>323.00</td>
            <td>655.00</td>
            <td>5524.00</td>
        </tr>
        <tr>
            <th scope=""row"">7</th>
            <td>666.00</td>
            <td>555.00</td>
            <td>3541.00</td>
        </tr>
        <tr>
            <th scope=""row"">8</th>
            <td>432.00</td>
            <td>243.00</td>
            <td>2020.00</td>
        </tr>
        <tr>
            <th scope=""row"">9</th>
            <td>140.00</td>
            <td>327.00</td>
            <td>2010.00</td>

        </tr>
    </tbody>
</table>");
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