using System.Collections.ObjectModel;
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

namespace TodoApp
{
    
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<string> items = [];

        public MainWindow()
        {
            InitializeComponent();
            Input_Name.Focus();

            List_TaskList.ItemsSource = items;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Input_Name.Text)) {
                items.Add(Input_Name.Text);
                Input_Name.Text = string.Empty;
            }
        }
    }
}