#pragma checksum "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c31299bffacfe1a3259a41bdb97edfda22aea4d3"
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
#line 3 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/customersalescount")]
    public partial class Customersalescount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card card-fluid");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><ul class=\"nav nav-tabs card-header-tabs\"><li class=\"nav-item\"><a href=\"inventory/inventorymenu\" class=\"nav-link\">Sales Count (Sales)</a></li></ul></div>\r\n        \r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.OpenElement(9, "table");
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "style", "width:420px;");
            __builder.AddMarkupContent(13, "<label for=\"maskUsphone\">Customer</label>\r\n                            ");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
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
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                 if (subledger != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                     foreach (var item in subledger)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 40 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                        item.LedgerId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 40 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(23, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 41 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "<label for=\"maskUsphone\">Voucher Type</label>\r\n                            ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                           VoucherTypeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => VoucherTypeId = __value, VoucherTypeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "0");
            __builder.AddContent(33, "Choose");
            __builder.CloseElement();
#nullable restore
#line 50 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                 if (listvoucherType != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                     foreach (var item in listvoucherType)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 54 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                        item.VoucherTypeId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 54 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(36, item.VoucherTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 55 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "table");
            __builder.OpenElement(39, "tr");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "style", "width:260px;");
            __builder.AddMarkupContent(42, "<label for=\"maskUsphone\">From Date</label>\r\n                            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 65 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                                             ChangeFrom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "autocomplete", "off");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                       FromNepali

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromNepali = __value, FromNepali));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "style", "width:100px;");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "readonly");
            __builder.AddAttribute(55, "autocomplete", "off");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                                            FromDateEng

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromDateEng = __value, FromDateEng));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "style", "width:260px;");
            __builder.AddMarkupContent(61, "<label for=\"maskUsphone\">To Date</label>\r\n                            ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "text");
            __builder.AddAttribute(64, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 71 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                                           ChangeTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "autocomplete", "off");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                       ToNepali

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToNepali = __value, ToNepali));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddAttribute(70, "style", "width:100px;");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "text");
            __builder.AddAttribute(73, "readonly");
            __builder.AddAttribute(74, "autocomplete", "off");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                       ToDateEng

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToDateEng = __value, ToDateEng));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "style", "width:140px;");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-secondary");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                                        (() => Search())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "btn btn-secondary");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                                         Print

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Print");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            \r\n            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "id", "myTable_wrapper");
            __builder.AddAttribute(92, "class", "dataTables_wrapper dt-bootstrap4 no-footer");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "table-responsive");
#nullable restore
#line 86 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                     if (Check == "Uncheck")
                    {

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "<span style=\"border-bottom:1px solid Blue; text-align:center;\"></span>\r\n                        ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "id", "PrintDiv");
            __builder.AddAttribute(98, "style", "width:100%;height:800px;border-width:2px;border-color:blue;border:solid");
            __builder.OpenElement(99, "table");
            __builder.AddAttribute(100, "id", "table");
            __builder.AddAttribute(101, "style", "margin-top:40px;");
            __builder.AddMarkupContent(102, "<tr><th></th>\r\n                                    <th></th>\r\n                                    <th></th></tr>\r\n                                ");
            __builder.OpenElement(103, "tr");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(106, "span");
            __builder.AddAttribute(107, "style", "font-size:20px;");
#nullable restore
#line 103 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(108, companyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                                ");
            __builder.OpenElement(110, "tr");
            __builder.OpenElement(111, "td");
            __builder.AddAttribute(112, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(113, "span");
            __builder.AddAttribute(114, "style", "font-size:15px;");
#nullable restore
#line 109 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(115, address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                ");
            __builder.OpenElement(117, "tr");
            __builder.OpenElement(118, "td");
            __builder.AddAttribute(119, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(120, "span");
            __builder.AddAttribute(121, "style", "font-size:11px;");
#nullable restore
#line 115 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(122, phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                ");
            __builder.AddMarkupContent(124, "<tr><td style=\"width:1000px; text-align:center;\"><span style=\"font-size:14px;\">Customer Count (Sales)</span></td></tr>\r\n                                ");
            __builder.OpenElement(125, "tr");
            __builder.OpenElement(126, "td");
            __builder.AddAttribute(127, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(128, "span");
            __builder.AddAttribute(129, "style", "font-size:13px;");
            __builder.AddContent(130, "Report :");
#nullable restore
#line 125 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(131, fromD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, " / ");
#nullable restore
#line 125 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(133, toD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(134, " BS");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 130 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                             if (final == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(135, "<div class=\"spinner\"></div>");
#nullable restore
#line 133 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(136, "table");
            __builder.AddAttribute(137, "id", "myTable");
            __builder.AddAttribute(138, "class", "table dataTable no-footer");
            __builder.AddAttribute(139, "aria-describedby", "myTable_info");
            __builder.AddAttribute(140, "role", "grid");
            __builder.AddMarkupContent(141, @"<tr style=""font-size:10px;""><th>S.No.</th>
                                        <th style>Customer Name</th>
                                        <th style>Voucher Type</th>
                                        <th>Total Sales (Count)</th>
                                        <th>Grand Total</th></tr>");
#nullable restore
#line 146 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                      
                                        int sno = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                     foreach (var item in final)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(142, "tr");
            __builder.AddAttribute(143, "style", "font-size:10px;");
            __builder.OpenElement(144, "td");
#nullable restore
#line 153 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                                  sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(145, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                                            ");
            __builder.OpenElement(147, "td");
#nullable restore
#line 156 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(148, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                                            ");
            __builder.OpenElement(150, "td");
#nullable restore
#line 157 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(151, item.VoucherTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                                            ");
            __builder.OpenElement(153, "td");
#nullable restore
#line 158 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(154, item.TotalSales);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                                            ");
            __builder.OpenElement(156, "td");
#nullable restore
#line 159 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(157, item.GrandTotal);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 161 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(158, "tfoot");
            __builder.OpenElement(159, "tr");
            __builder.AddAttribute(160, "style", "font-size:10px; color:red;");
            __builder.AddMarkupContent(161, "<td>Total</td>\r\n                                            <td></td>\r\n                                            <td></td>\r\n                                            ");
            __builder.OpenElement(162, "td");
#nullable restore
#line 167 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(163, final.Sum(i => i.TotalSales));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                                            ");
            __builder.OpenElement(165, "td");
#nullable restore
#line 168 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
__builder.AddContent(166, final.Sum(i => i.GrandTotal));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 172 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 174 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
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
#line 182 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\Customersalescount.razor"
       
    List<AccountLedger> subledger = new List<AccountLedger>();
    List<VoucherType> listvoucherType = new List<VoucherType>();
    List<PurchaseSales> final = new List<PurchaseSales>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long LedgerId;
    long VoucherTypeId;
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
    string strMenu = "CustomerSalesCount";
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
        subledger = salesRepository.GetAccountLedger(CompanyId);
        listvoucherType = salesRepository.GetVoucherType();
        StateHasChanged();
        //Search();
    }
    protected void Search()
    {
        Check = "check";
        fromD = FromNepali;
        toD = ToNepali;
        final = reports.CustomerCountSales(Convert.ToDateTime(FromDateEng), Convert.ToDateTime(ToDateEng), LedgerId, VoucherTypeId);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InventoryReportRepository reports { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PurchaseInvoiceRepository purchaseRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SalesInvoiceRepository salesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
