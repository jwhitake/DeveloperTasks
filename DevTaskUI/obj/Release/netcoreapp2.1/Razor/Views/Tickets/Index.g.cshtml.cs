#pragma checksum "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "623f3be3e85453a0b5546b41f44234f11b90127d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Index), @"mvc.1.0.view", @"/Views/Tickets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tickets/Index.cshtml", typeof(AspNetCore.Views_Tickets_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"623f3be3e85453a0b5546b41f44234f11b90127d", @"/Views/Tickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6218b741ce7b19d45bf087ed1ef57f5103f39488", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevTaskApi.Models.Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
  
    ViewData["Title"] = "Tickets View";

#line default
#line hidden
            BeginContext(96, 28, true);
            WriteLiteral("\r\n<h2>Tickets View\"</h2>\r\n\r\n");
            EndContext();
            BeginContext(182, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(267, 38, false);
#line 16 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(305, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(361, 40, false);
#line 19 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(401, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(457, 47, false);
#line 22 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(504, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(560, 45, false);
#line 25 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(605, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(661, 45, false);
#line 28 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(706, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(762, 42, false);
#line 31 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(804, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(922, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(971, 37, false);
#line 40 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1064, 39, false);
#line 43 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1159, 46, false);
#line 46 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1261, 44, false);
#line 49 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1361, 44, false);
#line 52 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1461, 41, false);
#line 55 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1830, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\jwhitake\Desktop\DeveloperTasks\DevTaskUI\Views\Tickets\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1848, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevTaskApi.Models.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
