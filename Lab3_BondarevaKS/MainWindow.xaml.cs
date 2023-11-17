using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab3_BondarevaKS.Models;
using Lab3_BondarevaKS.Solution;

namespace Lab3_BondarevaKS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Output(InfTriangle triangle)
        {
            result.Text =
                $"{triangle.length1} \n{triangle.length2} \n{triangle.length3} \n{triangle.TypeTriangle} \n{triangle.Exception}";
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InfTriangle triangle = Controller.GoControl(leng1.Text, leng2.Text, leng3.Text);
                Output(triangle);
            }
            catch
            {
                MessageBox.Show("Не правильно введены данные");
                leng1.Clear();
                leng2.Clear();
                leng3.Clear();
            }
        }

    }
}
