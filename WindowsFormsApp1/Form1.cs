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
                fdata = float.Parse(fdataz.Text),
                idata = Int32.Parse(idataz.Text)
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
            FileStream fsin = new FileStream(@dir, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fsin);
            try
            {
                using (fsin)
                {
                    br.BaseStream.Seek(index, SeekOrigin.Begin);
                    float fdata = br.ReadSingle();
                    int idata = br.ReadInt32();
                    float vec_x = br.ReadSingle();
                    float vec_y = br.ReadSingle();
                    float vec_z = br.ReadSingle();
                    char cdata = br.ReadChar();
                    char flagdata = br.ReadChar();
                    int MID = br.ReadInt32();
                    int OptionBits = br.ReadInt32();
                    int OptionVals = br.ReadInt32();
                    char tag = br.ReadChar();
                    int Behavior = br.ReadInt32();
                    uint ID = br.ReadUInt32();
                    br.Close();
                    //if(Int32.Parse(textBox3.Text) )
                    label6.Text = "Object Derserialized";
                    fdataz.Text = fdata.ToString();
                    idataz.Text = idata.ToString();
                    vecxz.Text = vec_z.ToString();
                    vecyz.Text = vec_y.ToString();
                    veczz.Text = vec_z.ToString();
                    cdataz.Text = cdata.ToString();
                    MIDz.Text = MID.ToString();
                    OBitz.Text = OptionBits.ToString();
                    OptionValz.Text = OptionVals.ToString();
                    tagz.Text = tag.ToString();
                    Behaviorz.Text = Behavior.ToString();
                    IDz.Text = ID.ToString();
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
                fdata = float.Parse(idataz.Text),
                idata = Int32.Parse(fdataz.Text),
                vdata = new vec_t { x = float.Parse(vecxz.Text), y = float.Parse(vecyz.Text), z = float.Parse(veczz.Text) },
                cdata = cdataz.Text[0],
                flagdata = flagdataz.Text[0],
                MID = Int32.Parse(MIDz.Text),
                OptionBits = Int32.Parse(OBitz.Text),
                OptionVals = Int32.Parse(OptionValz.Text),
                tag = tagz.Text[0],
                Behavior = Int32.Parse(Behaviorz.Text),
                ID = UInt32.Parse(IDz.Text)
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
