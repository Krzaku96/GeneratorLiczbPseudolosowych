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
            File.WriteAllText("Plik5.txt", string.Empty);
            FileStream fileStream = new FileStream("Plik5.txt", FileMode.OpenOrCreate, FileAccess.Write);
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
            int i, j;
          
 
            this.chart1.Titles.Add("Wykres emipiryczny");
  


            string[] path = File.ReadAllLines(@"Plik5.txt");


            string[] tab = new string[path.Length];
            string[] tab2 = new string[path.Length];
            int licznik = 1; 

            for (i = 0; i < path.Length; i++)
            {

                for (j = 1; j < path.Length; j++)
                {

                    if (path[i] == path[j])
                    {
                        
                        licznik++;
                    }
                 
                }   
                    int x = int.Parse(path[i]);
                    chart1.Series["Series1"].Points.AddXY(x, licznik);
                licznik = 0;
                

            }



        }
    }
}
