#pragma checksum "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd1aadcf781ddbf5f1f9cd7f58059e328ef17989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_List), @"mvc.1.0.view", @"/Views/Vendor/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendor/List.cshtml", typeof(AspNetCore.Views_Vendor_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd1aadcf781ddbf5f1f9cd7f58059e328ef17989", @"/Views/Vendor/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c134f2356b6a3f66ffb648b38457e1b6e6d1eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendor_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StadiumManagementSys.Models.Vendor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vendor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
  
    ViewData["Title"] = "Vedor List";

#line default
#line hidden
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(98, 6110, true);
            WriteLiteral(@"


<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>

<style type=""text/css"">

    .table-wrapper {
        background: #fff;
        padding: 20px 25px;
        margin: 30px 0;
        border-radius: 3px;
        box-shadow: 0 1px 1px rgba(0,0,0,.05);
    }

    .table-title {
        padding-bottom: 15px;
        background: #435d7d;
        color: #fff;
        padding: 16px 30px;
        margin: -20px -25px 10px;
        border-radius: 3px 3px 0 0;
    }

        .table-title h2 {
            margin: 5px 0 0;
            font-size: 24p");
            WriteLiteral(@"x;
        }

        .table-title .btn-group {
            float: right;
        }

        .table-title .btn {
            color: #fff;
            float: right;
            font-size: 13px;
            border: none;
            min-width: 50px;
            border-radius: 2px;
            border: none;
            outline: none !important;
            margin-left: 10px;
        }

            .table-title .btn i {
                float: left;
                font-size: 21px;
                margin-right: 5px;
            }

            .table-title .btn span {
                float: left;
                margin-top: 2px;
            }

    table.table tr th, table.table tr td {
        border-color: #e9e9e9;
        padding: 12px 15px;
        vertical-align: middle;
    }

        table.table tr th:first-child {
            width: 60px;
        }

        table.table tr th:last-child {
            width: 100px;
        }

    table.table-striped tbody tr:nth-of-t");
            WriteLiteral(@"ype(odd) {
        background-color: #fcfcfc;
    }

    table.table-striped.table-hover tbody tr:hover {
        background: #f5f5f5;
    }

    table.table th i {
        font-size: 13px;
        margin: 0 5px;
        cursor: pointer;
    }

    table.table td:last-child i {
        opacity: 0.9;
        font-size: 22px;
        margin: 0 5px;
    }

    table.table td a {
        font-weight: bold;
        color: #566787;
        display: inline-block;
        text-decoration: none;
        outline: none !important;
    }

        table.table td a:hover {
            color: #2196F3;
        }

        table.table td a.edit {
            color: #FFC107;
        }

        table.table td a.delete {
            color: #F44336;
        }

    table.table td i {
        font-size: 19px;
    }

    table.table .avatar {
        border-radius: 50%;
        vertical-align: middle;
        margin-right: 10px;
    }

    .pagination {
        float: right;
       ");
            WriteLiteral(@" margin: 0 0 5px;
    }

        .pagination li a {
            border: none;
            font-size: 13px;
            min-width: 30px;
            min-height: 30px;
            color: #999;
            margin: 0 2px;
            line-height: 30px;
            border-radius: 2px !important;
            text-align: center;
            padding: 0 6px;
        }

            .pagination li a:hover {
                color: #666;
            }

        .pagination li.active a, .pagination li.active a.page-link {
            background: #03A9F4;
        }

            .pagination li.active a:hover {
                background: #0397d6;
            }

        .pagination li.disabled i {
            color: #ccc;
        }

        .pagination li i {
            font-size: 16px;
            padding-top: 6px
        }

    .hint-text {
        float: left;
        margin-top: 10px;
        font-size: 13px;
    }

    /* Modal styles */
    .modal .modal-dialog {
        max-");
            WriteLiteral(@"width: 400px;
    }

    .modal .modal-header, .modal .modal-body, .modal .modal-footer {
        padding: 20px 30px;
    }

    .modal .modal-content {
        border-radius: 3px;
    }

    .modal .modal-footer {
        background: #ecf0f1;
        border-radius: 0 0 3px 3px;
    }

    .modal .modal-title {
        display: inline-block;
    }

    .modal .form-control {
        border-radius: 2px;
        box-shadow: none;
        border-color: #dddddd;
    }

    .modal textarea.form-control {
        resize: vertical;
    }

    .modal .btn {
        border-radius: 2px;
        min-width: 100px;
    }

    .modal form label {
        font-weight: normal;
    }
</style>
<script type=""text/javascript"">
    $(document).ready(function () {
        // Activate tooltip
        $('[data-toggle=""tooltip""]').tooltip();

        // Select/Deselect checkboxes
        var checkbox = $('table tbody input[type=""checkbox""]');
        $(""#selectAll"").click(function () {
 ");
            WriteLiteral(@"           if (this.checked) {
                checkbox.each(function () {
                    this.checked = true;
                });
            } else {
                checkbox.each(function () {
                    this.checked = false;
                });
            }
        });
        checkbox.click(function () {
            if (!this.checked) {
                $(""#selectAll"").prop(""checked"", false);
            }
        });

    function ConfirmDelete()
    {
      var x = confirm(""Are you sure you want to delete?"");
            if (x)
                return true;
            else
            return false
    }

});
</script>








<div class=""container"">
    <div class=""table-wrapper"">
        <div class=""table-title"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <h2>Vandor <b>Details</b></h2>
                </div>
                <div class=""col-sm-6"">
                    ");
            EndContext();
            BeginContext(6208, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "749718eb1c0646988b6e3863df2e5442", async() => {
                BeginContext(6296, 59, true);
                WriteLiteral("<i class=\"material-icons\"></i> <span>Add New Vendor</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6359, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6530, 607, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
        <table class=""table table-striped table-hover"">
            <thead>
                <tr>

                    <th>Registration No</th>
                    <th>Organization Name</th>
                    <th>Organization Email</th>
                    <th>Phone</th>
                    <th>Organization Registration NO</th>
                    <th>Contact Duration Upto</th>
                    <th>Service Type</th>
                    <th>Service Comment</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 288 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
            BeginContext(7199, 56, true);
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(7256, 16, false);
#line 292 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.RegistrationNo);

#line default
#line hidden
            EndContext();
            BeginContext(7272, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7308, 18, false);
#line 293 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.OrganizationName);

#line default
#line hidden
            EndContext();
            BeginContext(7326, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7362, 19, false);
#line 294 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.OrganizationEmail);

#line default
#line hidden
            EndContext();
            BeginContext(7381, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7417, 7, false);
#line 295 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(7424, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7460, 19, false);
#line 296 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.OrganizationRegNO);

#line default
#line hidden
            EndContext();
            BeginContext(7479, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7515, 17, false);
#line 297 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.ContactDuration);

#line default
#line hidden
            EndContext();
            BeginContext(7532, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7568, 13, false);
#line 298 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.ServiceType);

#line default
#line hidden
            EndContext();
            BeginContext(7581, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(7617, 16, false);
#line 299 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                       Write(x.ServiceComment);

#line default
#line hidden
            EndContext();
            BeginContext(7633, 67, true);
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(7700, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "813ee7261f214ed4ba4e894905511ec7", async() => {
                BeginContext(7811, 89, true);
                WriteLiteral("<i class=\"material-icons\" data-toggle=\"tooltip\" title=\"\" data-original-title=\"Edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 302 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                                                                                        WriteLiteral(x.RegistrationNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7904, 32, true);
            WriteLiteral("\r\n\r\n                            ");
            EndContext();
            BeginContext(7936, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9017480c9829432e8aa7ab8eb4ea25b6", async() => {
                BeginContext(8063, 91, true);
                WriteLiteral("<i class=\"material-icons\" data-toggle=\"tooltip\" title=\"\" data-original-title=\"Delete\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RegistrationNo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 304 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                                                                                         WriteLiteral(x.RegistrationNo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RegistrationNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RegistrationNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RegistrationNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8158, 68, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 311 "G:\StadiumManagementSys-20190720T203424Z-001\StadiumManagementSys\StadiumManagementSys\Views\Vendor\List.cshtml"
                }

#line default
#line hidden
            BeginContext(8245, 66, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StadiumManagementSys.Models.Vendor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
