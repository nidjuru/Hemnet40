#pragma checksum "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bbf37053ca74b293550b8c26b1acdee20e0338d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Objekts_Details), @"mvc.1.0.view", @"/Views/Objekts/Details.cshtml")]
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
#line 1 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\_ViewImports.cshtml"
using Hemnet42;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\_ViewImports.cshtml"
using Hemnet42.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbf37053ca74b293550b8c26b1acdee20e0338d", @"/Views/Objekts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6562bc7b98665d3282f32b1f1b29219ef670c25", @"/Views/_ViewImports.cshtml")]
    public class Views_Objekts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hemnet41.Models.Objekt>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/IndexFinal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexFinal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbf37053ca74b293550b8c26b1acdee20e0338d4578", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bbf37053ca74b293550b8c26b1acdee20e0338d4840", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        // Initialize and add the map\r\n        function initMap() {\r\n            // The location of Uluru\r\n            const uluru = {lat:");
#nullable restore
#line 13 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
                           Write($"{Decimal.ToDouble(Model.Coordinate.Latitude)}");

#line default
#line hidden
#nullable disable
                WriteLiteral(", lng:");
#nullable restore
#line 13 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
                                                                                    Write($"{Decimal.ToDouble(Model.Coordinate.Longitude)}");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"};
            // The map, centered at Uluru
            const map = new google.maps.Map(document.getElementById(""map""), {
                zoom: 15,
                center: uluru,
            });
            // The marker, positioned at Uluru
            const marker = new google.maps.Marker({
                position: uluru,
                map: map,
            });
            console.log(""HEJ"" + uluru)

        }
    </script>
    <style type=""text/css"">
        /* Set the size of the div element that contains the map */
        #map {
            height: 400px;
            /* The height is 400 pixels */
            width: 100%;
            /* The width is the width of the web page */
        }
    </style>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Objekt</h4>\r\n    <hr />\r\n    <div class=\"img-container\">\r\n        <img class=\"col-sm-10\"");
            BeginWriteAttribute("src", "\r\n             src=\"", 1292, "\"", 1351, 1);
#nullable restore
#line 48 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
WriteAttributeValue("", 1312, Html.DisplayFor(model => model.Images), 1312, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Address:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 56 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => Decimal.ToDouble(model.Coordinate.Latitude)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Utgångspris:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" SEK\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Bostadstyp:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.HousingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Upplåtelseform:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.FormOfLease));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Antal rum:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rum\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Boarea:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m²\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Biarea:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.BiArea));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m²\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Tomtarea:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlotArea));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m²\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Byggår:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.BuildYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Beskrivning:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descriptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Visnings datum:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Mäklare:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Brooker.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 124 "C:\Users\eenid\source\repos\Hemnet40\Hemnet42\Views\Objekts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Brooker.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<div id=""map""></div>

<!-- Async script executes immediately and must be after any DOM elements used in callback. -->
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyA-i6OyTv8dONZ3tJZf0UeGcsEWd9nP2NU&callback=initMap&libraries=&v=weekly""
        async></script>
<div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bbf37053ca74b293550b8c26b1acdee20e0338d14463", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hemnet41.Models.Objekt> Html { get; private set; }
    }
}
#pragma warning restore 1591
