#pragma checksum "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5cf477cf8ab0602e27a8994bddb2c8d7aea7327"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.Account.LedgerAccount
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
#line 4 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
using NPOI.SS.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
using NPOI.XSSF.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/ledgeraccount")]
    public partial class Ledgeraccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card card-fluid");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><ul class=\"nav nav-tabs card-header-tabs\"><li class=\"nav-item\"><a href=\"inventory/inventorymenu\" class=\"nav-link\">Ledger Report</a></li></ul></div>\r\n        \r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.OpenElement(9, "table");
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "style", "width:420px;");
            __builder.AddMarkupContent(13, "<label for=\"maskUsphone\">Account Ledger</label>\r\n                            ");
            __Blazor.Dreamer.Pages.Account.LedgerAccount.Ledgeraccount.TypeInference.CreateRadzen_Blazor_RadzenDropDownDataGrid_0(__builder, 14, 15, 
#nullable restore
#line 35 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                                                                FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 35 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                                                                                                                       StringFilterOperator.StartsWith

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 36 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                                                                listCustomer

#line default
#line hidden
#nullable disable
            , 20, "LedgerName", 21, "LedgerId", 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                            LedgerClicked

#line default
#line hidden
#nullable disable
            ), 23, "width:300px; height:32px; font-size:12px;", 24, 
#nullable restore
#line 35 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                               LedgerId

#line default
#line hidden
#nullable disable
            , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LedgerId = __value, LedgerId)), 26, () => LedgerId);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "table");
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "style", "width:260px;");
            __builder.AddMarkupContent(32, "<label for=\"maskUsphone\">From Date</label>\r\n                            ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "text");
            __builder.AddAttribute(35, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 45 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                             ChangeFrom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "autocomplete", "off");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                       FromNepali

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromNepali = __value, FromNepali));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "style", "width:100px;");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "readonly");
            __builder.AddAttribute(45, "autocomplete", "off");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                            FromDateEng

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FromDateEng = __value, FromDateEng));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "style", "width:260px;");
            __builder.AddMarkupContent(51, "<label for=\"maskUsphone\">To Date</label>\r\n                            ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 51 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                           ChangeTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "autocomplete", "off");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                       ToNepali

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToNepali = __value, ToNepali));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "style", "width:100px;");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "readonly");
            __builder.AddAttribute(64, "autocomplete", "off");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                       ToDateEng

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ToDateEng = __value, ToDateEng));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "style", "width:140px;");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-secondary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                        (() => Search())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-secondary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                                                                         Print

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Print");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            \r\n            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "id", "myTable_wrapper");
            __builder.AddAttribute(82, "class", "dataTables_wrapper dt-bootstrap4 no-footer");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "table-responsive");
