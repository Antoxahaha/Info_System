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
    public partial class ChangePhone : Form
    {
        ServiceReference1.Service1Client client;
        public ChangePhone()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
            VonderCode.TextChanged += VonderCode_TextChanged;
        }

        private void VonderCode_TextChanged(object sender, EventArgs e)
        {
            if(VonderCode.Text != "")
            {
                SelectOne();
            }
           
        }

        private async  void SelectOne()
        {
            try
            {
                string kod = VonderCode.Text;
                var result = await client.Select_Comming_Phones_oneAsync(kod);
                namefirm.Text = result[0].NameFirm;
                modelName.Text = result[0].NameModel;
                count.Text = result[0].Count.ToString();
                Instock.Text = result[0].InStock;
                data.Text = result[0].DMY;
                price.Text = result[0].Price;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Upd()
        {
            try
            {
                ServiceReference1.CommingUp r = new ServiceReference1.CommingUp();
                r.NameFirm = namefirm.Text;
                r.NameModel = modelName.Text;
                r.VonderCode = VonderCode.Text;
                r.Count = Convert.ToInt32(count.Text);
                r.InStock = Instock.Text;
                r.DMY = data.Text;
                r.Price = price.Text;
                client.Update_Comming(r.VonderCode, r.NameFirm, r);
                MessageBox.Show("Товар изменен");
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Upd();
        }
    }
}
