#pragma checksum "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16d21cfd44b5de5b8d79a1ae3bab7af82a1e261b"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.Inventory.Customer
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/customerlist")]
    public partial class Customerlist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card card-fluid");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "nav nav-tabs card-header-tabs");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "nav-item");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", "account/transaction");
            __builder.AddAttribute(12, "class", "nav-link");
#nullable restore
#line 17 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(13, localizer["Customer"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        \r\n\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "input-group input-group-alt");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "input-group-append");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "id", "table-search");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "placeholder", "Customer Name");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                                               ledgerNme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ledgerNme = __value, ledgerNme));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "id", "table-search");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "placeholder", "Code");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                                               ledgerNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ledgerNo = __value, ledgerNo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenComponent<MudBlazor.MudButton>(39);
            __builder.AddAttribute(40, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 32 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                            Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                       LoadData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(43, "Search");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenComponent<MudBlazor.MudButton>(45);
            __builder.AddAttribute(46, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 33 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                            Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                        Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 33 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                                                          Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 33 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                                                                            Size.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "Link", "account/customeradd");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 33 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder2.AddContent(52, localizer["Create"]);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "id", "myTable_wrapper");
            __builder.AddAttribute(56, "class", "dataTables_wrapper dt-bootstrap4 no-footer");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "table-responsive");
#nullable restore
#line 39 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                     if (articleModel == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<div class=\"spinner\"></div>");
#nullable restore
#line 42 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "table");
            __builder.AddAttribute(61, "id", "myTable");
            __builder.AddAttribute(62, "class", "table dataTable no-footer");
            __builder.AddAttribute(63, "aria-describedby", "myTable_info");
            __builder.AddAttribute(64, "role", "grid");
            __builder.OpenElement(65, "thead");
            __builder.OpenElement(66, "tr");
            __builder.AddAttribute(67, "role", "row");
            __builder.OpenElement(68, "th");
#nullable restore
#line 50 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(69, localizer["S.No"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                    ");
            __builder.OpenElement(71, "th");
#nullable restore
#line 51 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(72, localizer["Customer Name"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                    ");
            __builder.OpenElement(74, "th");
#nullable restore
#line 52 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(75, localizer["Code"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                    ");
            __builder.OpenElement(77, "th");
#nullable restore
#line 53 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(78, localizer["Group"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                    ");
            __builder.OpenElement(80, "th");
#nullable restore
#line 54 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(81, localizer["Area"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                    ");
            __builder.OpenElement(83, "th");
#nullable restore
#line 55 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(84, localizer["Phone"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                    ");
            __builder.OpenElement(86, "th");
#nullable restore
#line 56 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(87, localizer["Mobile"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                                    ");
            __builder.OpenElement(89, "th");
#nullable restore
#line 57 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(90, localizer["Added Date"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.OpenElement(92, "th");
#nullable restore
#line 58 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(93, localizer["Modify Date"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                    ");
            __builder.AddMarkupContent(95, "<th> &nbsp; </th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                            \r\n                            ");
            __builder.OpenElement(97, "tbody");
#nullable restore
#line 65 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                  
                                    int sno = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                 foreach (var item in articleModel)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "tr");
            __builder.AddAttribute(99, "role", "row");
            __builder.OpenElement(100, "td");
            __builder.AddAttribute(101, "class", " align-middle");
#nullable restore
#line 72 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                              sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(102, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                        ");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "class", " align-middle");
#nullable restore
#line 75 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(106, item.LedgerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                                        ");
            __builder.OpenElement(108, "td");
            __builder.AddAttribute(109, "class", " align-middle");
#nullable restore
#line 76 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(110, item.LedgerCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                        ");
            __builder.OpenElement(112, "td");
            __builder.AddAttribute(113, "class", " align-middle");
#nullable restore
#line 77 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(114, item.AccountGroupName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                                        ");
            __builder.OpenElement(116, "td");
            __builder.AddAttribute(117, "class", " align-middle");
#nullable restore
#line 78 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(118, item.AreaName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                                        ");
            __builder.OpenElement(120, "td");
            __builder.AddAttribute(121, "class", " align-middle");
#nullable restore
#line 79 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(122, item.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                        ");
            __builder.OpenElement(124, "td");
            __builder.AddAttribute(125, "class", " align-middle");
#nullable restore
#line 80 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(126, item.Mobile);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                                        ");
            __builder.OpenElement(128, "td");
            __builder.AddAttribute(129, "class", " align-middle");
#nullable restore
#line 81 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(130, item.AddedDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                                        ");
            __builder.OpenElement(132, "td");
            __builder.AddAttribute(133, "class", " align-middle");
#nullable restore
#line 82 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(134, item.ModifyDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                        ");
            __builder.OpenElement(136, "td");
            __builder.AddAttribute(137, "class", " align-middle text-right");
            __builder.OpenElement(138, "a");
            __builder.AddAttribute(139, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(140, "href", "account/customeredit/" + (
#nullable restore
#line 85 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                                                       item.LedgerId

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 86 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(141, localizer["Edit"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(142, " |\r\n                                            ");
            __builder.OpenElement(143, "a");
            __builder.AddAttribute(144, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                                                                       () => Delete(item.LedgerId)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 92 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
__builder.AddContent(146, localizer["Delete"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
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
#line 107 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Customer\Customerlist.razor"
       
    AccountLedger customerType = new AccountLedger();
    List<AccountLedgerView> articleModel;
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long FinancialYearId;
    long UserId;
    string Email;
    string ledgerNme = string.Empty;
    string ledgerNo = string.Empty;
    Privilege privi = new Privilege();
    string strMenu = "Customer";
    bool strAdd = true;
    bool strEdit = true;
    bool strDelete = true;
    bool strShow = true;
    protected async override void OnInitialized()
    {
        Email = await sessionStorage.GetItemAsync<string>("Email");
        CompanyId = await sessionStorage.GetItemAsync<long>("CompanyId");
        RoleId = await sessionStorage.GetItemAsync<long>("RoleId");
        FinancialYearId = await sessionStorage.GetItemAsync<long>("FinancialYearId");
        UserId = await sessionStorage.GetItemAsync<long>("UserId");
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
        LoadData();
        StateHasChanged();
    }
    protected void LoadData()
    {
        articleModel = areaservices.ViewAllCustomer(ledgerNme, ledgerNo, CompanyId);
    }


    async Task Delete(long id)
    {
        if (strDelete == true)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                bool isSave = false;
                isSave = areaservices.DeleteAccountLedger(id);
                if (isSave == true)
                {
                    Toaster.Add("Delete Successfully.", MatToastType.Info, "AccountLedger", null);
                    LoadData();
                    navManager.NavigateTo("account/customerlist");
                }
                else
                {
                    Toaster.Add("Cannot be delete. already in used.", MatToastType.Warning, "AccountLedger", null);
                    navManager.NavigateTo("account/customerlist");
                }
            }

        }
        else
        {
            Toaster.Add("You dont have to privilege.", MatToastType.Success, "Dashboard", null);
            navManager.NavigateTo("dashboard");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountLedgerRepository areaservices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
