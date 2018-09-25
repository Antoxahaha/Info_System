using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockCentralDeskTop
{
    public partial class AddForm : Form
    {
        ServiceReference1.Service1Client client;
        public AddForm()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="" && textBox5.Text!=""&& textBox6.Text!="" && textBox7.Text!="")
            {
                Insert();
                this.Close();
            } else MessageBox.Show("Не все поля заполнены!");
        }
        private void Insert()
        {
               try
               { 
            ServiceReference1.CommingUp r = new ServiceReference1.CommingUp();
               r.NameFirm = textBox1.Text;
            r.NameModel = textBox2.Text;
            r.VonderCode = textBox3.Text;
            r.Count = Convert.ToInt32(textBox4.Text);
            r.InStock = textBox5.Text;
            r.DMY =  textBox6.Text;
            r.Price = textBox7.Text;
            client.Insert_Comming(r);
               }
              catch { MessageBox.Show("Ошибка"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
