using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class ModalBox : Form
    {
        public ModalBox()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        public ModalBox(string MessageTitle, string MessageContent)
        {
            InitializeComponent();
            this.MessageTitle = MessageTitle;
            this.MessageContent = MessageContent;
            this.Icon = Properties.Resources.icon;
        }

        public string MessageTitle
        {
            get => MessageTitleLabel.Text;
            set => MessageTitleLabel.Text = value;
        }

        public string MessageContent
        {
            get => MessageContentTextBox.Text;
            set => MessageContentTextBox.Text = value;
        }

        public static void Show(string MessageTitle, string MessageContent)
        {
            Thread Thread = new Thread(() =>
            {
                Application.Run(new ModalBox(MessageTitle, MessageContent));
            });
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
