#pragma checksum "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac6700413540cdd7d285b0c1aaa07bd54e09204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameSchedule_SetSchedule), @"mvc.1.0.view", @"/Views/GameSchedule/SetSchedule.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GameSchedule/SetSchedule.cshtml", typeof(AspNetCore.Views_GameSchedule_SetSchedule))]
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
#line 1 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\_ViewImports.cshtml"
using StadiumManagementSys;

#line default
#line hidden
#line 2 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\_ViewImports.cshtml"
using StadiumManagementSys.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac6700413540cdd7d285b0c1aaa07bd54e09204", @"/Views/GameSchedule/SetSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c134f2356b6a3f66ffb648b38457e1b6e6d1eb", @"/Views/_ViewImports.cshtml")]
    public class Views_GameSchedule_SetSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StadiumManagementSys.Models.GameSchedule>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GameSchedule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
  
    ViewData["Title"] = "Set Schedule";

#line default
#line hidden
            BeginContext(48, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(109, 114, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:10px; margin-bottom:10px\">\r\n    <div class=\"row\">\r\n\r\n        \r\n        ");
            EndContext();
            BeginContext(223, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94a2f64fe73f4c898bb7efbb66d38bfa", async() => {
                BeginContext(312, 12, true);
                WriteLiteral("Set New Game");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 86, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n    <div class=\"container\" style=\"background:#bdc3c7\">\r\n\r\n\r\n");
            EndContext();
#line 21 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
            BeginContext(460, 224, true);
            WriteLiteral("            <div class=\"row\" style=\"height:175px\">\r\n\r\n                <div class=\"col-sm-4\" style=\"height:160px;width:350px; margin:12px;margin-left:30px\">\r\n                    <h1 style=\"text-align:center;margin-top:60px\"> ");
            EndContext();
            BeginContext(685, 11, false);
#line 26 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
                                                              Write(x.FirstTeam);

#line default
#line hidden
            EndContext();
            BeginContext(696, 175, true);
            WriteLiteral("</h1>\r\n\r\n                </div>\r\n\r\n\r\n                <div class=\"col-sm-4\" style=\"margin:12px;height:160px;width:350px\">\r\n\r\n                    <h3 style=\"text-align:center\"> ");
            EndContext();
            BeginContext(872, 12, false);
#line 33 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
                                              Write(x.Tournament);

#line default
#line hidden
            EndContext();
            BeginContext(884, 58, true);
            WriteLiteral("</h3>\r\n                    <h5 style=\"text-align:center\"> ");
            EndContext();
            BeginContext(943, 12, false);
#line 34 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
                                              Write(x.TourGameNo);

#line default
#line hidden
            EndContext();
            BeginContext(955, 58, true);
            WriteLiteral("</h5>\r\n                    <h3 style=\"text-align:center\"> ");
            EndContext();
            BeginContext(1014, 10, false);
#line 35 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
                                              Write(x.GameTime);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 189, true);
            WriteLiteral("</h3>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-sm-4\" style=\"height:160px;width:350px; margin:12px\">\r\n\r\n                    <h1 style=\"text-align:center;margin-top:60px\">");
            EndContext();
            BeginContext(1214, 12, false);
#line 41 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
                                                             Write(x.SecondTeam);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 56, true);
            WriteLiteral(" </h1>\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(1286, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1298, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "353f181e6f284de2a2b0e54540ff4b5e", async() => {
                BeginContext(1415, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-GameNo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"
                                                                                            WriteLiteral(x.GameNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GameNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-GameNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GameNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1425, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1435, 20, true);
            WriteLiteral("            <hr />\r\n");
            EndContext();
#line 54 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\GameSchedule\SetSchedule.cshtml"


        }

#line default
#line hidden
            BeginContext(1470, 16, true);
            WriteLiteral("    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StadiumManagementSys.Models.GameSchedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
