using System.Windows;
using DCOMProductions.MVVMDemo.ViewModels;

namespace DCOMProductions.MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CustomerViewModel();
        }
    }
}
