#pragma checksum "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13de50f568bc09ed537f02af80b075eae3a73867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortFolio_Reciept), @"mvc.1.0.view", @"/Views/PortFolio/Reciept.cshtml")]
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
#line 1 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\_ViewImports.cshtml"
using CustomerPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\_ViewImports.cshtml"
using CustomerPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13de50f568bc09ed537f02af80b075eae3a73867", @"/Views/PortFolio/Reciept.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de25a99d9013385517ee44566c9b12860c4edb1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PortFolio_Reciept : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerPortal.Models.AssetSaleResponse>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-md-right "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
  
    ViewData["Title"] = "Reciept";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <h1 class=\"bg-dark rounded text-white shadow-lg\">Receipt</h1>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13de50f568bc09ed537f02af80b075eae3a738674682", async() => {
                WriteLiteral("LogOut");
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
            WriteLiteral("\n</div>\n\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
       Write(Html.DisplayNameFor(model => model.SaleStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n\n");
#nullable restore
#line 19 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
             if (Model.SaleStatus == false)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"bg-danger p-3 mb-3 rounded box-shadow\">\n                    ");
#nullable restore
#line 23 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
               Write(Model.SaleStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                    You Don\'t Have Enough Assets To Sell.\n                </div>\n");
#nullable restore
#line 26 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"bg-primary rounded col-sm-1\">");
#nullable restore
#line 29 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
                                                    Write(Model.SaleStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 30 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <!--");
#nullable restore
#line 32 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
           Write(Html.DisplayFor(model => model.SaleStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\n        </dd>\n        <dt class = \"col-sm-2\">\n            New NetWorth\n        </dt>\n        <dd class = \"col-sm-10\">\n\n            Rs.");
#nullable restore
#line 39 "C:\Users\divya\Downloads\MFPE--PortFolio-Management-master\MFPE--PortFolio-Management-master\CustomerPortal\Views\PortFolio\Reciept.cshtml"
          Write(Html.DisplayFor(model => model.Networth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>|\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13de50f568bc09ed537f02af80b075eae3a738678978", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerPortal.Models.AssetSaleResponse> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
