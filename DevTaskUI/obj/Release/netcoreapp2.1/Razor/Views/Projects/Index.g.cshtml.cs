#pragma checksum "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39bf8ebb36c4721e0e70954d79d6f859f28b0bad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Index.cshtml", typeof(AspNetCore.Views_Projects_Index))]
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
#line 1 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\_ViewImports.cshtml"
using DevTaskUI;

#line default
#line hidden
#line 2 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\_ViewImports.cshtml"
using DevTaskUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39bf8ebb36c4721e0e70954d79d6f859f28b0bad", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6218b741ce7b19d45bf087ed1ef57f5103f39488", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevTaskApi.Models.Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
  
    ViewData["Title"] = "Projects View";

#line default
#line hidden
            BeginContext(98, 33, true);
            WriteLiteral("\r\n<h2>Projects View</h2>\r\n\r\n<p>\r\n");
            EndContext();
            BeginContext(178, 90, true);
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(269, 38, false);
#line 16 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(363, 40, false);
#line 19 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(403, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(459, 47, false);
#line 22 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(562, 45, false);
#line 25 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(607, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(663, 46, false);
#line 28 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SolutionId));

#line default
#line hidden
            EndContext();
            BeginContext(709, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(827, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(876, 37, false);
#line 37 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(913, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(969, 39, false);
#line 40 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1064, 46, false);
#line 43 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1166, 44, false);
#line 46 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1266, 45, false);
#line 49 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SolutionId));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1639, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Projects\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1657, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevTaskApi.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
