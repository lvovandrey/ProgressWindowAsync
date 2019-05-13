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

namespace ProgressWindowAsync
{
    /// <summary>
    /// Логика взаимодействия для WindowProgress.xaml
    /// </summary>
    public partial class WindowProgress : Window
    {
        public WindowProgress()
        {
            InitializeComponent();
        }
        public void SetVal(int val)
        {
            ProgressBar1.Value = val;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetVal(90);
        }
    }
}
