#pragma checksum "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6ea37af6f6a1191343873d87dc2e2bf2ad470f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminUsers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminUsers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminUsers/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminUsers_Index))]
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
#line 1 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6ea37af6f6a1191343873d87dc2e2bf2ad470f", @"/Areas/Admin/Views/AdminUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add87ae52faa7df67fbebca5d3c39a845d0e03fe", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GraniteHouse.Models.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 174, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\"> Admin Users List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(272, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13ffd791a4024812a18d1b794666589e", async() => {
                BeginContext(345, 48, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Admin User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(397, 154, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(552, 32, false);
#line 23 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(584, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(640, 33, false);
#line 26 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(673, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(729, 39, false);
#line 29 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(768, 124, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Disabled\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 37 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(941, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1002, 31, false);
#line 41 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1101, 32, false);
#line 44 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
               Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1201, 38, false);
#line 47 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
               Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 50 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                     if (item.LockoutEnd != null && item.LockoutEnd > DateTime.Now)
                    {

#line default
#line hidden
            BeginContext(1394, 49, true);
            WriteLiteral("                        <label>Disabled</label>\r\n");
            EndContext();
#line 53 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1466, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 56 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                     if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                    {

#line default
#line hidden
            BeginContext(1619, 64, true);
            WriteLiteral("                        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1683, "\"", 1720, 1);
#line 58 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 1690, Url.Action("Edit/" + item.Id), 1690, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1721, 153, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        </a>\r\n                        <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1874, "\"", 1911, 1);
#line 61 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 1881, Url.Action("Delete/"+item.Id), 1881, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1912, 95, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-trash-alt\"></i>\r\n                        </a>\r\n");
            EndContext();
#line 64 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2030, 44, true);
            WriteLiteral("                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 68 "C:\Users\Mike\Desktop\code\Granite House\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2087, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GraniteHouse.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
