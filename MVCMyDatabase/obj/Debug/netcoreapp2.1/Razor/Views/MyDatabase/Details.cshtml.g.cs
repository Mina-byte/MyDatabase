#pragma checksum "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c45b8759e373e8f3ad20b938646fee96ebc769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyDatabase_Details), @"mvc.1.0.view", @"/Views/MyDatabase/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyDatabase/Details.cshtml", typeof(AspNetCore.Views_MyDatabase_Details))]
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
#line 1 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\_ViewImports.cshtml"
using MVCMyDatabase;

#line default
#line hidden
#line 2 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\_ViewImports.cshtml"
using MVCMyDatabase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c45b8759e373e8f3ad20b938646fee96ebc769", @"/Views/MyDatabase/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b729d2b8776834f4a893489cd16e8226a4db7b", @"/Views/_ViewImports.cshtml")]
    public class Views_MyDatabase_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCMyDatabase.Models.MyDatabase>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
   
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 119, true);
            WriteLiteral("<h2>Details</h2>\r\n<div>\r\n    <h4>Employees</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 49, false);
#line 12 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HireLevelName));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 45, false);
#line 15 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.HireLevelName));

#line default
#line hidden
            EndContext();
            BeginContext(344, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(388, 44, false);
#line 18 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(476, 40, false);
#line 21 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(560, 45, false);
#line 24 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressID));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 41, false);
#line 27 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressID));

#line default
#line hidden
            EndContext();
            BeginContext(690, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(734, 45, false);
#line 30 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(823, 41, false);
#line 33 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(864, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(908, 46, false);
#line 36 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(954, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(998, 42, false);
#line 39 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1084, 44, false);
#line 42 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1172, 40, false);
#line 45 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1256, 39, false);
#line 48 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1339, 35, false);
#line 51 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1418, 42, false);
#line 54 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1504, 38, false);
#line 57 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1586, 39, false);
#line 60 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SIN));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1669, 35, false);
#line 63 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
       Write(Html.DisplayFor(model => model.SIN));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1751, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157a9d09360742ba8c14b2597e7977e2", async() => {
                BeginContext(1797, 4, true);
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
#line 68 "C:\Users\assaa\OneDrive\Documents\MVCMyDatabase\MVCMyDatabase\MVCMyDatabase\Views\MyDatabase\Details.cshtml"
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
            BeginContext(1805, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1811, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19a65d540bd64013a36df415e6d005c4", async() => {
                BeginContext(1833, 12, true);
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
            BeginContext(1849, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCMyDatabase.Models.MyDatabase> Html { get; private set; }
    }
}
#pragma warning restore 1591
