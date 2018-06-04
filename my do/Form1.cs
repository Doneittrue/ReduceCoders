using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydo
{
    public partial class Form1 : Form
    {
        // array of text from TextBox
        TextBox text = new TextBox();
        //true or false for different between input file C++ or Life coding on the TextBox but the code false and else the life codeing will be tru  
        bool live_code = false;
        //to count the line to know you if you in side the class or out Side the class
        int line_count = 0;
        //to know the class when strat
        int line_class_count = 0;
        // array of object form class variable that contain all thing about variable
        variable [] VAR = new variable [100];
        //array of object form class anlysis that contain all thing about class
        class_info [] Class = new class_info [100];
        //to d
        int var_count = 0;
        int class_count = 0;
        //variable shareable that contain the value of var 
        string vname;
        //the class name shareable that contain the value of class name 
        public static int count_clere = 0;
        string nclass;
        //the file shareable i wont to read it and convert it to file
        string fileName;
        //index  shareable that contain the  index of reserved word of the array
        int index;
        //statment shareable that contain the words to make analysis 
        string statment;
        public Form1()
        {
            InitializeComponent();
            //this code for make splash screen
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {//this function that open file and read the txt file
            live_code = false;

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse";
            //Using the verbatim string syntax, the assignment can be altered to
            fdlg.InitialDirectory = @"D:\exp";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if ( fdlg.ShowDialog() == DialogResult.OK )
            {
                fileName = fdlg.FileName;
            }
        }
        //call form to run the splach screan
        public void SplashStart()
        {
            Application.Run(new Form2());
        }
        //shareable reseved words of C++ that make the ability to know the line that contain  
        public static string rv = File.ReadAllText(@"D:\C# ITI\C#work\mydo\RS_WORD.DAT");
        //shareable and the save the reseved word in array and treat with the index of the to know the all line content
        public static string [] words = rv.Split(' ');
        //the shareable to know the line 
        public static int curent_line = 0;
        private void button2_Click_1(object sender, EventArgs e)
        {
            int line_counter = 0;
            if ( live_code == true )
                //to count the all line number
                curent_line++;
            string line;


            if ( live_code == false )// that case in read file
                text.Lines = File.ReadLines(fileName).ToArray();//to read line line to and then treat with it
            else
            {//that case in life coding only
                int z = txtsource.Lines.Length - 2;
                text.Text = txtsource.Lines [z];

            }

            //to know the have content the reserved word or not
            foreach ( var item in text.Lines )
            {
                line_count++;
                if ( item == "" ) continue;
                for ( int i = 0 ; i < words.Length ; i++ )
                {
                    if ( item.Contains(words [i]) && words [i] != "" )
                    { index = i; statment = item; break; }
                }

                //tha switch tell me which function i need to determine and analysis code to jave code 
                vname = "";
                switch ( index )
                {
                    case 17: //double 
                    case 48: //short 
                    case 15: //char 
                    case 25: //float 
                    case 34: //int 
                    case 35: //long 
                    case 89: //string  
                    case 69: //void
                    case 39://const
                        {// that cases that above to determin any variable
                            if ( statment.Contains("main") )
                                main_analysis(statment);
                            else
                                variable_analysis(statment);
                            //   File.AppendAllText("D:\\java.txt", statment + "\r\n");
                        }
                        break;
                    case 9:
                        cin_analysis(statment);//Cin that case to know each var have delaration and go to calss variable to take it and make input in java 
                        break;
                    case 10:
                        cout_analysis(statment);//Cout that make to analysis all var in cout and make anther in jave
                        break;
                    case 7://for
                        for_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 94://{the same thing in the two language C++and Java
                        if ( live_code == false )
                            File.AppendAllText("D:\\java.txt", "{\r\n");
                        else
                            txtresult.Text = txtresult.Text + "{\r\n";
                        break;
                    case 78://}
                            // the same thing in the two language C++and Java but i wont to know the class or for or while ...
                            //class
                        if ( live_code == false )
                            if ( statment.Contains(";") )
                            {
                                if ( pub.inside_class == true )
                                    pub.inside_class = false;
                                pub.class_list [pub.no_class].set_class_end(line_counter);
                                /*1*/
                                File.AppendAllText("D:\\java.txt", "}\r\n");
                            }
                            else
                                File.AppendAllText("D:\\java.txt", "}\r\n");
                        else
                        {
                            if ( statment.Contains(";") )
                            {
                                if ( pub.inside_class == true )
                                    pub.inside_class = false;
                                pub.class_list [pub.no_class--].set_class_end(line_counter);
                                txtresult.Text = txtresult.Text + "}\r\n";
                            }
                            else
                                txtresult.Text = txtresult.Text + "}\r\n";
                        }
                        break;

                    case 18:
                        do_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 73:
                        while_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 32:
                        if_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 20:
                        else_analysis(statment);//the same thing in the two language C++and Java
                        break;

                    case 54:
                        switch_analysis(statment);// the same thing in the two language C++and Java
                        break;
                    case 4:
                        break_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 5:
                        case_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 16:
                        default_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 8://class to detemine all thig about the class strat end to determine the object
                           /*  File.AppendAllText("D:\\java.txt", "{\r\n");
                           else
                               txtresult.Text = txtresult.Text + "{\r\n";

                           */
                        if ( live_code == false )
                        {
                            File.AppendAllText("D:\\java.txt", statment + "\r\n");
                            //line_class_count = line_count;
                            pub.inside_class = true;
                            pub.class_list [pub.no_class++] = new class_info();
                            class_analysis(statment, line_counter);
                        }
                        else
                        {
                            txtresult.Text = txtresult.Text + statment + "\r\n";
                            pub.inside_class = true;
                            pub.class_list [pub.no_class++] = new class_info();
                            class_analysis(statment, line_counter);
                        }
                        break;
                    //case 97://(
                    //  case 87://

                    //  break;
                    case 47:
                        return_analysis(statment); //the same thing in the two language C++and Java
                        break;
                    //  case 98:
                    //       Array_analysis(statment);
                    //       break;
                    //break;
                    //    case 97:
                    //      break;
                    case 1://one line comment
                        linecomm_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 102:
                        ///   case 103:          
                        multiple_line_analysis(statment);//the same thing in the two language C++and Java
                        break;
                    case 80://->//object for all thing
                    case 92://   ;
                        object_analysis(statment);

                        break;
                    case 82://.
                        object_fun_analysis(statment);
                        break;
                    default:
                        constractor_class(statment);


                    break;

                }
            }
        }



        /// <summary>
        ///  variable_analysis
        /// </summary>
        /// <param name="st"></param>

        private void variable_analysis(string st)//float x;
        {

            int ind = st.IndexOf(' ');
            string vtype = st.Substring(0, ind);
            st = st.Substring(ind);


            int i = 0;

            vname = "";
            while ( st [i] != ';' && st [i] != '[' && st [i] != '(' )
            {
                if ( st [i] != ',' )
                    vname += st [i++].ToString();
                else
                {

                    VAR [var_count] = new variable();
                    VAR [var_count].set_name(vname);
                    VAR [var_count++].set_type(vtype);
                    vname = "";
                    i++;

                }


            }
            VAR [var_count] = new variable();
            VAR [var_count].set_name(vname);
            VAR [var_count++].set_type(vtype);
            if ( !st.Contains("[")/* && st[i] != '='*/&& st.Contains("(") ) //for function
            {
                // call_fun_analysis(statment);
                if ( st.Contains("(") && st.Contains("=") )
                {
                    if ( live_code == false )
                        File.AppendAllText("D:\\java.txt", statment + "\r\n");
                    else
                        txtresult.Text = statment + "\r\n";

                }
                else
                {

                    if ( live_code == false )
                        if ( pub.inside_class )
                            File.AppendAllText("D:\\java.txt", "public" + statment + "\r\n");
                        else
                            txtresult.Text += "public" + statment + "\r\n";
                    else
                    if ( live_code == false )
                        File.AppendAllText("D:\\java.txt", "public static " + statment + "\r\n");
                    else
                        txtresult.Text += "public static " + statment + "\r\n";
                }
            }
            else if ( st.Contains("[") )
            {
                string arrsize = "";
                while ( st [i] != ']' )
                {
                    arrsize += st [i];
                    i++;
                }
                int newcount = var_count - 1;

                if ( live_code == false )
                    if ( pub.inside_class )
                        File.AppendAllText("D:\\java.txt", "public " + VAR [newcount].get_type().Trim() + "[] " + VAR [newcount].get_name().Trim() + "= new " + VAR [newcount].get_type().Trim() + arrsize + "]" + "\r\n");

                    else
                        File.AppendAllText("D:\\java.txt", VAR [newcount].get_type().Trim() + "[] " + VAR [newcount].get_name().Trim() + "= new " + VAR [newcount].get_type().Trim() + arrsize + "]" + "\r\n");
                else
                    txtresult.Text += VAR [newcount].get_type().Trim() + "[] " + VAR [newcount].get_name().Trim() + "= new " + VAR [newcount].get_type().Trim() + arrsize + "]" + "\r\n";

            }
            else

            if ( live_code == false )
                if ( pub.inside_class )
                    File.AppendAllText("D:\\java.txt", "public" + statment + "\r\n");

                else
                    File.AppendAllText("D:\\java.txt", statment + "\r\n");
            else
                txtresult.Text += statment + "\r\n";

            // File.AppendAllText("D:\\java.txt", VAR[var_count-1].get_type().Trim() + " " + VAR[var_count-1].get_name().Trim() + ";" + "\r\n");


        }
        /// <summary>
        /// cin_analysis
        /// </summary>
        /// <param name="st"></param>

        private void cin_analysis(string st)
        {//Scanner sc = new Scanner(System.in);
            //   float age = sc.nextFloat();



            // var map2 = new Dictionary<string, string> { { "cin", "Scanner sc=new Scanner(System.in);" } };

            //  var lines = map2.Select(kvp => kvp.Value.ToString()); 
            //    string newstr = string.Join(Environment.NewLine, lines);


            //string new_statment = "";
            int ind = st.IndexOf('>');
            st = st.Substring(ind + 2);
            int i = 0;

            vname = "";
            while ( st [i] != ';' )
            {
                if ( st [i] == ' ' ) { i++; continue; }
                if ( st [i] != '>' )
                    vname += st [i++].ToString();
                else
                {
                    //vname += " = sc.nextfloat(); ";

                    for ( int iii = 0 ; iii < var_count ; iii++ )
                    {
                        if ( VAR [iii].get_name().Trim() == vname.Trim() )
                        {
                            string vtype = VAR [iii].get_type();
                            if ( vtype.Contains("string") || vtype.Contains("char") )
                                vname += " = sc.next();";
                            else
                            {
                                vtype = vtype.First().ToString().ToUpper() + vtype.Substring(1);
                                vname += " = sc.next" + vtype + "();";
                            }

                        }

                    }
                    if ( live_code == false )
                        File.AppendAllText("e:\\java.txt", vname + "\r\n");
                    else txtresult.Text = txtresult.Text + vname + "\r\n";
                    vname = ""; i += 2;

                }

            }
            for ( int iii = 0 ; iii < var_count ; iii++ )
            {
                if ( VAR [iii].get_name().Trim() == vname.Trim() )
                {
                    string vtype = VAR [iii].get_type();
                    if ( vtype.Contains("string") || vtype.Contains("char") )
                        vname += " = sc.next();";
                    else
                    {
                        vtype = vtype.First().ToString().ToUpper() + vtype.Substring(1);
                        vname += " = sc.next" + vtype + "();";
                    }

                }

            }
            if ( live_code == false )
                File.AppendAllText("e:\\java.txt", vname + "\r\n");
            else
                txtresult.Text = txtresult.Text + vname + "\r\n";






            //for (int ii = 0; ii < var_count; ii++)
            //{
            //    File.AppendAllText("e:\\java.txt", VAR[ii].get_type() + " " + + ";" + "\r\n");
            //}

        }


        /// <summary>
        /// cout_analysis
        /// </summary>
        /// <param name="st"></param>



        private void cout_analysis(string st)
        {
            int found_var = 0;
            string new_statment = "system.out.println(";
            int ind = st.IndexOf('<');
            int ind_cot = st.LastIndexOf('"');
            st = st.Substring(ind + 2);
            //  st = st.Substring(ind_cot);
            int i = 0;
            // int c = 0;
            vname = "";
            while ( st [i] != ';' )
            {
                //  if (st[i] == ' ') { i++; continue; }
                if ( st [i] != '<' )
                    vname += st [i++].ToString();
                else
                {
                    vname += " +\" \"+ ";
                    new_statment += vname;
                    vname = ""; i += 2;
                    found_var++;
                }

            }
            if ( !vname.Contains("endl") )
                new_statment += vname + "+";
            //  if (found_var == 1)
            //     File.AppendAllText("e:\\java.txt", new_statment+st + "\r\n");
            //  else
            //   {
            int ind1 = new_statment.LastIndexOf('+');
            new_statment = new_statment.Remove(ind1);
            new_statment += ");";
            if ( live_code == false )
                File.AppendAllText("e:\\java.txt", new_statment + "\r\n");
            else
                txtresult.Text = txtresult.Text + new_statment + "\r\n";
        }
        private void for_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";
        }
        private void constractor_class(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";
        }

        private void do_analysis(string st)
        {

            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";
        }

        private void while_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }
        private void if_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }

        private void else_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }
        private void switch_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }
        private void break_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }
        private void case_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }
        private void default_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }
        private void main_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", "public static void main(String[] args)" + "{\r\n" + "Scanner sc=new Scanner(System.in);");
            else
                txtresult.Text = "public static void main(String[] args)" + "{ \r\n" + "Scanner sc=new Scanner(System.in);";

        }

        private void call_fun_analysis(string st)
        {
            if ( st.Contains("(") && st.Contains("=") )
            {
                if ( live_code == false )
                    File.AppendAllText("D:\\java.txt", st + "\r\n");
                else
                    txtresult.Text = txtresult.Text + st + "\r\n";
            }

        }




        private void return_analysis(string st)
        {
            if ( !st.Contains("0") )
                if ( live_code == false )
                    File.AppendAllText("D:\\java.txt", st + "\r\n");
                else
                    txtresult.Text = txtresult.Text + st + "\r\n";



        }

        private void linecomm_analysis(string st)
        {
            if ( live_code == false )

                File.AppendAllText("D:\\java.txt", st + "\r\n");

            else
                txtresult.Text = txtresult.Text + st + "\r\n";


        }
        private void object_fun_analysis(string st)
        {
            if ( live_code == false )
                File.AppendAllText("D:\\java.txt", st + "\r\n");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";

        }
        private void multiple_line_analysis(string st)
        {
            if ( live_code == false )

                File.AppendAllText("D:\\java.txt", st + "\r\n" + "*/");
            else
                txtresult.Text = txtresult.Text + st + "\r\n";


        }
        private void class_analysis(string st, int count_c)
        {
            int ind = st.IndexOf(' ');
            string C_declar = st.Substring(0, ind);
            st = st.Substring(ind);
            string C_name = st;

            pub.class_list [--pub.no_class].set_class_start(count_c);
            pub.class_list [pub.no_class].set_c_name(C_name);
            // pub.class_list[pub.no_class].set_cons_end(st);
            ///////////////////////////




        }

        private void object_analysis(string st)
        {
            string O_declar_main = "";
            int ind = st.IndexOf(' ');
            string C_declar_main = st.Substring(0, ind);
            st = st.Substring(ind);
            //  MessageBox.Show(st);
            O_declar_main += st.TrimEnd(';');
            if ( live_code == false )

                File.AppendAllText("D:\\java.txt", C_declar_main + " " + O_declar_main + "= new " + C_declar_main + "();" + "\r\n");

            else
                txtresult.Text = txtresult.Text + C_declar_main + " " + O_declar_main + "= new " + C_declar_main + "();" + "\r\n" + "\r\n";






        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }



        private void txtsource_TextChanged(object sender, EventArgs e)
        {
            foreach ( var line in txtsource.Lines )
            {
                if ( line.Contains("//") )
                {
                    var matchString = Regex.Escape(line);
                    foreach ( Match match in Regex.Matches(txtsource.Text, matchString) )
                    {
                        txtsource.Select(match.Index, line.Length);
                        txtsource.SelectionColor = Color.Green;
                        txtsource.Select(txtsource.TextLength, 0);
                        txtsource.SelectionColor = txtsource.ForeColor;
                    }
                }
                else
                {
                    string [] elem = line.Split(' ');
                    foreach ( var item in elem )
                    {
                        if ( words.Contains(item) )
                        {
                            var matchString = Regex.Escape(item);
                            foreach ( Match match in Regex.Matches(txtsource.Text, matchString) )
                            {
                                txtsource.Select(match.Index, item.Length);
                                txtsource.SelectionColor = Color.Blue;
                                txtsource.Select(txtsource.TextLength, 0);
                                txtsource.SelectionColor = txtsource.ForeColor;
                            }

                        }
                    }
                }
            }
            //   string rv = File.ReadAllText(@"D:\C# ITI\C#work\mydo\RS_WORD.DAT");
            //  string[] words = rv.Split(' ');
            //foreach (string item in words)
            //{
            //    if (!(item.Contains("/")) && !(item.Contains("{")) && !(item.Contains("}")))
            //    {
            //        string find = item;
            //        if (txtsource.Text.Contains(find))
            //        {

            //            var matchString = Regex.Escape(find);
            //            foreach (Match match in Regex.Matches(txtsource.Text, matchString))
            //            {
            //                txtsource.Select(match.Index, find.Length);
            //                txtsource.SelectionColor = Color.Blue;
            //                txtsource.Select(txtsource.TextLength, 0);
            //                txtsource.SelectionColor = txtsource.ForeColor;
            //            }
            //           // break;
            //        }

            //    }
            //   /* else if (item.Contains("//"))
            //    {
            //        string find = item;
            //        if (txtsource.Text.Contains(find))
            //        {
            //            var matchString = Regex.Escape(find);
            //            foreach (Match match in Regex.Matches(txtsource.Text, matchString))
            //            {
            //                txtsource.Select(match.Index, find.Length);
            //                txtsource.SelectionColor = Color.Green;
            //                txtsource.Select(txtsource.TextLength, 0);
            //                txtsource.SelectionColor = txtsource.ForeColor;
            //            };
            //        }
            //    }*/
            //}
        }

        private void txtsource_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            live_code = true;

            if ( e.KeyChar.ToString() == "\r" )
            {
                button2_Click_1(null, null);
            }
            String s = e.KeyChar.ToString();

     }
        
       
        
       
        private void ZoomIn_Click_1(object sender, EventArgs e)
        {
            txtsource.ZoomFactor += Convert.ToSingle(0.1);


        }

        private void ZoomOut_Click_1(object sender, EventArgs e)
        {
            txtsource.ZoomFactor -= Convert.ToSingle(0.1);

        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            txtsource.Clear();
            txtresult.Clear();

        }

        private void RedoText_Click_1(object sender, EventArgs e)
        {
            //check to see if last action can be redone
            if ( txtsource.CanRedo == true )
            {
                txtsource.Redo();

            }
        }

        private void UndoText_Click_1(object sender, EventArgs e)
        {
            //check to see if last action can be undone
            if ( txtsource.CanUndo == true )
            {
                txtsource.Undo();

            }
        }

        private void PasteText_Click_1(object sender, EventArgs e)
        {
            txtsource.Text = Clipboard.GetText();

        }

        private void CopyText_Click_1(object sender, EventArgs e)
        {
            if ( txtresult.Text != "" )
            {
                Clipboard.SetText(txtresult.Text);
            }
        }

        private void txtsource_HideSelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsource.Text = "write you c++ code here!!";
            count_clere++;
        }

        private void txtsource_MouseClick(object sender, MouseEventArgs e)
        {
            if ( count_clere == 1 ) 
                txtsource.Text = "";
            count_clere++;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}//}
