using AsterNET.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Asterisk.NET.WinForm
{
    public partial class PhoneConfirmation : Form
    {
        private string confirm_num;
        private FormMain _parent;
        public PhoneConfirmation(MatchCollection mc, FormMain parent)
        {
            InitializeComponent();
            if (parent == null) throw new NullReferenceException("Can't be NULL!!!"); // check clause
            _parent = parent; // assign the ref of the parent
            foreach (Match m in mc)
                if (m.Groups[1].Value == "NUMBER")
                    this.confirm_num = Encoding.UTF8.GetString(Convert.FromBase64String(m.Groups[2].Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != confirm_num)
                MessageBox.Show("Incorrect confirmation number");
            else
            {
                
                _parent.setConfirmState(true);
                this.Close();
            }
        }

        

        private void PhoneConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
