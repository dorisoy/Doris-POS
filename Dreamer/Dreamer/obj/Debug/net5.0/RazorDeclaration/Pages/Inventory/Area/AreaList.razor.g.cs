// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.Area
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
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Connection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Apimodel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Chart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Nepdreamer.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Nepdreamer.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Nepdreamer.Repository.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using NumericWordsConversion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/arealist")]
    public partial class AreaList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\Area\AreaList.razor"
       
    List<Area> articleModel;
    Privilege privi = new Privilege();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    private bool dense = true;
    private bool hover = true;
    private string searchString = "";
    private HashSet<Area> selectedItems = new HashSet<Area>();
    string strMenu = "Area";
    bool strAdd = true;
    bool strEdit = true;
    bool strDelete = true;
    bool strShow = true;
    private HubConnection hubConnection;
    protected override void OnInitialized()
    {
        LoadData();
        StateHasChanged();
    }
    protected async void LoadData()
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
                Snackbar.Add("You dont have to privilege.", Severity.Error);
                //Toaster.Add("You dont have to privilege.", MatToastType.Success, "dashboard", null);
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
        articleModel = areaservices.ViewAllArea(CompanyId);
        StateHasChanged();
    }
    Task SendMessage() => hubConnection.SendAsync("SendMessage");
    private bool FilterFunc(Area element)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.AreaName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
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
                    isSave = areaservices.DeleteArea(id);
                    if (isSave == true)
                    {
                        Snackbar.Add("Delete Successfully.", Severity.Success);
                        navManager.NavigateTo("arealist");
                    }
                    else
                    {
                        Snackbar.Add("Cannot be delete. already in used.", Severity.Warning);
                        navManager.NavigateTo("arealist");
                    }
                }
                else
                {
                    Snackbar.Add("Default data cannot be delete.", Severity.Warning);
                    navManager.NavigateTo("arealist");
                }
            }
        }
        else
        {
            Snackbar.Add("You dont have to privilege.", Severity.Error);
            navManager.NavigateTo("dashboard");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AreaRepository areaservices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
