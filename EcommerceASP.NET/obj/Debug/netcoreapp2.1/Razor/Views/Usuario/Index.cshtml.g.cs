#pragma checksum "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca63f72635f81799b8788e4c44e2fd85757fc26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
#line 1 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\_ViewImports.cshtml"
using EcommerceASP.NET;

#line default
#line hidden
#line 2 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\_ViewImports.cshtml"
using EcommerceASP.NET.Models;

#line default
#line hidden
#line 3 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\_ViewImports.cshtml"
using Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca63f72635f81799b8788e4c44e2fd85757fc26", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de65dc932d1622aeb45aed8730723c2bfb60f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Usuarios Cadastrados";

#line default
#line hidden
            BeginContext(85, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(92, 17, false);
#line 6 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 10, true);
            WriteLiteral("</h2>\r\n<p>");
            EndContext();
            BeginContext(119, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "699848ae532a4e0bb75ac6aa3a597ad9", async() => {
                BeginContext(166, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(180, 358, true);
            WriteLiteral(@"</p>
<hr />

<div class=""row"">
    <div class=""col-sm-12"">
        <table class=""table table-striped table-hover"">
            <thead class=""success"">
                <tr>
                    <td>Email</td>
                    <td>Senha</td>
                    <td>Criado em</td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 21 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(603, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(658, 10, false);
#line 24 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(668, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(704, 10, false);
#line 25 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml"
                       Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(714, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(750, 13, false);
#line 26 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml"
                       Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(763, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Jony\source\repos\EcommerceASP.NET\EcommerceASP.NET\Views\Usuario\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(816, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
