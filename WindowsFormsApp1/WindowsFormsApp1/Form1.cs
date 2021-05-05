using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Math;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a=0, b=0, r=0;
        int p = 0;
        bool lamda = false, minus_flag = false;
        string exe = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void refreshminus() {
            minus_flag = false;
            label1.Text = "+";
        }
        private void execlick() {
            if (exe == "")
                a = r;
            else {
                switch (exe) {
                    case "+": a += r;break;
                    case "-": a -= r; break;
                    case "*": a *= r; break;
                    case "/": a /= r; break;
                    case "^": a = Math.Pow(a,r); break;
                    case "S": a = Math.Sqrt(r); break;
                    case "Q": a = r*r; break;
                }
            }
            if (exe != "S" && exe != "Q")
            {
                r = 0;
                lamda = false;
                p = 0;
            }
            else if (exe == "S" || exe == "Q")
            {
                r = a;
                exe = "";
            }
   
            textBox1.Text = a.ToString();
        }
        private void Click1(object sender, EventArgs e)
        {
            
            if (!lamda && p >= 0){
                r *= 10;
                r += 1;
            }
            else if(lamda || p<0){
                p--;
                r += 1 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click2(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 2;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 2 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click3(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 3;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 3 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click4(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 4;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 4 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click5(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 5;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 5 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click6(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 6;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 6 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click7(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 7;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 7 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click8(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 8;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 8 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Clicklambda(object sender, EventArgs e)
        {
            if (!lamda)
                if (r != 0 && p == 0)
                textBox1.Text += ',';
                else textBox1.Text = "0,";
            else
                if(r!=0 && p==0)
                    textBox1.Text = textBox1.Text.Replace(',', '\0');
            lamda = !lamda;

        }

        private void ClickPlus(object sender, EventArgs e)
        {
            if (minus_flag)
            {
                refreshminus();
                r = -r;
            }
            execlick();
            exe = "+";
        }

        private void ClickMinus(object sender, EventArgs e)
        {
            if (minus_flag)
            {
                refreshminus();
                r = -r;
            }
            execlick();
            exe = "-";
        }

        private void ClickMult(object sender, EventArgs e)
        {
            if (minus_flag)
            {
                refreshminus();
                r = -r;
            }
            execlick();
            exe = "*";
        }

        private void ClickDiv(object sender, EventArgs e)
        {
            if (minus_flag)
            {
                refreshminus();
                r = -r;
            }
            execlick();
            exe = "/";
        }

        private void ClickSq(object sender, EventArgs e)
        {
            if (minus_flag)
            {
                refreshminus();
                r = -r;
            }
            exe = "S";
            execlick();
        }

        private void ClickPow(object sender, EventArgs e)
        {
            if (minus_flag)
                r = -r;
            execlick();
            exe = "^";
        }

        private void ClickQ(object sender, EventArgs e)
        {
            if (minus_flag)
            {
                refreshminus();
                r = -r;
            }
            exe = "Q";
            execlick();
        }

        private void ClickCancel(object sender, EventArgs e)
        {
            a = 0; 
            b = 0; 
            r = 0;
            p = 0;
            lamda = false;
            exe = "";
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MinusFlag_Click(object sender, EventArgs e)
        {
            minus_flag = !minus_flag;
            if (minus_flag)
            {
                label1.Text = "-";
            }
            else
            { 
                label1.Text = "+";
            }
        }

        private void ClickEq(object sender, EventArgs e)
        {
            if (minus_flag)
            {
                refreshminus();
                r = -r;
            }
            execlick();
            r = a;
            a = 0;
            b = 0;
            p = 0;
            lamda = false;
            exe = "";
        }

        private void Click9(object sender, EventArgs e)
        {
            if (!lamda && p >= 0)
            {
                r *= 10;
                r += 9;
            }
            else if (lamda || p < 0)
            {
                p--;
                r += 9 * Math.Pow(10, p);
            }
            textBox1.Text = r.ToString();
        }

        private void Click0(object sender, EventArgs e)
        {   
                if (!lamda && p >= 0)
                {
                    r *= 10;
                    r += 0;
                }
                else if (lamda || p < 0)
                {
                    p--;
                    r += 0 * Math.Pow(10, p);
                }
                textBox1.Text = r.ToString();
        }
    }
}
