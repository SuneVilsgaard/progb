namespace ProgB
{
    partial class HovedmenuAdmin
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
            this.btn_SeKunder = new System.Windows.Forms.Button();
            this.btn_SeBaner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SeKunder
            // 
            this.btn_SeKunder.BackColor = System.Drawing.Color.White;
            this.btn_SeKunder.BackgroundImage = global::ProgB.Properties.Resources.kunder_2;
            this.btn_SeKunder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SeKunder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_SeKunder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SeKunder.Location = new System.Drawing.Point(39, 105);
            this.btn_SeKunder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SeKunder.Name = "btn_SeKunder";
            this.btn_SeKunder.Size = new System.Drawing.Size(400, 334);
            this.btn_SeKunder.TabIndex = 1;
            this.btn_SeKunder.Text = "Se kunder";
            this.btn_SeKunder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SeKunder.UseVisualStyleBackColor = false;
            this.btn_SeKunder.Click += new System.EventHandler(this.btn_SeKunder_Click);
            // 
            // btn_SeBaner
            // 
            this.btn_SeBaner.BackColor = System.Drawing.Color.White;
            this.btn_SeBaner.BackgroundImage = global::ProgB.Properties.Resources.bane_icon;
            this.btn_SeBaner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SeBaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_SeBaner.Location = new System.Drawing.Point(473, 105);
            this.btn_SeBaner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SeBaner.Name = "btn_SeBaner";
            this.btn_SeBaner.Size = new System.Drawing.Size(400, 334);
            this.btn_SeBaner.TabIndex = 0;
            this.btn_SeBaner.Text = "Se baner i brug";
            this.btn_SeBaner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SeBaner.UseVisualStyleBackColor = false;
            this.btn_SeBaner.Click += new System.EventHandler(this.btn_SeBaner_Click);
            // 
            // HovedmenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 523);
            this.Controls.Add(this.btn_SeKunder);
            this.Controls.Add(this.btn_SeBaner);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HovedmenuAdmin";
            this.Text = "HovedmenuAdmin";
            this.Load += new System.EventHandler(this.HovedmenuAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SeBaner;
        private System.Windows.Forms.Button btn_SeKunder;
    }
}