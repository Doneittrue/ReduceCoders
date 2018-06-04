using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mydo
{

    class variable
    {
        string type;
        string name;

        public void set_type(string type)
        {
            this.type = type;

        }
        public void set_name(string name)
        {
            this.name = name;

        }
        public string get_type()
        {
            return type.ToString();
        }

        public string get_name()
        {
            return name.ToString();
        }


    }
}
