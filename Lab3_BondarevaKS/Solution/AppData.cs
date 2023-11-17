using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_BondarevaKS.Models;

namespace Lab3_BondarevaKS.Solution
{
    public static class AppData
    {
        public static LabTriangleEntities db = new LabTriangleEntities();

        public static InfTriangle SearchInfo(string f, string s, string t)
        {
            return db.InfTriangle.FirstOrDefault(u => u.length1 == f && u.length2 == s && u.length3 == t);
        }

        public static InfTriangle AddInfo(string f, string s, string t)
        {
            var triangle = Triangle.GoTriangle(f, s, t);
            InfTriangle tr = new InfTriangle();
            tr.length1 = f;
            tr.length2 = s;
            tr.length3 = t;
            tr.TypeTriangle = triangle.Item1;
            tr.Exception = triangle.Item5;
            db.InfTriangle.Add(tr);
            db.SaveChanges();

            return tr;
        }

        public static void DeleteInfo(string f, string s, string t)
        {
            InfTriangle triangle = db.InfTriangle.FirstOrDefault(u => u.length1 == f && u.length2 == s && u.length3 == t);
            db.InfTriangle.Remove(triangle);
            db.SaveChanges();
        }

    }
}
