﻿using Dreamer.Data.Setting;
using System.Collections.Generic;

namespace Dreamer.Services.Interface
{
    public interface IFinancialYear
    {
        List<FinancialYear> GetAll();
        bool CheckName(string name);
        int CheckNameId(string name);
        FinancialYear Edit(int id);
        int Save(FinancialYear model);
        void Update(FinancialYear model);
        bool Delete(int id);
    }
}
