#pragma checksum "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef98526e610774495e26a48d678b95bf140f4a63"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.SalesInvoicePage.SalesInvoice
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales/receivecustomershow/{id}")]
    public partial class ReceiveCustomerShow : Microsoft.AspNetCore.Components.ComponentBase
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
#line 12 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(6, localizer["Receive Details"]);

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
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(12, localizer["Receive List"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, " \r\n                ");
            __builder.OpenElement(14, "li");
#nullable restore
#line 15 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(15, localizer["Receive Details"]);

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
            __builder.AddAttribute(27, "class", "card-body");
            __builder.AddMarkupContent(28, "<div class=\"row\"><div class=\"mb-2 col-md-12\"><button onclick=\"printDiv(\'PrintDiv\')\" class=\"btn btn-warning btn-icon ripple btn-sm\"><i class=\"i-Billing\"></i>\r\n          Print</button></div></div>\r\n\r\n\r\n\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "id", "PrintDiv");
            __builder.AddAttribute(31, "class", "invoice mt-5");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "invoice-print");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row justify-content-md-center");
            __builder.OpenElement(36, "h4");
            __builder.AddAttribute(37, "class", "font-weight-bold");
#nullable restore
#line 39 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(38, localizer["Receive Detail"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, " : ");
#nullable restore
#line 39 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(40, master.VoucherNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, " <hr> ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row mt-5");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "mb-4 col-sm-12 col-md-6 col-lg-6");
            __builder.OpenElement(46, "h5");
            __builder.AddAttribute(47, "class", "font-weight-bold");
#nullable restore
#line 42 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(48, localizer["Customer Info"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, " \r\n                            ");
            __builder.OpenElement(50, "div");
#nullable restore
#line 43 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(51, master.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, " \r\n                            ");
            __builder.OpenElement(53, "div");
#nullable restore
#line 44 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(54, master.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, " \r\n                            ");
            __builder.OpenElement(56, "div");
#nullable restore
#line 45 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(57, master.Mobile);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, " \r\n                            ");
            __builder.OpenElement(59, "div");
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(60, master.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(61, " ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "mb-4 col-sm-12 col-md-6 col-lg-6");
            __builder.OpenElement(64, "h5");
            __builder.AddAttribute(65, "class", "font-weight-bold");
#nullable restore
#line 48 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(66, localizer["Company Info"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, " \r\n                            ");
            __builder.OpenElement(68, "div");
#nullable restore
#line 49 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(69, company.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, " \r\n                            ");
            __builder.OpenElement(71, "div");
#nullable restore
#line 50 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(72, company.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, " \r\n                            ");
            __builder.OpenElement(74, "div");
#nullable restore
#line 51 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(75, company.PhoneNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row mt-3");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-md-12");
            __builder.AddMarkupContent(81, "<h5 class=\"font-weight-bold\"></h5> \r\n                  ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "table-responsive");
            __builder.OpenElement(84, "table");
            __builder.AddAttribute(85, "class", "table table-hover table-md");
            __builder.OpenElement(86, "thead");
            __builder.AddAttribute(87, "class", "bg-gray-300");
            __builder.OpenElement(88, "tr");
            __builder.OpenElement(89, "th");
            __builder.AddAttribute(90, "scope", "col");
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(91, localizer["Voucher No"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(92, " \r\n                              ");
            __builder.OpenElement(93, "th");
            __builder.AddAttribute(94, "scope", "col");
#nullable restore
#line 59 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(95, localizer["Paid By"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(96, " \r\n                              ");
            __builder.OpenElement(97, "th");
            __builder.AddAttribute(98, "scope", "col");
#nullable restore
#line 60 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(99, localizer["Amount"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, " \r\n                              ");
            __builder.OpenElement(101, "tbody");
            __builder.OpenElement(102, "tr");
            __builder.OpenElement(103, "td");
#nullable restore
#line 65 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(104, master.VoucherNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                      ");
            __builder.OpenElement(106, "td");
#nullable restore
#line 66 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(107, master.PaymentType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                      ");
            __builder.OpenElement(109, "td");
#nullable restore
#line 67 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
__builder.AddContent(110, master.Amount);

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
#line 83 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesInvoicePage\SalesInvoice\ReceiveCustomerShow.razor"
       
    [Parameter]
    public string id { get; set; }
    PaymentReceiveView master = new PaymentReceiveView();
    Company company = new Company();
    protected async override void OnInitialized()
    {
        master = _receiveCustomer.ReceiveCustomerView(Convert.ToInt32(id));
        company = _company.Edit(1);
        StateHasChanged();
    }
    void Cancel()
    {
        navManager.NavigateTo("/sales/salesinvoicelist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReceiveCustomer _receiveCustomer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany _company { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRole _role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
