using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_BondarevaKS.Models;
using Lab3_BondarevaKS.Solution;

namespace Lab3_BondarevaKS.Solution
{
    public class Controller
    {
        public static InfTriangle GoControl(string f, string s, string t)
        {
            InfTriangle triangle = new InfTriangle();

            if (AppData.SearchInfo(f, s, t) == null) AppData.AddInfo(f, s, t);
            SendData send = new SendData();
            send.SendInfo(AppData.SearchInfo(f, s, t));
            return AppData.SearchInfo(f, s, t);
        }
    }
}
