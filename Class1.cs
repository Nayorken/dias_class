using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diasdevida
{
    class Class1
    {
        private int idade;

        public string recebe
        {
            set
            {
                idade = Convert.ToInt32(value);
                idade = idade * 365;
            }
        }

        public string envia
        {
            get
            {
                return "Já viveu " + idade.ToString() + " dias!";
            }
        }
    }
}
