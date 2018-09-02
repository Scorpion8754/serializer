using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public string dir = SelectFile();
        
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                name = textBox1.Text,
                phone = textBox2.Text
            };
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream(dir, FileMode.Create, FileAccess.Write, FileShare.None);
                try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, data);
                    label6.Text = "Object Serialized";
                }
            }
            catch
            {
                label6.Text = "Error";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Data data = new Data();

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsin = new FileStream(@dir, FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    data = (Data)bf.Deserialize(fsin);
                    label6.Text = "Object Derserialized";
                    textBox1.Text = data.name;
                    textBox2.Text = data.phone;
                }
            }
            catch
            {
                label6.Text = "ERROR";
            }
        }

        private static string SelectFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return (ofd.FileName);
                
            else
            {
                return "null";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = dir;
        }
    }
}
