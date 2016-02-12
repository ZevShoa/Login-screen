using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_screen
{
    public partial class Form1 : Form
    {
       public static string user = "Bartholomew";
       public static string pass = "abc123";
        public Form1()
        {
           
            InitializeComponent();
            login ln = new login();
            this.Controls.Add(ln);
        }

       

        
    }
}
