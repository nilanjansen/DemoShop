#pragma checksum "C:\Users\senni\source\repos\DemoShop\DemoShop.WebApp\Views\Home\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34bfe951cd10f795bc3bd9e3dab54f0977053fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactUs.cshtml", typeof(AspNetCore.Views_Home_ContactUs))]
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
#line 1 "C:\Users\senni\source\repos\DemoShop\DemoShop.WebApp\Views\_ViewImports.cshtml"
using DemoShop.WebApp;

#line default
#line hidden
#line 2 "C:\Users\senni\source\repos\DemoShop\DemoShop.WebApp\Views\_ViewImports.cshtml"
using DemoShop.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34bfe951cd10f795bc3bd9e3dab54f0977053fd4", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ae369dc56769bdfaab0bae7aa7e1e4905f1ffd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\senni\source\repos\DemoShop\DemoShop.WebApp\Views\Home\ContactUs.cshtml"
  
    ViewData["Title"] = "Contact Us";

#line default
#line hidden
            BeginContext(46, 65, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1>Demo Contact Form</h1>\r\n\r\n    ");
            EndContext();
            BeginContext(111, 991, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34bfe951cd10f795bc3bd9e3dab54f0977053fd43884", async() => {
                BeginContext(131, 964, true);
                WriteLiteral(@"
        <fieldset>
            <div class=""row"">
                <div class=""col-8 offset-2"">
                    <div class=""form-group"">
                        <label for=""ContactName"">Contact Name</label>
                        <input class=""form-control"" type=""text"" name=""ContactName"" value="""" />
                    </div>
                </div>
                <div class=""col-8 offset-2"">
                    <div class=""form-group"">
                        <label for=""ContactName"">Email Address</label>
                        <input class=""form-control"" type=""text"" name=""EmailAddress"" value="""" />
                    </div>
                </div>
                <div class=""col-4 offset-4"">
                    <div class=""form-group"">
                        <input type=""submit"" value=""Submit"" class=""btn btn-block btn-primary"" />
                    </div>
                </div>
            </div>
        </fieldset>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1102, 31, true);
            WriteLiteral("\r\n    <h2 class=\"text-success\">");
            EndContext();
            BeginContext(1134, 25, false);
#line 30 "C:\Users\senni\source\repos\DemoShop\DemoShop.WebApp\Views\Home\ContactUs.cshtml"
                        Write(Html.Raw(ViewBag.Message));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 13, true);
            WriteLiteral("</h2>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
