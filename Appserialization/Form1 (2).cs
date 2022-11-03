using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Appserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criação do arquivo 
            Departamento depar = new Departamento(1, "Desenvolvimento de Sistemas de Informação", "DSI");
            FileStream fs = new FileStream(@"C:\teste\Departamento.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, depar);
            fs.Close();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\teste\Departamento.bin");     
            if (fi.Exists)    
            {     
                FileStream fs = new FileStream(@"C:\teste\Departamento.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Departamento novo = (Departamento) bf.Deserialize(fs);  
                fs.Close();  
                textBox1.Text = novo.Codigo + " - " + novo.Nome + " - " + novo.Sigla;
            }    
            else 
                textBox1.Text = "Arquivo inexistente.";

     }

        private void button3_Click(object sender, EventArgs e)
        {
            Departamento depar = new Departamento(2, "Expedição e Recebimento", "EXR");
            FileStream fs = new FileStream(@"C:\teste\Departamento.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Departamento));
            xs.Serialize(fs, depar);   
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\teste\Departamento.xml");
            if (fi.Exists)
            {     
                FileStream fs = new FileStream(@"C:\teste\Departamento.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(Departamento));
                Departamento novo = (Departamento)xs.Deserialize(fs);    
                fs.Close();
                textBox1.Text = novo.Codigo + " - " + novo.Nome + " - " + novo.Sigla;
            }
            else 
                textBox1.Text = "Arquivo inexistente.";

        }
    }
}
