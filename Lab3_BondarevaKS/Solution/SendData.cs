using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_BondarevaKS.Models;

namespace Lab3_BondarevaKS.Solution
{
    public interface ISendData
    {
        void SendInfo(InfTriangle triangle);
    }
    class SendData : ISendData
    {
        public void SendInfo(InfTriangle triangle)
        {
            Console.WriteLine($"Отправка данных: {triangle.length1} {triangle.length2} {triangle.length3} {triangle.TypeTriangle}");
        }
    }
}
