namespace Project
{
    partial class MouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseForm));
            this.image = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.BackBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(483, 43);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(269, 479);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(29, 124);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(437, 398);
            this.description.TabIndex = 1;
            this.description.Text = "Description";
            // 
            // header
            // 
            this.header.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(32, 55);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(434, 55);
            this.header.TabIndex = 2;
            this.header.Text = "Header";
            // 
            // BackBox1
            // 
            this.BackBox1.Image = ((System.Drawing.Image)(resources.GetObject("BackBox1.Image")));
            this.BackBox1.Location = new System.Drawing.Point(1, 1);
            this.BackBox1.Name = "BackBox1";
            this.BackBox1.Size = new System.Drawing.Size(55, 40);
            this.BackBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBox1.TabIndex = 3;
            this.BackBox1.TabStop = false;
            this.BackBox1.Click += new System.EventHandler(this.BackBox1_Click_1);
            // 
            // MouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.description);
            this.Controls.Add(this.image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse";
            this.Load += new System.EventHandler(this.MouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.PictureBox BackBox1;
    }
}