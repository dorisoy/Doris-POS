#pragma checksum "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa667d7537fb8cd6744d40577d90243c74d37263"
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
#line 3 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/productstockreportlist")]
    public partial class ProductstockReport : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card card-fluid");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><ul class=\"nav nav-tabs card-header-tabs\"><li class=\"nav-item\"><a href=\"inventory/inventorymenu\" class=\"nav-link\">Stock Report</a></li></ul></div>\r\n        \r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.OpenElement(9, "table");
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "style", "width:420px;");
            __builder.AddMarkupContent(13, "<label for=\"maskUsphone\">Product Group</label>\r\n                            ");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                           GroupId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroupId = __value, GroupId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "0");
            __builder.AddContent(20, "Choose");
            __builder.CloseElement();
#nullable restore
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                 if (subledger != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                     foreach (var item in subledger)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 40 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                                        item.GroupId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 40 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(23, item.GroupName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 41 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "<label for=\"maskUsphone\">PRoduct</label>\r\n                            ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                           ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductId = __value, ProductId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "0");
            __builder.AddContent(33, "Choose");
            __builder.CloseElement();
#nullable restore
#line 50 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                 if (listvoucherType != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                     foreach (var item in listvoucherType)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 54 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                                        item.ProductId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 54 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(36, item.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 55 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                     
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
            __builder.AddAttribute(41, "style", "width:140px;");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-secondary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                                                        (() => Search())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-secondary");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                                                         Print

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Print");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            \r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "id", "myTable_wrapper");
            __builder.AddAttribute(54, "class", "dataTables_wrapper dt-bootstrap4 no-footer");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "table-responsive");
#nullable restore
#line 86 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                     if (Check == "Uncheck")
                    {

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<span style=\"border-bottom:1px solid Blue; text-align:center;\"></span>\r\n                        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "id", "PrintDiv");
            __builder.AddAttribute(60, "style", "width:100%;height:800px;border-width:2px;border-color:blue;border:solid");
            __builder.OpenElement(61, "table");
            __builder.AddAttribute(62, "id", "table");
            __builder.AddAttribute(63, "style", "margin-top:40px;");
            __builder.AddMarkupContent(64, "<tr><th></th>\r\n                                    <th></th>\r\n                                    <th></th></tr>\r\n                                ");
            __builder.OpenElement(65, "tr");
            __builder.OpenElement(66, "td");
            __builder.AddAttribute(67, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(68, "span");
            __builder.AddAttribute(69, "style", "font-size:20px;");
#nullable restore
#line 103 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(70, companyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.OpenElement(72, "tr");
            __builder.OpenElement(73, "td");
            __builder.AddAttribute(74, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(75, "span");
            __builder.AddAttribute(76, "style", "font-size:15px;");
#nullable restore
#line 109 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(77, address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.OpenElement(79, "tr");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(82, "span");
            __builder.AddAttribute(83, "style", "font-size:11px;");
#nullable restore
#line 115 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(84, phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                ");
            __builder.AddMarkupContent(86, "<tr><td style=\"width:1000px; text-align:center;\"><span style=\"font-size:14px;\">Stock Report</span></td></tr>\r\n                                ");
            __builder.OpenElement(87, "tr");
            __builder.OpenElement(88, "td");
            __builder.AddAttribute(89, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(90, "span");
            __builder.AddAttribute(91, "style", "font-size:13px;");
            __builder.AddContent(92, "Report :");
#nullable restore
#line 125 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(93, fromD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, " / ");
#nullable restore
#line 125 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(95, toD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, " BS");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 130 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                             if (final == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "<div class=\"spinner\"></div>");
#nullable restore
#line 133 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "table");
            __builder.AddAttribute(99, "id", "myTable");
            __builder.AddAttribute(100, "class", "table dataTable no-footer");
            __builder.AddAttribute(101, "aria-describedby", "myTable_info");
            __builder.AddAttribute(102, "role", "grid");
            __builder.AddMarkupContent(103, @"<tr style=""font-size:10px;""><th>S.No.</th>
                                        <th>Product Code</th>
                                        <th>Product Name</th>
                                        <th>Batch No</th>
                                        <th>Unit</th>
                                        <th>Rate</th>
                                        <th style>Sales Rate</th>
                                        <th>Stock</th>
                                        <th>Stock Amount</th></tr>");
#nullable restore
#line 150 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                      
                                        int sno = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                     foreach (var item in final)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(104, "tr");
            __builder.AddAttribute(105, "style", "font-size:10px;");
            __builder.OpenElement(106, "td");
#nullable restore
#line 157 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                                  sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(107, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                            ");
            __builder.OpenElement(109, "td");
#nullable restore
#line 160 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(110, item.productCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                            ");
            __builder.OpenElement(112, "td");
#nullable restore
#line 161 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(113, item.productName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                            ");
            __builder.OpenElement(115, "td");
#nullable restore
#line 162 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(116, item.batchNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                            ");
            __builder.OpenElement(118, "td");
#nullable restore
#line 163 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(119, item.unitName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                                            ");
            __builder.OpenElement(121, "td");
#nullable restore
#line 164 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(122, item.rate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                            ");
            __builder.OpenElement(124, "td");
#nullable restore
#line 165 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(125, item.salesRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                                            ");
            __builder.OpenElement(127, "td");
#nullable restore
#line 166 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(128, item.Stock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                                            ");
            __builder.OpenElement(130, "td");
#nullable restore
#line 167 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(131, item.stockvalue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 169 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(132, "tfoot");
            __builder.OpenElement(133, "tr");
            __builder.AddAttribute(134, "style", "font-size:10px; color:red;");
            __builder.AddMarkupContent(135, "<td></td>\r\n                                            ");
            __builder.AddMarkupContent(136, @"<td>Total</td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            ");
            __builder.OpenElement(137, "td");
#nullable restore
#line 179 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(138, final.Sum(i => i.Stock));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                            ");
            __builder.OpenElement(140, "td");
#nullable restore
#line 180 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
__builder.AddContent(141, final.Sum(i => i.stockvalue));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 184 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 186 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
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
#line 194 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\InventoryReport\ProductstockReport.razor"
       
    List<ProductGroup> subledger = new List<ProductGroup>();
    List<Product> listvoucherType = new List<Product>();
    List<InventoryViewFinl> final = new List<InventoryViewFinl>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long GroupId;
    long ProductId;
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
    string strMenu = "StockSummary";
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
        subledger = productRepository.GetProductGroup();
        listvoucherType = purchaseRepository.GetProduct(CompanyId);

        //Search();
        StateHasChanged();
    }
    protected void Search()
    {
        Check = "check";
        fromD = FromNepali;
        toD = ToNepali;
        final = purchaseRepository.StockReportGridFill1(GroupId, ProductId, CompanyId);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductRepository productRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PurchaseInvoiceRepository purchaseRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SalesInvoiceRepository salesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
