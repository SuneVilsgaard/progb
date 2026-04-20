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
            this.btn_SeBaner = new System.Windows.Forms.Button();
            this.btn_SeKunder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SeBaner
            // 
            this.btn_SeBaner.Location = new System.Drawing.Point(110, 85);
            this.btn_SeBaner.Name = "btn_SeBaner";
            this.btn_SeBaner.Size = new System.Drawing.Size(195, 108);
            this.btn_SeBaner.TabIndex = 0;
            this.btn_SeBaner.Text = "Se baner i brug";
            this.btn_SeBaner.UseVisualStyleBackColor = true;
            this.btn_SeBaner.Click += new System.EventHandler(this.btn_SeBaner_Click);
            // 
            // btn_SeKunder
            // 
            this.btn_SeKunder.Location = new System.Drawing.Point(330, 85);
            this.btn_SeKunder.Name = "btn_SeKunder";
            this.btn_SeKunder.Size = new System.Drawing.Size(195, 108);
            this.btn_SeKunder.TabIndex = 1;
            this.btn_SeKunder.Text = "Se kunder";
            this.btn_SeKunder.UseVisualStyleBackColor = true;
            this.btn_SeKunder.Click += new System.EventHandler(this.btn_SeKunder_Click);
            // 
            // HovedmenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SeKunder);
            this.Controls.Add(this.btn_SeBaner);
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