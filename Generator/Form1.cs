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

namespace Generator
{
    public partial class Form1 : Form
    {
        int seed;
        int n;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
   
 
        private void button1_Click(object sender, EventArgs e)
        {

            seed = int.Parse(textBox1.Text);
            n = int.Parse(textBox2.Text);

            Generator.Init(seed);

            FileStream fileStream = new FileStream("Plik.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            for(int i=0; i<n; i++)
            {
                int tmp = Generator.LFG();
                string s = tmp.ToString() + " ";
                listBox1.Items.Add(s);
                

            }
            foreach(object o in listBox1.Items)
            {
                streamWriter.WriteLine(o.ToString());
            }

            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();            
        }

        

    }
}
