#pragma checksum "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2498551e0de50befa91139cf61e2a3d3d44650"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.SalesInvoicePage.CustomerPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Connection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Apimodel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.PdfReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales/customeredit/{id}")]
    public partial class CustomerEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-content pt-4");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "breadcrumb");
            __builder.OpenElement(5, "h1");
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder.AddContent(6, localizer["Customer"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "ul");
            __builder.OpenElement(9, "li");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href");
#nullable restore
#line 13 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder.AddContent(12, localizer["Sales"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, " \r\n                ");
            __builder.OpenElement(14, "li");
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder.AddContent(15, localizer["Customer"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, " / ");
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder.AddContent(17, localizer["Edit"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            <div class=\"separator-breadcrumb border-top\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card wrapper");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(22);
            __builder.AddAttribute(23, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                  master

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "row");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-12");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "card");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "card-body");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "card-title mb-3");
#nullable restore
#line 28 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(38, localizer["Customer"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                                    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(44, "label");
                __builder2.AddAttribute(45, "for", "firstName1");
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(46, localizer["Customer Name"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                            ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "type", "text");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.LedgerName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.LedgerName = __value, master.LedgerName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SalesInvoicePage.CustomerPage.CustomerEdit.TypeInference.CreateValidationMessage_0(__builder2, 54, 55, 
#nullable restore
#line 33 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                  () => master.LedgerName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                                        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(59, "label");
                __builder2.AddAttribute(60, "for", "lastName1");
#nullable restore
#line 36 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(61, localizer["Code"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                                            ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "readonly");
                __builder2.AddAttribute(66, "type", "text");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.LedgerCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.LedgerCode = __value, master.LedgerCode));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SalesInvoicePage.CustomerPage.CustomerEdit.TypeInference.CreateValidationMessage_1(__builder2, 70, 71, 
#nullable restore
#line 38 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                  () => master.LedgerCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(75, "label");
                __builder2.AddAttribute(76, "for", "lastName1");
#nullable restore
#line 41 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(77, localizer["Phone"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                            ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Phone = __value, master.Phone));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SalesInvoicePage.CustomerPage.CustomerEdit.TypeInference.CreateValidationMessage_2(__builder2, 85, 86, 
#nullable restore
#line 43 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                  () => master.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                                        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(90, "label");
                __builder2.AddAttribute(91, "for", "lastName1");
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(92, localizer["Mobile"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                            ");
                __builder2.OpenElement(94, "input");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "type", "text");
                __builder2.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.Mobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Mobile = __value, master.Mobile));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SalesInvoicePage.CustomerPage.CustomerEdit.TypeInference.CreateValidationMessage_3(__builder2, 100, 101, 
#nullable restore
#line 48 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                  () => master.Mobile

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                                        ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(105, "label");
                __builder2.AddAttribute(106, "for", "lastName1");
#nullable restore
#line 51 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(107, localizer["Email"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                                            ");
                __builder2.OpenElement(109, "input");
                __builder2.AddAttribute(110, "class", "form-control");
                __builder2.AddAttribute(111, "type", "text");
                __builder2.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Email = __value, master.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SalesInvoicePage.CustomerPage.CustomerEdit.TypeInference.CreateValidationMessage_4(__builder2, 115, 116, 
#nullable restore
#line 53 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                  () => master.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                                        ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(120, "label");
                __builder2.AddAttribute(121, "for", "website");
#nullable restore
#line 56 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(122, localizer["Country"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                                            ");
                __builder2.OpenElement(124, "input");
                __builder2.AddAttribute(125, "class", "form-control");
                __builder2.AddAttribute(126, "type", "text");
                __builder2.AddAttribute(127, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.Country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Country = __value, master.Country));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                                        ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(132, "label");
                __builder2.AddAttribute(133, "for", "picker2");
#nullable restore
#line 60 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(134, localizer["City"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                                            ");
                __builder2.OpenElement(136, "input");
                __builder2.AddAttribute(137, "class", "form-control");
                __builder2.AddAttribute(138, "type", "text");
                __builder2.AddAttribute(139, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.City = __value, master.City));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                                        ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(144, "label");
                __builder2.AddAttribute(145, "for", "picker2");
#nullable restore
#line 64 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(146, localizer["Address"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n                                            ");
                __builder2.OpenElement(148, "input");
                __builder2.AddAttribute(149, "class", "form-control");
                __builder2.AddAttribute(150, "type", "text");
                __builder2.AddAttribute(151, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                               master.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Address = __value, master.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n                                        ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "col-md-12");
                __builder2.OpenElement(156, "button");
                __builder2.AddAttribute(157, "class", "btn btn-primary");
#nullable restore
#line 68 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(158, localizer["Submit"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n                                            ");
                __builder2.OpenElement(160, "button");
                __builder2.AddAttribute(161, "type", "button");
                __builder2.AddAttribute(162, "class", "btn btn-danger");
                __builder2.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
                                                                                                    Cancel

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 69 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
__builder2.AddContent(164, localizer["Back to List"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\CustomerPage\CustomerEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    AccountLedger master = new AccountLedger();
    string strMenu = "Customer";
    bool strAdd = true;
    bool strEdit = true;
    bool strDelete = true;
    bool strShow = true;
    int RoleId = 1;
    Privilege privi = new Privilege();
    protected async override void OnInitialized()
    {
        //RoleId = await sessionStorage.GetItemAsync<int>("RoleId");
        //CheckPriviliage
        privi = _role.PriviliageCheck(strMenu, RoleId, 1);
        if (privi != null)
        {
            strAdd = privi.AddAction;
            strEdit = privi.EditAction;
            strDelete = privi.DeleteAction;
            strShow = privi.ShowAction;
            if (strEdit == false)
            {
                Snackbar.Add("You dont have to privilege.", Severity.Success);
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
        master = accountLedger.Edit(Convert.ToInt32(id));
        StateHasChanged();
    }
    public async Task HandleValidSubmit()
    {
        master.AccountGroupId = 26;
        master.OpeningBalance = 0;
            master.Narration = string.Empty;
            master.IsDefault = false;
            master.CrOrDr = "Dr";
            master.ModifyDate = DateTime.UtcNow;
            master.CompanyId = 1;
            var isCheck = accountLedger.CheckNameId(master.LedgerCode);
            if (isCheck == master.LedgerId || isCheck == 0)
            {
                accountLedger.Update(master);
                Snackbar.Add("Saved Successfully.", Severity.Success);
                navManager.NavigateTo("/sales/customerlist");
            }
            else
            {
                Snackbar.Add("Code Already Exists.", Severity.Info);
            }
    }
    void Cancel()
    {
        navManager.NavigateTo("/sales/customerlist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger accountLedger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRole _role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
namespace __Blazor.Dreamer.Pages.SalesInvoicePage.CustomerPage.CustomerEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
