#pragma checksum "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7f7d84f4421c3b0bcc8096b465ad55879dfee90"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.SettingPage
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
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
using Dreamer.Services.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting/systemsettingedit/{id}")]
    public partial class SystemSettingEdit : Microsoft.AspNetCore.Components.ComponentBase
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
#line 13 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(6, localizer["System Setting"]);

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
#line 15 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(12, localizer["Setting"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, " \r\n                ");
            __builder.OpenElement(14, "li");
#nullable restore
#line 16 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(15, localizer["System Setting"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            <div class=\"separator-breadcrumb border-top\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card wrapper");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-md-12");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-title mb-3");
#nullable restore
#line 27 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(28, localizer["System Setting"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card-body");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(36, "label");
            __builder.AddAttribute(37, "for", "firstName1");
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(38, localizer["VoucherType Name"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                            ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                                               master.VoucherTypeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.VoucherTypeName = __value, master.VoucherTypeName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(48, "label");
            __builder.AddAttribute(49, "for", "lastName1");
#nullable restore
#line 35 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(50, localizer["Start Index"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                            ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "class", "form-control");
            __builder.AddAttribute(54, "type", "text");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                                               master.StartIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.StartIndex = __value, master.StartIndex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(60, "label");
            __builder.AddAttribute(61, "for", "lastName1");
#nullable restore
#line 39 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(62, localizer["Prefix"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                            ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "class", "form-control");
            __builder.AddAttribute(66, "type", "text");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                                               master.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Prefix = __value, master.Prefix));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(72, "label");
            __builder.AddAttribute(73, "for", "lastName1");
#nullable restore
#line 43 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(74, localizer["Suffix"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                            ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "type", "text");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                                               master.Suffix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Suffix = __value, master.Suffix));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(84, "label");
            __builder.AddAttribute(85, "for", "lastName1");
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(86, localizer["Show Note"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                                            ");
            __builder.OpenElement(88, "select");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                           master.ShowNote

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.ShowNote = __value, master.ShowNote));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(91, "option");
            __builder.AddAttribute(92, "value", "Yes");
            __builder.AddContent(93, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                                ");
            __builder.OpenElement(95, "option");
            __builder.AddAttribute(96, "value", "No");
            __builder.AddContent(97, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(101, "label");
            __builder.AddAttribute(102, "for", "lastName1");
#nullable restore
#line 54 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(103, localizer["Show Address"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                            ");
            __builder.OpenElement(105, "select");
            __builder.AddAttribute(106, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                           master.ShowAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.ShowAddress = __value, master.ShowAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "Yes");
            __builder.AddContent(110, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                                ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "No");
            __builder.AddContent(114, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                                        ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(118, "label");
            __builder.AddAttribute(119, "for", "lastName1");
#nullable restore
#line 61 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(120, localizer["Show Email"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                                            ");
            __builder.OpenElement(122, "select");
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                           master.ShowEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.ShowEmail = __value, master.ShowEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(125, "option");
            __builder.AddAttribute(126, "value", "Yes");
            __builder.AddContent(127, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                                                ");
            __builder.OpenElement(129, "option");
            __builder.AddAttribute(130, "value", "No");
            __builder.AddContent(131, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                                        ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(135, "label");
            __builder.AddAttribute(136, "for", "lastName1");
#nullable restore
#line 68 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(137, localizer["Show Phone"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                            ");
            __builder.OpenElement(139, "select");
            __builder.AddAttribute(140, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                           master.ShowPhone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.ShowPhone = __value, master.ShowPhone));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(142, "option");
            __builder.AddAttribute(143, "value", "Yes");
            __builder.AddContent(144, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                                                ");
            __builder.OpenElement(146, "option");
            __builder.AddAttribute(147, "value", "No");
            __builder.AddContent(148, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                                        ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(152, "label");
            __builder.AddAttribute(153, "for", "lastName1");
#nullable restore
#line 75 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(154, localizer["Show Discount"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                                            ");
            __builder.OpenElement(156, "select");
            __builder.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                           master.ShowDiscount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.ShowDiscount = __value, master.ShowDiscount));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(159, "option");
            __builder.AddAttribute(160, "value", "Yes");
            __builder.AddContent(161, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                                                ");
            __builder.OpenElement(163, "option");
            __builder.AddAttribute(164, "value", "No");
            __builder.AddContent(165, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                                        ");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(169, "label");
            __builder.AddAttribute(170, "for", "lastName1");
#nullable restore
#line 82 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(171, localizer["Show Tax"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n                                            ");
            __builder.OpenElement(173, "select");
            __builder.AddAttribute(174, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                           master.ShowTax

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(175, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.ShowTax = __value, master.ShowTax));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(176, "option");
            __builder.AddAttribute(177, "value", "Yes");
            __builder.AddContent(178, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                                                ");
            __builder.OpenElement(180, "option");
            __builder.AddAttribute(181, "value", "No");
            __builder.AddContent(182, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n                                        ");
            __builder.OpenElement(184, "div");
            __builder.AddAttribute(185, "class", "col-md-6 form-group mb-3");
            __builder.OpenElement(186, "label");
            __builder.AddAttribute(187, "for", "lastName1");
#nullable restore
#line 89 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(188, localizer["Show Barcode"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                                            ");
            __builder.OpenElement(190, "select");
            __builder.AddAttribute(191, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                           master.ShowBarcode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(192, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.ShowBarcode = __value, master.ShowBarcode));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(193, "option");
            __builder.AddAttribute(194, "value", "Yes");
            __builder.AddContent(195, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                                                ");
            __builder.OpenElement(197, "option");
            __builder.AddAttribute(198, "value", "No");
            __builder.AddContent(199, "No");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n                                        ");
            __builder.OpenElement(201, "div");
            __builder.AddAttribute(202, "class", "col-md-12");
            __builder.OpenElement(203, "button");
            __builder.AddAttribute(204, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
                                                              () =>Save()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(205, "class", "btn btn-primary");
            __builder.AddAttribute(206, "type", "button");
#nullable restore
#line 96 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
__builder.AddContent(207, localizer["Submit"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\SystemSettingEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    VoucherType master = new VoucherType();
    string strMenu = "System Setting";
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
        Load();
        StateHasChanged();
    }
    private void Load()
    {
        master = _voucherType.Edit( Convert.ToInt32(id));
    }
    private async void Save()
    {
        if(master.VoucherTypeName == string.Empty)
        {
            Snackbar.Add("Type VoucherName.", Severity.Info);
        }
        else
        {
            master.VoucherTypeId = Convert.ToInt32(id);
            master.CompanyId = 1;
            master.IsActive = true;
            _voucherType.Update(master);
                Snackbar.Add("Updated Successfully.", Severity.Success);
                Load();
                navManager.NavigateTo("setting/systemsetting");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVoucherType _voucherType { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRole _role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
