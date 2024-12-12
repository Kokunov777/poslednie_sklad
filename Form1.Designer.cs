namespace poslednie_sklad
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
            this.btnWarehouses = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarehouses
            // 
            this.btnWarehouses.Location = new System.Drawing.Point(29, 26);
            this.btnWarehouses.Name = "btnWarehouses";
            this.btnWarehouses.Size = new System.Drawing.Size(93, 34);
            this.btnWarehouses.TabIndex = 0;
            this.btnWarehouses.Text = "Управление складами";
            this.btnWarehouses.UseVisualStyleBackColor = true;
           
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(155, 26);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(93, 34);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Управление клиентами";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnGoods
            // 
            this.btnGoods.Location = new System.Drawing.Point(289, 26);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(93, 34);
            this.btnGoods.TabIndex = 2;
            this.btnGoods.Text = " Управление ТМЦ";
            this.btnGoods.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(421, 26);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(93, 34);
            this.btnContracts.TabIndex = 3;
            this.btnContracts.Text = "  Управление договорами";
            this.btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(548, 26);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(93, 34);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Отчеты                                                                           " +
    "                                                           ";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 495);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnWarehouses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWarehouses;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnReports;
    }
}

