using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Site_İp_Öğren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sitetext.Text != "")
            {
                ipögren.Enabled = true;
            
            }
            else
            {
                ipögren.Enabled = false;
              
            }
            if (sitetext.Text != "" && iptext.Text != "")
            {
                ipkaydet.Enabled = true;
            }
            else
            {
                ipkaydet.Enabled = false;
            }



        }

        private void iptext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ipögren_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry site=Dns.GetHostEntry(sitetext.Text);
                IPAddress[]ip=site.AddressList;
                iptext.Text=ip[0].ToString();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                  
        }
    }
}
