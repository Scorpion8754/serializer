﻿using System;
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
            int offset = System.Runtime.InteropServices.Marshal.SizeOf(typeof(GenCapsule)); //get size of struct
            index = Int32.Parse(numericUpDown1.Text);
            int realindex = index * offset;
            FileStream fout = new FileStream(@dir, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fout);
            try
            {
                using (fout)
                {
                    bw.BaseStream.Seek(realindex, SeekOrigin.Begin);

                    label6.Text = "Object Serialized";
                    numericUpDown1.Enabled = true;
                    //float[4]
                    bw.Write(float.Parse(fdataz.Text.ToString()));
                    bw.Write(float.Parse(fdataz.Text.ToString()));
                    bw.Write(float.Parse(fdataz.Text.ToString()));
                    bw.Write(float.Parse(fdataz.Text.ToString()));
                    //int[4]
                    bw.Write(Convert.ToInt32(idataz.Text.ToString()));
                    bw.Write(Convert.ToInt32(idataz.Text.ToString()));
                    bw.Write(Convert.ToInt32(idataz.Text.ToString()));
                    bw.Write(Convert.ToInt32(idataz.Text.ToString()));
                    //vec_t[4]
                    bw.Write(float.Parse(vecxz.Text.ToString()));
                    bw.Write(float.Parse(vecyz.Text.ToString()));
                    bw.Write(float.Parse(veczz.Text.ToString()));
                    bw.Write(float.Parse(vecxz.Text.ToString()));
                    bw.Write(float.Parse(vecyz.Text.ToString()));
                    bw.Write(float.Parse(veczz.Text.ToString()));
                    bw.Write(float.Parse(vecxz.Text.ToString()));
                    bw.Write(float.Parse(vecyz.Text.ToString()));
                    bw.Write(float.Parse(veczz.Text.ToString()));
                    bw.Write(float.Parse(vecxz.Text.ToString()));
                    bw.Write(float.Parse(vecyz.Text.ToString()));
                    bw.Write(float.Parse(veczz.Text.ToString()));
                    //cdata[4][32]
                    string newcdata = cdataz.Text.ToString();
                    for(int i = 0; i < 32 - newcdata.Length; i++)
                    {
                        newcdata = newcdata + "\0";
                    }
                    newcdata += newcdata += newcdata += newcdata;
                    for (int i = 0; i < 128; i++) //4*32 = 128
                        bw.Write(Convert.ToByte(newcdata[i]));
                    //flags
                    bw.Write(Convert.ToByte(cdataz.Text.ToString()[0]));
                    
                    //3 bytes for char* padding
                    byte[] bytes = new byte[] { 1 };
                    bw.Write(bytes);
                    bw.Write(bytes);
                    bw.Write(bytes);
                    //int32
                    bw.Write(Convert.ToInt32(MIDz.Text.ToString()));
                    //int32
                    bw.Write(Convert.ToInt32(OBitz.Text.ToString()));
                    //int[8]
                    string NewInt = OptionValz.Text.ToString() + "\0";
                    NewInt += NewInt += NewInt += NewInt;
                    for (int i = 0; i < 8; i++)
                        bw.Write(Convert.ToInt32(NewInt[i]));
                    //char[8]
                    string NewTag = tagz.Text.ToString();
                    NewTag += NewTag += NewTag += NewTag;
                    for (int i = 0; i < 8; i++)
                        bw.Write(Convert.ToByte(NewTag[i]));
                    //int32
                    bw.Write(Convert.ToInt32(Behaviorz.Text.ToString()));
                    //uint32
                    bw.Write(Convert.ToUInt32(IDz.Text.ToString()));

                    bw.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                label6.Text = "Error";

            }
        }


        unsafe public struct GenCapsule
            {            
            fixed float fdata[4]; //4
            fixed int idata[4]; //4
            fixed float vdata[12]; //4x3
            fixed byte cdata[128]; //4x32
            byte flagdata; //1
            int MID; // 1
            int OptionBits; //1 
            fixed int OptionVals[8]; //8
            fixed byte tag[8]; //8
            int Behavior; //1 
            uint ID; //1
            }


        private void button2_Click(object sender, EventArgs e) //deserialize
        {
            int offset = System.Runtime.InteropServices.Marshal.SizeOf(typeof(GenCapsule)); //get size of struct

            index = Int32.Parse(numericUpDown1.Text);

            int realindex = index * offset;

            FileStream fsin = new FileStream(@dir, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fsin);
            try
            {
                using (fsin)
                {
                    br.BaseStream.Seek(realindex, SeekOrigin.Begin);

                    //float[4]
                    float fdata = br.ReadSingle();
                     fdata = br.ReadSingle();
                     fdata = br.ReadSingle();
                     fdata = br.ReadSingle();

                    //int[4]
                    int idata = br.ReadInt32();
                    idata = br.ReadInt32();
                    idata = br.ReadInt32();
                    idata = br.ReadInt32();

                    //vec_t[4]
                    float vec_x = br.ReadSingle();
                    float vec_y = br.ReadSingle();
                    float vec_z = br.ReadSingle();
                     vec_x = br.ReadSingle();
                     vec_y = br.ReadSingle();
                     vec_z = br.ReadSingle();
                     vec_x = br.ReadSingle();
                     vec_y = br.ReadSingle();
                     vec_z = br.ReadSingle();
                     vec_x = br.ReadSingle();
                     vec_y = br.ReadSingle();
                     vec_z = br.ReadSingle();

                    //cdata[4][32]
                     char[] cdata = new char[128];
                     for (int i = 0; i < 128; i++) //4*32 = 128
                         cdata[i] = Convert.ToChar(br.ReadByte());                        

                    //flags
                     char flagdata = Convert.ToChar(br.ReadByte());

                    //3 bytes for char* padding
                     br.ReadByte();
                     br.ReadByte();
                     br.ReadByte();

                    //int32
                    int MID = br.ReadInt32();

                    //int32
                    int OptionBits = br.ReadInt32();

                    //int[8]
                    int[] OptionVals = new int[8];
                    for (int i = 0; i < 8; i++)
                        OptionVals[i] = br.ReadInt32();

                    //char[8]
                    char[] tag = new char[8];
                    for (int i = 0; i < 8; i++)
                         tag[i] = Convert.ToChar(br.ReadByte());

                    //int32
                    int Behavior = br.ReadInt32();

                    //uint32
                    uint ID = br.ReadUInt32();

                    br.Close();
                    //if(Int32.Parse(textBox3.Text) )
                    label6.Text = "Object Derserialized";
                    fdataz.Text = fdata.ToString();
                    idataz.Text = idata.ToString();
                    vecxz.Text = vec_z.ToString();
                    vecyz.Text = vec_y.ToString();
                    veczz.Text = vec_z.ToString();

                    //char to string
                    String cstr = new String(cdata);

                    cdataz.Text = cstr;
                    flagdataz.Text = flagdata.ToString();

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

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            dir = SelectFile();
        }
    }
}
