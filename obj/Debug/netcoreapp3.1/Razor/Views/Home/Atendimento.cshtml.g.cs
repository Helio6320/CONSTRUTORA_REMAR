#pragma checksum "C:\Users\user\Desktop\PI UC 08 ATVS\UC_08_PI_ATV_06\Views\Home\Atendimento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2593f860aab7162c83db139ea36b47b8a79988c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Atendimento), @"mvc.1.0.view", @"/Views/Home/Atendimento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2593f860aab7162c83db139ea36b47b8a79988c", @"/Views/Home/Atendimento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843bb7f008d92d06b2662148e355b19098e20924", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Atendimento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>
<html lang=""pr-br"">

<p>
<h2 class=""TituloAtendimento"">Prezado cliente, fique a vontade para nos enviar suas prefer??ncias.</h2>
<ul>
    <li>Uma ou mais su??tes?</li>
    <li>Cozinha aberta ou fechada?</li>
    <li>??rea de servi??o interna ou externa?</li>
    <li>Vagas de garagem?</li>
</ul>
</p>

Confira as sugest??es de nossos clientes, <a class=""consulta"" href=""/Home/Sugestao"">clicando aqui</a>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c4459", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>CONSTRUTORA REMAR</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
            ");
            WriteLiteral(@"    </li>
                ||<li class=""nav-item"">
                    <a class=""nav-link"" href=""/Home/FaleConosco"">Consulte nossos profissionais</a>
                </li>
                ||<li class=""nav-item"">
                    <a class=""nav-link"" href=""/Home/Cadastro"">Cadastro</a>
                </li>
                ||<li class=""nav-item"">
                    <a class=""nav-link"" href=""/Home/Sugestao"">Sugest??es</a>
                </li>
            </ul>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c7250", async() => {
                WriteLiteral("\r\n                <input class=\"form-control mr-sm-2\" type=\"text\" placeholder=\"Busca\" aria-label=\"Busca\">\r\n                <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Login</button>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n    </nav>\r\n</header>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c8845", async() => {
                WriteLiteral("\r\n    <h2 class=\"SubTituloAtendimento\">Departamento t??cnico.</h2>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c9176", async() => {
                    WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputName"">Solicita????es</label>
                <input type=""name"" class=""form-control"" id=""inputName"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputName"">Nome</label>
                <input type=""name"" class=""form-control"" id=""inputName"">
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputEmail4"">Email</label>
                <input type=""email"" class=""form-control"" id=""inputEmail4"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputPassword4"">Senha</label>
                <input type=""password"" class=""form-control"" id=""inputPassword4"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputTelefone"">Telefone</label>
            <input type=""text"" cla");
                    WriteLiteral("ss=\"form-control\" id=\"Telefone\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 3605, "\"", 3619, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"inputAddress2\">Endere??o</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"Endereco\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 3795, "\"", 3809, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputCity"">Cidade</label>
                <input type=""text"" class=""form-control"" id=""inputCity"">
            </div>
            <div class=""form-group col-md-4"">
                <label for=""inputState"">Estado</label>
                <select id=""inputState"" class=""form-control"">
                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c11589", async() => {
                        WriteLiteral("Buscar...");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c13018", async() => {
                        WriteLiteral("...");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group col-md-2"">
                <label for=""inputZip"">CEP</label>
                <input type=""text"" class=""form-control"" id=""inputZip"">
            </div>
        </div>
        <div class=""form-group"">
            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
                <label class=""form-check-label"" for=""gridCheck"">
                    Dados conferidos!!!
                </label>
            </div>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Salvar</button>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <h2 class=\"SubTituloAtendimento\">Departamento de vendas - Corretores.</h2>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c15880", async() => {
                    WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputName"">Solicita????es</label>
                <input type=""name"" class=""form-control"" id=""inputName"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputName"">Nome</label>
                <input type=""name"" class=""form-control"" id=""inputName"">
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputEmail4"">Email</label>
                <input type=""email"" class=""form-control"" id=""inputEmail4"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputPassword4"">Senha</label>
                <input type=""password"" class=""form-control"" id=""inputPassword4"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputTelefone"">Telefone</label>
            <input type=""text"" cla");
                    WriteLiteral("ss=\"form-control\" id=\"Telefone\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 6125, "\"", 6139, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"inputAddress2\">Endere??o</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"Endereco\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 6315, "\"", 6329, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputCity"">Cidade</label>
                <input type=""text"" class=""form-control"" id=""inputCity"">
            </div>
            <div class=""form-group col-md-4"">
                <label for=""inputState"">Estado</label>
                <select id=""inputState"" class=""form-control"">
                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c18294", async() => {
                        WriteLiteral("Buscar...");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2593f860aab7162c83db139ea36b47b8a79988c19723", async() => {
                        WriteLiteral("...");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group col-md-2"">
                <label for=""inputZip"">CEP</label>
                <input type=""text"" class=""form-control"" id=""inputZip"">
            </div>
        </div>
        <div class=""form-group"">
            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
                <label class=""form-check-label"" for=""gridCheck"">
                    Dados conferidos!!!
                </label>
            </div>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Salvar</button>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
