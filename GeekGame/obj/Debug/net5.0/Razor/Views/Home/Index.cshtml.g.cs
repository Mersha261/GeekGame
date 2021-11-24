#pragma checksum "E:\GeekGame\GeekGame\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b7273344229dfe3405f4bc974b405c9f006e17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\GeekGame\GeekGame\Views\_ViewImports.cshtml"
using GeekGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GeekGame\GeekGame\Views\_ViewImports.cshtml"
using GeekGame.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\GeekGame\GeekGame\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\GeekGame\GeekGame\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b7273344229dfe3405f4bc974b405c9f006e17", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4baf8265582634375fc0d1f601d6ac59dfd73318", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GeekGame\GeekGame\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .height-350 {
        height: 350px;
    }

    .nationality-box {
        height: 150px;
        width: 150px;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .nationality-image-container {
        position: absolute;
        top: 0px;
        left: 45%;
        width: 200px;
        height: 300px;
        overflow: hidden;
        cursor: grab;
        z-index: 1001;
    }
</style>
<div class=""container"">
    <div class=""row height-350"">
        <div class=""col-md-6"" id=""japanesebox"">
            <div class=""nationality-box w3-card-2  w3-display-topleft"">
                Japanese
            </div>
        </div>
        <div class=""col-md-6"" id=""chinesebox"">
            <div class=""nationality-box w3-card-2  w3-display-topright"">
                Chinese
            </div>
        </div>
    </div>
    <div class=""row height-350"">
        <div class=""col-md-6"" id=""koreanbox"">
            <div class=""nationalit");
            WriteLiteral(@"y-box w3-card-2  w3-display-bottomleft"">
                Korean
            </div>
        </div>
        <div class=""col-md-6"" id=""thaibox"">
            <div class=""nationality-box w3-card-2  w3-display-bottomright"">
                Thai
            </div>
        </div>
    </div>
</div>
<div id=""dataContainer""></div>
<div id=""score"" class=""bg-light w3-padding w3-margin w3-round-medium text-center"">

</div>
<button class=""btn btn-primary w3-margin w3-padding "" style=""display:none"" id=""refreshButton"">Play again</button>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66b7273344229dfe3405f4bc974b405c9f006e175452", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://code.jquery.com/ui/1.13.0/jquery-ui.js""></script>

    <script>
        var thiPosition = $('#thaibox').position();
        var pageVerticalCenter = thiPosition.left;
        var pageHorizentalCenter = thiPosition.top;
        var score = 0;
        $(document).ready(function () {
            GetData(0);
        });
        function GetData(dataIndex) {
            var scriptUrl = ""/Home/GetData/?dataIndex="" + dataIndex;
            $.ajax
                ({
                    url: scriptUrl,
                    type: 'get',
                    dataType: 'Json',
                    success: function (result) {
                        setTimeout(function () {
                            if (result != ""null"" && result != null) {
                                $(""#dataContainer"").html("""");
                                $(""#dataContainer"").append($(""<div class='nationality-image-container' id='imgcontainer' ><img src='"" + result.image + ""' alt='"" + result.nation");
                WriteLiteral(@"ality + ""' class='img-fluid img-thumbnail w3-card-2' id='natImage' draggable='true' /></div >""));
                                $(""#imgcontainer"").fadeIn(50);
                                $(""#imgcontainer"").css({ top: 500, 'opacity': '.4', 'transition': 'linear 3s' });
                                $(""#imgcontainer"").draggable();
                                dataIndex++;
                                setScore();
                                GetData(dataIndex);
                            } else {
                                $('#score').html(""your score is "" + score);
                                $(""#imgcontainer"").fadeOut();
                                $(""#dataContainer"").fadeOut();
                                $('#refreshButton').fadeIn();
                            }
                        }, 3000);

                    },
                    error: function () {
                        alert(""There was a problem. Please reload the page."");
                  ");
                WriteLiteral(@"  }
                });

        }
        function setScore() {
            setTimeout(function () {
                var imgPosition = $('#imgcontainer').position();
                var imgWidth = $('#natImage').width();
                var imgHeight = $('#natImage').height();
                var imgVerticalCenter = imgPosition.left + imgWidth / 2;
                var imgHorizentalCenter = imgPosition.top + imgHeight / 2;
                var nationality = $('#natImage').attr(""alt"");
                if (imgVerticalCenter > pageVerticalCenter) {
                    if (imgHorizentalCenter > pageHorizentalCenter) {
                        if (nationality == ""4"") {
                            score += 20;
                            showScore();
                        } else {
                            score -= 5;
                            showScore();
                        }
                    } else {
                        if (nationality == ""2"") {
                            s");
                WriteLiteral(@"core += 20;
                            showScore();
                        } else {
                            score -= 5;
                            showScore();
                        }
                    }
                } else {
                    if (imgHorizentalCenter < pageHorizentalCenter) {
                        if (nationality == ""1"") {
                            score += 20;
                            showScore();
                        } else {
                            score -= 5;
                            showScore();
                        }
                    }
                    else {
                        if (nationality == ""3"") {
                            score += 20;
                            showScore();
                        } else {
                            score -= 5;
                            showScore();
                        }
                    }
                }
                $(""#natImage"").fadeOut(400);
        ");
                WriteLiteral("    }, 3000);\r\n\r\n\r\n        }\r\n\r\n        $(\'#refreshButton\').click(function () {\r\n            location.reload();\r\n        });\r\n        function showScore() {\r\n            $(\'#score\').html(\"your score is \" + score);\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
