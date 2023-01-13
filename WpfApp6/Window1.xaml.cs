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
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //Model.tb = TBCount;
            ClassWindows.tbCombo = Znach;
            Box.ItemsSource = ClassWindows.datalist;
        }

        private void BtnCount_Click(object sender, RoutedEventArgs e)
        {


            int Result_0 = ClassWindows.Count_1 + ClassWindows.Count_2;
            Result.Text = Result_0.ToString();
            //
            //int n;
            //n = 10;
        }
    }
}
