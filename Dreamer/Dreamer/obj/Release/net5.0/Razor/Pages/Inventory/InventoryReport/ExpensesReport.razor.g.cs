#pragma checksum "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1f3e7f295496696e46ce09c7ef23d35851811bb"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.Inventory.InventoryReport
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
#nullable restore
#line 3 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/expensesreport")]
    public partial class ExpensesReport : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card card-fluid");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><ul class=\"nav nav-tabs card-header-tabs\"><li class=\"nav-item\"><a href=\"inventory/expensesreport\" class=\"nav-link\">Expenses Report</a></li></ul></div>\r\n        \r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.OpenElement(9, "table");
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "style", "width:420px;");
            __builder.AddMarkupContent(13, "<label for=\"maskUsphone\">Ledger Name</label>\r\n                            ");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                           LedgerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LedgerId = __value, LedgerId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "0");
            __builder.AddContent(20, "Choose");
            __builder.CloseElement();
#nullable restore
#line 34 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                 foreach (var item in listLedger)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                    item.LedgerId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(23, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "table");
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "style", "width:260px;");
            __builder.AddMarkupContent(29, "<label for=\"maskUsphone\">From Date</label>\r\n                            ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 46 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                                             ChangeFrom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "autocomplete", "off");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                       FromNepali

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromNepali = __value, FromNepali));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "style", "width:100px;");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "readonly");
            __builder.AddAttribute(42, "autocomplete", "off");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                                            FromDateEng

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromDateEng = __value, FromDateEng));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "style", "width:260px;");
            __builder.AddMarkupContent(48, "<label for=\"maskUsphone\">To Date</label>\r\n                            ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 52 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                                           ChangeTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "autocomplete", "off");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                       ToNepali

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToNepali = __value, ToNepali));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "style", "width:100px;");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "text");
            __builder.AddAttribute(60, "readonly");
            __builder.AddAttribute(61, "autocomplete", "off");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                       ToDateEng

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToDateEng = __value, ToDateEng));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "td");
            __builder.AddAttribute(66, "style", "width:140px;");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "btn btn-secondary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                                        (() => Search())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-secondary");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                                         Print

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Print");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            \r\n            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "id", "myTable_wrapper");
            __builder.AddAttribute(79, "class", "dataTables_wrapper dt-bootstrap4 no-footer");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "table-responsive");
