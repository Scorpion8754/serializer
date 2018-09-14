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
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string dir = SelectFile();
        private int index;
        private List<Data> itemz = new List<Data>();


        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                fdata = float.Parse(fdata.Text),
                idata = Int32.Parse(idata.Text)
            };
            itemz[index] = data;
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream(dir, FileMode.Create, FileAccess.Write, FileShare.None);
                try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, itemz);
                    label6.Text = "Object Serialized";
                    numericUpDown1.Enabled = true;
                }
            }
            catch
            {
                label6.Text = "Error";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = Int32.Parse(numericUpDown1.Text);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream(@dir, FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    itemz = ((List<Data>)bf.Deserialize(fsin));
                    //if(Int32.Parse(textBox3.Text) )
                    label6.Text = "Object Derserialized";
                    fdata.Text = itemz[index].fdata.ToString();
                    idata.Text = itemz[index].idata.ToString();
                    vecx.Text = itemz[index].vdata.x.ToString();
                    vecy.Text = itemz[index].vdata.y.ToString();
                    vecz.Text = itemz[index].vdata.z.ToString();
                    cdata.Text = itemz[index].cdata.ToString();
                    MID.Text = itemz[index].MID.ToString();
                    OBits.Text = itemz[index].OptionBits.ToString();
                    OptionVals.Text = itemz[index].OptionVals.ToString();
                    tag.Text = itemz[index].tag.ToString();
                    Behavior.Text = itemz[index].Behavior.ToString();
                    ID.Text = itemz[index].ID.ToString();
                    numericUpDown1.Enabled = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                fdata = float.Parse(idata.Text),
                idata = Int32.Parse(fdata.Text),
                vdata = new vec_t { x = float.Parse(vecx.Text), y = float.Parse(vecy.Text), z = float.Parse(vecz.Text) },
                cdata = cdata.Text[0],
                flagdata = flagdata.Text[0],
                MID = Int32.Parse(MID.Text),
                OptionBits = Int32.Parse(OBits.Text),
                OptionVals = Int32.Parse(OptionVals.Text),
                tag = tag.Text[0],
                Behavior = Int32.Parse(Behavior.Text),
                ID = UInt32.Parse(ID.Text)
            };
            itemz.Add(data);
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream(dir, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, itemz);
                    label6.Text = "Object Serialized";
                }
            }
            catch
            {
                label6.Text = "Error";

            }
        }
    }
}
