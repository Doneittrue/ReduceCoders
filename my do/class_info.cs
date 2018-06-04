using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mydo
{
    class class_info
{
        string cname;
        int obj_no;
        int o_n;
        //data_list d;
        int start;
        int end;
        int fun_num;
        int nfun;
        int startclass, endclass;
        public void set_c_name(string c) { cname = c; }
        public string get_c_name() { return cname; }
        public void set_class_start(int s) { startclass = s; }
        public void set_class_end(int e) { endclass = e; }
        public int get_c_start() { return startclass; }
        public int get_c_end() { return endclass; }

        

    }
}
