using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_BondarevaKS.Models;

namespace Lab3_BondarevaKS.Solution
{
    public class Triangle
    {
        public static (string, float[], float[], float[], string) GoTriangle(string first, string second, string third)
        {
            try
            {
                float a = float.Parse(first);
                float b = float.Parse(second);
                float c = float.Parse(third); // конвертируем длины треугольников

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    float[] xy1 = new float[] { -2, -2 };
                    float[] xy2 = new float[] { -2, -2 };
                    float[] xy3 = new float[] { -2, -2 };
                    string msg = $" ({xy1[0]}; {xy1[1]}), ({xy2[0]}; {xy2[1]}), ({xy3[0]}; {xy3[1]})";
                    return ("Невалидные значения", xy1, xy2, xy3, "");
                }

                if (a + b > c && a + c > b && b + c > a)
                {
                    string type = "";


                    if (a == b && b == c && a == c) { type = "Равносторонний"; }
                    else if (a == b || b == c || c == a) { type = "Равнобедренный"; }
                    else { type = "Разносторонний"; }

                    float[] xy1 = new float[] { 0, 0 };
                    float[] xy2 = new float[] { c, 0 };

                    float cosA = (b * b + c * c - a * a) / (2 * b * c);
                    float sinA = (float)Math.Sqrt(1 - cosA * cosA);
                    float height = b * sinA;

                    float temp = (c * c - b * b + a * a) / (2 * a); // находим координаты третьей вершины
                    float[] xy3 = new float[] { temp, (float)Math.Sqrt(height * height - temp * temp) };

                    if (Math.Max(xy1[0], Math.Max(xy1[1], Math.Max(xy2[0], Math.Max(xy2[1], Math.Max(xy3[0], xy3[1]))))) > 80)
                    {
                        float scale = 100 / Math.Max(xy2[0], Math.Max(xy3[0], xy3[1]));
                        xy1[0] *= scale;
                        xy1[1] *= scale;
                        xy2[0] *= scale;
                        xy2[1] *= scale;
                        xy3[0] *= scale;
                        xy3[1] *= scale;
                    }

                    string msg = $"{type}";
                    return (type, xy1, xy2, xy3, ""); // возвращаем значения, логируем
                }
                else
                {
                    float[] xy1 = new float[] { -1, -1 };
                    float[] xy2 = new float[] { -1, -1 };
                    float[] xy3 = new float[] { -1, -1 };
                    string msg = $" Не треугольник ({xy1[0]}; {xy1[1]}), ({xy2[0]}; {xy2[1]}), ({xy3[0]}; {xy3[1]})";
                    return ("Не треугольник", xy1, xy2, xy3, "");
                }
            }
            catch (Exception ex) // случай, при котором данные не могут быть корректно конвертированы
            {
                float[] xy1 = new float[] { -2, -2 };
                float[] xy2 = new float[] { -2, -2 };
                float[] xy3 = new float[] { -2, -2 };
                string msg = $" ({xy1[0]}; {xy1[1]}), ({xy2[0]}; {xy2[1]}), ({xy3[0]}; {xy3[1]})";
                return ("Не введены значения сторон", xy1, xy2, xy3, ex.ToString());
            }
        }
    }
}
