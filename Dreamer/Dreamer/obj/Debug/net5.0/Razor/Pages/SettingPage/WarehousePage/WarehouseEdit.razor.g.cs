#pragma checksum "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52dbd13069c8cb4241b8a1f61169e5e8f135fd80"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.SettingPage.WarehousePage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting/warehouseedit/{id}")]
    public partial class WarehouseEdit : Microsoft.AspNetCore.Components.ComponentBase
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
#line 11 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder.AddContent(6, localizer["Warehouse"]);

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
#line 13 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder.AddContent(12, localizer["Setting"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, " \r\n                ");
            __builder.OpenElement(14, "li");
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder.AddContent(15, localizer["Warehouse"]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, " / ");
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
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
#line 22 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                  master

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
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
#line 28 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(38, localizer["Warehouse"]);

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
#line 31 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(46, localizer["Warehouse Name"]);

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
#line 32 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                               master.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Name = __value, master.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SettingPage.WarehousePage.WarehouseEdit.TypeInference.CreateValidationMessage_0(__builder2, 54, 55, 
#nullable restore
#line 33 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                  () => master.Name

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
#line 36 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(61, localizer["Mobile"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                                            ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "type", "text");
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                               master.Mobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Mobile = __value, master.Mobile));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SettingPage.WarehousePage.WarehouseEdit.TypeInference.CreateValidationMessage_1(__builder2, 69, 70, 
#nullable restore
#line 38 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                  () => master.Mobile

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(74, "label");
                __builder2.AddAttribute(75, "for", "lastName1");
#nullable restore
#line 41 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(76, localizer["Email"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                            ");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "class", "form-control");
                __builder2.AddAttribute(80, "type", "text");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                               master.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Email = __value, master.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SettingPage.WarehousePage.WarehouseEdit.TypeInference.CreateValidationMessage_2(__builder2, 84, 85, 
#nullable restore
#line 43 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                  () => master.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                                        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(89, "label");
                __builder2.AddAttribute(90, "for", "lastName1");
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(91, localizer["Country"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                            ");
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "class", "form-control");
                __builder2.AddAttribute(95, "type", "text");
                __builder2.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                               master.Country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Country = __value, master.Country));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SettingPage.WarehousePage.WarehouseEdit.TypeInference.CreateValidationMessage_3(__builder2, 99, 100, 
#nullable restore
#line 48 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                  () => master.Country

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                                        ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-md-6 form-group mb-3");
                __builder2.OpenElement(104, "label");
                __builder2.AddAttribute(105, "for", "lastName1");
#nullable restore
#line 51 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(106, localizer["City"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                                            ");
                __builder2.OpenElement(108, "input");
                __builder2.AddAttribute(109, "class", "form-control");
                __builder2.AddAttribute(110, "type", "text");
                __builder2.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                               master.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.City = __value, master.City));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                                        ");
                __Blazor.Dreamer.Pages.SettingPage.WarehousePage.WarehouseEdit.TypeInference.CreateValidationMessage_4(__builder2, 114, 115, 
#nullable restore
#line 53 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                  () => master.City

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                                        ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "col-md-12");
                __builder2.OpenElement(119, "button");
                __builder2.AddAttribute(120, "class", "btn btn-primary");
#nullable restore
#line 56 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(121, localizer["Submit"]);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                                            ");
                __builder2.OpenElement(123, "button");
                __builder2.AddAttribute(124, "type", "button");
                __builder2.AddAttribute(125, "class", "btn btn-danger");
                __builder2.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
                                                                                                    Cancel

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 57 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
__builder2.AddContent(127, localizer["Back to List"]);

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
#line 67 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\WarehousePage\WarehouseEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    Warehouse master = new Warehouse();
    string strMenu = "Warehouse";
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
            master.ModifyDate = DateTime.UtcNow;
            master.CompanyId = 1;
            var isCheck = accountLedger.CheckNameId(master.Name);
            if (isCheck == master.WarehouseId || isCheck == 0)
            {
                accountLedger.Update(master);
                Snackbar.Add("Saved Successfully.", Severity.Success);
                navManager.NavigateTo("/setting/warehouselist");
            }
            else
            {
                Snackbar.Add("Code Already Exists.", Severity.Info);
            }
    }
    void Cancel()
    {
        navManager.NavigateTo("/setting/warehouselist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWarehouse accountLedger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRole _role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
namespace __Blazor.Dreamer.Pages.SettingPage.WarehousePage.WarehouseEdit
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
