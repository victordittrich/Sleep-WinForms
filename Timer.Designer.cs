namespace Sleep
{
    partial class Timer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Time = new System.Windows.Forms.MaskedTextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutos para desligar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Time
            // 
            this.txt_Time.BackColor = System.Drawing.Color.White;
            this.txt_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Time.Location = new System.Drawing.Point(135, 74);
            this.txt_Time.Mask = "00000";
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(123, 29);
            this.txt_Time.TabIndex = 1;
            this.txt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Time.ValidatingType = typeof(int);
            this.txt_Time.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ok.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_Ok.FlatAppearance.BorderSize = 3;
            this.btn_Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Ok.Location = new System.Drawing.Point(164, 117);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(68, 32);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Desligar_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label1);
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_Time;
        private System.Windows.Forms.Button btn_Ok;
    }
}