#pragma checksum "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c730531f9e4114db11c3c80291fdaa954eeabba"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.Inventory.PurchaseRetun
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Connection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Apimodel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Chart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Nepdreamer.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Nepdreamer.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Nepdreamer.Repository.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using NumericWordsConversion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BlankLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/purchasereturnprint/{id}")]
    public partial class PurchasereturndetalsPrint : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddAttribute(1, "onload", "window.print()");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "id", "content");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "class", "main padder");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "lefttablefull");
            __builder.AddAttribute(10, "style", "width:100%");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "id", "table");
            __builder.AddMarkupContent(13, "<tr><th></th>\r\n                            <th></th>\r\n                            <th></th></tr>\r\n                        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "<td rowspan=\"5\" style=\"width:50px;\"></td>\r\n                            ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "style", "width:100%; text-align:center;");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "style", "font-size:20px;");
#nullable restore
#line 26 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(20, companyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "style", "width:100%; text-align:center;");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "style", "font-size:15px;");
#nullable restore
#line 31 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(27, address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "style", "width:100%; text-align:center;");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "style", "font-size:11px;");
#nullable restore
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(34, phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "style", "width:100%; font-weight:bold; text-align:center;");
            __builder.OpenElement(39, "span");
            __builder.AddAttribute(40, "style", "font-size:11px;");
#nullable restore
#line 41 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(41, billtype);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            <p></p>\r\n            ");
            __builder.OpenElement(43, "section");
            __builder.AddAttribute(44, "class", "panel");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "panel-body");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-sm-5");
            __builder.OpenElement(51, "h4");
            __builder.OpenElement(52, "strong");
#nullable restore
#line 57 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(53, mster.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "<p></p>\r\n                            ");
            __builder.OpenElement(55, "b");
            __builder.AddContent(56, "Pan:");
#nullable restore
#line 58 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(57, mster.Pan);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-sm-7");
            __builder.OpenElement(61, "section");
            __builder.AddAttribute(62, "class", "panel");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "panel-body");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-sm-6");
            __builder.OpenElement(67, "p");
            __builder.AddMarkupContent(68, "<strong>Voucher No#:</strong> ");
#nullable restore
#line 65 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(69, mster.VoucherNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.OpenElement(71, "p");
            __builder.AddMarkupContent(72, "<strong>Date#:</strong> ");
#nullable restore
#line 68 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(73, mster.NepaliDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                        ");
            __builder.OpenElement(75, "p");
            __builder.AddMarkupContent(76, "<strong>Amount :</strong> ");
#nullable restore
#line 69 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(77, mster.GrandTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.OpenElement(79, "footer");
            __builder.AddAttribute(80, "class", "panel-footer");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "row");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "col-sm-6");
            __builder.AddMarkupContent(85, "<i class=\"icon-calendar\"></i>Created on ");
#nullable restore
#line 75 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(86, DateTime.Now);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, " NepDreamer\r\n                                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "row");
            __builder.OpenElement(91, "table");
            __builder.AddAttribute(92, "class", "table table-striped b-t text-small");
            __builder.AddAttribute(93, "id", "report");
            __builder.AddMarkupContent(94, @"<thead><tr><th>S.No.</th>
                                    <th>Item</th>
                                    <th>Unit</th>
                                    <th class=""text-right"">Qty</th>
                                    <th class=""text-right"">Rate</th>
                                    <th class=""text-right"">Discount</th>
                                    <th class=""text-right"">TaxRate</th>
                                    <th class=""text-right"">TotalAmount</th></tr></thead>
                            ");
            __builder.OpenElement(95, "tbody");
#nullable restore
#line 102 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                  
                                    int sno = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                 foreach (var td in TodoList)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "tr");
            __builder.AddAttribute(97, "valign", "top");
            __builder.OpenElement(98, "td");
#nullable restore
#line 109 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                              sno++;

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                        ");
            __builder.OpenElement(100, "td");
#nullable restore
#line 112 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(101, td.ProductName);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "<br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                        ");
            __builder.OpenElement(104, "td");
#nullable restore
#line 115 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(105, td.UnitName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                                        ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "align", "right");
#nullable restore
#line 116 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(109, td.Qty);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                        ");
            __builder.OpenElement(111, "td");
            __builder.AddAttribute(112, "class", "text-right");
#nullable restore
#line 117 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(113, td.Rate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                        ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "align", "right");
#nullable restore
#line 118 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(117, td.DiscountAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                                        ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "align", "right");
#nullable restore
#line 119 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(121, td.TaxRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                                        ");
            __builder.OpenElement(123, "td");
            __builder.AddAttribute(124, "align", "right");
