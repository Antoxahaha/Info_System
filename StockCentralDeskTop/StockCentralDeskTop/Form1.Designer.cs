namespace StockCentralDeskTop
{
    partial class Form1
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
            this.changephones = new System.Windows.Forms.Button();
            this.Deletephone = new System.Windows.Forms.Button();
            this.vonderCode = new System.Windows.Forms.TextBox();
            this.AddPhones = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.excel = new System.Windows.Forms.Button();
            this.refreshsending = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.changephones);
            this.tabPage1.Controls.Add(this.Deletephone);
            this.tabPage1.Controls.Add(this.vonderCode);
            this.tabPage1.Controls.Add(this.AddPhones);
            this.tabPage1.Controls.Add(this.btnshow);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пришедшие товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // changephones
            // 
            this.changephones.Location = new System.Drawing.Point(356, 248);
            this.changephones.Name = "changephones";
            this.changephones.Size = new System.Drawing.Size(148, 41);
            this.changephones.TabIndex = 8;
            this.changephones.Text = "Изменить товар";
            this.changephones.UseVisualStyleBackColor = true;
            this.changephones.Click += new System.EventHandler(this.changephones_Click);
            // 
            // Deletephone
            // 
            this.Deletephone.Location = new System.Drawing.Point(16, 307);
            this.Deletephone.Name = "Deletephone";
            this.Deletephone.Size = new System.Drawing.Size(148, 55);
            this.Deletephone.TabIndex = 7;
            this.Deletephone.Text = "Удалить товар по артикулу";
            this.Deletephone.UseVisualStyleBackColor = true;
            this.Deletephone.Click += new System.EventHandler(this.Deletephone_Click);
            // 
            // vonderCode
            // 
            this.vonderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vonderCode.Location = new System.Drawing.Point(183, 328);
            this.vonderCode.Name = "vonderCode";
            this.vonderCode.Size = new System.Drawing.Size(251, 34);
            this.vonderCode.TabIndex = 6;
            // 
            // AddPhones
            // 
            this.AddPhones.Location = new System.Drawing.Point(183, 249);
            this.AddPhones.Name = "AddPhones";
            this.AddPhones.Size = new System.Drawing.Size(148, 41);
            this.AddPhones.TabIndex = 5;
            this.AddPhones.Text = "Добавить товар";
            this.AddPhones.UseVisualStyleBackColor = true;
            this.AddPhones.Click += new System.EventHandler(this.AddPhones_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(16, 248);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(148, 41);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Обновить таблицу";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 239);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.excel);
            this.tabPage3.Controls.Add(this.refreshsending);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отправленные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(176, 251);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(195, 41);
            this.excel.TabIndex = 6;
            this.excel.Text = "Открыть отчет в Эксель";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // refreshsending
            // 
            this.refreshsending.Location = new System.Drawing.Point(5, 251);
            this.refreshsending.Name = "refreshsending";
            this.refreshsending.Size = new System.Drawing.Size(148, 41);
            this.refreshsending.TabIndex = 5;
            this.refreshsending.Text = "Обновить таблицу";
            this.refreshsending.UseVisualStyleBackColor = true;
            this.refreshsending.Click += new System.EventHandler(this.refreshsending_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(943, 239);
            this.dataGridView2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Центральный склад";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddPhones;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Deletephone;
        private System.Windows.Forms.TextBox vonderCode;
        private System.Windows.Forms.Button changephones;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button refreshsending;
        private System.Windows.Forms.Button excel;
    }
}

