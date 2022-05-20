namespace Sleep
{
    partial class Sleep
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sleep));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddSleep = new System.Windows.Forms.Button();
            this.btn_CancelSleep = new System.Windows.Forms.Button();
            this.btn_Desligar = new System.Windows.Forms.Button();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sleep :)";
            // 
            // btn_AddSleep
            // 
            this.btn_AddSleep.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddSleep.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_AddSleep.FlatAppearance.BorderSize = 3;
            this.btn_AddSleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_AddSleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_AddSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSleep.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSleep.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_AddSleep.Location = new System.Drawing.Point(33, 111);
            this.btn_AddSleep.Name = "btn_AddSleep";
            this.btn_AddSleep.Size = new System.Drawing.Size(182, 90);
            this.btn_AddSleep.TabIndex = 1;
            this.btn_AddSleep.Text = "Adicionar SLEEP";
            this.btn_AddSleep.UseVisualStyleBackColor = false;
            this.btn_AddSleep.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_CancelSleep
            // 
            this.btn_CancelSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelSleep.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelSleep.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_CancelSleep.FlatAppearance.BorderSize = 3;
            this.btn_CancelSleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_CancelSleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_CancelSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelSleep.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelSleep.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_CancelSleep.Location = new System.Drawing.Point(368, 111);
            this.btn_CancelSleep.Name = "btn_CancelSleep";
            this.btn_CancelSleep.Size = new System.Drawing.Size(182, 90);
            this.btn_CancelSleep.TabIndex = 2;
            this.btn_CancelSleep.Text = "Cancelar SLEEP";
            this.btn_CancelSleep.UseVisualStyleBackColor = false;
            this.btn_CancelSleep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Desligar
            // 
            this.btn_Desligar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Desligar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Desligar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Desligar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_Desligar.FlatAppearance.BorderSize = 3;
            this.btn_Desligar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_Desligar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_Desligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Desligar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Desligar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Desligar.Location = new System.Drawing.Point(33, 262);
            this.btn_Desligar.Name = "btn_Desligar";
            this.btn_Desligar.Size = new System.Drawing.Size(182, 90);
            this.btn_Desligar.TabIndex = 3;
            this.btn_Desligar.Text = "Desligar";
            this.btn_Desligar.UseVisualStyleBackColor = false;
            this.btn_Desligar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reiniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reiniciar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_Reiniciar.FlatAppearance.BorderSize = 3;
            this.btn_Reiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_Reiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reiniciar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Reiniciar.Location = new System.Drawing.Point(368, 262);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(182, 90);
            this.btn_Reiniciar.TabIndex = 4;
            this.btn_Reiniciar.Text = "Reiniciar";
            this.btn_Reiniciar.UseVisualStyleBackColor = false;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_Sair.FlatAppearance.BorderSize = 3;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Sair.Location = new System.Drawing.Point(239, 402);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(121, 47);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Close";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Sleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.btn_Desligar);
            this.Controls.Add(this.btn_CancelSleep);
            this.Controls.Add(this.btn_AddSleep);
            this.Controls.Add(this.label1);
            this.Name = "Sleep";
            this.Text = "SLEEP";
            this.Load += new System.EventHandler(this.Sleep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddSleep;
        private System.Windows.Forms.Button btn_CancelSleep;
        private System.Windows.Forms.Button btn_Desligar;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Button btn_Sair;
    }
}

