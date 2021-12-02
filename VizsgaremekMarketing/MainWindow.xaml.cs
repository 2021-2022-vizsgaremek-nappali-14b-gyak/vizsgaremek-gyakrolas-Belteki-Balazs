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
using VizsgaremekMarketing.Navigation;
using VizsgaremekMarketing.Pages;

namespace VizsgaremekMarketing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //Statikus osztály a Navigate
            //Eltárolja a nyitó ablakot, hogy azon tudjuk módosítani a pageket.
            Navigate.mainWindow = this;
            WelcomePage welcomePage = new WelcomePage();
            Navigate.Navigation(welcomePage);
        }
    }
}
