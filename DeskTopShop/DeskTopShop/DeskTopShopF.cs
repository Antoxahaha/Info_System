using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTopShop
{
    public partial class DeskTopShopF : Form
    {
        SaitDbEntities db = new SaitDbEntities();
        private DataGridViewCellEventArgs loc;
        ServiceReference1.Service1Client client;
        List<Sait> listsait = new List<Sait>();
        ToolStripMenuItem[] toolmenu = new ToolStripMenuItem[2];
        ToolStripMenuItem toolmenuOrd = new ToolStripMenuItem();
        List<Sinding> ListCommingup = new List<Sinding>();
        List<Orders> listOrders = new List<Orders>();
        string[] Keys = new string[2];
        string strHelp = ""; 
        public DeskTopShopF()
        {  
            client = new ServiceReference1.Service1Client();
            InitializeComponent();
            TableComingUp.ColumnCount = 7;
            TableComingUp.RowHeadersVisible = false;
            TableComingUp.Columns[0].HeaderText = "Номер заказа";
            TableComingUp.Columns[1].HeaderText = "Название фирмы";
            TableComingUp.Columns[2].HeaderText = "Модель телефона";
            TableComingUp.Columns[3].HeaderText = "Артикул";
            TableComingUp.Columns[4].HeaderText = "Количество";
            TableComingUp.Columns[5].HeaderText = "Статус доставки";
            TableComingUp.Columns[6].HeaderText = "Время доставки";
            SelectRoutes();
            //////////////////////////////////////////
            orderTable.DataSource = SelectOrders();
            orderTable.RowHeadersVisible = false;
            orderTable.Columns[0].HeaderText = "Номер заказа";
            orderTable.Columns[1].HeaderText = "Фирма";
            orderTable.Columns[2].HeaderText = "Модель телефона";
            orderTable.Columns[3].HeaderText = "Артикул";
            orderTable.Columns[4].HeaderText = "Количество";
            orderTable.Columns[5].HeaderText = "Статус наличия";
            orderTable.Columns[6].HeaderText = "Цена";
            orderTable.Columns[7].HeaderText = "Телефон Клиента";
            orderTable.Columns[8].HeaderText = "Время заказа";
            orderTable.Columns[9].HeaderText = "Статус продажи";
            InitTableOrders();
            SelectSait();
        }
        private void InitTableOrders()
        {
            ContextMenuStrip strip = new ContextMenuStrip();
            toolmenuOrd = new ToolStripMenuItem();
            toolmenuOrd.Text = "Продать";
            toolmenuOrd.Click += new EventHandler(toolStripOrderItem1_Click);
            foreach (DataGridViewColumn col in orderTable.Columns)
            {
                col.ContextMenuStrip = strip;
                col.ContextMenuStrip.Items.Add(toolmenuOrd);
            }
        }
        private async void Sale()
        {
            string[] str = new string[orderTable.ColumnCount];
            for (int i = 0; i < orderTable.ColumnCount; i++)
            {
                if (orderTable.Rows[loc.RowIndex].Cells[i].Value != null)
                {
                    str[i] = orderTable.Rows[loc.RowIndex].Cells[i].Value.ToString();
                }
            }
            int y =0;
            try{
                  int ids = Convert.ToInt32(str[0]);
                string YoarTelephone = str[7];
                 var item = (from x in db.Orders
                                where (x.YoarTelephone == YoarTelephone)
                                where (x.Id == ids)
                                select x).First();
                    item.NameFirm = str[1];
                item.VonderCode = str[3];
                item.NameModel = str[2];
                    item.Count = Convert.ToInt32(str[4]);
                    item.Price = str[6];
                   item.Sales = "Продано " + DateTime.Now.ToLongDateString();                      
                var iis = (from x in db.Sait
                            where (x.VonderCode == item.VonderCode)
                            select x).First();
            int index = 0;
            for(int i=0;i< listsait.Count;i++)
            {
                if (listsait[i].NameModel.Equals(item.NameModel))
                {
                    index = i;
                    break;
                }
            }
                iis.NameFirm = listsait[index].NameFirm;
                iis.NameModel = listsait[index].NameModel;
                iis.VonderCode = listsait[index].VonderCode;
                int c = Convert.ToInt32(listsait[index].Count) - (int)item.Count;
                if (c <= 0)
                {
                    iis.InStock = "Нет";
                    iis.Count = 0;
                }
                else if (c>0)
                {
                    iis.InStock = listsait[index].InStock;
                    iis.Count = c;
                }
                iis.Description = listsait[index].Description;
                iis.Сharacteristic = listsait[index].Сharacteristic;
                iis.ImageName = listsait[index].ImageName;
                iis.DMY = listsait[index].DMY;
                await db.SaveChangesAsync();
                MessageBox.Show("Товар продан!");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void toolStripOrderItem1_Click(object sender, EventArgs e)
        {
            Sale();
        }

        private async void SelectRoutes()
        {
           try
            {
                ListCommingup.Clear();
                TableComingUp.RowCount = 1;
                var result = await client.Select_SendingAsync();
                for (int i = 0; i < result.Length; i++)
                {
                    Sinding s = new Sinding();
                    s.id = result[i].Id;
                    s.NameFirm = result[i].NameFirm.ToString();
                    s.NameModel = result[i].NameModel.ToString();
                    s.VonderCode = result[i].VonderCode.ToString();
                    s.Count = result[i].Count.ToString();
                    s.Address = result[i].Address.ToString();
                    s.Status = result[i].Status.ToString();
                    strHelp = s.Status;
                    s.Dolgota = result[i].Dolgota;
                    s.Shirota = result[i].Shirota;
                    s.TimeOfSend = result[i].TimeOfSend;
                    ListCommingup.Add(s);
                }

                InitCombo();
            INITMENUSTRIP2();     
                ShowTable();

           }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void ShowTable()
        {
            int u = -1;
            try
            {
                for (int i = 0; i < ListCommingup.Count; i++)
                {
                    if (ComboAdr.SelectedItem.Equals(ListCommingup[i].Address))
                    {
                        TableComingUp.Rows.Add();
                        u++;
                        TableComingUp.Rows[u].Cells[0].Value = ListCommingup[i].id;
                        TableComingUp.Rows[u].Cells[1].Value = ListCommingup[i].NameFirm;
                        TableComingUp.Rows[u].Cells[2].Value = ListCommingup[i].NameModel;
                        TableComingUp.Rows[u].Cells[3].Value = ListCommingup[i].VonderCode;
                        TableComingUp.Rows[u].Cells[4].Value = ListCommingup[i].Count;
                        TableComingUp.Rows[u].Cells[5].Value = ListCommingup[i].Status;
                        TableComingUp.Rows[u].Cells[6].Value = ListCommingup[i].TimeOfSend;
                    }
                }
            }
            catch { }
        }
        private void INITMENUSTRIP2()
        {
            ContextMenuStrip strip = new ContextMenuStrip();
            toolmenu[0] = new ToolStripMenuItem();
            toolmenu[0].Text = "Добавить на сайт";
            toolmenu[0].Click += new EventHandler(toolStripItem1_Click); 
            ContextMenuStrip strip2 = new ContextMenuStrip();
            toolmenu[1] = new ToolStripMenuItem();
            toolmenu[1].Text = "Отметить как полученное";
            toolmenu[1].Click += new EventHandler(toolStripItem2_Click); ;
            foreach (DataGridViewColumn col in TableComingUp.Columns)
            { 
               col.ContextMenuStrip = strip2;            
                col.ContextMenuStrip.Items.Add(toolmenu[0]);
                col.ContextMenuStrip.Items.Add(toolmenu[1]);
            }
        }

        private void toolStripItem2_Click(object sender, EventArgs e)
        {
            Poluch();
        }

        private void toolStripItem1_Click(object sender, EventArgs e)
        {
            OnSait();
        }

        private void OnSait()
        {
            
                string[] str = new string[TableComingUp.ColumnCount];
                for (int i = 0; i < TableComingUp.ColumnCount; i++)
                {
                    if (TableComingUp.Rows[loc.RowIndex].Cells[i].Value != null)
                    {
                        str[i] = TableComingUp.Rows[loc.RowIndex].Cells[i].Value.ToString();
                    }
                }
                AddToSait ads = new AddToSait();
                ads.firm.Text = str[1];
                ads.model.Text = str[2];
                ads.art.Text = str[3];
                ads.count.Text = str[4];      
                ads.Show();
            
        }
  
 
 
        private void Poluch()
        {
            try
            {
                string[] str = new string[7];
                for (int i = 0; i < TableComingUp.ColumnCount; i++)
                {
                    if (TableComingUp.Rows[loc.RowIndex].Cells[i].Value != null)
                    {
                        str[i] = TableComingUp.Rows[loc.RowIndex].Cells[i].Value.ToString();
                    }
                }
                ServiceReference1.Sending s = new ServiceReference1.Sending();
                s.Id = Convert.ToInt32(str[0]);
                s.NameFirm = str[1];
                s.NameModel = str[2];
                s.VonderCode = str[3];
                s.Count = Convert.ToInt32(str[4]);
                s.Address = ListCommingup[loc.RowIndex].Address;
                s.Shirota = ListCommingup[loc.RowIndex].Shirota;
                s.Dolgota = ListCommingup[loc.RowIndex].Dolgota;
                s.Status = "Доставлено";
                s.TimeOfSend = DateTime.Now.ToString("dd/MM/yy hh:mm:ss");
                client.Update_SendingAsync(s.VonderCode, s.Address, s.Status, s.Id, s);
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void InitCombo()
        {
            try
            {
                ComboAdr.Items.Clear();
                StreamReader strR = new StreamReader("Keys");
                for (int i = 0; i < 2; i++)
                {
                    Keys[i] = strR.ReadLine();
                }
                strR.Close();
                if (Keys[1].Equals("true"))
                {
                    ComboAdr.Items.Add(Keys[0]);
                    ComboAdr.SelectedIndex = 0; ;
                    ComboAdr.Enabled = false;
                }
                else
                {
                    for (int i = 0; i < ListCommingup.Count; i++)
                    {
                        ComboAdr.Items.Add(ListCommingup[i].Address);
                    }
                }
            }
            catch {
                for (int i = 0; i < ListCommingup.Count; i++)
                {
                    ComboAdr.Items.Add(ListCommingup[i].Address);
                }
            }


        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SelectRoutes();
        }

        private void ComboAdr_SelectedValueChanged(object sender, EventArgs e)
        {
            StreamWriter strw = new StreamWriter("Keys");
            strw.WriteLine(ComboAdr.SelectedItem.ToString());
            strw.WriteLine("true");
            strw.Close();
            ComboAdr.Enabled = false;
        }

        private void TableComingUp_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            loc = e;
        }

        private void SelectSait()
        {
            Saitdata.ClearSelection();
            Saitdata.DataSource = Selects();
            Saitdata.RowHeadersVisible = false;
            Saitdata.Columns[0].HeaderText = "Id";
            Saitdata.Columns[1].HeaderText = "Название фирмы";
            Saitdata.Columns[2].HeaderText = "Модель телефона";
            Saitdata.Columns[3].HeaderText = "Артикул";
            Saitdata.Columns[4].HeaderText = "Количество";
            Saitdata.Columns[5].HeaderText = "В наличии";
            Saitdata.Columns[6].HeaderText = "Дата следующего поступления";
            Saitdata.Columns[7].HeaderText = "Цена";
            Saitdata.Columns[8].HeaderText = "Описание";
            Saitdata.Columns[9].HeaderText = "Характеристики";
            Saitdata.Columns[10].HeaderText = "Картинка";
        }
        public List<Sait> Selects()
        { 
            var q = db.Sait;
            listsait = q.ToList();
            return q.ToList();
        }
        private void UpdateSait_Click(object sender, EventArgs e)
        {
            SelectSait();
        }

        private void Updbtn_Click(object sender, EventArgs e)
        {
            UpdateF pdf = new UpdateF();
            pdf.Show();

        }
        public async void Delete_Comming(string VonderCode)
        {
            try
            {
                var item = (from x in db.Sait
                            where (x.VonderCode == VonderCode)
                            select x).First();
                db.Sait.Remove(item);
                await db.SaveChangesAsync();
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void delbtn_Click(object sender, EventArgs e)
        {
            if (artText.Text!=null)
            {
                Delete_Comming(artText.Text);
                MessageBox.Show("Запись удалена");
                artText.Text = "";
            }
        }
        private  List<Orders> SelectOrders()
        { 
            try
            {           
                        var query = db.Orders.OrderBy(s => s.NameFirm);
                        return query.ToList();
            }
            catch {
                MessageBox.Show("Ошибка");
                return null;
            }
        }
        private void UpdOrders_Click(object sender, EventArgs e)
        {
            orderTable.DataSource = SelectOrders();
            orderTable.RowHeadersVisible = false;
            orderTable.Columns[0].HeaderText = "Номер заказа";
            orderTable.Columns[1].HeaderText = "Фирма";
            orderTable.Columns[2].HeaderText = "Модель телефона";
            orderTable.Columns[3].HeaderText = "Артикул";
            orderTable.Columns[4].HeaderText = "Количество";
            orderTable.Columns[5].HeaderText = "Статус наличия";
            orderTable.Columns[6].HeaderText = "Цена";
            orderTable.Columns[7].HeaderText = "Телефон Клиента";
            orderTable.Columns[8].HeaderText = "Время заказа";
            orderTable.Columns[9].HeaderText = "Статус продажи";

        }

        private void orderTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            loc = e;
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            try  {
                Microsoft.Office.Interop.Excel.Application _application = null;
                Microsoft.Office.Interop.Excel.Workbook _workBook = null;
                Microsoft.Office.Interop.Excel.Worksheet _workSheet = null;
                _application = new Microsoft.Office.Interop.Excel.Application();
                _workBook = _application.Workbooks.Add(System.Reflection.Missing.Value);
                _workSheet = (Microsoft.Office.Interop.Excel.Worksheet)_workBook.Sheets[1];
                for (int i = 1; i < orderTable.ColumnCount + 1; i++)
                {
                    _workSheet.Cells[1, i] = orderTable.Columns[i - 1].HeaderText;
                    (_workSheet.Cells[1, i] as Microsoft.Office.Interop.Excel.Range).Font.Bold = true;
                    (_workSheet.Cells[1, i] as Microsoft.Office.Interop.Excel.Range).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    (_workSheet.Cells[1, i] as Microsoft.Office.Interop.Excel.Range).ColumnWidth = 20;
                    (_workSheet.Cells[1, i] as Microsoft.Office.Interop.Excel.Range).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                }
                for (int i = 2; i < orderTable.RowCount + 2; i++)
                {
                    for (int j = 1; j < orderTable.ColumnCount + 1; j++)
                    {
                        _workSheet.Cells[i, j] = orderTable.Rows[i - 2].Cells[j - 1].Value;
                        (_workSheet.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    }
                }
                _application.Visible = true;
                _application.UserControl = true;
            }
            catch { MessageBox.Show("Ошибка"); }
        }
    }
    }

