﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNoteParser.Shared
{
    public interface IGenerator
    {
        string GenerateMD(string parentId);
    }
}
