using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Data
    {
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Phone;
        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }
    }
}
