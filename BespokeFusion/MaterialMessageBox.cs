using System;
using System.Windows;
using System.Windows.Media;

namespace BespokeFusion
{
    public static class MaterialMessageBox
    {
        /// <summary>
        /// Displays a message box with OK button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="isRtl">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void Show(string message, bool isRtl = false)
        {
            using (MessageBoxWindow msg = new MessageBoxWindow())
            {
                msg.MessageTextBlock.Text = message;
                msg.CancelButton.Visibility = Visibility.Collapsed;
                if (isRtl)
                    msg.FlowDirection = FlowDirection.RightToLeft;
                msg.OkButton.Focus();
                msg.ShowDialog();
            }
        }

        /// <summary>
        /// Displays an error message box
        /// </summary>
        /// <param name="errorMessage">The error error message to display</param>
        /// <param name="isRtl">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        public static void ShowError(string errorMessage, bool isRtl = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.MessageTextBlock.Text = errorMessage;
                    msg.BorderBrush = Brushes.Red;
                    msg.BorderThickness = new Thickness(2, 2, 2, 2);
                    msg.CancelButton.Visibility = Visibility.Collapsed;
                    if (isRtl)
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    msg.OkButton.Focus();
                    msg.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Displays a warning message box
        /// </summary>
        /// <param name="warningMessage">The warning message to display</param>
        public static void ShowWarning(string warningMessage)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.MessageTextBlock.Text = warningMessage;
                    msg.BorderBrush = Brushes.Orange;
                    msg.BorderThickness = new Thickness(2, 2, 2, 2);
                    msg.CancelButton.Visibility = Visibility.Collapsed;
                    msg.OkButton.Focus();
                    msg.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(warningMessage);
            }
        }

        /// <summary>
        /// Displays a message box with a cancel button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="isRtl">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        /// <returns>Message box Result OK or CANCEL</returns>
        public static MessageBoxResult ShowWithCancel(string message, bool isRtl = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.MessageTextBlock.Text = message;
                    if (isRtl)
                        msg.FlowDirection = FlowDirection.RightToLeft;
                    msg.OkButton.Focus();
                    msg.ShowDialog();
                    return msg.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(message);
                return MessageBoxResult.Cancel;
            }
        }

        /// <summary>
        /// Displays a message box with a cancel button
        /// </summary>
        /// <param name="message">The message to display</param>
        /// <param name="isError">If the message is an error</param>
        /// <param name="isRtl">(Optional) If true the MessageBox FlowDirection will be RightToLeft</param>
        /// <returns>Message box Result OK or CANCEL</returns>
        public static MessageBoxResult ShowWithCancel(string message, bool isError, bool isRtl = false)
        {
            try
            {
                using (MessageBoxWindow msg = new MessageBoxWindow())
                {
                    msg.MessageTextBlock.Text = message;
                    msg.BorderBrush = isError
                        ? Brushes.Red
                        : new SolidColorBrush(Color.FromRgb(3, 169, 244));
                    if (isRtl) msg.FlowDirection = FlowDirection.RightToLeft;
                    msg.OkButton.Focus();
                    msg.ShowDialog();
                    return msg.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(message);
                return MessageBoxResult.Cancel;
            }
        }

    }
}
