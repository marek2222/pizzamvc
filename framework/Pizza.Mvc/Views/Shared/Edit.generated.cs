﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Pizza.Mvc;
    
    #line 1 "..\..\Views\Shared\Edit.cshtml"
    using Pizza.Mvc.HtmlHelpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\Edit.cshtml"
    using Pizza.Mvc.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Edit.cshtml")]
    public partial class _Views_Shared_Edit_cshtml : System.Web.Mvc.WebViewPage<Pizza.Contracts.IEditModelBase>
    {
        public _Views_Shared_Edit_cshtml()
        {
        }
        public override void Execute()
        {
DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 6 "..\..\Views\Shared\Edit.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Views\Shared\Edit.cshtml"
Write(Scripts.Render("~/bundles/tinymce"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n<h2>\r\n");

WriteLiteral("    ");

            
            #line 11 "..\..\Views\Shared\Edit.cshtml"
Write(ViewBag.PageTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n</h2>\r\n\r\n");

            
            #line 14 "..\..\Views\Shared\Edit.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Shared\Edit.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Shared\Edit.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\Edit.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("        ");

            
            #line 21 "..\..\Views\Shared\Edit.cshtml"
   Write(Html.ValidationSummary(true, string.Empty, new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Views\Shared\Edit.cshtml"
   Write(Html.ModelEditor(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-11 col-md-12\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 628), Tuple.Create("\"", 660)
            
            #line 26 "..\..\Views\Shared\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 636), Tuple.Create<System.Object, System.Int32>(UiTexts.FormButton_Save
            
            #line default
            #line hidden
, 636), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");

            
            #line 31 "..\..\Views\Shared\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 34 "..\..\Views\Shared\Edit.cshtml"
Write(Html.ActionLink(UiTexts.Link_BackToIndex, ScriptKeys.Index));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
