#pragma checksum "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bed5773ef70a86541245dc9f7f2812455dc194d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bed5773ef70a86541245dc9f7f2812455dc194d4", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClassLibrary1.Class1.DateInformation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/table.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
      
    ViewData["Title"] = "Asteroids Challenge";
    

#line default
#line hidden
            BeginContext(123, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(129, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bed5773ef70a86541245dc9f7f2812455dc194d45521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(192, 20, true);
            WriteLiteral("        \r\n\r\n    <h1>");
            EndContext();
            BeginContext(213, 17, false);
#line 9 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(230, 79, true);
            WriteLiteral("</h1>\r\n\r\n    <p> This page shows the near asteroids.</p>\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(309, 299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed5773ef70a86541245dc9f7f2812455dc194d47300", async() => {
                BeginContext(350, 251, true);
                WriteLiteral("\r\n            Enter the start date:\r\n            <input name=\"startDate\" type=\"date\"><br>\r\n            Enter the end date:\r\n            <input name=\"endDate\" type=\"date\"><br>\r\n            <button name=\"button\" type=\"submit\"> Update </button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(608, 385, true);
            WriteLiteral(@"
        <u>
            
        </u>
    </div>

    <table>
        <tr>
            <th>Id</th>
            <th>Date</th>
            <th>Name</th>
            <th>Absolute magnitude</th>
            <th>Is potentially hazardous</th>
            <th>Is centry object</th>
            <th>Distance</th>
            <th>Time to get speed of light</th>
        </tr>
");
            EndContext();
#line 37 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
             foreach (var dateInfo in Model)
            {

#line default
#line hidden
            BeginContext(1054, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1085, 22, false);
#line 40 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
           Write(dateInfo.id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1107, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1131, 62, false);
#line 41 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
           Write(dateInfo.close_approach_data[0].close_approach_date.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1193, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1217, 24, false);
#line 42 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
           Write(dateInfo.name.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1241, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1265, 40, false);
#line 43 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
           Write(dateInfo.absolute_magnitude_h.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1305, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1329, 53, false);
#line 44 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
           Write(dateInfo.is_potentially_hazardous_asteroid.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1382, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1406, 36, false);
#line 45 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
           Write(dateInfo.is_sentry_object.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1442, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1466, 56, false);
#line 46 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
           Write(dateInfo.close_approach_data[0].miss_distance.kilometers);

#line default
#line hidden
            EndContext();
            BeginContext(1522, 26, true);
            WriteLiteral(" Km</td>\r\n            <td>");
            EndContext();
            BeginContext(1550, 113, false);
#line 47 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
            Write(ClassLibrary1.Class1.getTimeToSppedOfLight(float.Parse(dateInfo.close_approach_data[0].miss_distance.kilometers)));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 24, true);
            WriteLiteral(" m</td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\sarredondo\source\repos\WebApplication1\WebApplication1\Views\Home\Privacy.cshtml"
            }

#line default
#line hidden
            BeginContext(1703, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClassLibrary1.Class1.DateInformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
