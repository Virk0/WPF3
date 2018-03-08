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
            //List<TodoItem> items = new List<TodoItem>();
            //items.Add(new TodoItem() { Nimi = "Sharleen Coplan", Age = 12 });
            //items.Add(new TodoItem() { Nimi = "Miles Mcgown", Age = 25 });
            //items.Add(new TodoItem() { Nimi = "Sherley Clodfelter", Age = 56 });
            //items.Add(new TodoItem() { Nimi = "Celestina Davenport", Age =45 });
            //items.Add(new TodoItem() { Nimi = "Celina Whitmore", Age =76 });
            //items.Add(new TodoItem() { Nimi = "Prudence Gariepy", Age =69});
            //items.Add(new TodoItem() { Nimi = "Elva Mower", Age = 12});
            //items.Add(new TodoItem() { Nimi = "Nerissa Mcelyea", Age =16});
            //items.Add(new TodoItem() { Nimi = "Dionna Linquist", Age =15 });
            //items.Add(new TodoItem() { Nimi = "Milo Sebesta", Age =45});
            //items.Add(new TodoItem() { Nimi = "Pricilla Cecere", Age =34});
            //items.Add(new TodoItem() { Nimi = "Victoria Giefer", Age =59});
            //items.Add(new TodoItem() { Nimi = "Shemika Gotto", Age =89});
            //items.Add(new TodoItem() { Nimi = "Lyndsey Kleinschmidt", Age =5});


            //TodoListBox.ItemsSource = items;            
            string[] names = System.IO.File.ReadAllLines("../../names.txt");
            List<TodoItem> todo = new List<TodoItem>();

            foreach (string name in names)
            {
                TodoItem item = new TodoItem();

                item.Nimi = name;

                todo.Add(item);
            }

            TodoListBox.ItemsSource = todo;
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
            Random rnd = new Random();
            foreach (var item in TodoListBox.SelectedItems)
            {
                MessageBox.Show("Name: \"" +(item as TodoItem).Nimi + "\",  Age: "+ rnd.Next(12, 100));
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
        //    int nextIndex = 0;
        //    if ((TodoListBox.SelectedIndex >= 0) && (TodoListBox.SelectedIndex < (TodoListBox.Items.Count - 1)))
        //    {
        //        nextIndex = TodoListBox.SelectedIndex - 1;
        //    }
        //    TodoListBox.SelectedIndex = nextIndex;
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
        public int Age { get; set; }
    }
}
