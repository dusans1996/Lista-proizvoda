#pragma checksum "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b53403754c1812f370fb44a72e7b1c78fc9e4baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvodi_Delete), @"mvc.1.0.view", @"/Views/Proizvodi/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Proizvodi/Delete.cshtml", typeof(AspNetCore.Views_Proizvodi_Delete))]
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
#line 1 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\_ViewImports.cshtml"
using Proizvodi;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\_ViewImports.cshtml"
using Proizvodi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53403754c1812f370fb44a72e7b1c78fc9e4baf", @"/Views/Proizvodi/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbc7b0b665666b0e03c1dfe1221d39176e9e665", @"/Views/_ViewImports.cshtml")]
    public class Views_Proizvodi_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proizvodi.Models.Proizvod>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml"
  
    ViewData["Title"] = "Brisanje";

#line default
#line hidden
            BeginContext(80, 224, true);
            WriteLiteral("<br />\r\n<h3>Da li ste sigurni da zelite da obrisete proizvod?</h3>\r\n<br />\r\n<div>\r\n    <h4>Proizvod</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Naziv\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 11, false);
#line 17 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml"
       Write(Model.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(316, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Opis\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(407, 10, false);
#line 23 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml"
       Write(Model.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(417, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Kategorija\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 16, false);
#line 29 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml"
       Write(Model.Kategorija);

#line default
#line hidden
            EndContext();
            BeginContext(530, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Proizvodjac\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(628, 17, false);
#line 35 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml"
       Write(Model.Proizvodjac);

#line default
#line hidden
            EndContext();
            BeginContext(645, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Cena\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(736, 10, false);
#line 41 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml"
       Write(Model.Cena);

#line default
#line hidden
            EndContext();
            BeginContext(746, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(784, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "728e917d446741a48c075b8b4d1aeeab", async() => {
                BeginContext(810, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(820, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ef1790bed8b4b838424d6211d0d1fc8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 46 "C:\Users\Lenovo\source\repos\Proizvodi\Proizvodi\Views\Proizvodi\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(856, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Obrisi\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(939, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d54afdea640430d8ce1e5481bded6e3", async() => {
                    BeginContext(961, 24, true);
                    WriteLiteral("Nazad na listu proizvoda");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(989, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1002, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proizvodi.Models.Proizvod> Html { get; private set; }
    }
}
#pragma warning restore 1591
