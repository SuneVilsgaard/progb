namespace ProgB
{
    partial class HovedmenuKunde
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
            this.btn_bookBane = new System.Windows.Forms.Button();
            this.btn_SeBookinger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_bookBane
            // 
            this.btn_bookBane.Location = new System.Drawing.Point(203, 138);
            this.btn_bookBane.Name = "btn_bookBane";
            this.btn_bookBane.Size = new System.Drawing.Size(100, 48);
            this.btn_bookBane.TabIndex = 0;
            this.btn_bookBane.Text = "Book bane";
            this.btn_bookBane.UseVisualStyleBackColor = true;
            this.btn_bookBane.Click += new System.EventHandler(this.btn_bookBane_Click);
            // 
            // btn_SeBookinger
            // 
            this.btn_SeBookinger.Location = new System.Drawing.Point(361, 138);
            this.btn_SeBookinger.Name = "btn_SeBookinger";
            this.btn_SeBookinger.Size = new System.Drawing.Size(100, 48);
            this.btn_SeBookinger.TabIndex = 1;
            this.btn_SeBookinger.Text = "Se bookinger";
            this.btn_SeBookinger.UseVisualStyleBackColor = true;
            // 
            // Hovedmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SeBookinger);
            this.Controls.Add(this.btn_bookBane);
            this.Name = "Hovedmenu";
            this.Text = "Hovedmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bookBane;
        private System.Windows.Forms.Button btn_SeBookinger;
    }
}