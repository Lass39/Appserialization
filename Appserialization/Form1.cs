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
            Voo depar = new Voo("VG456", "CGH", "POA", "14:35", "Varig", "T");
            FileStream fs = new FileStream(@"C:\teste\Voo.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, depar);
            fs.Close();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\teste\Voo.bin");     
            if (fi.Exists)    
            {     
                FileStream fs = new FileStream(@"C:\teste\Voo.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Voo novo = (Voo) bf.Deserialize(fs);  
                fs.Close();  
                textBox1.Text = novo.Codigo + " - " + novo.Origem + " - " + novo.Destino + " - " + novo.Horario + " - " + novo.Compania + " - " + novo.Operando;
            }    
            else 
                textBox1.Text = "Arquivo inexistente.";

     }

        private void button3_Click(object sender, EventArgs e)
        {
            Voo depar = new Voo("AZ002", "VCP", "SSA", "18:00", "Azul", "F");
            FileStream fs = new FileStream(@"C:\teste\Voo.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Voo));
            xs.Serialize(fs, depar);   
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\teste\Voo.xml");
            if (fi.Exists)
            {     
                FileStream fs = new FileStream(@"C:\teste\Voo.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(Voo));
                Voo novo = (Voo)xs.Deserialize(fs);    
                fs.Close();
                textBox1.Text = novo.Codigo + " - " + novo.Origem + " - " + novo.Destino + " - " + novo.Horario + " - " + novo.Compania + " - " + novo.Operando;
            }
            else 
                textBox1.Text = "Arquivo inexistente.";

        }
    }
}
