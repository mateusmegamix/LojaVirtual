#pragma checksum "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79639aaac302a58e1cb41b12386baf7125b7cfce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Pedido_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Pedido/Index.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Pedido_Index))]
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
#line 3 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 5 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 6 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 7 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 8 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 9 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#line 10 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79639aaac302a58e1cb41b12386baf7125b7cfce", @"/Areas/Cliente/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f263bc763b2fa2629d545c9146b92aa0eb6a0c5", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 41, true);
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"container\">\r\n");
            EndContext();
#line 8 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
       await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
     if (Model.Count > 0)
    {


#line default
#line hidden
            BeginContext(223, 611, true);
            WriteLiteral(@"        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">N° Pedido</th>
                        <th scope=""col"">Data da compra</th>
                        <th scope=""col"">Valor</th>
                        <th scope=""col"">Forma de Pagamento</th>
                        <th scope=""col"">Situação</th>
                        <th scope=""col"">NF-e</th>
                        <th scope=""col"">Ações</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 27 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                     foreach (var pedido in Model)
                    {

#line default
#line hidden
            BeginContext(909, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(972, 9, false);
#line 30 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.Id);

#line default
#line hidden
            EndContext();
            BeginContext(981, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(983, 20, false);
#line 30 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                      Write(pedido.TransactionId);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1043, 42, false);
#line 31 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.DataRegistro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1125, 31, false);
#line 32 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1196, 21, false);
#line 33 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1257, 15, false);
#line 34 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1312, 10, false);
#line 35 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                           Write(pedido.NFE);

#line default
#line hidden
            EndContext();
            BeginContext(1322, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1395, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79639aaac302a58e1cb41b12386baf7125b7cfce9685", async() => {
                BeginContext(1448, 10, true);
                WriteLiteral("Visualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                                                             WriteLiteral(pedido.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1462, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1553, 64, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 44 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1624, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1629, 94, false);
#line 45 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina })));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
