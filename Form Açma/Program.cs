using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_Açma
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("Form Açılacak...");

            Class1 Form1 = new Class1();
            ListBox list;
            list = new ListBox();
            list.Top = 25;
            list.Left = 25;
            list.Parent = Form1;
            list.Items.Add("Murat");
            list.Items.Add("Ferhat");
            Application.Run(Form1);
        }
    }
}
