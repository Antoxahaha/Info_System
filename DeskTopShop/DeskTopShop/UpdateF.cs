using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTopShop
{
    public partial class UpdateF : Form
    {
        public UpdateF()
        {
            InitializeComponent();
        }
        SaitDbEntities db = new SaitDbEntities();
 
        public async void Update_Sait() 
        {
            try
            {
                if (art.Text != null && firm.Text != null && model.Text != null && price.Text != null && price.Text != null && count.Text != null && des.Text != null && chra.Text != null && imname.Text != null)
                {
                    var item = (from x in db.Sait
                               where (x.VonderCode == art.Text)
                               select x).First();
                    item.NameFirm = firm.Text;
                    item.VonderCode = art.Text;
                    item.NameModel = model.Text;
                    item.Count = Convert.ToInt32(count.Text);   
                    item.Price = price.Text;
                    item.ImageName = imname.Text;
                    item.Description = des.Text;
                    item.Сharacteristic = chra.Text;
                    await db.SaveChangesAsync();
                    MessageBox.Show("Изменение выполнено");
                }
         }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private List<Sait> Selects()
        {
            if (art.Text != null || art.Text != "")
            {
                var query = db.Sait.Where(x => x.VonderCode == art.Text);
                return query.ToList();
            }
            else return null;
        }
        private void imbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                imname.Text = op.SafeFileName;
                System.IO.FileInfo fi = new System.IO.FileInfo(op.FileName);
                System.IO.FileInfo fi1 = new System.IO.FileInfo("D:\\Учеба\\6 Семестр\\Практика\\SaitShop\\SaitShop\\Images\\" + op.SafeFileName);
                if (!fi1.Exists)
                {
                    fi.CopyTo("D:\\Учеба\\6 Семестр\\Практика\\SaitShop\\SaitShop\\Images\\" + op.SafeFileName);
                }
                else MessageBox.Show("Файл уже существует");

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Update_Sait();
        }
        List<Sait> list = new List<Sait>();
        private void art_TextChanged(object sender, EventArgs e)
        {
            try
            {
                list = Selects();
                if (list != null)
                {
                    firm.Text = list[0].NameFirm;
                    model.Text = list[0].NameModel;
                    count.Text = list[0].Count.ToString();
                    price.Text = list[0].Price;
                    des.Text = list[0].Description;
                    chra.Text = list[0].Сharacteristic;
                    imname.Text = list[0].ImageName;
                  
                }
            }
            catch { }
        }
    }
}
