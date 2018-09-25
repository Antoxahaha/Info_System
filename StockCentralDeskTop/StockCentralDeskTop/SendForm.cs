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
    public partial class SendForm : Form
    {
        int counts =0;
        public string[] str = new string[7];
        string[] shirota;
        string[] dolgota;
        ServiceReference1.Service1Client client;
        public SendForm()
        {
            InitializeComponent();        
            client = new ServiceReference1.Service1Client();
            comboInit();
        }

        private void refreshcombo_Click(object sender, EventArgs e)
        {
            comboShops.Items.Clear();
            comboInit();
        }

        private void addShops_Click(object sender, EventArgs e)
        {
            FormAdAddress ash = new FormAdAddress();
            ash.Show();
        }

        private void SendPhones_Click(object sender, EventArgs e)
        {
            if (comboShops.SelectedIndex != -1 && name.Text != "" && model.Text != "" && art.Text != "" && kol.Text != "")
            {
               int  y = Convert.ToInt32(kol.Text);    
                 int x = counts - y;
                if ((counts > 0 || x > 0 ) && y>0)
                {
                    Upd();
                   Sendphones();
                    this.Close();
                }
                else MessageBox.Show("Согласуйте количество отправленного товара с количеством в наличии");
            
            }
            else MessageBox.Show("Не все параметры установлены");
        }
        private async void comboInit()
        {
            var result = await client.Select_AdressesShopsAsync();
            shirota = new string[result.Length];
            dolgota = new string[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                comboShops.Items.Add(result[i].Adress);
                shirota[i] = result[i].Shirota;
                dolgota[i] = result[i].Dolgota;
            }
            counts = Convert.ToInt32(kol.Text);
        }
        private void Sendphones()
        {
            try
            {
                ServiceReference1.Sending r = new ServiceReference1.Sending();
                r.NameFirm = name.Text;
                r.NameModel = model.Text;
                r.VonderCode = art.Text;
                r.Count = Convert.ToInt32(kol.Text);
                r.Address = comboShops.SelectedItem.ToString(); ;
                r.Shirota = shirota[comboShops.SelectedIndex];
                r.Dolgota = dolgota[comboShops.SelectedIndex];
                r.Status = "Отправлено";
                r.TimeOfSend = "Не получено";
                client.Insert_SendingPhone(r);
            }
            catch { MessageBox.Show("Ошибка"); }

        }
        private void Upd()
        {
            try
            {               
                    ServiceReference1.CommingUp r = new ServiceReference1.CommingUp();
                    r.NameFirm = name.Text;
                       r.NameModel = model.Text;
                         r.VonderCode = art.Text;
                    r.Count = counts - Convert.ToInt32(kol.Text);
                     r.InStock = str[4];
                     r.DMY = str[5];
                    r.Price = str[6];
                client.Update_Comming(r.VonderCode, r.NameFirm, r); 
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }
    }
}
