using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorldGit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void mainPaneRadioButton_Click(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                switch (radioButton.Tag.ToString())
                {
                    case "Hello":
                        break;
                    case "Search":
                        break;
                    case "Settings":
                        break;
                    case "About":
                        break;
                }
            }
        }

        private void HambergerButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = MainSplitView.IsPaneOpen ? false : true;
        }

    }
}