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
            dict.Clear();
            lblResults.Text = "Calculating Results...";
            //Add input data to dictionary
            add_input_to_dictionary(sender, e);
            //Perform CYK algorithm
            cyk_Algorithm(sender, e);
                
            
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
        private void cyk_Algorithm(object sender, EventArgs e)
        { 
            //Determine word length
            int word_length = tbWord.TextLength;
            Console.WriteLine(word_length);
            if(word_length < 1)
            {
                MessageBox.Show("Please enter a word to test for membership\n");
                return;
            }
            else
            {
                init_table(sender, word_length);
            }
            fill_in_row_2(sender, word_length);

           
        
        }
        private void init_table(object sender, int word_length)
        {
            if (word_length == 5)
            {
                
                X11.Text = "X11 = ";
                X22.Text = "X22 = ";
                X33.Text = "X33 = ";
                X44.Text = "X44 = ";
                X55.Text = "X55 = ";
                //Search through the dictionary for each letter.     
                foreach (KeyValuePair<string, string> kvp in dict)
                {
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(0, 1)))
                    {
                        X11.Text += kvp.Key;    
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(1, 1)))
                    {
                        X22.Text += kvp.Key;
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(2, 1)))
                    {
                        X33.Text += kvp.Key;
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(3, 1)))
                    {
                        X44.Text += kvp.Key;
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(4, 1)))
                    {
                        X55.Text += kvp.Key;
                    }
                   
                }
                X11.Visible = true;
                X22.Visible = true;
                X33.Visible = true;
                X44.Visible = true;
                X55.Visible = true;
            }
            else if (word_length == 4)
            {
                
            }
            else if (word_length == 3)
            {
                
            }
            
        
        }
        private void fill_in_row_2(object sender, int word_length)
        {
            if (word_length == 5)
            { 
                
            
            }
        }
  

    }
}
