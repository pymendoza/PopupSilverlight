using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PopupSilverlight
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void currentUser_Click(object sender, RoutedEventArgs e)
        {
            //userActions.Visibility = Visibility.Visible;
            userActions.IsOpen = !userActions.IsOpen;
        }

        private void userActions_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void userActions_Closed(object sender, EventArgs e)
        {

        }
    }
}
