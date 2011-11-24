using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Giffy
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdImageFile.ShowDialog();
            Stream stream;
            byte[] bytes = new byte[32];
            int byteIn;
            int i;

            if (!(result == DialogResult.OK))
                MessageBox.Show("error opening file!");
            stream = ofdImageFile.OpenFile();

            for (i=0; i < 32; i++)
            {
                byteIn = stream.ReadByte();
                if (byteIn >= 0)
                {
                    bytes[i] = (byte)byteIn;
                }
            }
        }

        private void txtContentBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("changed: " + txtContentBox.Text);
            
        }
    }
}
