#pragma checksum "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e2161aaf9bc0a109ba188098c52ff9062fdaea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workorders_Details), @"mvc.1.0.view", @"/Views/Workorders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Workorders/Details.cshtml", typeof(AspNetCore.Views_Workorders_Details))]
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
#line 1 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\_ViewImports.cshtml"
using LocalERP;

#line default
#line hidden
#line 2 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\_ViewImports.cshtml"
using LocalERP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4e2161aaf9bc0a109ba188098c52ff9062fdaea", @"/Views/Workorders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2b65fbf5da33b80b45823831229964304ff4551", @"/Views/_ViewImports.cshtml")]
    public class Views_Workorders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocalERP.Models.Workorder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Workorder</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(203, 47, false);
#line 14 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(250, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(294, 43, false);
#line 17 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(337, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(381, 50, false);
#line 20 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuoteRequested));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(475, 46, false);
#line 23 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuoteRequested));

#line default
#line hidden
            EndContext();
            BeginContext(521, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(565, 53, false);
#line 26 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalMaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(618, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(662, 49, false);
#line 29 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalMaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 51, false);
#line 32 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalLabourCost));

#line default
#line hidden
            EndContext();
            BeginContext(806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 47, false);
#line 35 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalLabourCost));

#line default
#line hidden
            EndContext();
            BeginContext(897, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(941, 45, false);
#line 38 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1030, 41, false);
#line 41 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1115, 47, false);
#line 44 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1206, 43, false);
#line 47 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1293, 50, false);
#line 50 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequiredBy));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1387, 46, false);
#line 53 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateRequiredBy));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1477, 49, false);
#line 56 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1570, 45, false);
#line 59 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1659, 48, false);
#line 62 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatePickedUp));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1751, 44, false);
#line 65 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatePickedUp));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1839, 53, false);
#line 68 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientPhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1936, 49, false);
#line 71 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientPhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2029, 47, false);
#line 74 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2120, 43, false);
#line 77 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2207, 46, false);
#line 80 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(2253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2297, 42, false);
#line 83 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(2339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2383, 51, false);
#line 86 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstMaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2478, 47, false);
#line 89 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstMaterialCost));

#line default
#line hidden
            EndContext();
            BeginContext(2525, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2569, 49, false);
#line 92 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstLabourCost));

#line default
#line hidden
            EndContext();
            BeginContext(2618, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2662, 45, false);
#line 95 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstLabourCost));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2751, 48, false);
#line 98 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstOtherCost));

#line default
#line hidden
            EndContext();
            BeginContext(2799, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2843, 44, false);
#line 101 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstOtherCost));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2931, 48, false);
#line 104 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstTotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(2979, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3023, 44, false);
#line 107 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstTotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(3067, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3111, 51, false);
#line 110 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstDeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(3162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3206, 47, false);
#line 113 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstDeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(3253, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3297, 48, false);
#line 116 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3345, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3389, 44, false);
#line 119 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3433, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3480, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "083ac60b10e44aaf9a8016e22ee6b644", async() => {
                BeginContext(3526, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 124 "C:\Users\Kon\Documents\Server\LocalERP\LocalERP\Views\Workorders\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3534, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3542, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a5e1caa63446b0965c3b03233b0a0c", async() => {
                BeginContext(3564, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(3580, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocalERP.Models.Workorder> Html { get; private set; }
    }
}
#pragma warning restore 1591
