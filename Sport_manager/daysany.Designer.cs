namespace Sport_manager
{
    partial class daysany
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdays = new System.Windows.Forms.Label();
            this.lb_uprazhnenie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbdays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbdays.Location = new System.Drawing.Point(63, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(25, 26);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "x";
            this.lbdays.Click += new System.EventHandler(this.lbdays_Click);
            // 
            // lb_uprazhnenie
            // 
            this.lb_uprazhnenie.AutoSize = true;
            this.lb_uprazhnenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uprazhnenie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_uprazhnenie.Location = new System.Drawing.Point(47, 44);
            this.lb_uprazhnenie.Name = "lb_uprazhnenie";
            this.lb_uprazhnenie.Size = new System.Drawing.Size(83, 29);
            this.lb_uprazhnenie.TabIndex = 1;
            this.lb_uprazhnenie.Text = "          ";
            this.lb_uprazhnenie.Click += new System.EventHandler(this.lb_uprazhnenie_Click);
            // 
            // daysany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.lb_uprazhnenie);
            this.Controls.Add(this.lbdays);
            this.Name = "daysany";
            this.Size = new System.Drawing.Size(161, 100);
            this.Load += new System.EventHandler(this.dayslb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label lb_uprazhnenie;
    }
}
