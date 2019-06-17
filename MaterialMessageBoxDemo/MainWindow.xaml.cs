using System;
using System.Windows;
using System.Windows.Media;
using BespokeFusion;

namespace MaterialMessageBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow() => InitializeComponent();

        private void ShowSimpleMessageBox_OnClick(object sender, RoutedEventArgs e) =>
            MaterialMessageBox.Show("This is a simple message\n\nIs\'nt it cool\n.\n.\n"
                                  + "You could even scroll!!!\nd\no\no\no\no\no\nw\nn", false);

        private void ShowErrorMessageBox_OnClick(object sender, RoutedEventArgs e) =>
            MaterialMessageBox.ShowError("This is an error message", false);

        private void ShowMessageBoxWithCancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MaterialMessageBox.Show("This is a simple message with a cancel button."
                                                                      + " You can listen to the return value", true);
            TxtResult.Text = $"Message Box Result is: {result}";
        }

        private void ShowCustomMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            //You can create this as a static class and reuse it all over your app
            //Don't forget to specify the BorderThickness if needed
            CustomMaterialMessageBox customMaterialMessageBox = new CustomMaterialMessageBox
            {
                MessageTextBlock = { Text = "Do you like white wine?", Foreground = Brushes.White },
                OkButton = { Content = "Yes" },
                CancelButton = { Content = "Noooo" },
                MainGrid = { Background = Brushes.Red },
                BorderBrush = Brushes.BlueViolet,
                BorderThickness = new Thickness(4, 4, 4, 4)
            };
            customMaterialMessageBox.Show();
            TxtResult.Text = $"Message Box Result is: {customMaterialMessageBox.Result}";
        }

        private void ShowSimpleRTLMessageBox_OnClick(object sender, RoutedEventArgs e) =>
            MaterialMessageBox.Show(
                $"This is a simple message{Environment.NewLine}هذه رسالة بسيطة{Environment.NewLine}{Environment.NewLine}"
              + "Is'nt it cool\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", false, true);
    }
}
