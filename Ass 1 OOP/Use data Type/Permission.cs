using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_1_OOP.Use_data_Type
{
    [Flags]
    internal enum Permission
    {
        Non =0,
        Read = 1,
        write = 2,
        Execute = 4,
        Delete = 8
    }
}