#nullable restore
#line 67 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                     if (Check == "Uncheck")
                    {

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "<span style=\"border-bottom:1px solid Blue; text-align:center;\"></span>\r\n                        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "id", "PrintDiv");
            __builder.AddAttribute(85, "style", "width:100%;height:800px;border-width:2px;border-color:blue;border:solid");
            __builder.OpenElement(86, "table");
            __builder.AddAttribute(87, "id", "table");
            __builder.AddAttribute(88, "style", "margin-top:40px;");
            __builder.AddMarkupContent(89, "<tr><th></th>\r\n                                    <th></th>\r\n                                    <th></th></tr>\r\n                                ");
            __builder.OpenElement(90, "tr");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(93, "span");
            __builder.AddAttribute(94, "style", "font-size:20px;");
#nullable restore
#line 84 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(95, companyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                ");
            __builder.OpenElement(97, "tr");
            __builder.OpenElement(98, "td");
            __builder.AddAttribute(99, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(100, "span");
            __builder.AddAttribute(101, "style", "font-size:15px;");
#nullable restore
#line 90 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(102, address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                ");
            __builder.OpenElement(104, "tr");
            __builder.OpenElement(105, "td");
            __builder.AddAttribute(106, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(107, "span");
            __builder.AddAttribute(108, "style", "font-size:11px;");
#nullable restore
#line 96 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(109, phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                ");
            __builder.AddMarkupContent(111, "<tr><td style=\"width:1000px; text-align:center;\"><span style=\"font-size:14px;\">Expenses Report</span></td></tr>\r\n                                ");
            __builder.OpenElement(112, "tr");
            __builder.OpenElement(113, "td");
            __builder.AddAttribute(114, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(115, "span");
            __builder.AddAttribute(116, "style", "font-size:13px;");
            __builder.AddContent(117, "Report :");
#nullable restore
#line 106 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(118, fromD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, " / ");
#nullable restore
#line 106 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(120, toD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, " BS");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 111 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                             if (final == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(122, "<div class=\"spinner\"></div>");
#nullable restore
#line 114 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(123, "table");
            __builder.AddAttribute(124, "id", "myTable");
            __builder.AddAttribute(125, "class", "table dataTable no-footer");
            __builder.AddAttribute(126, "aria-describedby", "myTable_info");
            __builder.AddAttribute(127, "role", "grid");
            __builder.AddMarkupContent(128, @"<tr style=""font-size:10px;""><th>S.No.</th>
                                        <th style>Voucher Name</th>
                                        <th style>Ledger Name</th>
                                        <th style>Voucher Type</th>
                                        <th>Grand Total</th>
                                        <th>Narration</th></tr>");
#nullable restore
#line 128 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                      
                                        int sno = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                     foreach (var item in final)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(129, "tr");
            __builder.AddAttribute(130, "style", "font-size:10px;");
            __builder.OpenElement(131, "td");
#nullable restore
#line 135 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                                  sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(132, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                                            ");
            __builder.OpenElement(134, "td");
#nullable restore
#line 138 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(135, item.NepaliDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                                            ");
            __builder.OpenElement(137, "td");
#nullable restore
#line 139 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(138, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                            ");
            __builder.OpenElement(140, "td");
#nullable restore
#line 140 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(141, item.VoucherTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                                            ");
            __builder.OpenElement(143, "td");
#nullable restore
#line 141 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(144, item.Amount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                                            ");
            __builder.OpenElement(146, "td");
#nullable restore
#line 142 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(147, item.UserId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                                            ");
            __builder.OpenElement(149, "td");
#nullable restore
#line 143 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(150, item.Narration);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 145 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(151, "tfoot");
            __builder.OpenElement(152, "tr");
            __builder.AddAttribute(153, "style", "font-size:10px; color:red;");
            __builder.AddMarkupContent(154, "<td></td>\r\n                                            ");
            __builder.AddMarkupContent(155, "<td>Total</td>\r\n                                            <td></td>\r\n                                            <td></td>\r\n                                            ");
            __builder.OpenElement(156, "td");
#nullable restore
#line 152 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
__builder.AddContent(157, final.Sum(i => i.Amount));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                                            <td></td>\r\n                                            <td></td>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 158 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 160 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ExpensesReport.razor"
       
    List<AccountLedger> listLedger = new List<AccountLedger>();
    List<ExpenseVoucherView> final = new List<ExpenseVoucherView>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long LedgerId;
    bool isDefault = false;
    string FromNepali;
    string ToNepali;
    string FromDateEng;
    string ToDateEng;
    string fromD;
    string toD;
    string Check = "Uncheck";
    string companyName;
    string address;
    string phone;
    string myMarkup;
    Privilege privi = new Privilege();
    string strMenu = "ExpenseSummary";
    bool strAdd = true;
    bool strEdit = true;
    bool strDelete = true;
    bool strShow = true;
    protected async override void OnInitialized()
    {
        CompanyId = await sessionStorage.GetItemAsync<long>("CompanyId");
        RoleId = await sessionStorage.GetItemAsync<long>("RoleId");
        //CheckPriviliage
        privi = priviliageRepository.PriviliageCheck(strMenu, RoleId, CompanyId);
        if (privi != null)
        {
            strAdd = privi.AddAction;
            strEdit = privi.EditAction;
            strDelete = privi.DeleteAction;
            strShow = privi.ShowAction;
            if (strShow == false)
            {
                Toaster.Add("You dont have to privilege.", MatToastType.Success, "dashboard", null);
                navManager.NavigateTo("dashboard");
            }
        }
        else
        {
            strAdd = true;
            strEdit = true;
            strDelete = true;
            strShow = true;
        }
        Check = "Uncheck";
        FromNepali = DreamerDateConveter.convertToBS(DateTime.Now);
        ToNepali = DreamerDateConveter.convertToBS(DateTime.Now);
        FromDateEng = DreamerDateConveter.convertToAD(FromNepali).ToShortDateString();
        ToDateEng = DreamerDateConveter.convertToAD(ToNepali).ToShortDateString();
        var resultCompany = icompany.ViewCompany(CompanyId);
        companyName = resultCompany.CompanyName;
        address = resultCompany.Address;
        phone = resultCompany.Phone;
        fromD = FromNepali;
        toD = ToNepali;
        listLedger = expenVoucher.GetAccountLedgerEpensive(CompanyId);
        //Search();
        StateHasChanged();
    }
    protected void Search()
    {
        Check = "check";
        fromD = FromNepali;
        toD = ToNepali;
        final = expenVoucher.ExpensesReport(Convert.ToDateTime(FromDateEng), Convert.ToDateTime(ToDateEng), LedgerId);

    }
    private async Task ChangeFrom()
    {
        try
        {

            if (FromNepali == string.Empty)
            {
                FromNepali = DreamerDateConveter.convertToBS(DateTime.Now);
                FromDateEng = DreamerDateConveter.convertToAD(FromNepali).ToShortDateString();
            }
            else
            {
                FromDateEng = DreamerDateConveter.convertToAD(FromNepali).ToShortDateString();
            }
        }
        catch (Exception ex)
        {
            if (FromDateEng == string.Empty)
            {
                Toaster.Add("Invalid From Date", MatToastType.Info, "Invalid", null);
            }
        }
    }
    private async Task ChangeTo()
    {
        try
        {

            if (ToNepali == string.Empty)
            {
                ToNepali = DreamerDateConveter.convertToBS(DateTime.Now);
                ToDateEng = DreamerDateConveter.convertToAD(ToNepali).ToShortDateString();
            }
            else
            {
                ToDateEng = DreamerDateConveter.convertToAD(ToNepali).ToShortDateString();
            }
        }
        catch (Exception ex)
        {
            if (ToDateEng == string.Empty)
            {
                Toaster.Add("Invalid To Date", MatToastType.Info, "Invalid", null);
            }
        }
    }
    public async Task Print()
    {
        await JsRuntime.InvokeVoidAsync("printDiv");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExpenditureVoucherRepository expenVoucher { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
