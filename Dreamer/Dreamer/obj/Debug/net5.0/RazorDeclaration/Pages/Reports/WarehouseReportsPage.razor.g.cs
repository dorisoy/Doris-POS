// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Reports
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Connection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Apimodel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.PdfReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/report/warehousereport")]
    public partial class WarehouseReportsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 270 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\Pages\Reports\WarehouseReportsPage.razor"
       
    decimal totalSales = 0;
    decimal totalPurchase = 0;
    decimal totalSalesReturn = 0;
    decimal totalPurchaseReturn = 0;
    private bool dense = true;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private string searchString2 = "";
    bool open;
    Anchor anchor;
    List<SalesMasterView> listModel = new List<SalesMasterView>();
    List<SalesReturnMasterView> listSalesReturn = new List<SalesReturnMasterView>();
    List<PurchaseMasterView> listPurchaseInvoice = new List<PurchaseMasterView>();
    List<PurchaseReturnMasterView> listPurchaseReturn = new List<PurchaseReturnMasterView>();
    List<Warehouse> listWarehouse = new List<Warehouse>();
    int CustomerId = 0;
    int WarehouseId = 0;
    string Status = "All";
    string strMenu = "SalesReport";
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
        listWarehouse = _warehouse.GetAll();
        StateHasChanged();
    }
    private void ChangeWarehouse()
    {
        if(WarehouseId > 0)
        {
            var resultSlesPurchse = reportRepository.SalesTotalwarehouse(WarehouseId); //TotalSales
        totalSales = resultSlesPurchse.GrandTotal;
        //TotalPurchase
        var returnTotalPurchase = reportRepository.PurchaseTotalwarehouse(WarehouseId);
        totalPurchase = returnTotalPurchase.GrandTotal;

        //TotalSalesReturn
        var returnSalesReturn = reportRepository.SalesReturnTotalwarehouse(WarehouseId);
        totalSalesReturn = returnSalesReturn.GrandTotal;

        //TotalPurchaseReturn
        var returnPurchaseReturn = reportRepository.PurchaseReturnTotalwarehouse(WarehouseId);
        totalPurchaseReturn = returnPurchaseReturn.GrandTotal;
            listModel = _salesInvoice.SalesInvoiceViewWarehouse(WarehouseId);
            listSalesReturn = _salesReturnInvoice.SalesReturnInvoiceViewwarehouse(WarehouseId); // 1 is companyid
            listPurchaseInvoice = _purchaseInvoice.PurchaseInvoiceViewwarehouse(WarehouseId);
            listPurchaseReturn = _purchaseReturnInvoice.PurchaseReturnInvoiceViewwarehouse(WarehouseId); // 1 is companyid
            StateHasChanged();
        }
        else
        {
            var resultSlesPurchse = reportRepository.SalesTotalwarehouse(WarehouseId); //TotalSales
        totalSales = resultSlesPurchse.GrandTotal;
        //TotalPurchase
        var returnTotalPurchase = reportRepository.PurchaseTotalwarehouse(WarehouseId);
        totalPurchase = returnTotalPurchase.GrandTotal;

        //TotalSalesReturn
        var returnSalesReturn = reportRepository.SalesReturnTotalwarehouse(WarehouseId);
        totalSalesReturn = returnSalesReturn.GrandTotal;

        //TotalPurchaseReturn
        var returnPurchaseReturn = reportRepository.PurchaseReturnTotalwarehouse(WarehouseId);
        totalPurchaseReturn = returnPurchaseReturn.GrandTotal;
            listModel = _salesInvoice.SalesInvoiceViewWarehouse(WarehouseId);
            listSalesReturn = _salesReturnInvoice.SalesReturnInvoiceViewwarehouse(WarehouseId); // 1 is companyid
            listPurchaseInvoice = _purchaseInvoice.PurchaseInvoiceViewwarehouse(WarehouseId);
            listPurchaseReturn = _purchaseReturnInvoice.PurchaseReturnInvoiceViewwarehouse(WarehouseId); // 1 is companyid
        }
    }
    private bool Search(SalesMasterView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.VoucherNo.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    private bool SearchSalesReturn(SalesReturnMasterView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.VoucherNo.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    private bool SearchPurchaseInvoice(PurchaseMasterView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.VoucherNo.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    private bool SearchPurchaseReturn(PurchaseReturnMasterView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.VoucherNo.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWarehouse _warehouse { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger _customer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPurchaseReturnInvoice _purchaseReturnInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPurchaseInvoice _purchaseInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesReturnInvoice _salesReturnInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesInvoice _salesInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryReport reportRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRole _role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
