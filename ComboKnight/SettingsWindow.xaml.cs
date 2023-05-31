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

namespace ComboKnight {
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window {
        public SettingsWindow() {
            InitializeComponent();
        }
        public static byte KeyValue1 = 0;
        public static byte KeyValue2 = 0;
        public static byte KeyValue3 = 0;

        public void Save() {
            KeyValue1 = Convert.ToByte(Item1.SelectedIndex);
            KeyValue2 = Convert.ToByte(Item2.SelectedIndex);
            KeyValue3 = Convert.ToByte(Item3.SelectedIndex);
            KeyChange.AllChangeStart();
            ValueChange.MiliSecondValue1 = int.Parse(Value1.Text);
            ValueChange.MiliSecondValue2 = int.Parse(Value2.Text);
            ValueChange.MiliSecondValue3 = int.Parse(Value3.Text);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {

            if (string.IsNullOrEmpty(Value1.Text) || string.IsNullOrEmpty(Value2.Text) || string.IsNullOrEmpty(Value3.Text)) {
                MessageBox.Show("Lütfen tuş hızını boş bırakmayınız!","Boş Kutu",MessageBoxButton.OK,MessageBoxImage.Error);
            } else {
            Save();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            if ((Item1.SelectedIndex != KeyChange.DefaultKey1 || Item2.SelectedIndex!= KeyChange.DefaultKey2 || Item3.SelectedIndex!= KeyChange.DefaultKey3) || (Value1.Text != ValueChange.MiliSecondValue1.ToString() || Value2.Text!= ValueChange.MiliSecondValue2.ToString() || Value3.Text != ValueChange.MiliSecondValue3.ToString())) {
              MessageBoxResult Cevap =  MessageBox.Show("Kaydedilmemiş değerler mevcuttur.\nÇıkmak istediğinize emin misiniz ?","Veri Kayıt",MessageBoxButton.YesNo,MessageBoxImage.Question);
                if (Cevap==MessageBoxResult.Yes) {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                } else {
                    ;
                }
            } else {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Item1.SelectedIndex = KeyChange.DefaultKey1;
            Item2.SelectedIndex = KeyChange.DefaultKey2;
            Item3.SelectedIndex = KeyChange.DefaultKey3;
            Value1.Text = ValueChange.MiliSecondValue1.ToString();
            Value2.Text = ValueChange.MiliSecondValue2.ToString();
            Value3.Text = ValueChange.MiliSecondValue3.ToString();
        }

        private void DefaultValue_Click(object sender, RoutedEventArgs e) {
            Value1.Text = "1000";
            Value2.Text = "1000";
            Value3.Text = "1000";
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }
    }
}
