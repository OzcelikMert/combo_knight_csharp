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
using System.Windows.Threading;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace ComboKnight {
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();

        }

        public DispatcherTimer StartTimer1 = new DispatcherTimer();
        public DispatcherTimer StartTimer2 = new DispatcherTimer();
        public DispatcherTimer StartTimer3 = new DispatcherTimer();
        public char ActivatedStart = '0';
        bool isRunning = true;
        public Thread TM;
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            TM = new Thread(Keyboardd);
            TM.SetApartmentState(ApartmentState.STA);
            TM.Start();
            StartTimer1.Tick += new EventHandler(StartTimer1_Tick);
            StartTimer2.Tick += new EventHandler(StartTimer2_Tick);
            StartTimer3.Tick += new EventHandler(StartTimer3_Tick);
        }
        void Keyboardd() {
            while (isRunning) {
                Thread.Sleep(40);
                if ((Keyboard.GetKeyStates(Key.Z) & KeyStates.Down)>0) {
                   Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Send,
                            (Action)delegate {
                                Starting();
                            });
                }
               else if ((Keyboard.GetKeyStates(Key.X) & KeyStates.Down) > 0) {
                   Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Send,
                            (Action)delegate {
                                Stoping();
                           });
                } else {
                    ;
                }
            }

        }

        private void Window_Closed(object sender, EventArgs e) {
            isRunning = false;
        }

        private void StartTimer1_Tick(object sender, EventArgs e) {
            KeysPress.press();
        }


        private void StartTimer2_Tick(object sender, EventArgs e) {
            KeysPress.press2();
        }

        private void StartTimer3_Tick(object sender, EventArgs e) {
            KeysPress.press3();
        }
        public void Starting() {
            if (ActivatedStart == '0') {
                ActivatedStart = '1';
                Start.Background = Brushes.Lime;
                StartTimer1.Interval = new TimeSpan(0, 0, 0, 0, ValueChange.MiliSecondValue1);
                StartTimer2.Interval = new TimeSpan(0, 0, 0, 0, ValueChange.MiliSecondValue2);
                StartTimer3.Interval = new TimeSpan(0, 0, 0, 0, ValueChange.MiliSecondValue3);
                StartTimer1.Start();
                StartTimer2.Start();
                StartTimer3.Start();
            } else {
                ;
            }
        }

        public void Stoping() {
            ActivatedStart = '0';
            Start.Background = Brushes.Azure;
            StartTimer1.Stop();
            StartTimer2.Stop();
            StartTimer3.Stop();
        }

        private void Start_Click(object sender, RoutedEventArgs e) {
            Starting();

        }

        private void Stop_Click(object sender, RoutedEventArgs e) {
            Stoping();
        }

        private void Settings_Click(object sender, RoutedEventArgs e) {
            StartTimer1.Stop();
            StartTimer2.Stop();
            StartTimer3.Stop();
            isRunning = false;
            SettingsWindow sw = new SettingsWindow();
            sw.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult CikisCevap = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz ?","Çıkış",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (CikisCevap==MessageBoxResult.Yes) {
            StartTimer1.Stop();
            StartTimer2.Stop();
            StartTimer3.Stop();
                Application.Current.Shutdown();
            } else {
                ;
            }
        }

        private void Hide_Click(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {

            Process.Start("https://www.ozceliksoftware.com/");

        }
    }
}
