// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.SupplierPyment
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
#line 4 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\SupplierPyment\Supplierpayedit.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\SupplierPyment\Supplierpayedit.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\SupplierPyment\Supplierpayedit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\SupplierPyment\Supplierpayedit.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/supplierpayedit/{id}")]
    public partial class Supplierpayedit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 218 "D:\dotnet5Blazor\BusinessAccount\BusinessAccount\Dreamer\Dreamer\Pages\Inventory\SupplierPyment\Supplierpayedit.razor"
       
    [Parameter]
    public string id { get; set; }
    InventorySetting setting = new InventorySetting();
    PaymentMaster mster = new PaymentMaster();
    List<AccountLedger> subledger = new List<AccountLedger>();
    List<AccountLedger> listCash = new List<AccountLedger>();
    List<AccountLedger> listBank = new List<AccountLedger>();
    List<PurchaseMasterView> articleModel = new List<PurchaseMasterView>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long FinancialYearId;
    long UserId;
    string Email;
    long decPaymenVoucherId = 4;
    string strNepaliDate;
    string strDate;
    decimal decTotal = 0;
    decimal PreviousDue = 0;
    bool chkPay = false;
    bool chkFullPayment = false;

    string FromNepali;
    string ToNepali;
    string FromDateEng;
    string ToDateEng;
    string fromD;
    string toD;
    Privilege privi = new Privilege();
    string strMenu = "PaymentOut";
    bool strAdd = true;
    bool strEdit = true;
    bool strDelete = true;
    bool strShow = true;
    string myMarkup;


    private string[] MonthNameFill = {
                                         "Baishak"
                                        ,"Jestha"
                                        ,"Aashar"
                                        ,"Sharwan"
                                        ,"Bhadra"
                                        ,"Aashoj"
                                        ,"Kartik"
                                        ,"Mansir"
                                        ,"Poush"
                                        ,"Magh"
                                        ,"Falgun"
                                        ,"Chaitra"
                                     };

    //private bool Ismousein = true;
    private string foday;
    DateTime focusday = DateTime.Today;
    private int years, months;
    private string yearmonth = string.Empty;
    string strMonth;
    string strYer;
    int intMonth;
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
        setting = settingRepository.EditInventorySetting(decPaymenVoucherId);

        LoadData();
        StateHasChanged();
    }

    protected void LoadData()
    {
        ////var strSerialNo = purchaseRepository.GetPaymentVoucherNo(CompanyId, FinancialYearId);
        //mster.VoucherNo = strSerialNo;
        //strNepaliDate = DreamerDateConveter.convertToBS(DateTime.Now);
        //mster.NepaliDate = strNepaliDate;
        //strDate = DreamerDateConveter.convertToAD(strNepaliDate).ToShortDateString();
        //mster.Date = Convert.ToDateTime(strDate);

        //foday = DreamerDateConveter.convertToBS(Convert.ToDateTime(strDate));
        //years = Convert.ToInt32(foday.Split('/')[0]);
        //months = Convert.ToInt32(foday.Split('/')[1]);
        //strYer = years.ToString();
        //strMonth = MonthNameFill[months - 1];
        mster.CreditAmount = 0;
        mster.BankAmount = 0;
        mster.CashAmount = 0;
        PreviousDue = 0;
        mster.CashId = 1;
        mster.Narration = string.Empty;
        mster = _pyment.EditPymentSupplier(Convert.ToInt64(id));
        subledger = purchaseRepository.GetAccountLedger(CompanyId);
        listCash = purchaseRepository.GetCashFill();
        listBank = purchaseRepository.GetBankFill();
        LedgerClicked();
    }


    protected void Save()
    {
        if (strEdit == true)
        {
            if (mster.LedgerId == 0)
            {
                Toaster.Add("Choose Supplier", MatToastType.Info, "PaymentSupplier", null);
            }
            else if (mster.VoucherNo == string.Empty)
            {
                Toaster.Add("Type voucher", MatToastType.Info, "PaymentSupplier", null);
            }
            else if (mster.NepaliDate == string.Empty)
            {
                Toaster.Add("Invalid Date", MatToastType.Info, "PaymentSupplier", null);
            }
            else if (mster.Date == null)
            {
                Toaster.Add("Invalid Date", MatToastType.Info, "PaymentSupplier", null);
            }
            else
            {
                if (mster.Optional == "Payment")
                {
                    var isCheck = _pyment.CheckPymentSupplierId(mster.VoucherNo, CompanyId, FinancialYearId, decPaymenVoucherId);
                    if (isCheck == mster.PaymentMasterId || isCheck == 0)
                    {
                        SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                        sqlcon.Open();
                        SqlTransaction sql = sqlcon.BeginTransaction();
                        decimal decCredit = mster.CashAmount + mster.BankAmount;

                        var paraLedger = new DynamicParameters();
                        paraLedger.Add("@PaymentMasterId", mster.PaymentMasterId);
                        paraLedger.Add("@SerialNo", mster.SerialNo);
                        paraLedger.Add("@Date", mster.Date);
                        paraLedger.Add("@NepaliDate", mster.NepaliDate);
                        paraLedger.Add("@LedgerId", mster.LedgerId);
                        paraLedger.Add("@VoucherNo", mster.VoucherNo);
                        paraLedger.Add("@SuffixPrefixId", 0);
                        paraLedger.Add("@financialYearId", FinancialYearId);
                        paraLedger.Add("@InvoiceNo", mster.VoucherNo);
                        paraLedger.Add("@VoucherTypeId", decPaymenVoucherId);
                        paraLedger.Add("@CompanyId", CompanyId);
                        paraLedger.Add("@DetailsId", 0);
                        paraLedger.Add("@CashAmount", mster.CashAmount);
                        paraLedger.Add("@BankAmount", mster.BankAmount);
                        paraLedger.Add("@CreditAmount", mster.CreditAmount);
                        paraLedger.Add("@TotalAmount", decCredit);
                        paraLedger.Add("@Narration", mster.Narration);
                        paraLedger.Add("@UserId", Email);
                        paraLedger.Add("@CashId", mster.CashId);
                        paraLedger.Add("@BankId", mster.BankId);
                        paraLedger.Add("@Optional", "Payment");
                        paraLedger.Add("@ModifyDate", DateTime.Now);
                        paraLedger.Add("@ModifyBy", UserId);
                        sqlcon.Execute("PaymentMasterUpdate", paraLedger, sql, 0, CommandType.StoredProcedure);
                        //LedgerPosting
                        //Delete
                        var paraScDelete = new DynamicParameters();
                        paraScDelete.Add("@VoucherNo", mster.VoucherNo);
                        paraScDelete.Add("@YearId", mster.FinancialYearId);
                        paraScDelete.Add("@CompanyId", mster.CompanyId);
                        paraScDelete.Add("@VoucherTypeId", decPaymenVoucherId);
                        var valueScDelete = sqlcon.Query<long>("DELETE FROM LedgerPosting where VoucherNo=@VoucherNo AND YearId=@YearId AND CompanyId=@CompanyId AND VoucherTypeId=@VoucherTypeId", paraScDelete, sql, true, 0, commandType: CommandType.Text);

                        //Supplier
                        decimal decSupplierAmount = mster.BankAmount + mster.CashAmount;
                        if (decSupplierAmount > 0)
                        {
                            var paraSc = new DynamicParameters();
                            paraSc.Add("@Date", mster.Date);
                            paraSc.Add("@NepaliDate", mster.NepaliDate);
                            paraSc.Add("@LedgerId", mster.LedgerId);
                            paraSc.Add("@Debit", decSupplierAmount);
                            paraSc.Add("@Credit", 0);
                            paraSc.Add("@VoucherNo", mster.VoucherNo);
                            paraSc.Add("@DetailsId", mster.PaymentMasterId);
                            paraSc.Add("@YearId", FinancialYearId);
                            paraSc.Add("@InvoiceNo", string.Empty);
                            paraSc.Add("@VoucherTypeId", decPaymenVoucherId);
                            paraSc.Add("@CompanyId", CompanyId);
                            paraSc.Add("@LongReference", mster.Narration);
                            paraSc.Add("@ReferenceN", mster.Narration);
                            paraSc.Add("@ChequeNo", string.Empty);
                            paraSc.Add("@ChequeDate", string.Empty);
                            paraSc.Add("@AddedDate", DateTime.Now);
                            var valueSc = sqlcon.Query<long>("LedgerPostingInsert", paraSc, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }

                        //Cash
                        if (mster.CashAmount > 0)
                        {
                            var paraCash = new DynamicParameters();
                            paraCash.Add("@Date", mster.Date);
                            paraCash.Add("@NepaliDate", mster.NepaliDate);
                            paraCash.Add("@LedgerId", mster.CashId);
                            paraCash.Add("@Debit", 0);
                            paraCash.Add("@Credit", mster.CashAmount);
                            paraCash.Add("@VoucherNo", mster.VoucherNo);
                            paraCash.Add("@DetailsId", mster.PaymentMasterId);
                            paraCash.Add("@YearId", FinancialYearId);
                            paraCash.Add("@InvoiceNo", string.Empty);
                            paraCash.Add("@VoucherTypeId", decPaymenVoucherId);
                            paraCash.Add("@CompanyId", CompanyId);
                            paraCash.Add("@LongReference", mster.Narration);
                            paraCash.Add("@ReferenceN", mster.Narration);
                            paraCash.Add("@ChequeNo", string.Empty);
                            paraCash.Add("@ChequeDate", string.Empty);
                            paraCash.Add("@AddedDate", DateTime.Now);
                            var valueCash = sqlcon.Query<long>("LedgerPostingInsert", paraCash, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }
                        //Bank
                        if (mster.BankAmount > 0)
                        {
                            var paraBank = new DynamicParameters();
                            paraBank.Add("@Date", mster.Date);
                            paraBank.Add("@NepaliDate", mster.NepaliDate);
                            paraBank.Add("@LedgerId", mster.BankId);
                            paraBank.Add("@Debit", 0);
                            paraBank.Add("@Credit", mster.BankAmount);
                            paraBank.Add("@VoucherNo", mster.VoucherNo);
                            paraBank.Add("@DetailsId", mster.PaymentMasterId);
                            paraBank.Add("@YearId", FinancialYearId);
                            paraBank.Add("@InvoiceNo", string.Empty);
                            paraBank.Add("@VoucherTypeId", decPaymenVoucherId);
                            paraBank.Add("@CompanyId", CompanyId);
                            paraBank.Add("@LongReference", mster.Narration);
                            paraBank.Add("@ReferenceN", mster.Narration);
                            paraBank.Add("@ChequeNo", string.Empty);
                            paraBank.Add("@ChequeDate", string.Empty);
                            paraBank.Add("@AddedDate", DateTime.Now);
                            var valueBank = sqlcon.Query<long>("LedgerPostingInsert", paraBank, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }
                        sql.Commit();
                        Toaster.Add("Successfully Saved", MatToastType.Info, "PaymentSupplier", null);
                        LoadData();
                        navManager.NavigateTo($"/inventory/suppliershow/{id}");
                    }
                    else
                    {
                        Toaster.Add("Voucher no already exists", MatToastType.Info, "PaymentSupplier", null);
                    }
                }
                else
                {
                    var isCheck = _pyment.CheckPymentSupplierId(mster.VoucherNo, CompanyId, FinancialYearId, decPaymenVoucherId);
                    if (isCheck == mster.PaymentMasterId || isCheck == 0)
                    {
                        SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                        sqlcon.Open();
                        SqlTransaction sql = sqlcon.BeginTransaction();
                        decimal decCredit = mster.CashAmount + mster.BankAmount;

                        var paraLedger = new DynamicParameters();
                        paraLedger.Add("@PaymentMasterId", mster.PaymentMasterId);
                        paraLedger.Add("@SerialNo", mster.SerialNo);
                        paraLedger.Add("@Date", mster.Date);
                        paraLedger.Add("@NepaliDate", mster.NepaliDate);
                        paraLedger.Add("@LedgerId", mster.LedgerId);
                        paraLedger.Add("@VoucherNo", mster.VoucherNo);
                        paraLedger.Add("@SuffixPrefixId", 0);
                        paraLedger.Add("@financialYearId", FinancialYearId);
                        paraLedger.Add("@InvoiceNo", mster.VoucherNo);
                        paraLedger.Add("@VoucherTypeId", decPaymenVoucherId);
                        paraLedger.Add("@CompanyId", CompanyId);
                        paraLedger.Add("@DetailsId", 0);
                        paraLedger.Add("@CashAmount", mster.CashAmount);
                        paraLedger.Add("@BankAmount", mster.BankAmount);
                        paraLedger.Add("@CreditAmount", mster.CreditAmount);
                        paraLedger.Add("@TotalAmount", decCredit);
                        paraLedger.Add("@Narration", mster.Narration);
                        paraLedger.Add("@UserId", Email);
                        paraLedger.Add("@CashId", mster.CashId);
                        paraLedger.Add("@BankId", mster.BankId);
                        paraLedger.Add("@Optional", "Return");
                        paraLedger.Add("@ModifyDate", DateTime.Now);
                        paraLedger.Add("@ModifyBy", UserId);
                        sqlcon.Execute("PaymentMasterUpdate", paraLedger, sql, 0, CommandType.StoredProcedure);
                        //LedgerPosting
                        //Delete
                        var paraScDelete = new DynamicParameters();
                        paraScDelete.Add("@VoucherNo", mster.VoucherNo);
                        paraScDelete.Add("@YearId", mster.FinancialYearId);
                        paraScDelete.Add("@CompanyId", mster.CompanyId);
                        paraScDelete.Add("@VoucherTypeId", decPaymenVoucherId);
                        var valueScDelete = sqlcon.Query<long>("DELETE FROM LedgerPosting where VoucherNo=@VoucherNo AND YearId=@YearId AND CompanyId=@CompanyId AND VoucherTypeId=@VoucherTypeId", paraScDelete, sql, true, 0, commandType: CommandType.Text);

                        //Supplier
                        decimal decSupplierAmount = mster.BankAmount + mster.CashAmount;
                        if (decSupplierAmount > 0)
                        {
                            var paraSc = new DynamicParameters();
                            paraSc.Add("@Date", mster.Date);
                            paraSc.Add("@NepaliDate", mster.NepaliDate);
                            paraSc.Add("@LedgerId", mster.LedgerId);
                            paraSc.Add("@Debit", 0);
                            paraSc.Add("@Credit", decSupplierAmount);
                            paraSc.Add("@VoucherNo", mster.VoucherNo);
                            paraSc.Add("@DetailsId", mster.PaymentMasterId);
                            paraSc.Add("@YearId", FinancialYearId);
                            paraSc.Add("@InvoiceNo", string.Empty);
                            paraSc.Add("@VoucherTypeId", decPaymenVoucherId);
                            paraSc.Add("@CompanyId", CompanyId);
                            paraSc.Add("@LongReference", mster.Narration);
                            paraSc.Add("@ReferenceN", mster.Narration);
                            paraSc.Add("@ChequeNo", string.Empty);
                            paraSc.Add("@ChequeDate", string.Empty);
                            paraSc.Add("@AddedDate", DateTime.Now);
                            var valueSc = sqlcon.Query<long>("LedgerPostingInsert", paraSc, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }

                        //Cash
                        if (mster.CashAmount > 0)
                        {
                            var paraCash = new DynamicParameters();
                            paraCash.Add("@Date", mster.Date);
                            paraCash.Add("@NepaliDate", mster.NepaliDate);
                            paraCash.Add("@LedgerId", mster.CashId);
                            paraCash.Add("@Debit", mster.CashAmount);
                            paraCash.Add("@Credit", 0);
                            paraCash.Add("@VoucherNo", mster.VoucherNo);
                            paraCash.Add("@DetailsId", mster.PaymentMasterId);
                            paraCash.Add("@YearId", FinancialYearId);
                            paraCash.Add("@InvoiceNo", string.Empty);
                            paraCash.Add("@VoucherTypeId", decPaymenVoucherId);
                            paraCash.Add("@CompanyId", CompanyId);
                            paraCash.Add("@LongReference", mster.Narration);
                            paraCash.Add("@ReferenceN", mster.Narration);
                            paraCash.Add("@ChequeNo", string.Empty);
                            paraCash.Add("@ChequeDate", string.Empty);
                            paraCash.Add("@AddedDate", DateTime.Now);
                            var valueCash = sqlcon.Query<long>("LedgerPostingInsert", paraCash, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }
                        //Bank
                        if (mster.BankAmount > 0)
                        {
                            var paraBank = new DynamicParameters();
                            paraBank.Add("@Date", mster.Date);
                            paraBank.Add("@NepaliDate", mster.NepaliDate);
                            paraBank.Add("@LedgerId", mster.BankId);
                            paraBank.Add("@Debit", mster.BankAmount);
                            paraBank.Add("@Credit", 0);
                            paraBank.Add("@VoucherNo", mster.VoucherNo);
                            paraBank.Add("@DetailsId", mster.PaymentMasterId);
                            paraBank.Add("@YearId", FinancialYearId);
                            paraBank.Add("@InvoiceNo", string.Empty);
                            paraBank.Add("@VoucherTypeId", decPaymenVoucherId);
                            paraBank.Add("@CompanyId", CompanyId);
                            paraBank.Add("@LongReference", mster.Narration);
                            paraBank.Add("@ReferenceN", mster.Narration);
                            paraBank.Add("@ChequeNo", string.Empty);
                            paraBank.Add("@ChequeDate", string.Empty);
                            paraBank.Add("@AddedDate", DateTime.Now);
                            var valueBank = sqlcon.Query<long>("LedgerPostingInsert", paraBank, sql, true, 0, commandType: CommandType.StoredProcedure);
                        }
                        sql.Commit();
                        Toaster.Add("Successfully Saved", MatToastType.Info, "PaymentSupplier", null);
                        //LoadData();
                        navManager.NavigateTo($"/inventory/suppliershow/{id}");
                    }
                    else
                    {
                        Toaster.Add("Voucher no already exists", MatToastType.Info, "PaymentSupplier", null);
                    }
                }
            }
        }
        else
        {
            Toaster.Add("You dont have to privilege.", MatToastType.Success, "dashboard", null);
            navManager.NavigateTo("dashboard");
        }
    }
    protected void LedgerClicked()
    {
        decimal decTotalDue = 0;

        if (mster.LedgerId > 0)
        {
            var view = purchaseRepository.GetPreviousDuesBalancepurchase(mster.LedgerId);
            articleModel = purchaseRepository.GetSupplierPaymentList(mster.LedgerId);
            foreach (var item in articleModel)
            {
                decTotalDue = decTotalDue + item.TotalDue;
                decTotal = decTotal + item.GrandTotal;
            }
            PreviousDue = view.DueBalance;
            //PreviousDue = decTotalDue;
        }
        else
        {
            articleModel.Clear();
            PreviousDue = 0;
            mster.CashAmount = 0;
            mster.BankAmount = 0;
            mster.CreditAmount = 0;
        }
        StateHasChanged();
    }
    protected void payinfull(decimal decTotalDue)
    {
        decimal decDueAmount = 0;
        decimal decPay = 0;
        decimal decPayTotal = 0;

        foreach (var item in articleModel)
        {
            if (chkFullPayment == true)
            {
                item.PaymentAmount = decTotalDue;
                decDueAmount = decDueAmount + item.TotalDue;
                decPayTotal = decPayTotal + item.PaymentAmount;
                decPay = item.TotalDue;
                //item.PaymentAmount = decPay;
            }
            else
            {
                item.PaymentAmount = 0;
                decDueAmount = 0;
                decPayTotal = 0;
                decPay = 0;
            }
        }
        mster.CashAmount = decPayTotal;
        StateHasChanged();
    }
    protected void checkPay()
    {
        decimal decDueAmount = 0;
        decimal decPay = 0;
        decimal decPayTotal = 0;

        foreach (var item in articleModel)
        {
            if (chkPay == false)
            {
                decDueAmount = decDueAmount + item.TotalDue;
                decPayTotal = decPayTotal + item.PaymentAmount;
                decPay = item.TotalDue;
                item.PaymentAmount = decPay;
            }
            else
            {
                decDueAmount = 0;
                decPayTotal = 0;
                item.PaymentAmount = 0;
            }
        }
        mster.CashAmount = decPayTotal;
        Calculate();
        StateHasChanged();
    }
    void Calculate()
    {
        decimal totalAmount = PreviousDue;
        decimal CashAmount = mster.CashAmount;
        decimal BankAmount = mster.BankAmount;
        decimal creditAmount = mster.CreditAmount;
        decimal decGrandTotal = CashAmount + BankAmount;
        if (totalAmount >= decGrandTotal)
        {
            decimal decTotl = totalAmount - decGrandTotal;
            mster.CreditAmount = decTotl;
        }
        else
        {
            mster.CreditAmount = 0;
            mster.CashAmount = 0;
            mster.BankAmount = 0;
        }
    }
    async Task PayCalculate()
    {
        decimal decDueAmount = 0;
        decimal decPay = 0;
        decimal decPayTotal = 0;
        foreach (var item in articleModel)
        {
            decDueAmount = decDueAmount + item.TotalDue;
            decPayTotal = decPayTotal + item.PaymentAmount;
            //decPay = item.TotalDue;
            //item.PaymentAmount = decPay;
        }
        mster.CashAmount = decPayTotal;
        Calculate();
    }
    private async Task ChangeFrom()
    {
        try
        {
            strNepaliDate = mster.NepaliDate;
            if (strNepaliDate == string.Empty)
            {
                strNepaliDate = DreamerDateConveter.convertToBS(DateTime.Now);
                mster.NepaliDate = strNepaliDate;
                strDate = DreamerDateConveter.convertToAD(strNepaliDate).ToShortDateString();
                mster.Date = Convert.ToDateTime(strDate);

                foday = DreamerDateConveter.convertToBS(Convert.ToDateTime(strDate));
                years = Convert.ToInt32(foday.Split('/')[0]);
                months = Convert.ToInt32(foday.Split('/')[1]);
                strYer = years.ToString();
                strMonth = MonthNameFill[months - 1];
            }
            else
            {
                strDate = DreamerDateConveter.convertToAD(strNepaliDate).ToShortDateString();
                mster.Date = Convert.ToDateTime(strDate);

                foday = DreamerDateConveter.convertToBS(Convert.ToDateTime(strDate));
                years = Convert.ToInt32(foday.Split('/')[0]);
                months = Convert.ToInt32(foday.Split('/')[1]);
                strYer = years.ToString();
                strMonth = MonthNameFill[months - 1];
            }
        }
        catch (Exception ex)
        {
            if (strDate == string.Empty)
            {
                Toaster.Add("Invalid From Date", MatToastType.Info, "Invalid", null);
            }
            mster.Date = (DateTime?)null;
        }
    }
    void Cancel()
    {
        navManager.NavigateTo("inventory/supplierpaylist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PurchaseInvoiceRepository purchaseRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PymentSupplierRepository _pyment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TapSizeRepository settingRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountLedgerRepository ledgerRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountgroupRepository groupRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
