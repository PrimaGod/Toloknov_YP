
namespace Toloknov_YP
{
    partial class EnterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            this.btn_Clients = new System.Windows.Forms.Button();
            this.btn_Service = new System.Windows.Forms.Button();
            this.btn_Worker = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clients
            // 
            this.btn_Clients.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clients.Location = new System.Drawing.Point(145, 56);
            this.btn_Clients.Name = "btn_Clients";
            this.btn_Clients.Size = new System.Drawing.Size(145, 60);
            this.btn_Clients.TabIndex = 0;
            this.btn_Clients.Text = "Клиенты";
            this.btn_Clients.UseVisualStyleBackColor = false;
            this.btn_Clients.Click += new System.EventHandler(this.btn_Clients_Click);
            // 
            // btn_Service
            // 
            this.btn_Service.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Service.Location = new System.Drawing.Point(296, 56);
            this.btn_Service.Name = "btn_Service";
            this.btn_Service.Size = new System.Drawing.Size(145, 60);
            this.btn_Service.TabIndex = 1;
            this.btn_Service.Text = "Услуги";
            this.btn_Service.UseVisualStyleBackColor = false;
            // 
            // btn_Worker
            // 
            this.btn_Worker.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Worker.Location = new System.Drawing.Point(447, 56);
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.Size = new System.Drawing.Size(145, 60);
            this.btn_Worker.TabIndex = 2;
            this.btn_Worker.Text = "Сотрудники";
            this.btn_Worker.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Товары";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "Управление ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Worker);
            this.Controls.Add(this.btn_Service);
            this.Controls.Add(this.btn_Clients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterForm";
            this.Text = "Вход в салон красоты \"Мордочка\"";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Clients;
        private System.Windows.Forms.Button btn_Service;
        private System.Windows.Forms.Button btn_Worker;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}

