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
    public partial class FormAdAddress : Form
    {
        ServiceReference1.Service1Client client;
        public FormAdAddress()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Insert();
            this.Close();
        }
        private void Insert()
        {
            try
            {
                ServiceReference1.AdressesShops r = new ServiceReference1.AdressesShops();
                r.Adress = adr.Text;
                r.Shirota = shir.Text;
                r.Dolgota = dol.Text;
                client.Insert_AddressNew(r);
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
