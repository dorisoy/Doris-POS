// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.ExpenditureVoucher
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
#line 4 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
using Microsoft.EntityFrameworkCore.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
using Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory/expenvoucheredit/{id}")]
    public partial class Expenvoucheredit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 208 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
       
    [Parameter]
    public string id { get; set; }
    InventorySetting setting = new InventorySetting();
    ExpenseMaster mster = new ExpenseMaster();
    IncomeExpenditureView product = new IncomeExpenditureView();
    List<AccountLedger> listLedger = new List<AccountLedger>();
    List<AccountLedger> listSupCus = new List<AccountLedger>();
    List<AccountLedger> listCash = new List<AccountLedger>();
    List<AccountLedger> listBank = new List<AccountLedger>();
    List<DeleteItem> deleteNo = new List<DeleteItem>();
    //GetSessionInfo
    long CompanyId;
    long RoleId;
    long FinancialYearId;
    long UserId;
    string Email;
    long decExpensiveVoucherTypeId = 29;
    long editedID = 0;
    string strNepaliDate;
    string strDate;
    public byte[] ImageUploaded { get; set; }
    bool showModal = false;
    Privilege privi = new Privilege();
    string strMenu = "ExpenseVoucher";
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
        setting = settingRepository.EditInventorySetting(decExpensiveVoucherTypeId);
        LoadData();
        StateHasChanged();
    }
    protected void LoadData()
    {
        mster = expenVoucher.EditExpenseMaster(Convert.ToInt64(id));
        mster.Addresses = expenVoucher.ViewExpenditureDetails(Convert.ToInt64(id));
        listLedger = expenVoucher.GetAccountLedgerEpensive(CompanyId);
        listSupCus = purchaseRepository.GetAccountLedger(CompanyId);
        listCash = purchaseRepository.GetCashFill();
        listBank = purchaseRepository.GetBankFill();
    }
    public void GetDefaultImage() //This function is used to pass the default image when there is no image for saving.
    {
        // To get deafult image this function is used
        // As we store default image in start up path,  we assign the file path as its path
        string strImagePath = Path.Combine(Environment.CurrentDirectory, @"logo\\logo.png");
        ImageUploaded = readfile(strImagePath);
        MemoryStream ms = new MemoryStream(ImageUploaded);
        //Image newImage = Image.FromStream(ms);
        //pbxCompnayLogo.Image = newImage;
        //pbxCompnayLogo.SizeMode = PictureBoxSizeMode.StretchImage;

    }
    byte[] readfile(string strimagepath)
    {
        System.IO.FileInfo flinfo = new System.IO.FileInfo(strimagepath);
        long numbytes = flinfo.Length;
        FileStream fstream = new FileStream(strimagepath, FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fstream);
        ImageUploaded = br.ReadBytes((int)numbytes);
        return ImageUploaded;
    }
    void ModalShow()
    {
        showModal = true;
    }
    void ModalCancel()
    {

        showModal = false;
    }
    protected void Save()
    {
        if (strEdit == true)
        {
            decimal decGrandTotalCshbnk = 0;
            decGrandTotalCshbnk = Math.Round(mster.CashAmount + mster.BankAmount + mster.CreditAmount, PublicVariables._inNoOfDecimalPlaces);
            if (mster.Addresses == null)
            {
                Toaster.Add("Invalid Entry.", MatToastType.Info, "Expense", null);
            }
            else if (decGrandTotalCshbnk != mster.Amount)
            {
                Toaster.Add("Invalid Entry.", MatToastType.Info, "Expense", null);
            }
            else if (mster.VoucherNo == "")
            {
                Toaster.Add("Type Voucherno", MatToastType.Info, "Expense", null);
            }
            else if (mster.NepaliDate == string.Empty)
            {
                Toaster.Add("Invalid Date", MatToastType.Info, "Expense", null);
            }
            else if (mster.Date == null)
            {
                Toaster.Add("Invalid Date", MatToastType.Info, "Expense", null);
            }
            else if (mster.CreditAmount > 0 && mster.LedgerId == 0)
            {
                Toaster.Add("Choose Supplier", MatToastType.Info, "Expense", null);
            }
            else if (mster.BankAmount > 0 && mster.BankId == 0)
            {
                Toaster.Add("Choose Bank", MatToastType.Info, "Expense", null);
            }
            else if (mster.CashAmount > 0 && mster.CashId == 0)
            {
                Toaster.Add("Choose Cash", MatToastType.Info, "Expense", null);
            }
            else if (mster.Amount == 0)
            {
                Toaster.Add("Invalid Entry", MatToastType.Info, "Expense", null);
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(_conn.DbConn);
                sqlcon.Open();
                SqlTransaction sql = sqlcon.BeginTransaction();
                if (ImageUploaded != null)
                {
                    mster.Photos = ImageUploaded;
                    ImageUploaded = null;
                }
                var para = new DynamicParameters();
                para.Add("@ExpensiveMasterId", mster.ExpensiveMasterId);
                para.Add("@SerialNo", mster.SerialNo);
                para.Add("@VoucherNo", mster.VoucherNo);
                para.Add("@InvoiceNo", mster.VoucherNo);
                para.Add("@SuffixPrefixId", 0);
                para.Add("@Date", mster.Date);
                para.Add("@NepaliDate", mster.NepaliDate);
                para.Add("@Amount", mster.Amount);
                para.Add("@LedgerId", mster.LedgerId);
                para.Add("@CreditAmount", mster.CreditAmount);
                para.Add("@BankId", mster.BankId);
                para.Add("@BankAmount", mster.BankAmount);
                para.Add("@CashId", mster.CashId);
                para.Add("@CashAmount", mster.CashAmount);
                para.Add("@VoucherTypeId", decExpensiveVoucherTypeId);
                para.Add("@Photos", mster.Photos);
                para.Add("@Narration", mster.Narration);
                para.Add("@SuffixPrefixId", 0);
                para.Add("@UserId", Email);
                para.Add("@FinancialYearId", FinancialYearId);
                para.Add("@CompanyId", CompanyId);
                para.Add("@ModifyDate", DateTime.Now);
                para.Add("@ModifyBy", UserId);
                sqlcon.Execute("ExpenseMasterUpdate", para, sql, 0, CommandType.StoredProcedure);


                //DeleteExpensesVoucher
                var paraScDelete = new DynamicParameters();
                paraScDelete.Add("@DetailsId", mster.ExpensiveMasterId);
                paraScDelete.Add("@VoucherTypeId", decExpensiveVoucherTypeId);
                var valueScDelete = sqlcon.Query<long>("DELETE FROM LedgerPosting where DetailsId=@DetailsId AND VoucherTypeId=@VoucherTypeId", paraScDelete, sql, true, 0, commandType: CommandType.Text);
                //DeleteExpenseDetails
                var paraScDeleteExpenseDetails = new DynamicParameters();
                paraScDeleteExpenseDetails.Add("@ExpensiveMasterId", mster.ExpensiveMasterId);
                var valueScDeleteExpense = sqlcon.Query<long>("DELETE FROM ExpenseDetails where ExpensiveMasterId=@ExpensiveMasterId", paraScDeleteExpenseDetails, sql, true, 0, commandType: CommandType.Text);
                //DeletePaymentVoucher
                foreach (var item in mster.Addresses)
                {
                    if (item.LedgerId > 0)
                    {
                        //if (item.ExpensiveMasterId == 0)
                        //{
                        var paraOpening = new DynamicParameters();
                        paraOpening.Add("@ExpensiveMasterId", mster.ExpensiveMasterId);
                        paraOpening.Add("@LedgerId", item.LedgerId);
                        paraOpening.Add("@Description", item.Description);
                        paraOpening.Add("@Amount", item.Amount);
                        paraOpening.Add("@TaxId", 1);
                        paraOpening.Add("@Rate", 0);
                        paraOpening.Add("@JourDId", dbType: DbType.Int64, direction: ParameterDirection.Output);
                        sqlcon.Execute("ExpenseDetailsAdd", paraOpening, sql, 0, CommandType.StoredProcedure);
                        long journaldetId = paraOpening.Get<long>("JourDId");

                        //ExpenseLedgerPosting
                        var paraLedger = new DynamicParameters();
                        paraLedger.Add("@Date", mster.Date);
                        paraLedger.Add("@NepaliDate", mster.NepaliDate);
                        paraLedger.Add("@LedgerId", item.LedgerId);
                        paraLedger.Add("@Debit", item.Amount);
                        paraLedger.Add("@Credit", 0);
                        paraLedger.Add("@VoucherNo", mster.VoucherNo);
                        paraLedger.Add("@DetailsId", mster.ExpensiveMasterId);
                        paraLedger.Add("@YearId", FinancialYearId);
                        paraLedger.Add("@InvoiceNo", mster.VoucherNo);
                        paraLedger.Add("@VoucherTypeId", decExpensiveVoucherTypeId);
                        paraLedger.Add("@CompanyId", CompanyId);
                        paraLedger.Add("@LongReference", mster.Narration);
                        paraLedger.Add("@ReferenceN", item.Description);
                        paraLedger.Add("@ChequeNo", string.Empty);
                        paraLedger.Add("@ChequeDate", string.Empty);
                        paraLedger.Add("@AddedDate", DateTime.Now);
                        var value = sqlcon.Query<long>("LedgerPostingInsert", paraLedger, sql, true, 0, commandType: CommandType.StoredProcedure);
                        //}
                        //else
                        //{
                        //    var paraOpening = new DynamicParameters();
                        //    paraOpening.Add("@ExpensiveDetailsId", item.ExpensiveDetailsId);
                        //    paraOpening.Add("@ExpensiveMasterId", mster.ExpensiveMasterId);
                        //    paraOpening.Add("@LedgerId", item.LedgerId);
                        //    paraOpening.Add("@Description", item.Description);
                        //    paraOpening.Add("@Amount", item.Amount);
                        //    paraOpening.Add("@TaxId", 1);
                        //    paraOpening.Add("@Rate", 0);
                        //    sqlcon.Execute("ExpenseDetailsUpdate", paraOpening, sql, 0, CommandType.StoredProcedure);
                        //}
                    }

                }

                //ExpenseLedger
                if (mster.LedgerId > 0)
                {
                    var paraScSupplier = new DynamicParameters();
                    paraScSupplier.Add("@Date", mster.Date);
                    paraScSupplier.Add("@NepaliDate", mster.NepaliDate);
                    paraScSupplier.Add("@LedgerId", mster.LedgerId);
                    paraScSupplier.Add("@Debit", 0);
                    paraScSupplier.Add("@Credit", mster.CreditAmount);
                    paraScSupplier.Add("@VoucherNo", mster.VoucherNo);
                    paraScSupplier.Add("@DetailsId", mster.ExpensiveMasterId);
                    paraScSupplier.Add("@YearId", FinancialYearId);
                    paraScSupplier.Add("@InvoiceNo", mster.InvoiceNo);
                    paraScSupplier.Add("@VoucherTypeId", decExpensiveVoucherTypeId);
                    paraScSupplier.Add("@CompanyId", CompanyId);
                    paraScSupplier.Add("@LongReference", mster.Narration);
                    paraScSupplier.Add("@ReferenceN", mster.Narration);
                    paraScSupplier.Add("@ChequeNo", string.Empty);
                    paraScSupplier.Add("@ChequeDate", string.Empty);
                    paraScSupplier.Add("@AddedDate", DateTime.Now);
                    var valueScSupplier = sqlcon.Query<long>("LedgerPostingInsert", paraScSupplier, sql, true, 0, commandType: CommandType.StoredProcedure);
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
                    paraCash.Add("@DetailsId", mster.ExpensiveMasterId);
                    paraCash.Add("@YearId", FinancialYearId);
                    paraCash.Add("@InvoiceNo", mster.InvoiceNo);
                    paraCash.Add("@VoucherTypeId", decExpensiveVoucherTypeId);
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
                    paraBank.Add("@DetailsId", mster.ExpensiveMasterId);
                    paraBank.Add("@YearId", FinancialYearId);
                    paraBank.Add("@InvoiceNo", mster.InvoiceNo);
                    paraBank.Add("@VoucherTypeId", decExpensiveVoucherTypeId);
                    paraBank.Add("@CompanyId", CompanyId);
                    paraBank.Add("@LongReference", mster.Narration);
                    paraBank.Add("@ReferenceN", mster.Narration);
                    paraBank.Add("@ChequeNo", string.Empty);
                    paraBank.Add("@ChequeDate", string.Empty);
                    paraBank.Add("@AddedDate", DateTime.Now);
                    var valueBank = sqlcon.Query<long>("LedgerPostingInsert", paraBank, sql, true, 0, commandType: CommandType.StoredProcedure);
                }
                ////Delete
                //foreach (var item in deleteNo)
                //{
                //    var paraDetailsDelete = new DynamicParameters();
                //    paraDetailsDelete.Add("@ExpensiveDetailsId", item.DeleteExpenditureId);
                //    var value = sqlcon.Query<long>("DELETE FROM ExpenseDetails where ExpensiveDetailsId=@ExpensiveDetailsId", paraDetailsDelete, sql, true, 0, commandType: CommandType.Text);
                //}
                sql.Commit();
                Toaster.Add("Updated Successfully.", MatToastType.Success, "Expense", null);
                //LoadData();
                navManager.NavigateTo($"/inventory/expensevouchershow/{id}");
            }
        }
        else
        {
            Toaster.Add("You dont have to privilege.", MatToastType.Success, "dashboard", null);
            navManager.NavigateTo("dashboard");
        }
    }
    void Calculate()
    {
        decimal decAmount = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 538 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
         for (var i = 0; i < mster.Addresses.Count; i++)
        {
            var address = mster.Addresses[i];
            decAmount = decAmount + address.Amount;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 542 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
         
        mster.Amount = Math.Round(decAmount, PublicVariables._inNoOfDecimalPlaces);
    }
    void Remove(int index)
    {
        if (index > 0)
        {
            mster.Addresses.RemoveAt(index);
            decimal decAmount = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 551 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
             for (var i = 0; i < mster.Addresses.Count; i++)
            {
                var address = mster.Addresses[i];
                decAmount = decAmount + address.Amount;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 555 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
             
            mster.Amount = Math.Round(decAmount, PublicVariables._inNoOfDecimalPlaces);

            ////HoldId
            //var myHoldId = new DeleteItem()
            //{
            //    DeleteExpenditureId = index,
            //};
            //deleteNo.Add(myHoldId);
            CalculateTotal();
        }
        else
        {
            Toaster.Add("Default value cannot be delete", MatToastType.Info, "Expense", null);
        }
    }
    void AddJournal()
    {
        decimal decAmount = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 574 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
         for (var i = 0; i < mster.Addresses.Count; i++)
        {

            if (mster.Addresses[i].LedgerId == 0)
            {
                Toaster.Add("Choose Expense", MatToastType.Info, "Expense", null);
            }
            else
            {
                mster.Addresses.Add(new ExpenseDetails());
                var address = mster.Addresses[i];
                decAmount = decAmount + address.Amount;
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 587 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\Inventory\ExpenditureVoucher\Expenvoucheredit.razor"
         
        mster.Amount = Math.Round(decAmount, PublicVariables._inNoOfDecimalPlaces);
        CalculateTotal();
    }
    void CalculateTotal()
    {
        decimal decGrandTotalCshbnk = 0;
        decimal decNetAmount = 0;
        decimal decGrandTotal = 0;
        decNetAmount = mster.Amount;
        decGrandTotal = Math.Round(decNetAmount, PublicVariables._inNoOfDecimalPlaces);
        decGrandTotalCshbnk = Math.Round(mster.CashAmount + mster.BankAmount + mster.CreditAmount, PublicVariables._inNoOfDecimalPlaces);
        if (mster.Amount >= decGrandTotalCshbnk)
        {
            //mster.CreditAmount = 0;
            //mster.CashAmount = 0;
            //mster.BankAmount = 0;
        }
        else
        {
            mster.CreditAmount = 0;
            mster.CashAmount = 0;
            mster.BankAmount = 0;
        }
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
            }
            else
            {
                strDate = DreamerDateConveter.convertToAD(strNepaliDate).ToShortDateString();
                mster.Date = Convert.ToDateTime(strDate);
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

    async Task HandleSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            ImageUploaded = ms.ToArray();
        }
    }

    string convertImageToDisplay(byte[] image)
    {
        if (image != null)
        {
            var base64 = Convert.ToBase64String(image);
            var finalStr = string.Format("data:image/jpg;base64,{0}", base64);
            return finalStr;
        }
        return "";
    }
    void Cancel()
    {
        navManager.NavigateTo("inventory/expenvoucherlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PriviliageRepository priviliageRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SalesInvoiceRepository salesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PurchaseInvoiceRepository purchaseRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExpenditureVoucherRepository expenVoucher { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TapSizeRepository settingRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatabaseConnection _conn { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
