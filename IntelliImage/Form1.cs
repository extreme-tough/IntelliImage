using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntelliImage
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void buttonAutoIdentify_Click(object sender, EventArgs e)
        {
            ImageParser Parser = new ImageParser();
            Parser.inputSource = inputSource.Text;
            Parser.AutoIdentify();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SourceType.Text = "URL";
        }
    }
}
