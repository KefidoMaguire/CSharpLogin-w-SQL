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

            //fsc.UploadFile("ftp://192.168.2.36/", @"C:\Users\kefid\OneDrive\Bilder\dondacover.png",
            //    "ftpserveruser","mygrind400","/abc");

            InitializeComponent();

            textBox1.Text = "a";
            showfiles();
        }

        private void uploudfile_Click(object sender, EventArgs e)
        {

            string fileSelected = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileSelected = openFileDialog1.FileName;

            }
            fsc.UploadFile("ftp://192.168.2.36/", fileSelected, "ftpserveruser", "mygrind400", "/abc");
            textBox1.Clear();
            showfiles();
        }

        private void showfiles()
        {
            foreach (var item in fsc.getAllFTPFiles("ftp://192.168.2.36/abc", "ftpserveruser", "mygrind400"))
            {
                textBox1.Text = textBox1.Text + "\r\n" + item;
            }
        }
    }
}
