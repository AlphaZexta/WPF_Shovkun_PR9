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

namespace WPF_Shovkun_PR9
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi = (ListBoxItem)(phoneslist.ItemContainerGenerator.ContainerFromIndex(1));

            int len;
            string text;

            if (phoneslist.SelectedItem != null)
            {
                ListBoxItem li = (ListBoxItem)phoneslist.Items[phoneslist.SelectedIndex];
                text = (string)li.Content;
                len = text.Length;

                int count = 0;

                int i = 0;

                while (i < len - 1)
                {
                    if (text[i] == ' ')
                        count++;
                    i++;
                }
                Schet.Text = Convert.ToString(count);
            }

            TextBlock.Text = lbi.Content.ToString();
        }
    }
}
