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
using System.Windows.Forms.DataVisualization.Charting;

namespace Generator
{
    public partial class Form1 : Form
    {
        int seed;
        int n;
        int tmp; 
       


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

            FileStream fileStream = new FileStream("Plik3.txt", FileMode.OpenOrCreate, FileAccess.Write);
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


        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("Plik3.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            // Set title.
            this.chart1.Titles.Add("Wykres emipiryczny");

            string line;
            // Read the file and display it line by line.
            while ((line = streamReader.ReadLine()) != null)
            {
                int i = 1;
                i++;
                // richTextBox1.Text += "\n" + line;
                chart1.Series["Series1"].Points.AddXY(streamReader.ReadLine(), i);

            }
            streamReader.Close();

          

                    
        
        }
    }
}
