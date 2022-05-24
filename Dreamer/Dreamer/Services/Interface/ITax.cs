﻿using Dreamer.Data.Setting;
using System.Collections.Generic;

namespace Dreamer.Services.Interface
{
    public interface ITax
    {
        List<Tax> GetAll();
        bool CheckName(string name);
        int CheckNameId(string name);
        Tax Edit(int id);
        int Save(Tax model);
        void Update(Tax model);
        bool Delete(int id);
    }
}
