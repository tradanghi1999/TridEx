﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public interface IHistory
    {
        string getJsonHistory();
        void writeJsonHistory(string jsonHis);
    }
}
