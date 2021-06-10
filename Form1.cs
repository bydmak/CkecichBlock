using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBlockCheir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Multiselect = true;
            string lastname = "";
            OPF.Filter = "Файлы dat|*.dat";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                
            }

            string[] lines = File.ReadAllLines(OPF.FileName);
            //StreamWriter f = new StreamWriter("test.txt", true);
            foreach (string i in lines)
            {
               // string pattern = @"\w[name]\w";
                //Regex rg = new Regex(pattern);
                //MatchCollection matchedAuthors = rg.Matches(i);
                //for (int count = 0; count < matchedAuthors.Count; count++)
                //    Console.WriteLine(matchedAuthors[count].Value);

                string str = i;
                string str1 = "name";
                if (str.Contains(str1))
                   // f.WriteLine(str, str1);
                    Console.WriteLine(str);


                lastname = str.Substring(str.IndexOf("name"));
                //f.WriteLine(lastname);
            }

           // Console.WriteLine(lastname);
            label3.Text = lastname;
            label4.Text = OPF.FileName;


        }


    }
}
