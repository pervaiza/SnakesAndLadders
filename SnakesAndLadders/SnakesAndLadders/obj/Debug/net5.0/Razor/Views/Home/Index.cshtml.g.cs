#pragma checksum "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a947c5af953f0f2baea9a3e62cbb09c9a81182ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\_ViewImports.cshtml"
using SnakesAndLadders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\_ViewImports.cshtml"
using SnakesAndLadders.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a947c5af953f0f2baea9a3e62cbb09c9a81182ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3b1e4ec750215291f4c1fe9d4e4ecec37ca8c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SnakesAndLadders.Services.GameMatrix>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/snake-ladders.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Snakes & Ladders";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <div id=\"divWin\" hidden>\r\n        <h1 class=\"bg-danger\">!!! You Win !!!\"</h1>\r\n    </div>\r\n    <table class=\"table\" style=\"border: 2px solid black\">\r\n");
#nullable restore
#line 10 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
          
            int SequenceCount = 100;

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
         for (int i = 0; i < 10; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 17 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
                 for (int j = 0; j < 10; j++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td");
            BeginWriteAttribute("id", " id=\"", 500, "\"", 519, 1);
#nullable restore
#line 20 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
WriteAttributeValue("", 505, SequenceCount, 505, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border: 2px solid black\"> ");
#nullable restore
#line 20 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
                                                                        Write(SequenceCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 21 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
                    SequenceCount--;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Pervaiz\source\repos\SnakesAndLadders\SnakesAndLadders\SnakesAndLadders\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
    <div class=""bg-success"">
        <div>
            Your Dice  :  <label id=""lblDiceValue""></label>
        </div>
        <button id=""btnRollDice"">Roll Dice</button>
        <button hidden id=""btnNewGame"">New Game</button>

    </div>
    <input type=""hidden"" id=""currentPosition"" value=""0"" />
    <input type=""hidden"" id=""previousPosition""  value=""0""/>

</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a947c5af953f0f2baea9a3e62cbb09c9a81182ee6519", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SnakesAndLadders.Services.GameMatrix> Html { get; private set; }
    }
}
#pragma warning restore 1591
