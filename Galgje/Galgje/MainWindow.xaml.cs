using Galgje.ViewModel;
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

namespace Galgje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyViewModel viewmodel = new MyViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewmodel.Spel;
        }

        private void btnLetter_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            viewmodel.Spel.RaadLetter(btn.Content.ToString().ToLower()[0]);
            txtTeRadenWoord.Text = viewmodel.Spel.SpelerWoord; //mag hier niet staan, zou moeten worden geupdate adhv databinding maar werkt niet voor een of andere reden
        }
    }
}
