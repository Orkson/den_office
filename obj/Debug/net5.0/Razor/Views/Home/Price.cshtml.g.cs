#pragma checksum "D:\Marcin\studia\praca dypl- płyta - wersja ostateczna\den_office\Views\Home\Price.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3963b75c4ae8a4ae12db909f7da76e77a4eec75f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Price), @"mvc.1.0.view", @"/Views/Home/Price.cshtml")]
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
#line 1 "D:\Marcin\studia\praca dypl- płyta - wersja ostateczna\den_office\Views\_ViewImports.cshtml"
using den_office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marcin\studia\praca dypl- płyta - wersja ostateczna\den_office\Views\_ViewImports.cshtml"
using den_office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3963b75c4ae8a4ae12db909f7da76e77a4eec75f", @"/Views/Home/Price.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9604176834238a9f8114d1b1988ebee5998c835d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Price : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Marcin\studia\praca dypl- płyta - wersja ostateczna\den_office\Views\Home\Price.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3963b75c4ae8a4ae12db909f7da76e77a4eec75f3544", async() => {
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3963b75c4ae8a4ae12db909f7da76e77a4eec75f4510", async() => {
                WriteLiteral(@"
    <div class=""col-md-12"">
        <h1 style=""text-align:center; margin-top:50px; margin-bottom:50px;"">Cennik usług w DentOptimal</h1>

        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th style=""text-align:center"">
                        Rodzaj usługi
                    </th>
                    <th>
                        Cena
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        Okresowe badanie stomatologiczne
                    </td>
                    <td>
                        50 zł
                    </td>
                </tr>
                <tr>
                    <td>
                        Znieczulenie do zabiegu
                    </td>
                    <td>
                        60 zł
                    </td>
                </tr>
                <tr>
                    <td>
          ");
                WriteLiteral(@"              Konsultacja lekarska
                    </td>
                    <td>
                        100 zł
                    </td>
                </tr>
                <tr>
                    <td>
                        Piaskowanie
                    </td>
                    <td>
                        150 zł
                    </td>
                </tr>
                <tr>
                    <td>
                        Fluoryzacja
                    </td>
                    <td>
                        100 zł
                    </td>
                </tr>
                <tr>
                    <td>
                        Wybielanie zębów
                    </td>
                    <td>
                        1000 zł
                    </td>
                </tr>
                <tr>
                    <td>
                        Ekstrakcja zęba mlecznego
                    </td>
                    <td>
                        100 zł
   ");
                WriteLiteral(@"                 </td>
                </tr>
                <tr>
                    <td>
                        Ekstrakcja zęba stałego
                    </td>
                    <td>
                        300 zł
                    </td>
                </tr>
                <tr>
                    <td>
                        Chirurgiczna ekstrakcja zęba
                    </td>
                    <td>
                        300-500 zł
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
