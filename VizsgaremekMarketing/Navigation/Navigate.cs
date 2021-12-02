using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VizsgaremekMarketing.Navigation
{
    public static class Navigate
    {
        public static MainWindow mainWindow;

        public static void Navigation(UserControl userControl)
        {
            mainWindow.PageContent.Children.Add(userControl);
        }
    }
}
