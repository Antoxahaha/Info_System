using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace StockCentralDeskTop
{
    public partial class Form1 : Form
    {

        private DataGridViewCellEventArgs loc;
        ServiceReference1.Service1Client client;
        ToolStripMenuItem toolmenu = new ToolStripMenuItem();
        private void INITMENUSTRIP()
        {
            toolmenu.Text = "Отправить этот товар";
            toolmenu.Click += Toolmenu_Click;
            ContextMenuStrip strip = new ContextMenuStrip();
            foreach(DataGridViewColumn col in dataGridView1.Columns)
            {
                col.ContextMenuStrip = strip;
                col.ContextMenuStrip.Items.Add(toolmenu);
            }
        }
  
        private void Toolmenu_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = new string[7];
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    str[i] = dataGridView1.Rows[loc.RowIndex].Cells[i].Value.ToString();
                }
                SendForm sf = new SendForm();
                sf.name.Text = str[0];
                sf.model.Text = str[1];
                sf.art.Text = str[2];
                sf.kol.Text = str[3];
                sf.str = str;
                sf.Show();
            }
            catch { }
        }

        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
            dataGridView1.ColumnCount = 7;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "Название фирмы";
            dataGridView1.Columns[1].HeaderText = "Модель телефона";
            dataGridView1.Columns[2].HeaderText = "Артикул";
            dataGridView1.Columns[3].HeaderText = "Количество";
            dataGridView1.Columns[4].HeaderText = "Наличие";
            dataGridView1.Columns[5].HeaderText = "Дата поступления";
            dataGridView1.Columns[6].HeaderText = "Цена за шт.(руб)";
         ///////////////////////////////////////////////////
            dataGridView2.ColumnCount = 8;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Columns[0].HeaderText = "Номер заказа";
            dataGridView2.Columns[1].HeaderText = "Название фирмы";
            dataGridView2.Columns[2].HeaderText = "Модель телефона";
            dataGridView2.Columns[3].HeaderText = "Артикул";
            dataGridView2.Columns[4].HeaderText = "Количество";
            dataGridView2.Columns[5].HeaderText = "Адрес";
         /*   dataGridView2.Columns[5].HeaderText = "Долгота";
            dataGridView2.Columns[6].HeaderText = "Широта";*/
            dataGridView2.Columns[6].HeaderText = "Статус доставки";
            dataGridView2.Columns[7].HeaderText = "Время доставки";
            SelectComming();
            SelectSending();
            INITMENUSTRIP();
        }
       public async  void SelectComming()
       {        
           var result = await client.Select_Comming_PhonesAsync();
           dataGridView1.Rows.Clear();
           for (int i = 0; i < result.Length; i++)  
           {
               dataGridView1.Rows.Add();  
               dataGridView1[0, i].Value = result[i].NameFirm;
               dataGridView1[1, i].Value = result[i].NameModel;
               dataGridView1[2, i].Value = result[i].VonderCode;
               dataGridView1[3, i].Value = result[i].Count;
               dataGridView1[4, i].Value = result[i].InStock;
               dataGridView1[5, i].Value = result[i].DMY;
               dataGridView1[6, i].Value = result[i].Price;
           }
       }
 
    
        private void AddPhones_Click(object sender, EventArgs e)
        {
            AddForm adf = new AddForm();
            adf.Show();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
      
            SelectComming();
          
        }

        private void Deletephone_Click(object sender, EventArgs e)
        {
            if(vonderCode.Text != "")
            {
                Delete();
                SelectComming();   
            }
            
        }
        private void Delete()
        {
            ServiceReference1.CommingUp r = new ServiceReference1.CommingUp();
            client.Delete_Comming(vonderCode.Text);
        }

        private void changephones_Click(object sender, EventArgs e)
        {
            ChangePhone chg = new ChangePhone();
            chg.Show();
        }

        private void addShops_Click(object sender, EventArgs e)
        {
            FormAdAddress ash = new FormAdAddress();
            ash.Show();
        }


        private void refreshsending_Click(object sender, EventArgs e)
        {    
            SelectSending();
        }
        public async void SelectSending()
        {
            var result = await client.Select_SendingAsync();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < result.Length; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2[0, i].Value = result[i].Id;
                dataGridView2[1, i].Value = result[i].NameFirm;
                dataGridView2[2, i].Value = result[i].NameModel;
                dataGridView2[3, i].Value = result[i].VonderCode;
                dataGridView2[4, i].Value = result[i].Count;
                dataGridView2[5, i].Value = result[i].Address;
                dataGridView2[6, i].Value = result[i].Status;
                dataGridView2[7, i].Value = result[i].TimeOfSend;
            }
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            loc = e;
        }

        private void excel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application _application = null;
                Microsoft.Office.Interop.Excel.Workbook _workBook = null;
                Microsoft.Office.Interop.Excel.Worksheet _workSheet = null;
                _application = new Microsoft.Office.Interop.Excel.Application();
                _workBook = _application.Workbooks.Add(System.Reflection.Missing.Value);
                _workSheet = (Microsoft.Office.Interop.Excel.Worksheet)_workBook.Sheets[1];
                for (int i = 1; i < dataGridView2.ColumnCount + 1; i++)
                {
                    _workSheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                    (_workSheet.Cells[1, i] as Excel.Range).Font.Bold = true;
                    (_workSheet.Cells[1, i] as Excel.Range).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    (_workSheet.Cells[1, i] as Excel.Range).ColumnWidth = 20;
                    (_workSheet.Cells[1, i] as Excel.Range).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                }
                for (int i = 2; i < dataGridView2.RowCount + 1; i++)
                {
                    for (int j = 1; j < dataGridView2.ColumnCount + 1; j++)
                    {
                        _workSheet.Cells[i, j] = dataGridView2.Rows[i - 2].Cells[j - 1].Value;
                        (_workSheet.Cells[i, j] as Excel.Range).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    }
                }
                _application.Visible = true;
                _application.UserControl = true;
            }
            catch { MessageBox.Show("Ошибка"); }
        }
    }
}
