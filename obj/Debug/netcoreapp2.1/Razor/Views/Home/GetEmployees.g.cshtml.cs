#pragma checksum "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee38ee1afa825a9718ff18ae9b5b55162a1de488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEmployees), @"mvc.1.0.view", @"/Views/Home/GetEmployees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetEmployees.cshtml", typeof(AspNetCore.Views_Home_GetEmployees))]
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
#line 1 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\_ViewImports.cshtml"
using Core_Demo_2.Models;

#line default
#line hidden
#line 2 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\_ViewImports.cshtml"
using Core_Demo_2.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee38ee1afa825a9718ff18ae9b5b55162a1de488", @"/Views/Home/GetEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698b253340ae5c08f1eb19128c11e781f7ced063", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_GetEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/download1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml"
  
    ViewBag.Title = "Employees";

#line default
#line hidden
            BeginContext(73, 27, true);
            WriteLiteral("\r\n<div class=\"card-deck\">\r\n");
            EndContext();
#line 8 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(141, 92, true);
            WriteLiteral("        <div class=\"card- m-3\">\r\n            <div class=\"card-header\">\r\n                <h3>");
            EndContext();
            BeginContext(234, 7, false);
#line 12 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(241, 39, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(280, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d0c812752ce4a5e9c1c8d9e986c846e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(337, 64, true);
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <p>Name: ");
            EndContext();
            BeginContext(402, 9, false);
#line 16 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml"
                    Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(411, 33, true);
            WriteLiteral(" </p>\r\n                <p>Email: ");
            EndContext();
            BeginContext(445, 10, false);
#line 17 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml"
                     Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(455, 37, true);
            WriteLiteral("</p>\r\n                <p>Department: ");
            EndContext();
            BeginContext(493, 15, false);
#line 18 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml"
                          Write(item.Department);

#line default
#line hidden
            EndContext();
            BeginContext(508, 300, true);
            WriteLiteral(@"</p>
            </div>
            <div class=""card-footer text-center"">
                <a href=""#"" class=""btn btn-primary"">View</a>
                <a href=""#"" class=""btn btn-primary"">Edit</a>
                <a href=""#"" class=""btn btn-danger"">Delete</a>
            </div>
        </div>
");
            EndContext();
#line 26 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployees.cshtml"
    }

#line default
#line hidden
            BeginContext(815, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(908, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
