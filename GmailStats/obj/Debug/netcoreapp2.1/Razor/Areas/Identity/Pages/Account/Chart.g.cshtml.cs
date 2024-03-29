#pragma checksum "C:\Users\Bodia\Documents\gmailstatisticclient\GmailStats\Areas\Identity\Pages\Account\Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c7a3e1ae2777497c3c32688233608671209a1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GmailStatsClient.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Chart), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Chart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Chart.cshtml", typeof(GmailStatsClient.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Chart), null)]
namespace GmailStatsClient.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\Bodia\Documents\gmailstatisticclient\GmailStats\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Bodia\Documents\gmailstatisticclient\GmailStats\Areas\Identity\Pages\_ViewImports.cshtml"
using GmailStatsClient.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\Bodia\Documents\gmailstatisticclient\GmailStats\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using GmailStatsClient.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c7a3e1ae2777497c3c32688233608671209a1b", @"/Areas/Identity/Pages/Account/Chart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cfeebf09b50b1f7e63cc4a796fc7068d59f294", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b19734ede01a65839e3e76d3ccdb16c6e25f5b81", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Chart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Bodia\Documents\gmailstatisticclient\GmailStats\Areas\Identity\Pages\Account\Chart.cshtml"
  
    ViewData["Title"] = "Chart";

#line default
#line hidden
            BeginContext(50, 299, true);
            WriteLiteral(@"
<h2>Chart</h2>

<div class=""row"">
    <div class=""col-md-4"">
        <button type=""button"" id=""chartbtn"" class=""btn btn-default"">Click to Create Pie Chart</button>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <div id=""chartArea""></div>
    </div>
</div>


");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(368, 303, true);
                WriteLiteral(@" 
    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script>
    $(document)
        .ready(function () {

            $('#chartbtn')
                .click(function () {
                    $.ajax({
                        type: ""GET"",

                        url: '");
                EndContext();
                BeginContext(672, 26, false);
#line 33 "C:\Users\Bodia\Documents\gmailstatisticclient\GmailStats\Areas\Identity\Pages\Account\Chart.cshtml"
                         Write(Url.Action("GetChartData"));

#line default
#line hidden
                EndContext();
                BeginContext(698, 1778, true);
                WriteLiteral(@"',

                        dataType: ""json"",
                        success: function (data) {
                            var series = [
                                {
                                    type: 'pie',
                                    name: '',
                                    data: data
                                }
                            ];


                            createChart(""#chartArea"", ""Simple PIE"", series)
                        }

                    });
                });
        });

        function createChart(chartcontainer, title, series) {

            $(chartcontainer)
                .highcharts({
                    chart: {
                        type: 'pie',
                    },
                    credits: {
                        enabled: false,
                    },
                    exporting: {
                        enabled: false,
                    },
                    plotOptions: {
          ");
                WriteLiteral(@"              pie: {
                            allowPointSelect: true,
                            cursor: 'pointer',
                            dataLabels: {
                                enabled: true,
                                format: '<b>{point.name}</b>: {point.percentage:lf} %',
                                style: {
                                    color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black',
                                },
                            }
                        }
                    },
                    series: series,
                    title: {
                        text: title
                    }
                });
        }
    </script>
    ");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_Chart> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Chart> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Chart>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_Chart Model => ViewData.Model;
    }
}
#pragma warning restore 1591
