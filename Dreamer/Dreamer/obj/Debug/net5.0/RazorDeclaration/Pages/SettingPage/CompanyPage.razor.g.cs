// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.SettingPage
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
#nullable restore
#line 5 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\Pages\SettingPage\CompanyPage.razor"
using Dreamer.Services.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting/companylist")]
    public partial class CompanyPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\Pages\SettingPage\CompanyPage.razor"
       
    Company master = new Company();
    VoucherType voucherType = new VoucherType();
    List<Currency> listCurrency = new List<Currency>();
    List<Warehouse> listWarehouse = new List<Warehouse>();
    List<VoucherType> listVoucherype = new List<VoucherType>();
    List<AccountLedgerView> listCustomer = new List<AccountLedgerView>();
    string strMenu = "Company";
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
        LoadCompany();
        StateHasChanged();
    }
    private void LoadCompany()
    {
        master = _company.Edit(1); //1 is companyid

        listCurrency = _currency.GetAll();
        listWarehouse = _warehouse.GetAll();
        listVoucherype = _voucherType.GetAll();
        listCustomer = _accountLedger.ViewAllCustomer(1);
        StateHasChanged();
    }
    private async void SaveCompany()
    {
        if(master.CurrencyId == 0)
        {
            Snackbar.Add("Choose Default Currency.", Severity.Info);
        }
        else if(master.WarehouseId == 0)
        {
            Snackbar.Add("Choose Default Warehouse.", Severity.Info);
        }
        else
        {
            master.ModifyDate = DateTime.UtcNow;
            master.CountryId = 1;
            master.FinancialYearId = 1;
            master.BusinessType = "Shop";
            _company.Update(master);
                Snackbar.Add("Updated Successfully.", Severity.Success);
                LoadCompany();
        }
    }
    async Task OnFileChange(InputFileChangeEventArgs e)
	{
		var format = "image/png";
		var resizedImage = await e.File.RequestImageFileAsync(format, 300, 300);
		var buffer = new byte[resizedImage.Size];
		await resizedImage.OpenReadStream().ReadAsync(buffer);
		var imageData = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
		if (imageData == null)
		{
			master.Logo = string.Empty;
		}
		else
		{
			master.Logo = imageData;
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger _accountLedger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICurrency _currency { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWarehouse _warehouse { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVoucherType _voucherType { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany _company { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRole _role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
