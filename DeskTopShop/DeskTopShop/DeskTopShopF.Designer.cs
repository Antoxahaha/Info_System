namespace DeskTopShop
{
    partial class DeskTopShopF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.TableComingUp = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.artText = new System.Windows.Forms.TextBox();
            this.delbtn = new System.Windows.Forms.Button();
            this.Updbtn = new System.Windows.Forms.Button();
            this.UpdateSait = new System.Windows.Forms.Button();
            this.Saitdata = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UpdOrders = new System.Windows.Forms.Button();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.ComboAdr = new System.Windows.Forms.ComboBox();
            this.Excel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableComingUp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Saitdata)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UpdateBtn);
            this.tabPage1.Controls.Add(this.TableComingUp);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Полученные товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.Location = new System.Drawing.Point(6, 292);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(153, 46);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // TableComingUp
            // 
            this.TableComingUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableComingUp.Location = new System.Drawing.Point(6, 3);
            this.TableComingUp.Name = "TableComingUp";
            this.TableComingUp.RowTemplate.Height = 24;
            this.TableComingUp.Size = new System.Drawing.Size(944, 283);
            this.TableComingUp.TabIndex = 2;
            this.TableComingUp.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableComingUp_CellMouseEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.artText);
            this.tabPage2.Controls.Add(this.delbtn);
            this.tabPage2.Controls.Add(this.Updbtn);
            this.tabPage2.Controls.Add(this.UpdateSait);
            this.tabPage2.Controls.Add(this.Saitdata);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Администрирование сайта";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // artText
            // 
            this.artText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artText.Location = new System.Drawing.Point(662, 315);
            this.artText.Name = "artText";
            this.artText.Size = new System.Drawing.Size(290, 34);
            this.artText.TabIndex = 7;
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delbtn.Location = new System.Drawing.Point(326, 303);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(330, 46);
            this.delbtn.TabIndex = 6;
            this.delbtn.Text = "Удалить по артикулу";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Updbtn
            // 
            this.Updbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Updbtn.Location = new System.Drawing.Point(167, 303);
            this.Updbtn.Name = "Updbtn";
            this.Updbtn.Size = new System.Drawing.Size(153, 46);
            this.Updbtn.TabIndex = 5;
            this.Updbtn.Text = "Изменить";
            this.Updbtn.UseVisualStyleBackColor = true;
            this.Updbtn.Click += new System.EventHandler(this.Updbtn_Click);
            // 
            // UpdateSait
            // 
            this.UpdateSait.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateSait.Location = new System.Drawing.Point(8, 303);
            this.UpdateSait.Name = "UpdateSait";
            this.UpdateSait.Size = new System.Drawing.Size(153, 46);
            this.UpdateSait.TabIndex = 4;
            this.UpdateSait.Text = "Обновить";
            this.UpdateSait.UseVisualStyleBackColor = true;
            this.UpdateSait.Click += new System.EventHandler(this.UpdateSait_Click);
            // 
            // Saitdata
            // 
            this.Saitdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Saitdata.Location = new System.Drawing.Point(6, 6);
            this.Saitdata.Name = "Saitdata";
            this.Saitdata.RowTemplate.Height = 24;
            this.Saitdata.Size = new System.Drawing.Size(946, 282);
            this.Saitdata.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Excel);
            this.tabPage3.Controls.Add(this.UpdOrders);
            this.tabPage3.Controls.Add(this.orderTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(960, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UpdOrders
            // 
            this.UpdOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdOrders.Location = new System.Drawing.Point(6, 306);
            this.UpdOrders.Name = "UpdOrders";
            this.UpdOrders.Size = new System.Drawing.Size(290, 38);
            this.UpdOrders.TabIndex = 2;
            this.UpdOrders.Text = "Обновить таблицу";
            this.UpdOrders.UseVisualStyleBackColor = true;
            this.UpdOrders.Click += new System.EventHandler(this.UpdOrders_Click);
            // 
            // orderTable
            // 
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Location = new System.Drawing.Point(6, 6);
            this.orderTable.Name = "orderTable";
            this.orderTable.RowTemplate.Height = 24;
            this.orderTable.Size = new System.Drawing.Size(946, 282);
            this.orderTable.TabIndex = 1;
            this.orderTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderTable_CellMouseEnter);
            // 
            // ComboAdr
            // 
            this.ComboAdr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboAdr.FormattingEnabled = true;
            this.ComboAdr.Location = new System.Drawing.Point(4, 6);
            this.ComboAdr.Name = "ComboAdr";
            this.ComboAdr.Size = new System.Drawing.Size(960, 33);
            this.ComboAdr.TabIndex = 1;
            this.ComboAdr.SelectedValueChanged += new System.EventHandler(this.ComboAdr_SelectedValueChanged);
            // 
            // Excel
            // 
            this.Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Excel.Location = new System.Drawing.Point(8, 362);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(290, 38);
            this.Excel.TabIndex = 3;
            this.Excel.Text = "Открыть в Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 492);
            this.Controls.Add(this.ComboAdr);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Магазин";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableComingUp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Saitdata)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView TableComingUp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox ComboAdr;
        private System.Windows.Forms.Button UpdateSait;
        private System.Windows.Forms.DataGridView Saitdata;
        private System.Windows.Forms.Button Updbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.TextBox artText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button UpdOrders;
        private System.Windows.Forms.DataGridView orderTable;
        private System.Windows.Forms.Button Excel;
    }
}

