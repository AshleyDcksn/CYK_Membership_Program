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
        List<string> rhs = new List<string>(); //Holds right hand side of grammar
        //For row 1 and 2 comparison
        List<string> var_list1 = new List<string>();
        List<string> var_list2 = new List<string>();
        List<string> var_list3 = new List<string>();
        List<string> var_list4 = new List<string>();
        List<string> var_list5 = new List<string>();
        //For row 2 and 3 comparison
        List<string> var_list6 = new List<string>();
        List<string> var_list7 = new List<string>();
        List<string> var_list8 = new List<string>();
        List<string> var_list9 = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "CYK Membership Program";   
        }

        private void Form1_Load(object sender, EventArgs e){         
        }

        private void Form1_Load_1(object sender, EventArgs e){
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear all data structures
            clear_all_data_structures();
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
            fill_in_row_3(sender, word_length);
        
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
                        var_list1.Add(kvp.Key);
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(1, 1)))
                    {
                        X22.Text += kvp.Key;
                        var_list2.Add(kvp.Key);
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(2, 1)))
                    {
                        X33.Text += kvp.Key;
                        var_list3.Add(kvp.Key);
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(3, 1)))
                    {
                        X44.Text += kvp.Key;
                        var_list4.Add(kvp.Key);
                    }
                    if (kvp.Value.Contains(tbWord.Text.ToString().Substring(4, 1)))
                    {
                        X55.Text += kvp.Key;
                        var_list5.Add(kvp.Key);
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
                //Now I want to go through the previous row and check for matches
                X12.Text = "X12 = "; //X12 = X11; X22
                X23.Text = "X23 = "; //X23 = X22; X33
                X34.Text = "X34 = "; //X34 = X33; X44
                X45.Text = "X45 = "; //X44 = X44; X55
                var_list1 = perform_concat(var_list1, var_list2);
                var_list2 = perform_concat(var_list2, var_list3);
                var_list3 = perform_concat(var_list3, var_list4);
                var_list4 = perform_concat(var_list4, var_list5);
                foreach (KeyValuePair<string, string> kvp in dict)
                {
                    
                    foreach (var item in var_list1)
                    {
                        if (kvp.Value.Contains(item))
                        {
                            X12.Text += kvp.Key;
                            var_list6.Add(kvp.Key);
                        }
                    }
                    
                    foreach (var item in var_list2)
                    {
                        if (kvp.Value.Contains(item))
                        {
                            X23.Text += kvp.Key;
                            var_list7.Add(kvp.Key);
                        }
                    }
                   
                    foreach (var item in var_list3)
                    {
                        if (kvp.Value.Contains(item))
                        {
                            X34.Text += kvp.Key;
                            var_list8.Add(kvp.Key);
                        }
                    }
                    
                    foreach (var item in var_list4)
                    {
                        if (kvp.Value.Contains(item))
                        {
                            X45.Text += kvp.Key;
                            var_list9.Add(kvp.Key);
                        }
                    }
                }
                X12.Visible = true;
                X23.Visible = true;
                X34.Visible = true;
                X45.Visible = true;
                
            
            }
        }
        private void fill_in_row_3(object sender, int word_length)
        {
            if (word_length == 5)
            {
                //Go through the previous row and check for matches
                X13.Text = "X13 = "; //X13 = X11X23; X12, X33
                X24.Text = "X24 = ";
                X35.Text = "X35 = ";
                var_list6 = perform_concat(var_list6, var_list7);
                var_list7 = perform_concat(var_list7, var_list8);
                var_list8 = perform_concat(var_list8, var_list9);
                //Clear lists 1,2, 3 to use for fill_in_row_4
                var_list1.Clear();
                var_list2.Clear();
                var_list3.Clear();
                foreach (KeyValuePair<string, string> kvp in dict)
                {

                    foreach (var item in var_list6)
                    {
                        if (kvp.Value.Contains(item))
                        {
                            X13.Text += kvp.Key;
                            var_list1.Add(kvp.Key);
                        }
                    }
                    foreach (var item in var_list7)
                    {
                        if (kvp.Value.Contains(item))
                        {
                            X24.Text += kvp.Key;
                            var_list2.Add(kvp.Key);
                        }
                    }
                    foreach (var item in var_list8)
                    {
                        if (kvp.Value.Contains(item))
                        {
                            X35.Text += kvp.Key;
                            var_list3.Add(kvp.Key);
                        }
                    }

                }
            }
            X13.Visible = true;
            X24.Visible = true;
            X35.Visible = true;
            
        }
        private List<string> perform_concat(List<string> list1, List<string> list2)
        {
            
            List<string> concat_list = new List<string>();
            foreach (var item in list1)
            {
                foreach (var item2 in list2)
                {
                    string items = item + item2;
                    concat_list.Add(items);
                }
            }
            Console.WriteLine("Length of concatted list is:");
            Console.WriteLine(concat_list.Count);
            return concat_list;
        }
        private void clear_all_data_structures()
        { 
            dict.Clear();
            var_list1.Clear();
            var_list2.Clear();
            var_list3.Clear();
            var_list4.Clear();
            var_list5.Clear();
            var_list6.Clear();
            var_list7.Clear();
            var_list8.Clear();
            var_list9.Clear();
            rhs.Clear();

        }
  

    }
}
