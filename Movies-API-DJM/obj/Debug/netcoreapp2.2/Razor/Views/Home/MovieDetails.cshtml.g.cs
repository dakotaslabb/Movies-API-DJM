#pragma checksum "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb8b5859a57d1e71f105f5156cb417636b1e628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieDetails), @"mvc.1.0.view", @"/Views/Home/MovieDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MovieDetails.cshtml", typeof(AspNetCore.Views_Home_MovieDetails))]
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
#line 1 "D:\Movies-API-DJM\Movies-API-DJM\Views\_ViewImports.cshtml"
using Movies_API_DJM;

#line default
#line hidden
#line 2 "D:\Movies-API-DJM\Movies-API-DJM\Views\_ViewImports.cshtml"
using Movies_API_DJM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb8b5859a57d1e71f105f5156cb417636b1e628", @"/Views/Home/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86631924fdbd46ee23de0bdb7e8eb4685dfa9b62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies_API_DJM.Models.Movies>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
  
    ViewData["Title"] = "MovieDetails";

#line default
#line hidden
            BeginContext(87, 134, true);
            WriteLiteral("\r\n<h1>MovieDetails</h1>\r\n\r\n<div>\r\n    <h4>Movies</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(222, 42, false);
#line 14 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.imdbID));

#line default
#line hidden
            EndContext();
            BeginContext(264, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 38, false);
#line 17 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.imdbID));

#line default
#line hidden
            EndContext();
            BeginContext(366, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(429, 41, false);
#line 20 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(470, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(534, 37, false);
#line 23 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(571, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(634, 40, false);
#line 26 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(674, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(738, 36, false);
#line 29 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(774, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(837, 40, false);
#line 32 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Plot));

#line default
#line hidden
            EndContext();
            BeginContext(877, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(941, 36, false);
#line 35 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Plot));

#line default
#line hidden
            EndContext();
            BeginContext(977, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1040, 41, false);
#line 38 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Rated));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1145, 37, false);
#line 41 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
       Write(Html.DisplayFor(model => model.Rated));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1230, 82, false);
#line 46 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
Write(Html.ActionLink("Add To Favorites", "AddToFavorites", new { Title = Model.Title }));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1321, 81, false);
#line 47 "D:\Movies-API-DJM\Movies-API-DJM\Views\Home\MovieDetails.cshtml"
Write(Html.ActionLink("Back to List", "Result", new { Title = TempData.Peek("Title") }));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies_API_DJM.Models.Movies> Html { get; private set; }
    }
}
#pragma warning restore 1591
