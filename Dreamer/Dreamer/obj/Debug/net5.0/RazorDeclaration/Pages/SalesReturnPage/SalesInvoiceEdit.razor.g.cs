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
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesInvoiceEdit.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales/salesinvoiceedit/{id}")]
    public partial class SalesInvoiceEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 316 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesInvoiceEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }
    int decPurchaseInvoiceVoucherType = 8;
    SalesMaster master = new SalesMaster();
    CartItem productDetails = new CartItem();
    IEnumerable<ProductView> listProduct;
    List<AccountLedgerView> listAccountledger;
    List<Tax> listTax;
    List<Warehouse> listWarehouse;
    ProductView product = new ProductView();
    //TodoTask
    List<CartItem> cartItems = new List<CartItem>();
    private CartItem cartItem = new CartItem { Qty = 1 };
    int editedID = 0;
    List<ProductView> TodoList = new List<ProductView>();
    //HoldDeleteItem
    List<DeleteItem> deleteNo = new List<DeleteItem>();
    bool isShow = false;
    string Title;
    string strSerialNo;
    protected async override void OnInitialized()
    {
        CartService.EmptyCart();
        master = _salesInvoice.EditSalesMaster(Convert.ToInt32(id));
        TodoList = _salesInvoice.SalesInvoiceDetails(Convert.ToInt32(id));
        listAccountledger = _accountLedger.ViewAllCustomer(1);
        listWarehouse = _warehouse.GetAll();
        listProduct = _product.ViewAllProduct(1);
        listTax = _tax.GetAll();
        foreach(var myTodoss in TodoList)
        {
            cartItem.SalesDetailsId = myTodoss.SalesDetailsId;
            cartItem.Qty = myTodoss.Qty;
            cartItem.ProductId = myTodoss.ProductId;
            cartItem.ProductCode = myTodoss.ProductCode;
            cartItem.ProductName = myTodoss.ProductName;
            cartItem.Barcode = myTodoss.Barcode;
            cartItem.UnitId = myTodoss.UnitId;
            cartItem.BatchId = myTodoss.BatchId;
            cartItem.SalesRate = myTodoss.SalesRate;
            cartItem.Mrp = myTodoss.Mrp;
            cartItem.SalesRate = myTodoss.SalesRate;
            cartItem.Discount = myTodoss.Discount;
            cartItem.DiscountAmount = myTodoss.DiscountAmount;
            cartItem.TaxId = myTodoss.TaxId;
            cartItem.TaxRate = myTodoss.TaxRate;
            cartItem.TaxAmount = myTodoss.TaxAmount;
            cartItem.Amount = myTodoss.Amount;
            cartItem.TotalAmount = myTodoss.Amount;
            cartItem.NetAmount = myTodoss.NetAmount;
            cartItem.UnitName = myTodoss.UnitName;
            cartItem.TaxName = myTodoss.TaxName;
            cartItem.CurrentStock = myTodoss.CurrentStock;
            cartItem.CartStatus = "edit";
            await CartService.AddToCart(cartItem);
            StateHasChanged();
        }
        cartItems = await CartService.GetCartItems();
        StateHasChanged();
    }
    public async Task HandleValidSubmit()
    {
        decimal decGrand = 0;
        decimal decCashBankAmount = 0;
        decimal decDue = 0;
        decGrand = master.GrandTotal;
        decCashBankAmount = master.PayAmount;
        decDue = decGrand - decCashBankAmount;
        if (cartItems == null)
        {
            Snackbar.Add("Invalid Entry.", Severity.Warning);
        }
        else if (master.WarehouseId == 0)
        {
            Snackbar.Add("Choose Warehouse.", Severity.Warning);
        }
        else if (master.LedgerId == 0)
        {
            Snackbar.Add("Choose Customer.", Severity.Warning);
        }
        else if (master.VoucherNo == string.Empty)
        {
            Snackbar.Add("Type Voucherno.", Severity.Warning);
        }
        else if (master.GrandTotal == 0)
        {
            Snackbar.Add("Invalid Entry.", Severity.Warning);
        }
        else
        {

            var authState = await authenticationState;
            var user = authState.User;
            string Id = user.Identity.Name.ToString();
                master.UserId = Id;
                master.CompanyId = 1;
                master.FinancialYearId = 1;
                master.VoucherTypeId = decPurchaseInvoiceVoucherType;
                master.PreviousDue = 0;
                master.BalanceDue = 0;
                //master.PaymentId = "Credit";
                if (decDue == 0)
                {
                    master.Status = "Paid";
                }
                else if (master.GrandTotal > decDue)
                {
                    master.Status = "Partial Paid";
                }
                else
                {
                    master.Status = "Draft";
                }
                master.OrderMasterId = 0;
                master.AddedDate = DateTime.UtcNow;
                foreach (var item in cartItems)
                {
                    SalesDetails details = new SalesDetails();
                    if (item != null)
                    {
                        details.SalesDetailsId = item.SalesDetailsId;
                        details.ProductId = item.ProductId;
                        details.Qty = item.Qty;
                        details.UnitId = item.UnitId;
                        details.Rate = item.SalesRate;
                        details.Amount = item.Amount;
                        details.Discount = item.Discount;
                        details.DiscountAmount = item.DiscountAmount;
                        details.TaxId = item.TaxId;
                        details.TaxAmount = item.TaxAmount;
                        details.BatchId = item.BatchId;
                        details.NetAmount = item.NetAmount;
                        details.GrossAmount = 0;
                        details.OrderDetailsId = 0;
                        master.listOrder.Add(details);
                    }

                }
                foreach (var items in deleteNo)
                {
                    DeleteItem details = new DeleteItem();
                    if (items != null)
                    {
                        details.SalesDetailsId = items.SalesDetailsId;
                        master.listDelete.Add(details);
                    }

                }
               bool isUpdate = _salesInvoice.Update(master);
                if(isUpdate == true)
                {
                    Snackbar.Add("Successfully Updated.", Severity.Success);
                    navManager.NavigateTo("/sales/salesinvoicelist");
                }
        }
        }
    protected async void LedgerClicked()
    {
        if (master.LedgerId > 0)
        {
            //var view = salesInvoiceRepository.CustomerSalesDue(master.LedgerId);
            //master.PreviousDue = view.DueBalance;
        }
        else
        {
            master.PreviousDue = 0;
        }
    }
    protected async void OnChange(object value, string name)
    {
        var myTodoss = listProduct.FirstOrDefault(x => x.ProductName == value);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 490 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesInvoiceEdit.razor"
         if (myTodoss != null)
        {
            foreach(var item in cartItems)
            {
                if(myTodoss.ProductId == item.ProductId)
                {
                    Snackbar.Add("This product is already added.", Severity.Warning);
                    return;
                }
            }
            cartItem.ProductId = myTodoss.ProductId;
            cartItem.ProductCode = myTodoss.ProductCode;
            cartItem.ProductName = myTodoss.ProductName;
        cartItem.Barcode = myTodoss.Barcode;
        cartItem.UnitId = myTodoss.UnitId;
        cartItem.BatchId = myTodoss.BatchId;
        cartItem.SalesRate = myTodoss.SalesRate;
        cartItem.Mrp = myTodoss.Mrp;
        cartItem.SalesRate = myTodoss.SalesRate;
        cartItem.Discount = myTodoss.Discount;
        cartItem.DiscountAmount = myTodoss.DiscountAmount;
        cartItem.TaxId = myTodoss.TaxId;
        cartItem.TaxRate = myTodoss.TaxRate;
        cartItem.TaxAmount = myTodoss.TaxAmount;
        cartItem.Amount = Math.Round(1 * myTodoss.SalesRate , 2);
        cartItem.TotalAmount = Math.Round(1 * myTodoss.SalesRate , 2);
        cartItem.NetAmount = myTodoss.NetAmount;
        cartItem.UnitName = myTodoss.UnitName;
        cartItem.TaxName = myTodoss.TaxName;
        cartItem.CurrentStock = myTodoss.CurrentStock;
        await CartService.AddToCart(cartItem);
        //Snackbar.Add("Successfully add to cart.", Severity.Info);
        cartItems = await CartService.GetCartItems();
            listProduct = _product.ViewAllProduct(1);
            CalculateTotal();
            StateHasChanged();
        }
        else
        {
            
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 530 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesInvoiceEdit.razor"
         
    }
    private async Task DeleteItem(CartItem item)
    {
        await CartService.DeleteItem(item);
        cartItems = await CartService.GetCartItems();
        //HoldId
        var myHoldId = new DeleteItem()
        {
            PurchaseDetailsId = cartItem.PurchaseDetailsId,
        };
        deleteNo.Add(myHoldId);
        StateHasChanged();
    }
    private async Task AddToCart(CartItem items)
    {

        cartItem.ProductId = items.ProductId;
        cartItem.ProductCode = items.ProductCode;
        cartItem.ProductName = items.ProductName;
        cartItem.Barcode = items.Barcode;
        cartItem.UnitId = items.UnitId;
        cartItem.BatchId = items.BatchId;
        cartItem.SalesRate = items.SalesRate;
        cartItem.Mrp = items.Mrp;
        cartItem.SalesRate = items.SalesRate;
        cartItem.Discount = items.Discount;
        cartItem.DiscountAmount = items.DiscountAmount;
        cartItem.TaxId = items.TaxId;
        cartItem.TaxRate = items.TaxRate;
        cartItem.TaxAmount = items.TaxAmount;
        cartItem.Amount = items.Amount;
        cartItem.TotalAmount = items.TotalAmount;
        cartItem.NetAmount = items.NetAmount;
        cartItem.UnitName = items.UnitName;
        cartItem.TaxName = items.TaxName;
        cartItem.CurrentStock = items.CurrentStock;
        cartItem.CartStatus = "equal";
        await CartService.AddToCart(cartItem);
        //Snackbar.Add("Successfully add to cart.", Severity.Info);
        cartItems = await CartService.GetCartItems();
        isShow = false;
        CalculateTotal();
        StateHasChanged();
    }
    private async Task AddToCartDsc(CartItem items)
    {

        cartItem.ProductId = items.ProductId;
        cartItem.ProductCode = items.ProductCode;
        cartItem.ProductName = items.ProductName;
        cartItem.Barcode = items.Barcode;
        cartItem.UnitId = items.UnitId;
        cartItem.BatchId = items.BatchId;
        cartItem.SalesRate = items.SalesRate;
        cartItem.Mrp = items.Mrp;
        cartItem.SalesRate = items.SalesRate;
        cartItem.Discount = items.Discount;
        cartItem.DiscountAmount = items.DiscountAmount;
        cartItem.TaxId = items.TaxId;
        cartItem.TaxRate = items.TaxRate;
        cartItem.TaxAmount = items.TaxAmount;
        cartItem.Amount = items.Amount;
        cartItem.TotalAmount = items.TotalAmount;
        cartItem.NetAmount = items.NetAmount;
        cartItem.UnitName = items.UnitName;
        cartItem.TaxName = items.TaxName;
        cartItem.CurrentStock = items.CurrentStock;
        cartItem.CartStatus = "Dsc";

        await CartService.AddToCart(cartItem);
        //Snackbar.Add("Successfully add to cart.", Severity.Info);
        cartItems = await CartService.GetCartItems();
        isShow = false;
        CalculateTotal();
        StateHasChanged();
    }
    private async Task AddToCartAsc(CartItem items)
    {
        if (items.Qty == 1)
        {

        }
        else
        {
            cartItem.ProductId = items.ProductId;
            cartItem.ProductCode = items.ProductCode;
            cartItem.ProductName = items.ProductName;
            cartItem.Barcode = items.Barcode;
            cartItem.UnitId = items.UnitId;
            cartItem.BatchId = items.BatchId;
            cartItem.SalesRate = items.SalesRate;
            cartItem.Mrp = items.Mrp;
            cartItem.SalesRate = items.SalesRate;
            cartItem.Discount = items.Discount;
            cartItem.DiscountAmount = items.DiscountAmount;
            cartItem.TaxId = items.TaxId;
            cartItem.TaxRate = items.TaxRate;
            cartItem.TaxAmount = items.TaxAmount;
            cartItem.Amount = items.Amount;
            cartItem.TotalAmount = items.TotalAmount;
            cartItem.NetAmount = items.NetAmount;
            cartItem.UnitName = items.UnitName;
            cartItem.TaxName = items.TaxName;
            cartItem.CurrentStock = items.CurrentStock;
            cartItem.CartStatus = "Asc";
            await CartService.AddToCart(cartItem);
            //Snackbar.Add("Successfully add to cart.", Severity.Info);
            cartItems = await CartService.GetCartItems();
            isShow = false;
            CalculateTotal();
            StateHasChanged();
        }
    }
    void CalculateTotal()
    {
        decimal decTotalAmount = 0;
        decimal decAdditionalCost = 0;
        decimal decTaxAmount = 0;
        decimal decTotalDisTax = 0;
        decimal decGrandTotalCshbnk = 0;
        decimal decNetAmount = 0;
        decimal decCheckTax = 0;
        decimal decGrandTotal = 0;
        foreach (var todo in cartItems)
        {
            decTotalAmount = decTotalAmount + todo.TotalAmount;
            decNetAmount = decNetAmount + todo.NetAmount;
            decCheckTax = decCheckTax + todo.TaxAmount;
        }
        master.NetAmounts = Math.Round(decNetAmount, 2);
        master.TotalAmount = Math.Round(decTotalAmount, 2);

        decimal decTotalAmountTax = 0;
        decTotalAmountTax = decTotalAmount + master.TotalTax;
        decTotalDisTax = decTotalAmount;
        master.DisPer = (master.BillDiscount * 100) / (decTotalAmountTax);
        if (decCheckTax > 0)
        {
            decTaxAmount = Math.Round(decCheckTax, 2);
            master.TotalTax = Math.Round(decCheckTax, 2);
        }
        else
        {
            decTaxAmount = decTotalDisTax * master.TaxRate / 100;
            master.TotalTax = Math.Round(decTaxAmount, 2);
        }
        decimal decDiscountAmount = 0;
        decDiscountAmount = master.BillDiscount;
        decGrandTotal = Math.Round((decTotalDisTax + decAdditionalCost + decTaxAmount) - (decDiscountAmount), 2);
        if (decGrandTotal >= 0)
        {
            master.GrandTotal = decGrandTotal + master.ShippingAmount;
        }
        else
        {
            master.BillDiscount = 0;
            master.GrandTotal = decGrandTotal + master.ShippingAmount;
        }
        decGrandTotalCshbnk = master.PayAmount;
        if (master.GrandTotal >= decGrandTotalCshbnk)
        {
            var decTotl = master.GrandTotal - decGrandTotalCshbnk;
            master.PreviousDue = Math.Round(decTotl, 2);
        }
        else
        {
            master.PayAmount = 0;
            master.PreviousDue = 0;
        }
    }
    private void ShowModel(int id)
    {
        isShow = true;
        Title = "Product";
        var myTodoss = cartItems.FirstOrDefault(x => x.ProductId == id);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 706 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesInvoiceEdit.razor"
         if (myTodoss != null)
        {
            productDetails.ProductId = myTodoss.ProductId;
            productDetails.ProductCode = myTodoss.ProductCode;
            productDetails.ProductName = myTodoss.ProductName;
        productDetails.Barcode = myTodoss.Barcode;
        productDetails.UnitId = myTodoss.UnitId;
        productDetails.SalesRate = myTodoss.SalesRate;
        productDetails.Mrp = myTodoss.Mrp;
        productDetails.SalesRate = myTodoss.SalesRate;
        productDetails.Discount = myTodoss.Discount;
        productDetails.DiscountAmount = myTodoss.DiscountAmount;
        productDetails.TaxId = myTodoss.TaxId;
        productDetails.TaxRate = myTodoss.TaxRate;
        productDetails.TaxAmount = myTodoss.TaxAmount;
        productDetails.Amount = Math.Round(1 * myTodoss.SalesRate , 2);
        productDetails.TotalAmount = Math.Round(1 * myTodoss.SalesRate , 2);
        productDetails.NetAmount = myTodoss.NetAmount;
        productDetails.UnitName = myTodoss.UnitName;
        productDetails.TaxName = myTodoss.TaxName;
        productDetails.CurrentStock = myTodoss.CurrentStock;
        }
        else
        {
            
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 731 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SalesReturnPage\SalesInvoiceEdit.razor"
         
        StateHasChanged();
    }
    private void CloseModel()
    {
        isShow = false;
        StateHasChanged();
    }
    void Cancel()
    {
        navManager.NavigateTo("/sales/salesinvoicelist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITax _tax { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesInvoice _salesInvoice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVoucherType _voucherType { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartSalesService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger _accountLedger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWarehouse _warehouse { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct _product { get; set; }
    }
}
#pragma warning restore 1591
