#pragma checksum "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e394f87e0438096662a93e2c5092ae946c8614e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\_ViewImports.cshtml"
using ProjectSAD3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\_ViewImports.cshtml"
using ProjectSAD3.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e394f87e0438096662a93e2c5092ae946c8614e4", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b799d0c77264befb969af4ff33b54056a60c6ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Computer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
 if (Model.Any()) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Company</th>
                <th>Models</th>
                <th>Description</th>
                <th>Price</th>
                <th>Buy</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 20 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
             foreach(Computer computer in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
               Write(computer.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
               Write(computer.Models);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
               Write(computer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
               Write(computer.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
               Write(Html.ActionLink("Buy", "GetItem", "Home", new { id = computer.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 35 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
 
}
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col-md-12 text-center\">\r\n                   <h3>No Result </h3>\r\n               </div>\r\n");
#nullable restore
#line 42 "C:\Users\hp\Desktop\Project3SAD-master\ProjectSAD3\Views\Home\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Computer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
