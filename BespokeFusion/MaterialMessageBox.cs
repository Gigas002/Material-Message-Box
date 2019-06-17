using System;
using System.Windows;
using System.Windows.Media;

namespace BespokeFusion
{
    public static class MaterialMessageBox
    {
        /// <summary>
        /// Shows usual message box.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="isCancel">Is cancel button visible?</param>
        /// <param name="isRightToLeft">(Optional) Is <see cref="FlowDirection"/>=<see cref="FlowDirection.RightToLeft"/>?</param>
        /// <returns>Message box result. <see cref="MessageBoxResult.Cancel"/> if <see cref="Exception"/> is thrown.</returns>
        public static MessageBoxResult Show(string message, bool isCancel, bool isRightToLeft = false)
        {
            try
            {
                using (MessageBoxWindow messageBoxWindow = new MessageBoxWindow())
                {
                    messageBoxWindow.MessageTextBlock.Text = message;
                    messageBoxWindow.CancelButton.Visibility = isCancel ? Visibility.Visible : Visibility.Collapsed;
                    messageBoxWindow.FlowDirection = isRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
                    messageBoxWindow.OkButton.Focus();
                    messageBoxWindow.ShowDialog();
                    return messageBoxWindow.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                return MessageBoxResult.Cancel;
            }
        }

        /// <summary>
        /// Shows an error message box.
        /// </summary>
        /// <param name="errorMessage">The error error message to display.</param>
        /// <param name="isCancel">Is cancel button visible?</param>
        /// <param name="isRightToLeft">(Optional) Is <see cref="FlowDirection"/>=<see cref="FlowDirection.RightToLeft"/>?</param>
        /// <returns>Message box result. <see cref="MessageBoxResult.Cancel"/> if <see cref="Exception"/> is thrown.</returns>
        public static MessageBoxResult ShowError(string errorMessage, bool isCancel, bool isRightToLeft = false)
        {
            try
            {
                using (MessageBoxWindow messageBoxWindow = new MessageBoxWindow())
                {
                    messageBoxWindow.BorderBrush = Brushes.Red;
                    messageBoxWindow.BorderThickness = new Thickness(2, 2, 2, 2);

                    messageBoxWindow.MessageTextBlock.Text = errorMessage;
                    messageBoxWindow.CancelButton.Visibility = isCancel ? Visibility.Visible : Visibility.Collapsed;
                    messageBoxWindow.FlowDirection = isRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
                    messageBoxWindow.OkButton.Focus();
                    messageBoxWindow.ShowDialog();
                    return messageBoxWindow.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                return MessageBoxResult.Cancel;
            }
        }

        /// <summary>
        /// Shows a warning message box.
        /// </summary>
        /// <param name="warningMessage">The warning message to display.</param>
        /// <param name="isCancel">Is cancel button visible?</param>
        /// <param name="isRightToLeft">(Optional) Is <see cref="FlowDirection"/>=<see cref="FlowDirection.RightToLeft"/>?</param>
        /// <returns>Message box result. <see cref="MessageBoxResult.Cancel"/> if <see cref="Exception"/> is thrown.</returns>
        public static MessageBoxResult ShowWarning(string warningMessage, bool isCancel, bool isRightToLeft = false)
        {
            try
            {
                using (MessageBoxWindow messageBoxWindow = new MessageBoxWindow())
                {
                    messageBoxWindow.BorderBrush = Brushes.Orange;
                    messageBoxWindow.BorderThickness = new Thickness(2, 2, 2, 2);

                    messageBoxWindow.MessageTextBlock.Text = warningMessage;
                    messageBoxWindow.CancelButton.Visibility = isCancel ? Visibility.Visible : Visibility.Collapsed;
                    messageBoxWindow.FlowDirection = isRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
                    messageBoxWindow.OkButton.Focus();
                    messageBoxWindow.ShowDialog();
                    return messageBoxWindow.Result == MessageBoxResult.OK ? MessageBoxResult.OK : MessageBoxResult.Cancel;
                }
            }
            catch (Exception)
            {
                return MessageBoxResult.Cancel;
            }
        }
    }
}
