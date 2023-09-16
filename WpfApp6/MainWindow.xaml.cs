using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp6
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as FrameworkElement;

            if(btn != null)
            {
                switch (btn.Name)
                {
                    case "grid1":
                        Trace.WriteLine("sender grid1");
                        break;
                    case "button1":
                        Trace.WriteLine("sender button");
                        break;
                }
            }

            btn = e.Source as FrameworkElement;

            if (btn != null)
            {
                switch (btn.Name)
                {
                    case "grid1":
                        Trace.WriteLine("e grid1");
                        break;
                    case "button1":
                        Trace.WriteLine("e button");
                        break;
                }
            }
        }
    }
}
