﻿using Dreamer.Data;
using Dreamer.Data.Inventory;
using Dreamer.Data.ViewModel;
using System;
using System.Collections.Generic;

namespace Dreamer.Services.Interface
{
    public interface IPurchaseReturnInvoice
    {
        string GetVoucherNo(int CompanyId, int FinancialYearId, int VoucherTypeId);
        bool AccountPurchseReturnInvoiceNoCheckExistence(int CompanyId, int FinancialYearId, string VoucherNo);
        int AccountPurchseReturnInvoiceNoCheckExistenceid(string name);
        int Save(PurchaseReturnMaster model);
        bool Update(PurchaseReturnMaster model);
        List<PurchaseReturnMasterView> PurchaseReturnInvoiceView(int id);
        List<PurchaseReturnMasterView> PurchaseReturnInvoiceViewwarehouse(int id);
        List<ProductView> PurchaseReturnInvoiceDetails(int PurchaseMasterId);
        PurchaseReturnMaster Edit(int id);
        PurchaseReturnMasterView Print(int id);
        bool Delete(int id, string VoucherNo, int CompanyId, int FinancialYearId);
    }
}
