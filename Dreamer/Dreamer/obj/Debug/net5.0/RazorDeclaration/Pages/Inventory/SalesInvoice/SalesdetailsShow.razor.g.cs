// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.SalesInvoice
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
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\SalesInvoice\SalesdetailsShow.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\SalesInvoice\SalesdetailsShow.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\SalesInvoice\SalesdetailsShow.razor"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\SalesInvoice\SalesdetailsShow.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\SalesInvoice\SalesdetailsShow.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\SalesInvoice\SalesdetailsShow.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/salesinvoicedetails/{id}")]
    public partial class SalesdetailsShow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 438 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\SalesInvoice\SalesdetailsShow.razor"
       
    [Parameter]
    public string id { get; set; }
    InventorySetting setting = new InventorySetting();
    InventorySetting settingPurchase = new InventorySetting();
    SalesMasterView mster = new SalesMasterView();
    List<ProductView> TodoList = new List<ProductView>();
    ReceiptMaster payment = new ReceiptMaster();
    List<AccountLedger> listCash = new List<AccountLedger>();
    List<AccountLedger> listBank = new List<AccountLedger>();
    List<ReceiptMaster> listPayment = new List<ReceiptMaster>();
    SmsHistory sms = new SmsHistory();
    //GetSessionInfo
    string companyName;
    string address;
    string phone;
    string billtype;
    long CompanyId;
    long RoleId;
    long FinancialYearId;
    long UserId;
    string Email;
    bool showPay = false;
    bool showModal = false;
    long decVouchertypeIdSalesInvoice = 19;
    long decVoucherReceiveId = 5;
    string strSerialNo;
    string strPrefix;
    string strSuffix;
    string strNepaliDate;
    string strDate;
    decimal decTotal = 0;
    decimal PreviousDue = 0;
    decimal paymentMade = 0;
    decimal balanceDue = 0;
    string from = "Demo";
    string token = "v2_VFPPjPYpr0FenbRlluKY9yo3KTZ.DDRj (t)";
    string to = "9869414235";
    string text;
    protected async override void OnInitialized()
    {

        Email = await sessionStorage.GetItemAsync<string>("Email");
        CompanyId = await sessionStorage.GetItemAsync<long>("CompanyId");
        RoleId = await sessionStorage.GetItemAsync<long>("RoleId");
        FinancialYearId = await sessionStorage.GetItemAsync<long>("FinancialYearId");
        UserId = await sessionStorage.GetItemAsync<long>("UserId");
        settingPurchase = settingRepository.EditInventorySetting(decVouchertypeIdSalesInvoice);

        var resultCompany = icompany.ViewCompany(CompanyId);
        companyName = resultCompany.CompanyName;
        address = resultCompany.Address;
        phone = resultCompany.Phone;
        billtype = "Sales Invoice";
        LoadData();
        StateHasChanged();
    }
    private void LoadData()
    {
        mster = salesRepository.SalesMasterPrint(Convert.ToInt64(id));
        TodoList = salesRepository.SalesInvoicePrint(Convert.ToInt64(id));
        LoadPaymentShow();
    }
    void ModalShow()
    {
        showModal = true;
    }
    void ModalShowPay()
    {
        strNepaliDate = DreamerDateConveter.convertToBS(DateTime.Now);
        payment.NepaliDate = strNepaliDate;
        strDate = DreamerDateConveter.convertToAD(strNepaliDate).ToShortDateString();
        payment.Date = Convert.ToDateTime(strDate);
        setting = settingRepository.EditInventorySetting(decVoucherReceiveId);
        strPrefix = setting.Prefix;
        strSuffix = setting.Suffix;
        strSerialNo = _pyment.GetReceiveVoucherNo(CompanyId, FinancialYearId, decVoucherReceiveId);
        payment.VoucherNo = strPrefix + strSerialNo + strSuffix;
        payment.SerialNo = strSerialNo;
        listCash = purchaseRepository.GetCashFill();
        listBank = purchaseRepository.GetBankFill();
        payment.CashId = 1;
        payment.BankId = 13;
        payment.TotalAmount = Math.Round(mster.GrandTotal - paymentMade, PublicVariables._inNoOfDecimalPlaces);
        payment.CashAmount = 0;
        payment.BankAmount = 0;
        payment.CreditAmount = 0;
        showPay = true;
    }
    void ModalCancelPay()
    {
        showPay = false;
    }
    void OnPay()
    {
        if (mster.LedgerId == 0)
        {
            Toaster.Add("Choose Supplier", MatToastType.Info, "Receive Voucher", null);
        }
        else if (payment.VoucherNo == string.Empty)
        {
            Toaster.Add("Type voucher", MatToastType.Info, "Receive Voucher", null);
        }
        else
        {
            var isCheck = _pyment.CheckReceiveCustomer(mster.VoucherNo, CompanyId, FinancialYearId, decVoucherReceiveId);
            if (isCheck == true)
            {
                Toaster.Add("Voucher no already exists", MatToastType.Info, "Receive Voucher", null);
            }
            else
            {
                //decimal TotalCashBank = mster.CashAmount + mster.BankAmount;
                //if (TotalCashBank == mster.Amountused)
                //{
                SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                sqlcon.Open();
                SqlTransaction sql = sqlcon.BeginTransaction();
                decimal decCredit = payment.CashAmount + payment.BankAmount;

                var paraLedger = new DynamicParameters();
                paraLedger.Add("@SerialNo", strSerialNo);
                paraLedger.Add("@Date", payment.Date);
                paraLedger.Add("@NepaliDate", payment.NepaliDate);
                paraLedger.Add("@LedgerId", mster.LedgerId);
                paraLedger.Add("@VoucherNo", payment.VoucherNo);
                paraLedger.Add("@SuffixPrefixId", 0);
                paraLedger.Add("@financialYearId", FinancialYearId);
                paraLedger.Add("@InvoiceNo", payment.VoucherNo);
                paraLedger.Add("@VoucherTypeId", decVoucherReceiveId);
                paraLedger.Add("@CompanyId", CompanyId);
                paraLedger.Add("@DetailsId", mster.SalesMasterId);
                paraLedger.Add("@CashAmount", payment.CashAmount);
                paraLedger.Add("@BankAmount", payment.BankAmount);
                paraLedger.Add("@CreditAmount", payment.CreditAmount);
                paraLedger.Add("@TotalAmount", decCredit);
                paraLedger.Add("@Narration", payment.Narration);
                paraLedger.Add("@UserId", Email);
                paraLedger.Add("@CashId", payment.CashId);
                paraLedger.Add("@BankId", payment.BankId);
                paraLedger.Add("@Optional", "Receive");
                paraLedger.Add("@AddedDate", DateTime.Now);
                paraLedger.Add("@AddedBy", UserId);
                paraLedger.Add("@MemOUT", dbType: DbType.Int64, direction: ParameterDirection.Output);
                sqlcon.Execute("ReceiptMasterAdd", paraLedger, sql, 0, CommandType.StoredProcedure);
                long MemID = paraLedger.Get<long>("MemOUT");
                //UpdatePurchaseMaster
                decimal decTotalDuess = mster.GrandTotal;
                decimal decPaymentAmount = payment.CashAmount + payment.BankAmount;
                var para = new DynamicParameters();
                para.Add("@SalesMasterId", mster.SalesMasterId);
                para.Add("@BalanceDue", payment.CreditAmount);
                para.Add("@CashAmount", payment.CashAmount);
                para.Add("@BankAmount", payment.BankAmount);
                para.Add("@CreditAmount", payment.CreditAmount);
                if (decTotalDuess == decPaymentAmount)
                {
                    para.Add("@Status", "Paid");
                }
                else if (decTotalDuess > decPaymentAmount)
                {
                    para.Add("@Status", "PartialPaid");
                }
                else
                {
                    para.Add("@Status", "Draft");
                }
                sqlcon.Execute("UPDATE SalesMaster SET BalanceDue=@BalanceDue,Status=@Status,CashAmount=@CashAmount,CreditAmount=@CreditAmount,BankAmount=@BankAmount where SalesMasterId=@SalesMasterId", para, sql, 0, CommandType.Text);

                //LedgerPosting
                //Supplier
                decimal decSupplierAmount = payment.BankAmount + payment.CashAmount;
                if (decSupplierAmount > 0)
                {
                    var paraSc = new DynamicParameters();
                    paraSc.Add("@Date", payment.Date);
                    paraSc.Add("@NepaliDate", payment.NepaliDate);
                    paraSc.Add("@LedgerId", mster.LedgerId);
                    paraSc.Add("@Debit", 0);
                    paraSc.Add("@Credit", decSupplierAmount);
                    paraSc.Add("@VoucherNo", payment.VoucherNo);
                    paraSc.Add("@DetailsId", mster.SalesMasterId);
                    paraSc.Add("@YearId", FinancialYearId);
                    paraSc.Add("@InvoiceNo", string.Empty);
                    paraSc.Add("@VoucherTypeId", decVoucherReceiveId);
                    paraSc.Add("@CompanyId", CompanyId);
                    paraSc.Add("@LongReference", payment.Narration);
                    paraSc.Add("@ReferenceN", payment.Narration);
                    paraSc.Add("@ChequeNo", string.Empty);
                    paraSc.Add("@ChequeDate", string.Empty);
                    paraSc.Add("@AddedDate", DateTime.Now);
                    var valueSc = sqlcon.Query<long>("LedgerPostingInsert", paraSc, sql, true, 0, commandType: CommandType.StoredProcedure);
                }

                //Cash
                if (payment.CashAmount > 0)
                {
                    var paraCash = new DynamicParameters();
                    paraCash.Add("@Date", payment.Date);
                    paraCash.Add("@NepaliDate", payment.NepaliDate);
                    paraCash.Add("@LedgerId", payment.CashId);
                    paraCash.Add("@Debit", payment.CashAmount);
                    paraCash.Add("@Credit", 0);
                    paraCash.Add("@VoucherNo", payment.VoucherNo);
                    paraCash.Add("@DetailsId", mster.SalesMasterId);
                    paraCash.Add("@YearId", FinancialYearId);
                    paraCash.Add("@InvoiceNo", string.Empty);
                    paraCash.Add("@VoucherTypeId", decVoucherReceiveId);
                    paraCash.Add("@CompanyId", CompanyId);
                    paraCash.Add("@LongReference", payment.Narration);
                    paraCash.Add("@ReferenceN", payment.Narration);
                    paraCash.Add("@ChequeNo", string.Empty);
                    paraCash.Add("@ChequeDate", string.Empty);
                    paraCash.Add("@AddedDate", DateTime.Now);
                    var valueCash = sqlcon.Query<long>("LedgerPostingInsert", paraCash, sql, true, 0, commandType: CommandType.StoredProcedure);
                }
                //Bank
                if (payment.BankAmount > 0)
                {
                    var paraBank = new DynamicParameters();
                    paraBank.Add("@Date", payment.Date);
                    paraBank.Add("@NepaliDate", payment.NepaliDate);
                    paraBank.Add("@LedgerId", payment.BankId);
                    paraBank.Add("@Debit", payment.BankAmount);
                    paraBank.Add("@Credit", 0);
                    paraBank.Add("@VoucherNo", payment.VoucherNo);
                    paraBank.Add("@DetailsId", mster.SalesMasterId);
                    paraBank.Add("@YearId", FinancialYearId);
                    paraBank.Add("@InvoiceNo", string.Empty);
                    paraBank.Add("@VoucherTypeId", decVoucherReceiveId);
                    paraBank.Add("@CompanyId", CompanyId);
                    paraBank.Add("@LongReference", mster.Narration);
                    paraBank.Add("@ReferenceN", mster.Narration);
                    paraBank.Add("@ChequeNo", string.Empty);
                    paraBank.Add("@ChequeDate", string.Empty);
                    paraBank.Add("@AddedDate", DateTime.Now);
                    var valueBank = sqlcon.Query<long>("LedgerPostingInsert", paraBank, sql, true, 0, commandType: CommandType.StoredProcedure);
                }
                sql.Commit();
                Toaster.Add("Successfully Saved", MatToastType.Info, "Receive Voucher", null);
                LoadData();
                showPay = false;
            }
        }
    }
    void LoadPaymentShow()
    {
        SalesMaster paymentmaster = new SalesMaster();
        decimal decTotalAmount = 0;
        listPayment = _pyment.GetReceiptMasterView(mster.SalesMasterId);
        foreach (var item in listPayment)
        {
            decTotalAmount = decTotalAmount + item.CashAmount;
        }
        paymentMade = decTotalAmount;
        balanceDue = mster.GrandTotal - paymentMade;
    }
    void ModalCancel()
    {
        showModal = false;
    }
    void OnSms()
    {
        CallSms();
    }
    string CallSms()
    {
        AccountLedger ledger = new AccountLedger();
        long longLedgerId = mster.LedgerId;
        ledger = ledgerRepository.EditAccountLedger(Convert.ToInt64(id));
        using (var client = new WebClient())
        {
            var values = new NameValueCollection();
            values["from"] = from;
            values["token"] = token;
            values["to"] = "9848056179";
            values["text"] = sms.Message;
            var response = client.UploadValues("http://api.sparrowsms.com/v2/sms/", "Post", values);
            client.UseDefaultCredentials = true;
            client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            var responseString = Encoding.Default.GetString(response);
            return responseString;
        }
    }
    void Calculate()
    {
        decimal totalAmount = payment.TotalAmount;
        decimal CashAmount = payment.CashAmount;
        decimal BankAmount = payment.BankAmount;
        decimal creditAmount = payment.CreditAmount;
        decimal decGrandTotal = CashAmount + BankAmount;
        if (totalAmount >= decGrandTotal)
        {
            decimal decTotl = Math.Round(totalAmount - decGrandTotal, 2);
            payment.CreditAmount = decTotl;
        }
        else
        {
            payment.CreditAmount = 0;
            payment.CashAmount = 0;
            payment.BankAmount = 0;
        }
    }
    private async Task ChangeFrom()
    {
        try
        {
            strNepaliDate = payment.NepaliDate;
            if (strNepaliDate == string.Empty)
            {
                strNepaliDate = DreamerDateConveter.convertToBS(DateTime.Now);
                mster.NepaliDate = strNepaliDate;
                strDate = DreamerDateConveter.convertToAD(strNepaliDate).ToShortDateString();
                payment.Date = Convert.ToDateTime(strDate);

            }
            else
            {
                strDate = DreamerDateConveter.convertToAD(strNepaliDate).ToShortDateString();
                payment.Date = Convert.ToDateTime(strDate);

            }
        }
        catch (Exception ex)
        {
            if (strDate == string.Empty)
            {
                Toaster.Add("Invalid From Date", MatToastType.Info, "Invalid", null);
            }
        }
    }
    private void Print()
    {
        JsRuntime.InvokeVoidAsync("Print");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MailService service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany icompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ReceiveCustomerRepository _pyment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TapSizeRepository settingRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountLedgerRepository ledgerRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PurchaseInvoiceRepository purchaseRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SalesInvoiceRepository salesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
