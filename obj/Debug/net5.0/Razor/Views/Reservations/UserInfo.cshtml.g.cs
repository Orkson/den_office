#pragma checksum "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a44e07e930624a8e8926c53c96410ca68e55f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_UserInfo), @"mvc.1.0.view", @"/Views/Reservations/UserInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a44e07e930624a8e8926c53c96410ca68e55f8", @"/Views/Reservations/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9604176834238a9f8114d1b1988ebee5998c835d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservations_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<den_office.Models.Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n<p> ");
#nullable restore
#line 7 "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml"
Write(ViewData["User"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<p> ");
#nullable restore
#line 8 "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml"
Write(ViewData["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p> ");
#nullable restore
#line 10 "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml"
Write(ViewData["Service"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 15 "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml"
       Write(Html.DisplayFor(modelItem => item.ServiceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 18 "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml"
       Write(Html.DisplayFor(modelItem => item.ServiceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 21 "D:\Projects\C#\den_office\den_office\Views\Reservations\UserInfo.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<den_office.Models.Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
