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
        //Declare Global vars
        Dictionary<string, string> dict = new Dictionary<string, string>();
        List<string> rhs = new List<string>();
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
            lblResults.Text = "Calculating Results...";
            //Add input data to dictionary
            add_input_to_dictionary(sender, e);
                
            
        }
        private void add_input_to_dictionary(object sender, EventArgs e)
        {
            
            rhs.Add(tbData1.Text.ToString());
            dict.Add(tbVar1.Text, rhs[0]);

            if (tbData2.Text != "")
            {
                rhs.Add(tbData2.Text.ToString());
                dict.Add(tbVar2.Text.ToString(), rhs[1]);
            }
            if (tbData3.Text != "")
            {
                rhs.Add(tbData3.Text.ToString());
                dict.Add(tbVar3.Text.ToString(), rhs[2]);
            }
            if (tbData4.Text != "")
            {
                rhs.Add(tbData4.Text.ToString());
                dict.Add(tbVar4.Text.ToString(), rhs[3]);
            }
            if (tbData5.Text != "")
            {
                rhs.Add(tbData5.Text.ToString());
                dict.Add(tbVar5.Text.ToString(), rhs[4]);
            }
            //DEBUG
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        
        
        }
  

    }
}
