#pragma checksum "D:\Projects\C#\den_office\den_office\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3865ace2dd8761528844e9f58e3cdfb513cc67a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
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
#line 1 "D:\Projects\C#\den_office\den_office\Views\_ViewImports.cshtml"
using den_office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\C#\den_office\den_office\Views\_ViewImports.cshtml"
using den_office.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
<<<<<<< Updated upstream:obj/Debug/net5.0/Razor/Views/HelloWorld/Index.cshtml.g.cs
=======
>>>>>>> d2acf5ae4fea832f2816cf27f7bf46bba95601b7
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3865ace2dd8761528844e9f58e3cdfb513cc67a1", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9604176834238a9f8114d1b1988ebee5998c835d", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<den_office.Tests.Game>>
=======
#nullable restore
#line 3 "D:\Projects\C#\den_office\den_office\Areas\Identity\Pages\_ViewImports.cshtml"
using den_office.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\C#\den_office\den_office\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using den_office.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa2ad01473fa832304d2166b6c6d5536eb62725", @"/Areas/Identity/Pages/Account/ResetPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3b7bf1e1b2cd4963fb009556580aadd0505661", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a01b4bc6d3c474ceed58a34be2ec613de92a82d5", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_ResetPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
>>>>>>> Stashed changes:obj/Debug/net5.0/Razor/Areas/Identity/Pages/Account/ResetPasswordConfirmation.cshtml.g.cs
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3865ace2dd8761528844e9f58e3cdfb513cc67a13075", async() => {
                WriteLiteral("\r\n    <h1>Hi hello there</h1>\r\n    <table>\r\n        <tbody>\r\n            <tr>\r\n                <td>Id</td>\r\n                <td>Name</td>\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 12 "D:\Projects\C#\den_office\den_office\Views\HelloWorld\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 16 "D:\Projects\C#\den_office\den_office\Views\HelloWorld\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "D:\Projects\C#\den_office\den_office\Views\HelloWorld\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "D:\Projects\C#\den_office\den_office\Views\HelloWorld\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream:obj/Debug/net5.0/Razor/Views/HelloWorld/Index.cshtml.g.cs
                WriteLiteral("    </table>\r\n");
=======
            WriteLiteral("</h1>\r\n<p>\r\n    Your password has been reset. Please ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fa2ad01473fa832304d2166b6c6d5536eb627254751", async() => {
                WriteLiteral("click here to log in");
>>>>>>> Stashed changes:obj/Debug/net5.0/Razor/Areas/Identity/Pages/Account/ResetPasswordConfirmation.cshtml.g.cs
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
            WriteLiteral("\r\n\r\n");
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
<<<<<<< Updated upstream:obj/Debug/net5.0/Razor/Views/HelloWorld/Index.cshtml.g.cs
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<den_office.Tests.Game>> Html { get; private set; }
=======
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResetPasswordConfirmationModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetPasswordConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetPasswordConfirmationModel>)PageContext?.ViewData;
        public ResetPasswordConfirmationModel Model => ViewData.Model;
>>>>>>> Stashed changes:obj/Debug/net5.0/Razor/Areas/Identity/Pages/Account/ResetPasswordConfirmation.cshtml.g.cs
    }
}
#pragma warning restore 1591
