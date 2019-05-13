using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ProgressWindowAsync
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

        WindowProgress windowProgress;
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            Thread newWindowThread = new Thread(new ThreadStart(ThreadStartingPoint));
            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.IsBackground = true;
            newWindowThread.Start();
        }

        private void ThreadStartingPoint()
        {
            windowProgress = new WindowProgress();
            windowProgress.Show();
            System.Windows.Threading.Dispatcher.Run();
        }

        private void AssignBtn_Click(object sender, RoutedEventArgs e)
        {
            Assign();
        }

        void Assign()
        {
            windowProgress.SetVal(10);
        }

        async void AssignAsync()
        {
            await Task.Run(() => Assign());                         
        }

        private void AssignBtnLock_Click(object sender, RoutedEventArgs e)
        {
            windowProgress.SetVal(10);
        }
    }
}
