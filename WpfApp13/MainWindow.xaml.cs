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

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class FLAT : MainWindow
        {
            public int room { get; set; }
            public int S { get; set; }
            public int stage { get; set; }
            public string Adres { get; set; }
            public int price { get; set; }
            public void Vvod()
            {
                room = Convert.ToInt32(TextBoxC.Text);
                S = Convert.ToInt32(TextBoxB.Text);
                stage = Convert.ToInt32(TextBoxN.Text);
                price = Convert.ToInt32(TextBoxM.Text);
                Adres = TextBoxA.Text;
            }
            public void Vavod()
            {
                B.Text += "\n" + "Комнат:" + room;
                B.Text += "\n" + "Площадь:" + S;
                B.Text += "\n" + "Этаж:" + stage;
                B.Text += "\n" + "Цена:" + price;
                B.Text += "\n" + "Адрес:" + Adres;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FLAT fLAT = new FLAT();
            fLAT.Vvod();
            fLAT.Vavod();
        }
    }
}
