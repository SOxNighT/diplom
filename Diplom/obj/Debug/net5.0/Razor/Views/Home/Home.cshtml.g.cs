#pragma checksum "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e4ffce4cb48401eb3313c291e055e107794e25e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 1 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\_ViewImports.cshtml"
using JWT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\_ViewImports.cshtml"
using JWT.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\_ViewImports.cshtml"
using JWT.Domain.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
using Main.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e4ffce4cb48401eb3313c291e055e107794e25e", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82271e504d14ab828f4f710244b63f86a701d3c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JWT.Domain.ViewModels.SharesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 123 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
 foreach (var item in Model.Shares)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <label>");
#nullable restore
#line 126 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.ApiTradeAvailableFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 127 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.BuyAvailableFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 128 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.ClassCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 129 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.CountryOfRisk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 130 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.CountryOfRiskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 131 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 132 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.DivYieldFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 133 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Dlong.GetQuotationDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 134 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.DlongMin.GetQuotationDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 135 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Dshort.GetQuotationDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 136 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.DshortMin.GetQuotationDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 137 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Exchange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 138 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Figi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 139 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.IpoDate.GetTimestampDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 140 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Isin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 141 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.IssueSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 142 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.IssueSizePlan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 143 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Klong.GetQuotationDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 144 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Kshort.GetQuotationDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 145 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Lot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 146 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.MinPriceIncrement.GetQuotationDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 147 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 148 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Nominal.GetMoneyValueDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 149 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.OtcFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 150 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.RealExchange.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 151 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Sector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 152 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.SellAvailableFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 153 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.ShareType.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 154 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.ShortEnabledFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 155 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Ticker);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 156 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.TradingStatus.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n        <label>");
#nullable restore
#line 157 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
          Write(item.Uid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br>\r\n    </div><br>\r\n");
#nullable restore
#line 159 "C:\Users\mrpoo\Desktop\ДИПЛОМ\Программа на диплом\Diplom\Diplom\Views\Home\Home.cshtml"
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JWT.Domain.ViewModels.SharesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591