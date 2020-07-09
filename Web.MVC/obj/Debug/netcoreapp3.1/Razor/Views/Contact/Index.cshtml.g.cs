#pragma checksum "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77b6cf2cf120939466cdd0ed803c3fa72daccdc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\_ViewImports.cshtml"
using Web.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\_ViewImports.cshtml"
using Web.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b6cf2cf120939466cdd0ed803c3fa72daccdc0", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25562730bf5bcfade3acfbfa557651a77aeb7871", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-wrapper"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "İletişim";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-title lb single-wrapper"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-md-8 col-sm-12 col-xs-12"">
                <h2><i class=""fa fa-envelope-open-o bg-orange""></i> Bize yazın <small class=""hidden-xs-down hidden-sm-down""> ");
#nullable restore
#line 11 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Contact\Index.cshtml"
                                                                                                                        Write(await Component.InvokeAsync("Param",new { key="ContactHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </small></h2>
            </div><!-- end col -->
            <div class=""col-lg-4 col-md-4 col-sm-12 hidden-xs-down hidden-sm-down"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""/Home"">Anasayfa</a></li>
                    <li class=""breadcrumb-item active"">İletişim</li>
                </ol>
            </div><!-- end col -->
        </div><!-- end row -->
    </div><!-- end container -->
</div><!-- end page-title -->

<section class=""section wb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""page-wrapper"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            ");
#nullable restore
#line 30 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Contact\Index.cshtml"
                       Write(await Component.InvokeAsync("Param",new { key="ContactDescription"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        </div>\r\n                        <div class=\"col-lg-7\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77b6cf2cf120939466cdd0ed803c3fa72daccdc05717", async() => {
                WriteLiteral(@"
                                <input type=""text"" class=""form-control"" placeholder=""Adınız"">
                                <input type=""text"" class=""form-control"" placeholder=""E-Posta adresiniz"">
                                <input type=""text"" class=""form-control"" placeholder=""Telefon"">
                                <input type=""text"" class=""form-control"" placeholder=""Konu"">
                                <textarea class=""form-control"" placeholder=""Mesajınız""></textarea>
                                <button type=""submit"" class=""btn btn-primary"">Gönder <i class=""fa fa-envelope-open-o""></i></button>
                            ");
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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div><!-- end page-wrapper -->\r\n            </div><!-- end col -->\r\n        </div><!-- end row -->\r\n    </div><!-- end container -->\r\n</section>");
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
