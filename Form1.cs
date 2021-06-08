using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            OPF.Filter = "Файлы dat|*.dat";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                
            }
            string[] lines = File.ReadAllLines(OPF.FileName);
            foreach (string i in lines)
            {
                string str = i;
                string str1 = "name";
                if (str.Contains(str1))
                    Console.WriteLine(str, str1);
            }
        }
    }
}
