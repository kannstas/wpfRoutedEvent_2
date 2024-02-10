using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfRoutedEvent_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement frameworkSource = e.Source as FrameworkElement;
            double number = Double.Parse(txtBox.Text);

            switch (frameworkSource.Name)
            {
                case "butAdd":
                    number += number;
                    break;
                case "butMult":
                    number*= number; 
                    break;
                case "butSquare":
                    number = Math.Sqrt(number); 
                    break;
            }

            e.Handled = true;

            txtBox.Text = String.Format($"{number:#.##}");

        }
    }
}