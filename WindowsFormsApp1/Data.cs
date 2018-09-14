using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public struct vec_t {
        public float x;
        public float y;
        public float z;
    }
    [Serializable]
    public struct Data
    {
        private float Fdata;
        public float fdata
        {
            get { return Fdata; }
            set { Fdata = value; }
        }
    
        private int Idata;
        public int idata
        {
            get { return Idata; }
            set { Idata = value; }
        }


        public vec_t vdata;
        public char cdata;
        public char flagdata;
        public int MID;
        public int OptionBits;
        public int OptionVals;
        public char tag;
        public int Behavior;
        public uint ID;
    }
}
