using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using System.Windows.Threading;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Class1 MyClass1 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Class1 class1 = new Class1();

            Task.Run(() =>
            {
                class1.Foo();
            });

            DataContext = class1;
        }

        

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Привет", "Привет");
        }


        public void FirstMethod(Object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Z", "Привет");
        }

        public void SecondMethod(Object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("H", "Привет");
        }
    }
}
