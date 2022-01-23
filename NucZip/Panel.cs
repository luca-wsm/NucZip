using NucZip.Constants;
using NucZip.Services;
using System;
using System.Threading;
using System.Windows.Forms;

namespace NucZip
{
    public partial class Panel : Form
    {
        private protected MessageBoxService _messageBoxService;
        private protected CrackingService _crackingService;
        private Thread crackThread;

        public Panel()
        {
            InitializeComponent();
            InitServices();
        }

        private void InitServices()
        {
            _messageBoxService = new MessageBoxService();
            _crackingService = new CrackingService();
        }

        private void zipFileBtn_Click(object sender, EventArgs e)
        {
            chooseZipDialog.ShowDialog();
        }

        private void wordListBtn_Click(object sender, EventArgs e)
        {
            chooseWordlistDialog.ShowDialog();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(chooseZipDialog.FileName) && !string.IsNullOrEmpty(chooseWordlistDialog.FileName) && !string.IsNullOrEmpty(outputFolderDialog.SelectedPath))
            {
                logBox.Items.Clear();
                startBtn.Enabled = false;
                crackThread = new Thread(Run);
                crackThread.IsBackground = true;
                crackThread.Start();
            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_OUTPUT_ERROR);
            }
        }

        private void outputFolderBtn_Click(object sender, EventArgs e)
        {
            outputFolderDialog.ShowDialog();
        }

        /// <summary>
        /// Method to start the cracking service.
        /// The delay will be rounded to a full integer.
        /// </summary>
        private void Run()
        {
            int delay = Convert.ToInt32(Math.Round(delayUpDown.Value, 0));
            _crackingService.Start(chooseZipDialog.FileName, outputFolderDialog.SelectedPath, chooseWordlistDialog.FileName, delay);
        }

        /// <summary>
        /// A method for adding a item entry to the logBox for the cracking thread.
        /// </summary>
        /// <param name="item">The item that will be added to the logbox</param>
        public void AddItems(string item)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate { this.AddItems(item); });
                    return;
                }
                logBox.Items.Add(item);
                logBox.SelectedIndex = logBox.Items.Count - 1;
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// A method for enabling the start button for the cracking thread.
        /// </summary>
        public void EnableStartButton()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate { this.EnableStartButton(); });
                    return;
                }
                startBtn.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
    }
}
