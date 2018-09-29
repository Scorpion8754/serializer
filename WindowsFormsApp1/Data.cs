using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public struct vec_t
    {
        public float x;
        public float y;
        public float z;
    }
    [Serializable]
    public struct Data
    {
        public float fdata;
        public int idata;
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