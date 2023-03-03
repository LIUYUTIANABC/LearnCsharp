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
using Template.ViewModels;

namespace Template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // 将 VM 中的处理逻辑赋值给 DataContext， 便于控件上的数据绑定
            // 方法一：使用默认的 MainWindow.xaml.cs 文件；调用其他 .cs 文件的构造函数初始化绑定数据；
            DataContext = new MainWindowViewModel();
            // 方法二：使用 MainWindow.xaml 指定其他自定义的 .cs 文件
            // xmlns:vm="clr-namespace:Template.ViewModels"  // 包含命名空间
            // <Window.DataContext>
            //     <vm:MainWindowViewModel />  // 使用指定的 .cs 文件的构造方法
            // </Window.DataContext>
        }
    }
}
