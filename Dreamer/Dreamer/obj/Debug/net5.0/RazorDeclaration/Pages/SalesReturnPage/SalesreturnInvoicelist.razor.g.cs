// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.SalesReturnPage
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
#line 10 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesreturnInvoicelist.razor"
using NPOI.SS.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesreturnInvoicelist.razor"
using NPOI.XSSF.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesreturnInvoicelist.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales/salesreturninvoicelist")]
    public partial class SalesreturnInvoicelist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "D:\商业项目\Blazor-Pos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesreturnInvoicelist.razor"
       
    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }
    private bool dense = true;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private string searchString2 = "";
    List<SalesReturnMasterView> listModel = new List<SalesReturnMasterView>();
    string strMenu = "Sales Return";
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
        LoadData();
        StateHasChanged();
    }
    private async void LoadData()
    {
        listModel = _salesInvoice.SalesReturnInvoiceView(1); // 1 is companyid
    }
    async Task Delete(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirmed)
        {
            SalesReturnMaster view = new SalesReturnMaster();
            view = _salesInvoice.Edit(id);
            bool isSave = false;
            isSave = _salesInvoice.Delete(id , view.VoucherNo, 1 , 1);
            if (isSave == true)
            {
                Snackbar.Add("Delete Successfully.", Severity.Success);
                LoadData();
            }
            else
            {
                Snackbar.Add("Cannot be delete. already in used.", Severity.Info);
            }
        }
    }
    private bool Search(SalesReturnMasterView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.VoucherNo.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    protected async Task GenerateExcel()
    {
        IWorkbook workbook = new XSSFWorkbook();
        var dataFormat = workbook.CreateDataFormat();
        var dataStyle = workbook.CreateCellStyle();
        dataStyle.DataFormat = dataFormat.GetFormat("MM/yy/dddd HH:mm:ss");
        ISheet worksheet = workbook.CreateSheet("Sheet1");



        int rowNumber1 = 0;
        IRow row1 = worksheet.CreateRow(rowNumber1++);
        //TbleHeder
        ICell cell1 = row1.CreateCell(3);
        cell1.SetCellValue("SalesInvoice");

        int rowNumber = 1;
        IRow row = worksheet.CreateRow(rowNumber++);
        //TbleHeder
        ICell cell = row.CreateCell(0);
        cell.SetCellValue("Voucher No");

        cell = row.CreateCell(1);
        cell.SetCellValue("Date");

        cell = row.CreateCell(2);
        cell.SetCellValue("Customer Name");

        cell = row.CreateCell(3);
        cell.SetCellValue("Voucher Type");

        cell = row.CreateCell(4);
        cell.SetCellValue("Amount");

        cell = row.CreateCell(5);
        cell.SetCellValue("Balance Due");

        cell = row.CreateCell(6);
        cell.SetCellValue("Status");


        //Tble Body
        foreach (var objDue in listModel)
    {
            row = worksheet.CreateRow(rowNumber++);

            cell = row.CreateCell(0);
            cell.SetCellValue(objDue.VoucherNo);

            cell = row.CreateCell(1);
            cell.SetCellValue(objDue.Date.ToString());

            cell = row.CreateCell(2);
            cell.SetCellValue(objDue.LedgerName);

            cell = row.CreateCell(3);
            cell.SetCellValue(objDue.VoucherTypeName);

            cell = row.CreateCell(4);
            cell.SetCellValue(objDue.GrandTotal.ToString());

            cell = row.CreateCell(5);
            cell.SetCellValue(objDue.BalanceDue.ToString());

            cell = row.CreateCell(6);
            cell.SetCellValue(objDue.Status.ToString());

        }
        MemoryStream ms = new MemoryStream();
        workbook.Write(ms);
        byte[] bytes = ms.ToArray();
        ms.Close();

        await JsRuntime.SaveAsFileAsync("SalesReturnInvoice", bytes, "application/vnd.ms-excel");
    }
    private void GeneratePdf()
    {
        PdfSalesReturn pdfExp = new PdfSalesReturn();
        JsRuntime.InvokeAsync<SalesReturnMasterView>(
            "saveAsFile",
            "SalesReturn.pdf",
            Convert.ToBase64String(pdfExp.Report(listModel))
        );
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVoucherType _voucherType { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesReturnInvoice _salesInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRole _role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
