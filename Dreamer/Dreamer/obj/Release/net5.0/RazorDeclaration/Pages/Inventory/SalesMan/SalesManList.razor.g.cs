// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.SalesMan
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/salesmanlist")]
    public partial class SalesManList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\SalesMan\SalesManList.razor"
       
    List<SalesMan> articleModel;
    Privilege privi = new Privilege();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long FinancialYearId;
    long UserId;
    string Email;
    string strMenu = "SalesMan";
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
        LoadData();
        StateHasChanged();
    }
    protected void LoadData()
    {

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
        articleModel = counterRepository.ViewAllSalesMan();
    }
    async Task Delete(long id)
    {
        if (strDelete == true)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                if (id != 1)
                {
                    bool isSave = false;
                    isSave = counterRepository.DeleteSalesMan(id);
                    if (isSave == true)
                    {
                        Toaster.Add("Delete Successfully.", MatToastType.Info, "SalesMan List", null);

                        navManager.NavigateTo("salesmanlist");
                    }
                    else
                    {
                        Toaster.Add("Cannot be delete. already in used.", MatToastType.Warning, "SalesMan List", null);
                        navManager.NavigateTo("salesmanlist");
                    }
                }
                else
                {
                    Toaster.Add("Default data cannot be delete.", MatToastType.Warning, "Area List", null);
                    navManager.NavigateTo("salesmanlist");
                }
            }
        }
        else
        {
            Toaster.Add("You dont have to privilege.", MatToastType.Success, "dashboard", null);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SalesManRepository counterRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
