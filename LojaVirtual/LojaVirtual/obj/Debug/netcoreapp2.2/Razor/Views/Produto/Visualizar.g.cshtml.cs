#pragma checksum "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39fb86175d5e186c42eeb609546ea0496157f987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
#line 3 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#line 8 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 9 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#line 10 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39fb86175d5e186c42eeb609546ea0496157f987", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.ProdutoAgregador.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 405, true);
            WriteLiteral(@"
<br style=""clear: both"" />
<div class=""container"">

    <section id=""product_detail"">
        <div id=""code_prod_detail"">
            <div class=""card"">
                <div class=""row no-gutters"">
                    <aside class=""col-sm-5 border-right"">
                        <article class=""gallery-wrap"">
                            <div class=""img-big-wrap"">
                                <div>
");
            EndContext();
#line 14 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                     if (Model.Imagens != null && Model.Imagens.Count > 0)
                                    {

#line default
#line hidden
            BeginContext(585, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 627, "\"", 669, 1);
#line 16 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 634, Model.Imagens.ElementAt(0).Caminho, 634, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 19, true);
            WriteLiteral(" data-fancybox><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 689, "\"", 730, 1);
#line 16 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 695, Model.Imagens.ElementAt(0).Caminho, 695, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(731, 6, true);
            WriteLiteral("></a>\n");
            EndContext();
#line 17 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(854, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(894, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39fb86175d5e186c42eeb609546ea0496157f9878384", async() => {
                BeginContext(943, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39fb86175d5e186c42eeb609546ea0496157f9878647", async() => {
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
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-fancybox", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(983, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1022, 158, true);
            WriteLiteral("                                </div>\n                            </div> <!-- slider-product.// -->\n                            <div class=\"img-small-wrap\">\n");
            EndContext();
#line 25 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                 if (Model.Imagens != null && Model.Imagens.Count > 0)
                                {
                                    foreach (Imagem imagem in Model.Imagens)
                                    {

#line default
#line hidden
            BeginContext(1416, 71, true);
            WriteLiteral("                                        <div class=\"item-gallery\"> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1487, "\"", 1508, 1);
#line 29 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 1493, imagem.Caminho, 1493, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1509, 8, true);
            WriteLiteral("></div>\n");
            EndContext();
#line 30 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(1589, 293, true);
            WriteLiteral(@"                            </div> <!-- slider-nav.// -->
                        </article> <!-- gallery-wrap .end// -->
                    </aside>
                    <aside class=""col-sm-7"">
                        <article class=""p-5"">
                            <h3 class=""title mb-3"">");
            EndContext();
            BeginContext(1883, 10, false);
#line 37 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                              Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1893, 175, true);
            WriteLiteral("</h3>\n                            <div class=\"mb-3\">\n                                <var class=\"price h3 text-warning\">\n                                    <span class=\"num\">");
            EndContext();
            BeginContext(2069, 25, false);
#line 40 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                 Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 365, true);
            WriteLiteral(@"</span>
                                </var>
                                <span>/unid</span>
                            </div> <!-- price-detail-wrap .// -->
                            <dl>
                                <dt>Descrição</dt>
                                <dd>
                                    <p>
                                        ");
            EndContext();
            BeginContext(2460, 15, false);
#line 48 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                   Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2475, 279, true);
            WriteLiteral(@"
                                    </p>
                                </dd>
                            </dl>
                            <dl class=""row"">
                                <dt class=""col-sm-3"">Peso(kg)</dt>
                                <dd class=""col-sm-9"">");
            EndContext();
            BeginContext(2755, 10, false);
#line 54 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(2765, 125, true);
            WriteLiteral("</dd>\n                                <dt class=\"col-sm-3\">Largura</dt>\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(2891, 13, false);
#line 56 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Largura);

#line default
#line hidden
            EndContext();
            BeginContext(2904, 124, true);
            WriteLiteral("</dd>\n                                <dt class=\"col-sm-3\">Altura</dt>\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3029, 12, false);
#line 58 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Altura);

#line default
#line hidden
            EndContext();
            BeginContext(3041, 129, true);
            WriteLiteral("</dd>\n                                <dt class=\"col-sm-3\">Comprimento</dt>\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3171, 17, false);
#line 60 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Comprimento);

#line default
#line hidden
            EndContext();
            BeginContext(3188, 139, true);
            WriteLiteral("</dd>\n                                <dt class=\"col-sm-3\">Quantidade em estoque</dt>\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3328, 13, false);
#line 62 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Estoque);

#line default
#line hidden
            EndContext();
            BeginContext(3341, 101, true);
            WriteLiteral("</dd>\n                            </dl>\n                            <hr>\n                            ");
            EndContext();
            BeginContext(3442, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39fb86175d5e186c42eeb609546ea0496157f98717648", async() => {
                BeginContext(3562, 60, true);
                WriteLiteral(" <i class=\"fas fa-shopping-cart\"></i> Adicionar ao Carrinho ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\mateu\Desktop\AspNetCurso\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3626, 236, true);
            WriteLiteral("\n                        </article> <!-- card-body.// -->\n                    </aside> <!-- col.// -->\n                </div> <!-- row.// -->\n            </div> <!-- card.// -->\n        </div> <!-- code-wrap.// -->\n    </section>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.ProdutoAgregador.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
