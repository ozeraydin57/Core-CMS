#pragma checksum "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd632c8f2e4504622806ca6cabd286cfbdb2505c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd632c8f2e4504622806ca6cabd286cfbdb2505c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25562730bf5bcfade3acfbfa557651a77aeb7871", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd632c8f2e4504622806ca6cabd286cfbdb2505c3875", async() => {
                WriteLiteral(@"
    <!-- Basic -->
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">

    <!-- Mobile Metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Site Metas -->
    <title>");
#nullable restore
#line 12 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 364, "\"", 395, 1);
#nullable restore
#line 13 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 374, ViewData["keywords"], 374, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 427, "\"", 461, 1);
#nullable restore
#line 14 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 437, ViewData["description"], 437, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 488, "\"", 517, 1);
#nullable restore
#line 15 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 498, ViewData["author"], 498, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

    <!-- Site Icons -->
    <link rel=""shortcut icon"" href=""/images/favicon.ico"" type=""image/x-icon"" />
    <link rel=""apple-touch-icon"" href=""/images/apple-touch-icon.png"">

    <!-- Design fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700"" rel=""stylesheet"">

    <!-- Bootstrap core CSS -->
    <link href=""/css/bootstrap.css"" rel=""stylesheet"">

    <!-- FontAwesome Icons core CSS -->
    <link href=""/css/font-awesome.min.css"" rel=""stylesheet"">

    <!-- Custom styles for this template -->
    <link href=""/style.css"" rel=""stylesheet"">

    <!-- Responsive styles for this template -->
    <link href=""/css/responsive.css"" rel=""stylesheet"">

    <!-- Colors for this template -->
    <link href=""/css/colors.css"" rel=""stylesheet"">

    <!-- Version Tech CSS for this template -->
    <link href=""/css/version/tech.css"" rel=""stylesheet"">

");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd632c8f2e4504622806ca6cabd286cfbdb2505c7550", async() => {
                WriteLiteral(@"
    <div id=""wrapper"">
        <header class=""tech-header header"">
            <div class=""container-fluid"">
                <nav class=""navbar navbar-toggleable-md navbar-inverse fixed-top bg-inverse"">
                    <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <a class=""navbar-brand"" href=""/Home""><img src=""/images/version/tech-logo.png"" alt=""Şirket Logo""></a>
                    <div class=""collapse navbar-collapse"" id=""navbarCollapse"">
                        ");
#nullable restore
#line 53 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
                   Write(await Component.InvokeAsync("Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <ul class=""navbar-nav mr-2"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""><i class=""fa fa-rss""></i></a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""><i class=""fa fa-android""></i></a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""><i class=""fa fa-apple""></i></a>
                            </li>
                        </ul>
                    </div>
                </nav>
            </div><!-- end container-fluid -->
        </header><!-- end market-header -->


        ");
#nullable restore
#line 71 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



        <footer class=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7"">
                        <div class=""widget"">
                            <div class=""footer-text text-left"">
                                <a href=""index.html""><img src=""images/version/tech-footer-logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 3410, "\"", 3416, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"></a>\r\n                                ");
#nullable restore
#line 82 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
                           Write(await Component.InvokeAsync("Param", new { key = "FooterSlogan" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <div class=\"social\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3635, "\"", 3701, 1);
#nullable restore
#line 84 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3642, await Component.InvokeAsync("Param",new{ key="Facebook" }), 3642, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Facebook\"><i class=\"fa fa-facebook\"></i></a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3840, "\"", 3905, 1);
#nullable restore
#line 85 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3847, await Component.InvokeAsync("Param",new{ key="Twitter" }), 3847, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Twitter\"><i class=\"fa fa-twitter\"></i></a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4042, "\"", 4109, 1);
#nullable restore
#line 86 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4049, await Component.InvokeAsync("Param",new{ key="Instagram" }), 4049, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Instagram\"><i class=\"fa fa-instagram\"></i></a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4250, "\"", 4318, 1);
#nullable restore
#line 87 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4257, await Component.InvokeAsync("Param",new{ key="GooglePlus" }), 4257, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Google Plus\"><i class=\"fa fa-google-plus\"></i></a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4463, "\"", 4530, 1);
#nullable restore
#line 88 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4470, await Component.InvokeAsync("Param",new{ key="Pinterest" }), 4470, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" data-toggle=""tooltip"" data-placement=""bottom"" title=""Pinterest""><i class=""fa fa-pinterest""></i></a>
                                </div>

                                <hr class=""invis"">

                                <div class=""newsletter-widget text-left"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd632c8f2e4504622806ca6cabd286cfbdb2505c13888", async() => {
                    WriteLiteral(@"
                                        <input type=""text"" class=""form-control"" placeholder=""Enter your email address"">
                                        <button type=""submit"" class=""btn btn-primary"">SUBMIT</button>
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
                WriteLiteral(@"
                                </div><!-- end newsletter -->
                            </div><!-- end footer-text -->
                        </div><!-- end widget -->
                    </div><!-- end col -->

                    <div class=""col-lg-3 col-md-12 col-sm-12 col-xs-12"">
                        <div class=""widget"">
                            <h2 class=""widget-title"">Popular Categories</h2>
                            <div class=""link-widget"">
                                <ul>
                                    <li><a href=""#"">Marketing <span>(21)</span></a></li>
                                    <li><a href=""#"">SEO Service <span>(15)</span></a></li>
                                    <li><a href=""#"">Digital Agency <span>(31)</span></a></li>
                                    <li><a href=""#"">Make Money <span>(22)</span></a></li>
                                    <li><a href=""#"">Blogging <span>(66)</span></a></li>
                                </ul>
               ");
                WriteLiteral(@"             </div><!-- end link-widget -->
                        </div><!-- end widget -->
                    </div><!-- end col -->

                    <div class=""col-lg-2 col-md-12 col-sm-12 col-xs-12"">
                        <div class=""widget"">
                            <h2 class=""widget-title"">Copyrights</h2>
                            <div class=""link-widget"">
                                <ul>
                                    <li><a href=""/Page/Detail/"">About us</a></li>
                                    <li><a href=""#"">Advertising</a></li>
                                    <li><a href=""#"">Write for us</a></li>
                                    <li><a href=""#"">Trademark</a></li>
                                    <li><a href=""#"">License & Help</a></li>
                                </ul>
                            </div><!-- end link-widget -->
                        </div><!-- end widget -->
                    </div><!-- end col -->
                </div>
");
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12 text-center\">\r\n                        <br>\r\n                        <div class=\"copyright\">\r\n                            ");
#nullable restore
#line 138 "C:\Users\OA-HOME\source\repos\OAProject\Web.MVC\Views\Shared\_Layout.cshtml"
                       Write(await Component.InvokeAsync("Param", new { key = "CopyRight" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div><!-- end container -->
        </footer><!-- end footer -->


    </div><!-- end wrapper -->
    <!-- Core JavaScript
    ================================================== -->
    <script src=""/js/jquery.min.js""></script>
    <script src=""/js/tether.min.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/custom.js""></script>

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
            WriteLiteral("\r\n</html>");
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
