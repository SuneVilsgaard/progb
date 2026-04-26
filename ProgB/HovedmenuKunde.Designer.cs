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
            this.btn_bookBane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_bookBane.Location = new System.Drawing.Point(195, 313);
            this.btn_bookBane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bookBane.Name = "btn_bookBane";
            this.btn_bookBane.Size = new System.Drawing.Size(228, 117);
            this.btn_bookBane.TabIndex = 0;
            this.btn_bookBane.Text = "Book bane";
            this.btn_bookBane.UseVisualStyleBackColor = true;
            this.btn_bookBane.Click += new System.EventHandler(this.btn_bookBane_Click);
            // 
            // btn_SeBookinger
            // 
            this.btn_SeBookinger.BackColor = System.Drawing.Color.Transparent;
            this.btn_SeBookinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SeBookinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeBookinger.Location = new System.Drawing.Point(446, 313);
            this.btn_SeBookinger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SeBookinger.Name = "btn_SeBookinger";
            this.btn_SeBookinger.Size = new System.Drawing.Size(219, 117);
            this.btn_SeBookinger.TabIndex = 1;
            this.btn_SeBookinger.Text = "Se bookinger";
            this.btn_SeBookinger.UseVisualStyleBackColor = false;
            this.btn_SeBookinger.Click += new System.EventHandler(this.btn_SeBookinger_Click);
            // 
            // HovedmenuKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgB.Properties.Resources.hal_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btn_SeBookinger);
            this.Controls.Add(this.btn_bookBane);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HovedmenuKunde";
            this.Text = "Hovedmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bookBane;
        private System.Windows.Forms.Button btn_SeBookinger;
    }
}