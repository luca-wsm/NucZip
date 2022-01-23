using NucZip.Constants;
using System.Windows.Forms;

namespace NucZip.Services
{
    /// <summary>
    /// A service for sending messageboxes
    /// </summary>
    public enum MessageBoxType
    {
        WARNING,
        INFORMATION,
        ERROR,
    }
    public class MessageBoxService
    {
        /// <summary>
        /// Sending a messagebox to the user
        /// </summary>
        /// <param name="type">The messageboxtype <example>MessageBoxType.WARNING</example></param>
        /// <param name="message">The message showed in the messagebox</param>
        public void Send(MessageBoxType type, string message)
        {
            switch (type)
            {
                case MessageBoxType.WARNING:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case MessageBoxType.INFORMATION:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MessageBoxType.ERROR:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
