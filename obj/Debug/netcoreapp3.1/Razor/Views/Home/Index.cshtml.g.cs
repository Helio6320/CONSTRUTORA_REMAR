#pragma checksum "C:\Users\user\Desktop\PI UC 08 ATVS\UC_08_PI_ATV_06\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee94bc38e60cc6521a246fc79d0772bdc3ef99a"
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
#line 1 "C:\Users\user\Desktop\PI UC 08 ATVS\UC_08_PI_ATV_06\Views\_ViewImports.cshtml"
using UC_08_PI_ATV_06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\PI UC 08 ATVS\UC_08_PI_ATV_06\Views\_ViewImports.cshtml"
using UC_08_PI_ATV_06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee94bc38e60cc6521a246fc79d0772bdc3ef99a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843bb7f008d92d06b2662148e355b19098e20924", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mt-2 mt-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n<div class=\"text-center\">\r\n  <h1 class=\"display-4\">BEM VINDO A CONSTRUTORA REMAR</h1>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee94bc38e60cc6521a246fc79d0772bdc3ef99a3868", async() => {
                WriteLiteral(@"
  <header>
    <nav class=""navbar navbar-expand-md navbar-dark fixed-top bg-dark"">
      <a class=""navbar-brand"" href=""#"">Construtora REMAR</a>
      <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarCollapse""
        aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
      </button>
      <div class=""collapse navbar-collapse"" id=""navbarCollapse"">
        <ul class=""navbar-nav mr-auto"">
          <li class=""nav-item active"">
            <a class=""nav-link"" href=""/Home/Index"">Home <span class=""sr-only"">(current)</span></a>
          </li>
          ||<li class=""nav-item"">
            <a class=""nav-link"" href=""/Home/Investimentos"">Op????es de Investimentos</a>
          </li>
          ||<li class=""nav-item"">
            <a class=""nav-link"" href=""/Home/Atendimento"">Atendimento ao Cliente</a>
          </li>
          ||<li class=""nav-item"">
            <a class=""nav-link"" ");
                WriteLiteral(@"href=""/Home/FaleConosco"">Consulte nossos profissionais</a>
          </li>
          ||<li class=""nav-item"">
            <a class=""nav-link"" href=""/Home/Cadastro"">Cadastro</a>
          </li>
          ||<li class=""nav-item"">
            <a class=""nav-link"" href=""/Home/Sugestao"">Sugest??es</a>
          </li>
        </ul>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee94bc38e60cc6521a246fc79d0772bdc3ef99a5590", async() => {
                    WriteLiteral("\r\n          <input class=\"form-control mr-sm-2\" type=\"text\" placeholder=\"Busca\" aria-label=\"Busca\">\r\n          <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Login</button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
      </div>
    </nav>

    <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
      <div class=""carousel-inner"">
        <div class=""carousel-item active"">
          <img src=""/imagem/sobrado.JPG"" class=""d-block w-100"" alt=""sobrado.JPG"">
        </div>
        <div class=""carousel-item"">
          <img src=""/imagem/prontos_para_morar.JPG"" class=""d-block w-100"" alt=""prontos_para_morar.JPG"">
        </div>
        <div class=""carousel-item"">
          <img src=""/imagem/sobrado_fundos.JPG"" class=""d-block w-100"" alt=""sobrado_fundos.JPG"">
        </div>
      </div>
      <button class=""carousel-control-prev"" type=""button"" data-target=""#carouselExampleControls"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
      </button>
      <button class=""carousel-control-next"" type=""button"" data-target=""#carouselExampleControls"" data-slide=""next"">
        <span class=""carousel-cont");
                WriteLiteral(@"rol-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
      </button>
    </div>

    <main>
      <h2 class=""subindex"">Confira algumas de nossas obras!</h2>

      <div class=""container"">

        <div class=""row mb-2"">
          <div class=""col-md-6"">
            <div
              class=""row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative"">
              <div class=""col p-4 d-flex flex-column position-static"">
                <strong class=""d-inline-block mb-2 text-primary"" _msthash=""1451996""
                  _msttexthash=""60918"">Sobrados</strong>
                <h3 class=""mb-0"" _msthash=""1214499"" _msttexthash=""263679"">Este pode ser seu!!</h3>
                <img src=""/imagem/sobrado_grande.JPG"" width=""400"">
                <p class=""card-text mb-auto"" _msthash=""1167569"" _msttexthash=""6101901"">Temos alguns sobrados em fase
                  final de constru????o. Fale com nossos especialistas e venha conferir");
                WriteLiteral(@".</p>
                <a class=""consulta"" href=""/Home/FaleConosco"" class=""stretched-link"" _msthash=""1166321""
                  _msttexthash=""233116"">Consulte nossos profissionais, <a class=""consulta""
                    href=""/Home/FaleConosco"">clicando aqui</a></a>
                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                  COMPRE AGORA!!
                </button>
              </div>

            </div>
          </div>
          <div class=""col-md-6"">
            <div
              class=""row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative"">
              <div class=""col p-4 d-flex flex-column position-static"">
                <strong class=""d-inline-block mb-2 text-primary"" _msthash=""1451996""
                  _msttexthash=""60918"">Sobrados</strong>
                <h3 class=""mb-0"" _msthash=""1214499"" _msttexthash=""263679"">Beleza e funcionalidade, confira!!</h3>
            ");
                WriteLiteral(@"    <img src=""/imagem/sobrados.JPG"" width=""400"">
                <p class=""card-text mb-auto"" _msthash=""1167569"" _msttexthash=""6101901"">Temos alguns sobrados em fase
                  final de constru????o. Fale com nossos especialistas e venha conferir.</p>
                <a class=""consulta"" href=""/Home/FaleConosco"" class=""stretched-link"" _msthash=""1166321""
                  _msttexthash=""233116"">Consulte nossos profissionais, <a class=""consulta""
                    href=""/Home/FaleConosco"">clicando aqui</a></a>
                    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                  COMPRE AGORA!!
                </button>
              </div>

            </div>
          </div>
          <div class=""col-md-6"">
            <div
              class=""row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative"">
              <div class=""col p-4 d-flex flex-column position-static"">
             ");
                WriteLiteral(@"   <strong class=""d-inline-block mb-2 text-primary"" _msthash=""1451996"" _msttexthash=""60918"">Casas
                  T??rreas</strong>
                <h3 class=""mb-0"" _msthash=""1214499"" _msttexthash=""263679"">Esta pode ser sua!!</h3>
                <img src=""/imagem/casa_terrea.JPG"" width=""400"">
                <p class=""card-text mb-auto"" _msthash=""1167569"" _msttexthash=""6101901"">Temos algumas casas em fase final
                  de constru????o. Fale com nossos especialistas e venha conferir.</p>
                <a class=""consulta"" href=""/Home/FaleConosco"" class=""stretched-link"" _msthash=""1166321""
                  _msttexthash=""233116"">Consulte nossos profissionais, <a class=""consulta""
                    href=""/Home/FaleConosco"">clicando aqui</a></a>
                    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                  COMPRE AGORA!!
                </button>
              </div>

            </div>
          </div>
          <di");
                WriteLiteral(@"v class=""col-md-6"">
            <div
              class=""row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative"">
              <div class=""col p-4 d-flex flex-column position-static"">
                <strong class=""d-inline-block mb-2 text-primary"" _msthash=""1451996"" _msttexthash=""60918"">Tem terreno e
                  quer construir?</strong>
                <h3 class=""mb-0"" _msthash=""1214499"" _msttexthash=""263679"">Do sonho a realiza????o!!</h3>
                <img src=""/imagem/terreno.JPG"" width=""400"">
                <p class=""card-text mb-auto"" _msthash=""1167569"" _msttexthash=""6101901""> Projetamos e constru??mos. Fale
                  com nossos especialistas e venha conferir.</p>
                <a class=""consulta"" href=""/Home/FaleConosco"" class=""stretched-link"" _msthash=""1166321""
                  _msttexthash=""233116"">Consulte nossos profissionais, <a class=""consulta""
                    href=""/Home/FaleConosco"">clicando aqui</a></a>
          ");
                WriteLiteral(@"          <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"" class=""text-decoration-line: underline;"">
                  COMPRE AGORA!!
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>

    </main>

    </div>


    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
      aria-hidden=""true"">
      <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
          <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLabel"">COMPRE AGORA!!</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          <div class=""modal-body"">
            ...
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-second");
                WriteLiteral(@"ary"" data-dismiss=""modal"">Close</button>
            <button type=""button"" class=""btn btn-primary"">Save changes</button>
          </div>
        </div>
      </div>
    </div>

    <div class=""modal fade"" id=""exampleModal1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1""
      aria-hidden=""true"">
      <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
          <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLabel"">COMPRE AGORA!!</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          <div class=""modal-body"">
            ...
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            <button type=""button"" class=""btn btn-primary"">Save changes</button>
          </div>
   ");
                WriteLiteral(@"     </div>
      </div>
    </div>

    <div class=""modal fade"" id=""exampleModal2"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel2""
      aria-hidden=""true"">
      <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
          <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLabel"">COMPRE AGORA!!</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          <div class=""modal-body"">
            ...
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            <button type=""button"" class=""btn btn-primary"">Save changes</button>
          </div>
        </div>
      </div>
    </div>

    <div class=""modal fade"" id=""exampleModal3"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModa");
                WriteLiteral(@"lLabel3""
      aria-hidden=""true"">
      <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
          <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLabel"">COMPRE AGORA!!</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          <div class=""modal-body"">
            ...
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            <button type=""button"" class=""btn btn-primary"">Save changes</button>
          </div>
        </div>
      </div>
    </div>

    <script src=""https://cdn.jsdelivr.net/npm/jquery.com/jquery@3.5.1/dist/jquery.slim.min.js""
      integrity=""sha384-DfXdz2htPH01sSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous"">
      </script>
    <script src=""h");
                WriteLiteral("ttps://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.bundle.min.js\"\r\n      integrity=\"sha384-fQybjgWLrvvRgtW6bF1B7jaZrFsaBXjsOMm/tB9LTS580NXgqbR9W8oWht/amnpF\" crossorigin=\"anonymous\">\r\n      </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
