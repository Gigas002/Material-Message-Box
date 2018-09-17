using System;
using System.Windows;

namespace BespokeFusion
{
    /// <summary>
    /// Interaction logic for MessageBoxWindow.xaml
    /// </summary>
    public partial class MessageBoxWindow : IDisposable
    {
        public MessageBoxResult Result { get; private set; }

        public MessageBoxWindow()
        {
            InitializeComponent();
            Result = MessageBoxResult.Cancel;
        }
        private void OkButton_OnClick(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.OK;
            Close();
        }
        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Cancel;
            Close();
        }

        public void Dispose() => Close();

        private void CopyMessageButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Clipboard.SetText(MessageTextBlock.Text);
            }
            catch (ArgumentNullException)
            {
                // ignored
            }
        }
    }
}
