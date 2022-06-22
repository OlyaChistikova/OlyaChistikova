namespace WindowsFormsApp1
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
            this.bt_Connect = new System.Windows.Forms.Button();
            this.tb_ModBus_Server_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(93, 144);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(100, 38);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "&Connect";
            this.bt_Connect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // tb_ModBus_Server_IP
            // 
            this.tb_ModBus_Server_IP.Location = new System.Drawing.Point(93, 118);
            this.tb_ModBus_Server_IP.Name = "tb_ModBus_Server_IP";
            this.tb_ModBus_Server_IP.Size = new System.Drawing.Size(100, 20);
            this.tb_ModBus_Server_IP.TabIndex = 1;
            this.tb_ModBus_Server_IP.TextChanged += new System.EventHandler(this.tb_ModBus_Server_IP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ModBus Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(236, 121);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 4;
            this.lb_status.Text = "Offline";
            this.lb_status.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Location = new System.Drawing.Point(93, 189);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(100, 40);
            this.bt_Disconnect.TabIndex = 5;
            this.bt_Disconnect.Text = "&Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ModBus_Server_IP);
            this.Controls.Add(this.bt_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.TextBox tb_ModBus_Server_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button bt_Disconnect;
    }
}

