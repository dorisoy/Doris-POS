// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.Batch
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
#line 10 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Batch\Batchlist.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/batchlist")]
    public partial class Batchlist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 190 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\Batch\Batchlist.razor"
       
    Batch customerType = new Batch();
    List<BatchView> batchView;
    List<ProductView> listProduct = new List<ProductView>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    DateTime? FromNepali = DateTime.Now;
    DateTime? ToNepali = DateTime.Now;
    string FromDateEng;
    string ToDateEng;
    string BatchNo = string.Empty;
    string ProductName = string.Empty;
    Privilege privi = new Privilege();
    string strMenu = "Batch";
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
    protected void Load()
    {
        customerType.ProductId = 0;
        customerType.ManufacturingDate = DateTime.Now;
        customerType.ExpiryDate = DateTime.Now;
        customerType.BatchId = 0;
        customerType.BatchNo = string.Empty;
        customerType.Rate = 0;
        customerType.Narration = "";
        listProduct = productrepository.ViewAllProduct(CompanyId);
        batchView = batchRepository.ViewAllBatch(CompanyId, BatchNo, ProductName);
    }
    protected void LoadData()
    {
        batchView = batchRepository.ViewAllBatch(CompanyId, BatchNo, ProductName);
    }
    protected void SaveCustomerType()
    {
        if (customerType.BatchNo == string.Empty)
        {
            Snackbar.Add("Type batch no.", Severity.Info);
            return;
        }
        else if (customerType.ProductId == 0)
        {
            Snackbar.Add("Choose Product.", Severity.Info);
            return;
        }
        else if (Convert.ToDateTime(customerType.ExpiryDate) < Convert.ToDateTime(customerType.ManufacturingDate))
        {
            Snackbar.Add("ExpiryDate should be greater than MfgDate.", Severity.Info);
            return;
        }
        else
        {
            if (customerType.BatchId == 0)
            {
                if (strAdd == true)
                {
                    customerType.ManufacturingNepali = string.Empty;
                    customerType.ExpiryNepali = string.Empty;
                    customerType.Barcode = string.Empty;
                    customerType.PartNo = string.Empty;
                    customerType.Mrp = 0;
                    customerType.CompanyId = CompanyId;
                    customerType.AddedDate = DateTime.Now;
                    bool isSave = false;
                    isSave = batchRepository.InsertBatch(customerType);
                    if (isSave == true)
                    {
                        Snackbar.Add("Saved Successfully.", Severity.Success);
                        Load();
                        LoadData();
                        navManager.NavigateTo("inventory/batchlist");
                    }
                    else
                    {
                        Snackbar.Add("Already exists.", Severity.Success);
                        navManager.NavigateTo("inventory/batchlist");
                    }
                }
                else
                {
                    Snackbar.Add("You dont have to priviliage.", Severity.Success);
                    navManager.NavigateTo("dashboard");
                }
            }
            else
            {
                if (strEdit == true)
                {
                    if (customerType.BatchNo == "NA")
                    {
                        Snackbar.Add("Default batch cannot update.", Severity.Success);
                    }
                    else
                    {
                        customerType.ManufacturingDate = Convert.ToDateTime(FromDateEng);
                        customerType.ManufacturingNepali = string.Empty;
                        customerType.ExpiryDate = Convert.ToDateTime(ToDateEng);
                        customerType.ExpiryNepali = string.Empty;
                        customerType.Mrp = 0;
                        customerType.ModifyDate = DateTime.Now;
                        if (batchRepository.UpdateBatch(customerType))
                        {
                            Snackbar.Add("Updated Successfully.", Severity.Success);
                            Load();
                            LoadData();
                            navManager.NavigateTo("inventory/batchlist");
                        }
                        else
                        {
                            Snackbar.Add("Already Exists.", Severity.Success);
                            navManager.NavigateTo("inventory/batchlist");
                        }
                    }
                }
                else
                {
                    Snackbar.Add("You dont have to privilege.", Severity.Success);
                    navManager.NavigateTo("dashboard");
                }
            }
        }
    }
    private async Task ChangeFrom()
    {
        //try
        //{

        //    if (FromNepali == string.Empty)
        //    {
        //        FromNepali = DreamerDateConveter.convertToBS(DateTime.Now);
        //        FromDateEng = DreamerDateConveter.convertToAD(FromNepali).ToShortDateString();
        //        //customerType.ManufacturingDate = Convert.ToDateTime(FromDateEng);
        //        //customerType.ManufacturingNepali = FromNepali;
        //    }
        //    else
        //    {
        //        FromDateEng = DreamerDateConveter.convertToAD(FromNepali).ToShortDateString();
        //        //customerType.ManufacturingDate = Convert.ToDateTime(FromDateEng);
        //    }
        //}
        //catch (Exception ex)
        //{
        //    if (FromDateEng == string.Empty)
        //    {
        //        Snackbar.Add("Invalid.", Severity.Error);
        //    }
        //}
    }
    private async Task ChangeTo()
    {
        //try
        //{

        //    if (ToNepali == string.Empty)
        //    {
        //        ToNepali = DreamerDateConveter.convertToBS(DateTime.Now);
        //        ToDateEng = DreamerDateConveter.convertToAD(ToNepali).ToShortDateString();

        //        //customerType.ExpiryDate = Convert.ToDateTime(ToDateEng);
        //        //customerType.ExpiryNepali = ToNepali;
        //    }
        //    else
        //    {
        //        ToDateEng = DreamerDateConveter.convertToAD(ToNepali).ToShortDateString();
        //        //customerType.ExpiryDate = Convert.ToDateTime(ToDateEng);
        //    }
        //}
        //catch (Exception ex)
        //{
        //    if (ToDateEng == string.Empty)
        //    {
        //        Snackbar.Add("Invalid.", Severity.Error);
        //    }
        //}
    }
    private async Task ChangeFromEng()
    {
        //try
        //{

        //    if (FromDateEng == string.Empty)
        //    {
        //        FromNepali = DreamerDateConveter.convertToBS(DateTime.Now);
        //    }
        //    else
        //    {
        //        //FromDateEng = DreamerDateConveter.convertToAD(FromNepali).ToShortDateString();
        //        FromNepali = DreamerDateConveter.convertToBS(Convert.ToDateTime(FeaturesDateTime.ToString()));
        //    }
        //}
        //catch (Exception ex)
        //{
        //    if (FromDateEng == string.Empty)
        //    {
        //        Snackbar.Add("Invalid.", Severity.Error);
        //    }
        //}
    }
    private async Task ChangeToEng()
    {
        //try
        //{

        //    if (ToDateEng == string.Empty)
        //    {
        //        ToNepali = DreamerDateConveter.convertToBS(DateTime.Now);
        //    }
        //    else
        //    {
        //        //ToDateEng = DreamerDateConveter.convertToAD(ToNepali).ToShortDateString();
        //        ToNepali = DreamerDateConveter.convertToBS(Convert.ToDateTime(ToDateEng.ToString()));
        //    }
        //}
        //catch (Exception ex)
        //{
        //    if (ToDateEng == string.Empty)
        //    {
        //        Snackbar.Add("Invalid.", Severity.Error);
        //    }
        //}
    }
    async Task Delete(long id)
    {
        if (strDelete == true)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                customerType = batchRepository.EditBatch(Convert.ToInt64(id));
                if (customerType.BatchNo == "NA")
                {
                    Snackbar.Add("Default value cannot be deleted.", Severity.Info);
                }
                else
                {
                    bool isSave = false;
                    isSave = batchRepository.DeleteBatch(id);
                    if (isSave == true)
                    {
                        Snackbar.Add("Deleted Successfully.", Severity.Success);
                        LoadData();
                        navManager.NavigateTo("inventory/batchlist");
                    }
                    else
                    {
                        Snackbar.Add("Cannot be delete. already in used.", Severity.Info);
                        navManager.NavigateTo("inventory/batchlist");
                    }
                }
            }
        }
        else
        {
            Snackbar.Add("You dont have to privilege.", Severity.Info);
            navManager.NavigateTo("dashboard");
        }
    }
    void Edit(long id)
    {
        customerType = batchRepository.EditBatch(Convert.ToInt64(id));
        FromDateEng = customerType.ManufacturingDate.ToString();
        //FromNepali = customerType.ManufacturingNepali.ToString();
        ToDateEng = customerType.ExpiryDate.ToString();
        //ToNepali = customerType.ExpiryNepali.ToString();
    }
    void Cancel()
    {
        Load();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductRepository productrepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BatchRepository batchRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
