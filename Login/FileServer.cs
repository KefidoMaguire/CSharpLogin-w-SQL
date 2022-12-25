using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class Form2 : Form
    {
        FileServerConnect fsc = new FileServerConnect();

        public Form2()
        {

            fsc.UploadFile("ftp://192.168.2.36/", @"C:\Users\kefid\OneDrive\Bilder\dondacover.png",
                "ftpserveruser","mygrind400","/abc");

            InitializeComponent();
        }
    }
}
