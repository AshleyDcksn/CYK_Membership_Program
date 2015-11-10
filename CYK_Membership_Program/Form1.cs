using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYK_Membership_Program
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "CYK Membership Program";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add input data to dictionary
            Dictionary<string, char[]> dict = new Dictionary<string, char[]>();
            char[] Data1 = tbData1.Text.ToCharArray();
            dict.Add(tbVar1.Text, Data1);
            char[] Data2, Data3, Data4, Data5;
            if (tbData2.Text != "")
            {
                Data2 = tbData2.Text.ToCharArray();
                dict.Add(tbVar2.Text, Data2);
            }
            if (tbData3.Text != "")
            {
                Data3 = tbData3.Text.ToCharArray();
                dict.Add(tbVar3.Text, Data3);
            }
            if (tbData4.Text != "")
            {
                Data4 = tbData4.Text.ToCharArray();
                dict.Add(tbVar4.Text, Data4);
            }
            if (tbData5.Text != "")
            {
                Data5 = tbData5.Text.ToCharArray();
                dict.Add(tbVar5.Text, Data5);
            }
            
            
                
            
        }

    }
}
