using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private MainModel _mainModel = new MainModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            _mainModel.Number = 0;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            _mainModel.Number++;
            NotifyPropertyChanged("MyProperty");
            //btn2.Content = _mainModel.Number.ToString();
        }

        protected void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Number
        {
            get{return _mainModel.Number;}
            set { _mainModel.Number = value; }
        }

        public string MyStr()
        {
            return "Jo"; 
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