#nullable restore
#line 120 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(125, td.TotalAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 122 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(126, "tr");
            __builder.AddMarkupContent(127, "<td align=\"right\" colspan=\"7\"><b>Sub total </b></td>\r\n                                    ");
            __builder.OpenElement(128, "td");
            __builder.AddAttribute(129, "align", "right");
            __builder.OpenElement(130, "b");
#nullable restore
#line 125 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(131, mster.TotalAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                                ");
            __builder.OpenElement(133, "tr");
            __builder.AddMarkupContent(134, "<td align=\"right\" colspan=\"7\"><b>Discount</b></td>\r\n                                    ");
            __builder.OpenElement(135, "td");
            __builder.AddAttribute(136, "align", "right");
            __builder.OpenElement(137, "b");
#nullable restore
#line 129 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(138, mster.BillDiscount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                ");
            __builder.OpenElement(140, "tr");
            __builder.AddMarkupContent(141, "<td align=\"right\" colspan=\"7\"><b>Vat</b></td>\r\n                                    ");
            __builder.OpenElement(142, "td");
            __builder.AddAttribute(143, "align", "right");
            __builder.OpenElement(144, "b");
#nullable restore
#line 133 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(145, mster.TaxRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                                ");
            __builder.OpenElement(147, "tr");
            __builder.AddAttribute(148, "valign", "top");
#nullable restore
#line 136 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                     if (mster.CashAmount > 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(149, "<td align=\"right\" colspan=\"7\"><b>Cash Amount </b></td>\r\n                                        ");
            __builder.OpenElement(150, "td");
            __builder.AddAttribute(151, "align", "right");
            __builder.OpenElement(152, "b");
#nullable restore
#line 139 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(153, mster.CashAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 140 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                                ");
            __builder.OpenElement(155, "tr");
#nullable restore
#line 143 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                     if (mster.BankAmount > 0)
                                    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(156, "<td align=\"right\" colspan=\"7\"><b>Bank Amount</b></td>\r\n                                        ");
            __builder.OpenElement(157, "td");
            __builder.AddAttribute(158, "align", "right");
            __builder.OpenElement(159, "b");
#nullable restore
#line 147 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(160, mster.BankAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 148 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                                ");
            __builder.OpenElement(162, "tr");
#nullable restore
#line 151 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                     if (mster.GrandTotal > 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(163, "<td align=\"right\" colspan=\"7\"><b>Grand Total</b></td>\r\n                                        ");
            __builder.OpenElement(164, "td");
            __builder.AddAttribute(165, "align", "right");
            __builder.OpenElement(166, "b");
#nullable restore
#line 154 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(167, mster.GrandTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 155 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                                ");
            __builder.OpenElement(169, "tr");
#nullable restore
#line 158 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                     if (mster.CreditAmount > 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(170, "<td align=\"right\" colspan=\"7\"><b>Due Amount</b></td>\r\n                                        ");
            __builder.OpenElement(171, "td");
            __builder.AddAttribute(172, "align", "right");
            __builder.OpenElement(173, "b");
#nullable restore
#line 161 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(174, mster.CreditAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 162 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                                ");
            __builder.OpenElement(176, "tr");
            __builder.AddMarkupContent(177, "<td align=\"right\" colspan=\"7\"><b>User</b></td>\r\n                                    ");
            __builder.OpenElement(178, "td");
            __builder.AddAttribute(179, "align", "right");
            __builder.OpenElement(180, "b");
#nullable restore
#line 166 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(181, mster.UserId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                    ");
            __builder.OpenElement(183, "div");
            __builder.AddAttribute(184, "class", "row");
            __builder.OpenElement(185, "div");
            __builder.AddAttribute(186, "class", "col-lg-12");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "alert alert-info");
#nullable restore
#line 174 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
__builder.AddContent(189, mster.Narration);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                    \r\n                    \r\n                    <div class=\"row\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 235 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\PurchaseRetun\PurchasereturndetalsPrint.razor"
       
    [Parameter]
    public string id { get; set; }
    PurchaseReturnView mster = new PurchaseReturnView();
    List<ProductView> TodoList = new List<ProductView>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    string companyName;
    string address;
    string phone;
    string billtype;
    protected async override void OnInitialized()
    {
        CompanyId = await sessionStorage.GetItemAsync<long>("CompanyId");
        RoleId = await sessionStorage.GetItemAsync<long>("RoleId");
        var resultCompany = icompany.ViewCompany(CompanyId);
        companyName = resultCompany.CompanyName;
        address = resultCompany.Address;
        phone = resultCompany.Phone;
        billtype = "Purchase Return";
        mster = purchaseRepository.PrintPurchaseReturnMasterView(Convert.ToInt64(id));
        TodoList = purchaseRepository.PurchaseReturnInvoicePrint(Convert.ToInt64(id));
        StateHasChanged();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MailService service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PurchaseInvoiceRepository purchaseRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