#nullable restore
#line 66 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
                     if (Check == "Uncheck")
                    {

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "<span style=\"border-bottom:1px solid Blue; text-align:center;\"></span>\r\n                        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "id", "PrintDiv");
            __builder.AddAttribute(88, "style", "width:100%;height:800px;border-width:2px;border-color:blue;border:solid");
            __builder.OpenElement(89, "table");
            __builder.AddAttribute(90, "id", "table");
            __builder.AddAttribute(91, "style", "margin-top:40px;");
            __builder.AddMarkupContent(92, "<tr><th></th>\r\n                                    <th></th>\r\n                                    <th></th></tr>\r\n                                ");
            __builder.OpenElement(93, "tr");
            __builder.OpenElement(94, "td");
            __builder.AddAttribute(95, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "style", "font-size:20px;");
#nullable restore
#line 83 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
__builder.AddContent(98, companyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                ");
            __builder.OpenElement(100, "tr");
            __builder.OpenElement(101, "td");
            __builder.AddAttribute(102, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(103, "span");
            __builder.AddAttribute(104, "style", "font-size:15px;");
#nullable restore
#line 89 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
__builder.AddContent(105, address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                                ");
            __builder.OpenElement(107, "tr");
            __builder.OpenElement(108, "td");
            __builder.AddAttribute(109, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(110, "span");
            __builder.AddAttribute(111, "style", "font-size:11px;");
#nullable restore
#line 95 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
__builder.AddContent(112, phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                                ");
            __builder.AddMarkupContent(114, "<tr><td style=\"width:1000px; text-align:center;\"><span style=\"font-size:14px;\">Ledger Report</span></td></tr>\r\n                                ");
            __builder.OpenElement(115, "tr");
            __builder.OpenElement(116, "td");
            __builder.AddAttribute(117, "style", "width:1000px; text-align:center;");
            __builder.OpenElement(118, "span");
            __builder.AddAttribute(119, "style", "font-size:13px;");
            __builder.AddContent(120, "Report :");
#nullable restore
#line 105 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
__builder.AddContent(121, fromD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, " / ");
#nullable restore
#line 105 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
__builder.AddContent(123, toD);

#line default
#line hidden
#nullable disable
            __builder.AddContent(124, " BS");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                            ");
            __builder.OpenElement(126, "table");
            __builder.OpenElement(127, "tr");
            __builder.AddMarkupContent(128, "<td>Ledger Name :</td>\r\n                                    ");
            __builder.OpenElement(129, "td");
#nullable restore
#line 113 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
__builder.AddContent(130, strLedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                            ");
#nullable restore
#line 116 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
__builder.AddContent(132, (MarkupString)myMarkup);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 119 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
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
#line 127 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Account\LedgerAccount\Ledgeraccount.razor"
       

    IEnumerable<AccountLedger> listCustomer;
    List<BillingReport> final = new List<BillingReport>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long LedgerId;
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
    string strMenu = "LedgerReport";
    bool strAdd = true;
    bool strEdit = true;
    bool strDelete = true;
    bool strShow = true;
    string strLedgerName = string.Empty;
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
                Toaster.Add("You dont have to privilege.", MatToastType.Success, "Dashboard", null);
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
        listCustomer = services.GetAccountLedger(CompanyId);
        //Search();
        StateHasChanged();
    }
    protected void Search()
    {
        Check = "check";
        string values = @"<table id='table' class='table table-striped'>
            <tr>
                <th style=''>S.No.</th>
                <th>Date</th>
                <th>Voucher No</th>
                <th>Particular</th>
                <th>Voucher Type</th>
                <th>Debit</th>
                <th>Credit</th>
                <th>Balance</th>
            </tr> ";

        decimal totlDebit = 0;
        decimal totlCredit = 0;

        DataTable dtblsub = new DataTable();
        DataSet dset = new DataSet();
        dset = services.LedgercountReport(Convert.ToDateTime(FromDateEng), Convert.ToDateTime(ToDateEng), LedgerId, string.Empty, CompanyId);
        int counter = 0;
        dtblsub = dset.Tables[0];
        string strBalance = string.Empty;
        string strName = string.Empty;

        if (dtblsub.Rows.Count > 0)
        {
            for (int i = 0; i < dtblsub.Rows.Count; i++)
            {
                counter++;
                strBalance = CalculateBalance(i, decimal.Parse(dtblsub.Rows[i]["debit"].ToString()), decimal.Parse(dtblsub.Rows[i]["credit"].ToString()), strBalance);
                totlDebit = totlDebit + decimal.Parse(dtblsub.Rows[i]["debit"].ToString());
                totlCredit = totlCredit + decimal.Parse(dtblsub.Rows[i]["credit"].ToString());
                string strVoucherTypeName = dtblsub.Rows[i]["VoucherTypeName"].ToString();
                if (strVoucherTypeName == "Purchase Invoice")
                {
                    strName = "To";
                }
                else if (strVoucherTypeName == "Purchase Return")
                {
                    strName = "To";
                }
                else if (strVoucherTypeName == "Payment Voucher")
                {
                    strName = "By";
                }
                else if (strVoucherTypeName == "Sales Invoice")
                {
                    strName = "To";
                }
                else if (strVoucherTypeName == "Sales Return")
                {
                    strName = "To";
                }
                else if (strVoucherTypeName == "Receipt Voucher")
                {
                    strName = "By";
                }
                else
                {
                }
                DateTime dtDate = Convert.ToDateTime(dtblsub.Rows[i]["date"].ToString());
                string strDate = DreamerDateConveter.convertToBS(dtDate);
                values += @"<tr>

        <td style=''>" + counter.ToString() + @"</td>
        <td>" + strDate + @"</td>
        <td>" + dtblsub.Rows[i]["voucherNo"].ToString() + @" </td>
        <td> " + strName + "-" + dtblsub.Rows[i]["ledgerName"].ToString() + @"</td>
        <td> " + dtblsub.Rows[i]["voucherTypeName"].ToString() + @"</td>
<td> " + dtblsub.Rows[i]["debit"].ToString() + @"</td>
        <td> " + dtblsub.Rows[i]["credit"].ToString() + @"</td>
        <td>" + strBalance.ToString() + @"</td>
    </tr>";

            }
        }
        decimal decTotlDebitss = totlDebit;
        decimal decTotlCreditss = totlCredit;
        decimal decBlnce = decTotlDebitss - decTotlCreditss;
        values += @"<tr>
<td style='display:none;'></td>
<td></td>
<td></td>
<td></td>
<td style='font-style:bold; color:black; font-size:16px;'>Total</td>
<td>" + "" + @"</td>
<td style='font-style:bold; color:black; font-size:16px;'>" + decTotlDebitss + @"</td>
<td style='font-style:bold; color:black; font-size:16px;'>" + decTotlCreditss + @"</td>
<td>" + decBlnce + @"</td>
</tr>";
        values += "</table>";
        myMarkup = values;
        //category = values;
        //listCustomer = services.GetAccountLedger(CompanyId)
    }
    private string CalculateBalance(int index, decimal decDebit, decimal decCredit, string strPreviousBalance)
    {
        string strCurrentBalance = string.Empty;
        string strCrOrDr = string.Empty;
        decimal decRowBalance = 0;
        try
        {
            if (index > 0)
            {
                string[] strLastBalance = strPreviousBalance.Split(' ');
                if (strLastBalance.Length >= 2)
                {
                    if ((strLastBalance[1] == null ? "" : strLastBalance[1]) != string.Empty)
                    {
                        if (strLastBalance[1] == "Dr")
                        {
                            decDebit = decimal.Parse(strLastBalance[0]) + decDebit;
                        }
                        if (strLastBalance[1] == "Cr")
                        {
                            decCredit = decimal.Parse(strLastBalance[0]) + decCredit;
                        }
                    }
                }
            }
            decRowBalance = decDebit - decCredit;
            if (decRowBalance > 0)
                strCrOrDr = " Dr";
            else if (decRowBalance < 0)
            {
                decRowBalance = decRowBalance * (-1);
                strCrOrDr = " Cr";
            }
            else
                strCrOrDr = string.Empty;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return strCurrentBalance = Convert.ToString(decRowBalance) + strCrOrDr;
    }
    private void LedgerClicked()
    {
        if (LedgerId > 0)
        {
            strLedgerName = listCustomer.FirstOrDefault(s => s.LedgerId == LedgerId).LedgerName;
        }
        else
        {
            strLedgerName = string.Empty;
        }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountReportRepository services { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
namespace __Blazor.Dreamer.Pages.Account.LedgerAccount.Ledgeraccount
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzen_Blazor_RadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Radzen.FilterCaseSensitivity __arg0, int __seq1, global::Radzen.StringFilterOperator __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Collections.IEnumerable __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, System.Object __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg10, int __seq11, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "FilterCaseSensitivity", __arg0);
        __builder.AddAttribute(__seq1, "FilterOperator", __arg1);
        __builder.AddAttribute(__seq2, "AllowFiltering", __arg2);
        __builder.AddAttribute(__seq3, "AllowClear", __arg3);
        __builder.AddAttribute(__seq4, "Data", __arg4);
        __builder.AddAttribute(__seq5, "TextProperty", __arg5);
        __builder.AddAttribute(__seq6, "ValueProperty", __arg6);
        __builder.AddAttribute(__seq7, "onclick", __arg7);
        __builder.AddAttribute(__seq8, "style", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.AddAttribute(__seq11, "ValueExpression", __arg11);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
