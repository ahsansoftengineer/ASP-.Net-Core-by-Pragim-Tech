#pragma checksum "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd1307955dcea3b442d04ffc8de4777b14822f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEmployee), @"mvc.1.0.view", @"/Views/Home/GetEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetEmployee.cshtml", typeof(AspNetCore.Views_Home_GetEmployee))]
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
#line 1 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\_ViewImports.cshtml"
using Core_Demo_2.Models;

#line default
#line hidden
#line 2 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\_ViewImports.cshtml"
using Core_Demo_2.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1307955dcea3b442d04ffc8de4777b14822f0a", @"/Views/Home/GetEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b2caf9b64371eb107c96bdc2c845f7968eea636", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("320"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/download1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
  
    // _ViewStart covering that
    // Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = Model.PageTitle;

#line default
#line hidden
            BeginContext(159, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(164, 15, false);
#line 8 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(179, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 10 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
  
    if (Model.Employee != null)
    {

#line default
#line hidden
            BeginContext(232, 80, true);
            WriteLiteral("    <div class=\"card- m-3\">\r\n        <div class=\"card-header\">\r\n            <h3>");
            EndContext();
            BeginContext(313, 17, false);
#line 15 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
           Write(Model.Employee.Id);

#line default
#line hidden
            EndContext();
            BeginContext(330, 31, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(361, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ffa5d83954ac46edb5eb8bea33215a71", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(431, 56, true);
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <p>Name: ");
            EndContext();
            BeginContext(488, 19, false);
#line 19 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
                Write(Model.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(507, 29, true);
            WriteLiteral(" </p>\r\n            <p>Email: ");
            EndContext();
            BeginContext(537, 20, false);
#line 20 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
                 Write(Model.Employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(557, 33, true);
            WriteLiteral("</p>\r\n            <p>Department: ");
            EndContext();
            BeginContext(591, 25, false);
#line 21 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
                      Write(Model.Employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(616, 314, true);
            WriteLiteral(@"</p>
        </div>
        <div class=""card-footer text-center"">
            <a href=""/home/employees"" class=""btn btn-primary"">Back</a>
            <a href=""/home/employees"" class=""btn btn-primary"">Edit</a>
            <a href=""/home/employees"" class=""btn btn-danger"">Delete</a>
        </div>
    </div>
");
            EndContext();
#line 29 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(954, 47, true);
            WriteLiteral("        <div>Message = Employee not found</div>");
            EndContext();
#line 32 "F:\Projects Practice\Core Demo 2\Core Demo 2\Views\Home\GetEmployee.cshtml"
                                               ;
    }


#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
