using QLBH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Events
{
    public class BillInfoArg : EventArgs
    {
        public BillInfo billInfo;

        public BillInfoArg(BillInfo bf)
        {
            billInfo = bf;
        }
    }
}
