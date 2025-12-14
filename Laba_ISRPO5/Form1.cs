using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_ISRPO5
{
    public partial class Form1 : Form
    {
        double per;
        bool operan_sloz_vith;
        string result = "";
        
        string st1 = "1";
        string st2 = "2";
        string st3 = "3";
        string st4 = "4";
        string st5 = "5";
        string st6 = "6";
        string st7 = "7";
        string st8 = "8";
        string st9 = "9";
        string st0 = "0";
        public Form1()
        {
            
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            result += st2;
            textBox_Prim.Text = result;

        }

        private void One_Click(object sender, EventArgs e)
        {
            result += st1;
            textBox_Prim.Text = result;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            result += st3;
            textBox_Prim.Text = result;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            result += st4;
            textBox_Prim.Text = result;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            result += st5;
            textBox_Prim.Text = result;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            result += st6;
            textBox_Prim.Text = result;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            result += st7;
            textBox_Prim.Text = result;

        }

        private void Eight_Click(object sender, EventArgs e)
        {
            result += st8;
            textBox_Prim.Text = result;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            result += st9;
            textBox_Prim.Text = result;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            result += st0;
            textBox_Prim.Text = result;
        }

        private void button_Sum_Click(object sender, EventArgs e)
        {
           textBox_Prim.Clear();
           if(result != "")
            {
                operan_sloz_vith = true;
                double localper = double.Parse(result);
                per += localper;
                result = "";
            }
            else
            {

            }
            
               

        }

        private void button_resulit_Click(object sender, EventArgs e)
        {
            if (operan_sloz_vith ==  true) button_Sum_Click(sender, e);
            if (operan_sloz_vith == false) button_razn_Click(sender,e);    
            textBox_Prim.Clear();
            textBox_Prim.Text = per.ToString();
        }
        double vith;
        private void button_razn_Click(object sender, EventArgs e)
        {
            
            
            if (vith != 0)
            {
                per = vith - double.Parse(textBox_Prim.Text);  
            }
            else
            {
                operan_sloz_vith = false;
                vith = double.Parse(textBox_Prim.Text);

            }
                
            textBox_Prim.Clear();
        }
    }
}
