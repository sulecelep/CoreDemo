#pragma checksum "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c3716d1803e395a8cbaeca934b31ece80d39e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_AddCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c3716d1803e395a8cbaeca934b31ece80d39e3", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c307eba8c33ad990c513f43e60d34a73e2e922", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Kategori Ekleme Paneli</h1>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm("AddCategory", "Category", FormMethod.Post))
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x=>x.CategoryName, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
#nullable restore
#line 17 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Açıklaması"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextAreaFor(x=>x.CategoryDescription,10,3, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
            WriteLiteral("\t<button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 23 "C:\Users\CELEP\source\repos\CoreDemo\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
