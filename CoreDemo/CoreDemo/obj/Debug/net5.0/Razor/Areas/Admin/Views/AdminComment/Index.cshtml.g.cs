#pragma checksum "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ad838cc3615bb4e2d20539c32dd6530373c7380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminComment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminComment/Index.cshtml")]
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
#line 1 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad838cc3615bb4e2d20539c32dd6530373c7380", @"/Areas/Admin/Views/AdminComment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c307eba8c33ad990c513f43e60d34a73e2e922", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminComment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""ibox "">
            <div class=""ibox-title"">
                <h5>Yorumlar </h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-wrench""></i>
                    </a>
                    <ul class=""dropdown-menu dropdown-user"">
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config option 1</a>
                        </li>
                        <li>
                            <a href=""#"" class=""dropdown-item"">Config option 2</a>
                        </li>
                    </ul>
                    <a class=""close-link"">
                        <i class=""fa fa-times""></i>
                    </a>
                </div>
            </d");
            WriteLiteral(@"iv>
            <div class=""ibox-content"">

                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Kullanıcı</th>
                            <th>Başlık</th>
                            <th>Blog</th>
                            <th>Puan</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Düzenle</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 51 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                         foreach(var item in Model){


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 54 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                           Write(item.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                           Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                           Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                           Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 58 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                 if (item.BlogScore >= 1 && item.BlogScore <= 3)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"text-danger\"> <i class=\"fa fa-level-down\"></i> ");
#nullable restore
#line 60 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                                                                         Write(item.BlogScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 61 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                 if (item.BlogScore >= 4 && item.BlogScore <= 6)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"text-warning\"> <i class=\"fa fa-level-up\"></i> ");
#nullable restore
#line 65 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                                                                        Write(item.BlogScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 66 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                 if (item.BlogScore >= 7 && item.BlogScore <= 8)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"text-success\"> <i class=\"fa fa-level-up\"></i> ");
#nullable restore
#line 70 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                                                                        Write(item.BlogScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 71 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                 if (item.BlogScore >= 9 && item.BlogScore <= 10)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"text-navy\"> <i class=\"fa fa-level-up\"></i> ");
#nullable restore
#line 75 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                                                                                     Write(item.BlogScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 76 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td> ");
#nullable restore
#line 78 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                             Write(((DateTime)item.Blog.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a href=\"#\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                            <td><a href=\"#\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 82 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
