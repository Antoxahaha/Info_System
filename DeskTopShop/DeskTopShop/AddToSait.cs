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
    public partial class AddToSait : Form
    {
        public AddToSait()
        {
            InitializeComponent();
        }
        SaitDbEntities db = new SaitDbEntities();
        public void Insert1( )
        {
            Sait s = new Sait();
            s.NameFirm = firm.Text;
            s.NameModel = model.Text;
            s.Price = price.Text;
            s.VonderCode = art.Text;
            s.Count = Convert.ToInt32(count.Text);
            s.Description = des.Text;
            s.Сharacteristic = chra.Text;
            s.ImageName = imname.Text;
            s.DMY = "";
            s.InStock = "В наличии";
            db.Sait.Add(s);
            db.SaveChanges();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Insert1();
            this.Close();
        }

        private void imbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                imname.Text = op.SafeFileName;
                System.IO.FileInfo fi = new System.IO.FileInfo(op.FileName);
                System.IO.FileInfo fi1 = new System.IO.FileInfo("D:\\Учеба\\6 Семестр\\Практика\\SaitShop\\SaitShop\\Images\\" + op.SafeFileName);
                if (!fi1.Exists)
                {
                    fi.CopyTo("D:\\Учеба\\6 Семестр\\Практика\\SaitShop\\SaitShop\\Images\\" + op.SafeFileName);
                }else MessageBox.Show("Файл уже существует");

            }
        }
    }
}
