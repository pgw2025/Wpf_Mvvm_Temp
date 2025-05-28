using System.Windows;
using Temp.ViewModels;

namespace Temp.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            this.DataContext=new MainViewModel();
        }
    }
}
