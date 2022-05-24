﻿using Dreamer.Data.Setting;
using System.Collections.Generic;

namespace Dreamer.Services.Interface
{
    public interface IBrand
    {
        List<Brand> GetAll();
        bool CheckName(string name);
        int CheckNameId(string name);
        Brand Edit(int id);
        int Save(Brand model);
        void Update(Brand model);
        bool Delete(int id);
    }
}
