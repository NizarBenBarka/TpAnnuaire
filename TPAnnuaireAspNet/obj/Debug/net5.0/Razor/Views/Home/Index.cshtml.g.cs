#pragma checksum "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fff81a4302715fde66c0002cae52e357c02aea01"
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
#line 1 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\_ViewImports.cshtml"
using TPAnnuaireAspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\_ViewImports.cshtml"
using TPAnnuaireAspNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff81a4302715fde66c0002cae52e357c02aea01", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8433bd8f66b082f905581638d0741e951faf05b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Accueil Annuaire</h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml"
            foreach (Contact c in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><div class=\"col\">");
#nullable restore
#line 21 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml"
                                    Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\r\n                    <td><div class=\"col\">");
#nullable restore
#line 22 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml"
                                    Write(c.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\r\n                    <td><div class=\"col\">");
#nullable restore
#line 23 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml"
                                    Write(c.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\r\n                    <td><div class=\"col\">");
#nullable restore
#line 24 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml"
                                    Write(c.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Hp\Desktop\AspNETCore\TPAnnuaireAspNet\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
