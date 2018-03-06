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

namespace WpfList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //List<TodoItem> items = new List<TodoItem>();
            //items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45});
            //items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            //items.Add(new TodoItem() { Title = "Go to shop", Completion = 100 });
            //items.Add(new TodoItem() { Title = "Buy stuff", Completion = 10 });
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Nimi = "Sharleen Coplan" });
            items.Add(new TodoItem() { Nimi = "Miles Mcgown" });
            items.Add(new TodoItem() { Nimi = "Sherley Clodfelter" });
            items.Add(new TodoItem() { Nimi = "Celestina Davenport" });
            items.Add(new TodoItem() { Nimi = "Celina Whitmore" });
            items.Add(new TodoItem() { Nimi = "Prudence Gariepy" });
            items.Add(new TodoItem() { Nimi = "Elva Mower" });
            items.Add(new TodoItem() { Nimi = "Nerissa Mcelyea" });
            items.Add(new TodoItem() { Nimi = "Dionna Linquist" });
            items.Add(new TodoItem() { Nimi = "Milo Sebesta" });
            items.Add(new TodoItem() { Nimi = "Pricilla Cecere" });
            items.Add(new TodoItem() { Nimi = "Victoria Giefer" });
            items.Add(new TodoItem() { Nimi = "Shemika Gotto" });
            items.Add(new TodoItem() { Nimi = "Lyndsey Kleinschmidt" });


            TodoListBox.ItemsSource = items;            
        }

        private void todoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TodoListBox.SelectedItem != null)
            {
                Title = (TodoListBox.SelectedItem as TodoItem).Nimi;
            }
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.SelectedItems)
            {
                MessageBox.Show((item as TodoItem).Nimi);
            }
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            TodoListBox.SelectedIndex = TodoListBox.Items.Count - 1;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if ((TodoListBox.SelectedIndex >= 0) && (TodoListBox.SelectedIndex < (TodoListBox.Items.Count - 1)))
            {
                nextIndex = TodoListBox.SelectedIndex + 1;
            }
            TodoListBox.SelectedIndex = nextIndex;
        }

        //private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        //{
        //    foreach (var item in TodoListBox.Items)
        //    {
        //        if ((item is TodoItem) && ((item as TodoItem).Title.Contains("C#")))
        //        {
        //            TodoListBox.SelectedItem = item;
        //            break;
        //        }
        //    }
        //}

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.Items)
            {
                TodoListBox.SelectedItems.Add(item);
            }
        }
    }

    public class TodoItem
    {
        //public string Title { get; set; }
        //public int Completion { get; set; }
        public string Nimi { get; set; }
        //public string PereN { get; set; }
        //public int Age { get; set; }
    }
}
