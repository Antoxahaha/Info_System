namespace StockCentralDeskTop
{
    partial class SendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendPhones = new System.Windows.Forms.Button();
            this.kol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.art = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshcombo = new System.Windows.Forms.Button();
            this.addShops = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboShops = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendPhones
            // 
            this.SendPhones.Location = new System.Drawing.Point(238, 323);
            this.SendPhones.Name = "SendPhones";
            this.SendPhones.Size = new System.Drawing.Size(235, 33);
            this.SendPhones.TabIndex = 25;
            this.SendPhones.Text = "Отправить товар";
            this.SendPhones.UseVisualStyleBackColor = true;
            this.SendPhones.Click += new System.EventHandler(this.SendPhones_Click);
            // 
            // kol
            // 
            this.kol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kol.Location = new System.Drawing.Point(238, 259);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(473, 30);
            this.kol.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Количество";
            // 
            // art
            // 
            this.art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.art.Location = new System.Drawing.Point(238, 207);
            this.art.Name = "art";
            this.art.Size = new System.Drawing.Size(473, 30);
            this.art.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Артикул";
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model.Location = new System.Drawing.Point(238, 155);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(473, 30);
            this.model.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Модель телефона";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(238, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(473, 30);
            this.name.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название фирмы";
            // 
            // refreshcombo
            // 
            this.refreshcombo.Location = new System.Drawing.Point(717, 25);
            this.refreshcombo.Name = "refreshcombo";
            this.refreshcombo.Size = new System.Drawing.Size(223, 33);
            this.refreshcombo.TabIndex = 16;
            this.refreshcombo.Text = "Обновить список адресов";
            this.refreshcombo.UseVisualStyleBackColor = true;
            this.refreshcombo.Click += new System.EventHandler(this.refreshcombo_Click);
            // 
            // addShops
            // 
            this.addShops.Location = new System.Drawing.Point(717, 68);
            this.addShops.Name = "addShops";
            this.addShops.Size = new System.Drawing.Size(223, 33);
            this.addShops.TabIndex = 15;
            this.addShops.Text = "Добавить магазин";
            this.addShops.UseVisualStyleBackColor = true;
            this.addShops.Click += new System.EventHandler(this.addShops_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Отправить \r\nв магазин:";
            // 
            // comboShops
            // 
            this.comboShops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboShops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboShops.FormattingEnabled = true;
            this.comboShops.Location = new System.Drawing.Point(182, 23);
            this.comboShops.Name = "comboShops";
            this.comboShops.Size = new System.Drawing.Size(529, 33);
            this.comboShops.Sorted = true;
            this.comboShops.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SendPhones);
            this.Controls.Add(this.kol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.art);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshcombo);
            this.Controls.Add(this.addShops);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboShops);
            this.Name = "SendForm";
            this.Text = "Отправить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendPhones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshcombo;
        private System.Windows.Forms.Button addShops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboShops;
        public System.Windows.Forms.TextBox kol;
        public System.Windows.Forms.TextBox art;
        public System.Windows.Forms.TextBox model;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
    }
}