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
using WPFJalon2.ViewModels;

namespace WPFJalon2.Views
{
    /// <summary>
    /// Logique d'interaction pour ListOffre.xaml
    /// </summary>
    public partial class ListOffre : UserControl
    {
        
        public ListOffre()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void LastNameCM_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
