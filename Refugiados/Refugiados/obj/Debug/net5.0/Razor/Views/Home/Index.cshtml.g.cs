#pragma checksum "D:\GitHub\proj_refugiados\Refugiados\Refugiados\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ee614699ffd9a3f284e793c1904060baa3b451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\GitHub\proj_refugiados\Refugiados\Refugiados\Views\_ViewImports.cshtml"
using Refugiados;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\proj_refugiados\Refugiados\Refugiados\Views\_ViewImports.cshtml"
using Refugiados.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ee614699ffd9a3f284e793c1904060baa3b451", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e20c9aebb0f2687060b6df4234d0d0952b50a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doacaos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\GitHub\proj_refugiados\Refugiados\Refugiados\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Slide Carrossel-->
<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img class=""d-block w-100"" src=""/assets/Refu_1.jpeg"" alt=""Primeiro Slide"">
            <div class=""carousel-caption d-none d-md-block"">
                <h5>Ajude a Nossa Plataforma</h5>
                <p>através dela ajudamos milhares de refugiados que chegam ao Brasil</p>
            </div>
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""/assets/Refu_2.jpeg"" alt=""Segundo Slide"">
            <div class=""carousel-caption d-none d-md-block"">
                <h5>Complementamos o SUS</h5>");
            WriteLiteral(@"
                <p>nosso serviço complementa os serviços públicos</p>
            </div>
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""/assets/Refu_3.jpeg"" alt=""Terceiro Slide"">
            <div class=""carousel-caption d-none d-md-block"">
                <h5>Precisamos de Investimento</h5>
                <p>temos planos para desenvolver mais soluções</p>
            </div>
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Anterior</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Próximo</span>
    </a>
</div>



<!-- Section Doações -->
<section class=""page-section bg-light"">
    <div class=""container"">");
            WriteLiteral(@"
        <div class=""text-center"">
            <h2 class=""section-heading text-uppercase pt-5"">Ajude os Refugiados</h2>
            <h3 class=""section-subheading text-muted pt-3 pb-3"">É graças a essas contribuições constantes que podemos nos planejar, agir rapidamente em situações urgentes como a pandemia do novo coronavírus e outras e emergências. Tudo isso significa salvar vidas!</h3>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-sm-6 mb-4"">
                <!-- Doação item 1-->
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" href=""/Doacaos/Create"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""/assets/Refu_5.jpeg"" alt=""..."" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""po");
            WriteLiteral("rtfolio-caption-heading pt-1\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ee614699ffd9a3f284e793c1904060baa3b4517849", async() => {
                WriteLiteral("R$ 40,00/mês");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""portfolio-caption-subheading text-muted text-center"">Você fornece kit de higiene pessoal e insumos ambulatorial.</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 mb-4"">
                <!-- Doação item 2-->
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-bs-toggle=""modal"" href=""/Doacaos/Create"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""/assets/Refu_5.jpeg"" alt=""..."" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading pt-1"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ee614699ffd9a3f284e793c1904060baa3b45110455", async() => {
                WriteLiteral("Doações avulsos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""portfolio-caption-subheading text-muted text-center"">Doe quanto permitir seu coração.</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 mb-4"">
                <!-- Doação item 3-->
                <div class=""portfolio-item"">
                    <a class=""portfolio-link"" data-bs-toggle=""modal"" href=""/Doacaos/Create"">
                        <div class=""portfolio-hover"">
                            <div class=""portfolio-hover-content""><i class=""fas fa-plus fa-3x""></i></div>
                        </div>
                        <img class=""img-fluid"" src=""/assets/Refu_5.jpeg"" alt=""..."" />
                    </a>
                    <div class=""portfolio-caption"">
                        <div class=""portfolio-caption-heading pt-1"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ee614699ffd9a3f284e793c1904060baa3b45113038", async() => {
                WriteLiteral("R$ 85,00/mês");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""portfolio-caption-subheading text-muted text-center"">Você fornece insumos para tratamentos odontológicos e oftamológicos.</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-6 mb-4 mb-sm-0"">
            </div>
        </div>
    </div>
</section>

<!-- Perguntas Mais Frequentes-->
<section class=""page-section bg-light"">
    <div class=""container"">
        <div class=""text-center"">
            <h2 class=""section-heading text-uppercase pt-5"">Perguntas Mais Frequentes</h2>
            <h3 class=""section-subheading text-muted pt-3 pb-3"">Como podemos te ajudar? Preparamos uma área de perguntas frequentes onde você pode tirar todas as suas dúvidas sobre nossos projeto. Confira!</h3>
        </div>
        <div id=""accordion"">

            <div class=""card"">
                <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapse");
            WriteLiteral(@"Three"">
                        Collapsible Group Item #3
                    </a>
                </div>
                <div id=""collapseThree"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        Lorem ipsum..
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    <a class=""card-link"" data-toggle=""collapse"" href=""#collapseOne"">
                        Como posso contribuir para o trabalho?
                    </a>
                </div>
                <div id=""collapseOne"" class=""collapse show"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        Lorem ipsum..
                    </div>
                </div>
            </div>

            <div class=""card"">
                <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseTwo"">
         ");
            WriteLiteral(@"               Collapsible Group Item #2
                    </a>
                </div>
                <div id=""collapseTwo"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        Lorem ipsum..
                    </div>
                </div>
            </div>

            <div class=""card"">
                <div class=""card-header"">
                    <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseThree"">
                        Collapsible Group Item #3
                    </a>
                </div>
                <div id=""collapseThree"" class=""collapse"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        Lorem ipsum..
                    </div>
                </div>
            </div>

        </div>
    </div>
 </section>
");
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
