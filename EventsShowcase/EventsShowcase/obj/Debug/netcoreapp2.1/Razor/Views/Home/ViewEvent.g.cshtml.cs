#pragma checksum "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1707dfd5b32c667d73d7681d42a23de2faad3c28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEvent), @"mvc.1.0.view", @"/Views/Home/ViewEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewEvent.cshtml", typeof(AspNetCore.Views_Home_ViewEvent))]
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
#line 1 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\_ViewImports.cshtml"
using EventsShowcase;

#line default
#line hidden
#line 2 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\_ViewImports.cshtml"
using EventsShowcase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1707dfd5b32c667d73d7681d42a23de2faad3c28", @"/Views/Home/ViewEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a85cb2768b0b8860c907ab5d29d0c20ac596499", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventsShowcase.Models.EventModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 44, true);
            WriteLiteral("\r\n<h2>View Event Details</h2>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(131, 33, false);
#line 10 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.Title));

#line default
#line hidden
            EndContext();
            BeginContext(164, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(171, 29, false);
#line 11 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.Title));

#line default
#line hidden
            EndContext();
            BeginContext(200, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(222, 39, false);
#line 14 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(261, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(268, 35, false);
#line 15 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(303, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(325, 37, false);
#line 18 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(362, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(369, 33, false);
#line 19 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(402, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(424, 35, false);
#line 22 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(459, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(466, 31, false);
#line 23 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(497, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(519, 33, false);
#line 26 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(552, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(559, 29, false);
#line 27 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(588, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(610, 36, false);
#line 30 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.Location));

#line default
#line hidden
            EndContext();
            BeginContext(646, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(653, 32, false);
#line 31 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.Location));

#line default
#line hidden
            EndContext();
            BeginContext(685, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(707, 26, false);
#line 34 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.LabelFor(m => m.City));

#line default
#line hidden
            EndContext();
            BeginContext(733, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(740, 27, false);
#line 35 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.EditorFor(m => m.City));

#line default
#line hidden
            EndContext();
            BeginContext(767, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(789, 30, false);
#line 38 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.LabelFor(m => m.Category));

#line default
#line hidden
            EndContext();
            BeginContext(819, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(826, 31, false);
#line 39 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.EditorFor(m => m.Category));

#line default
#line hidden
            EndContext();
            BeginContext(857, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(879, 37, false);
#line 42 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.Organizer));

#line default
#line hidden
            EndContext();
            BeginContext(916, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(923, 33, false);
#line 43 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.Organizer));

#line default
#line hidden
            EndContext();
            BeginContext(956, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(978, 35, false);
#line 46 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.Contact));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1020, 31, false);
#line 47 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.Contact));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1073, 33, false);
#line 50 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayNameFor(m => m.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1113, 29, false);
#line 51 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
Write(Html.DisplayFor(m => m.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 34, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(1177, 59, false);
#line 55 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
   Write(Html.ActionLink("Edit", "EditEvent", new { id = Model.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1249, 63, false);
#line 56 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
   Write(Html.ActionLink("Delete", "DeleteEvent", new { id = Model.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1325, 32, false);
#line 57 "D:\Work\Projects\events-showcase\EventsShowcase\EventsShowcase\Views\Home\ViewEvent.cshtml"
   Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 18, true);
            WriteLiteral("\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventsShowcase.Models.EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
