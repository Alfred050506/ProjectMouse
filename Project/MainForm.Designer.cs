namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 110F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(-65, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 169);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOUSE";
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundBox.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundBox.Image")));
            this.BackgroundBox.Location = new System.Drawing.Point(488, 133);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(175, 330);
            this.BackgroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundBox.TabIndex = 2;
            this.BackgroundBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(157, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome";
            // 
            // ListButton
            // 
            this.ListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ListButton.FlatAppearance.BorderSize = 0;
            this.ListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListButton.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.ListButton.Location = new System.Drawing.Point(1, 1);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(782, 46);
            this.ListButton.TabIndex = 4;
            this.ListButton.Text = "Список игровых мышек";
            this.ListButton.UseVisualStyleBackColor = false;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(0, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ООО \"PointerPro\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackgroundBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaming Computer Mice";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackgroundBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Label label3;
    }
}

