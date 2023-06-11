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

namespace WpfApp3
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

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var comboBox = (ComboBox)sender;


        //    if (comboBox?.SelectedItem is ComboBoxItem cboxItem)
        //    {
                
        //        lbl1.Content = cboxItem.Content;
        //    }
 
        //}

        //private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var listBox = (ListBox)sender;


        //    if (listBox?.SelectedItem is ListBoxItem lboxItem)
        //    {
        //        var button = (Button)lboxItem.Content;
        //        MessageBox.Show(button?.Content.ToString());
        //    }
        //    else if (listBox?.SelectedItem is Button lbl)
        //    {
        //        MessageBox.Show(lbl.Content.ToString());
        //    }
        //}

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{

        //        var b = (CheckBox)sender;
        //        if (b.IsChecked==true) {btn.IsEnabled = true; }

        //}

        //private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    var b = (CheckBox)sender;
        //    if (b.IsChecked==false) {btn.IsEnabled = false; }
        //}

        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    lbl1.Content = ((int)e.NewValue).ToString();
        //}

        //private void RepeatButton_Click(object sender, RoutedEventArgs e)
        //{
        //        prog.Value+=1;
        //        alabaw.Content = prog.Value;
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    prog.Value+=1;
        //    alabaw.Content = prog.Value;
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    prog.Value+=1;
        //    alabaw.Content = prog.Value;
        //}



        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //Button button = new Button();
        //    //button.Content = "4";

        //    //stack.Children.Add(button);


        //}



    }
}
