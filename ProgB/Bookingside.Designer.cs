namespace ProgB
{
    partial class Bookingside
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vælg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_booking = new System.Windows.Forms.DateTimePicker();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.cmb_Tidspunkt = new System.Windows.Forms.ComboBox();
            this.btn_Tilbage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fodbold",
            "Håndbold",
            "Floorbold"});
            this.comboBox1.Location = new System.Drawing.Point(421, 179);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hvilken type bane vil du booke";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_vælg
            // 
            this.btn_vælg.BackColor = System.Drawing.Color.White;
            this.btn_vælg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_vælg.Location = new System.Drawing.Point(404, 394);
            this.btn_vælg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_vælg.Name = "btn_vælg";
            this.btn_vælg.Size = new System.Drawing.Size(184, 65);
            this.btn_vælg.TabIndex = 2;
            this.btn_vælg.Text = "Book";
            this.btn_vælg.UseVisualStyleBackColor = false;
            this.btn_vælg.Click += new System.EventHandler(this.btn_vælg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(372, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hvilken dato vil du gerne spille";
            // 
            // dtp_booking
            // 
            this.dtp_booking.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtp_booking.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_booking.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtp_booking.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtp_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtp_booking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_booking.Location = new System.Drawing.Point(376, 269);
            this.dtp_booking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_booking.Name = "dtp_booking";
            this.dtp_booking.Size = new System.Drawing.Size(224, 28);
            this.dtp_booking.TabIndex = 5;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // cmb_Tidspunkt
            // 
            this.cmb_Tidspunkt.BackColor = System.Drawing.Color.White;
            this.cmb_Tidspunkt.FormattingEnabled = true;
            this.cmb_Tidspunkt.Items.AddRange(new object[] {
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmb_Tidspunkt.Location = new System.Drawing.Point(421, 358);
            this.cmb_Tidspunkt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Tidspunkt.Name = "cmb_Tidspunkt";
            this.cmb_Tidspunkt.Size = new System.Drawing.Size(150, 28);
            this.cmb_Tidspunkt.TabIndex = 6;
            // 
            // btn_Tilbage
            // 
            this.btn_Tilbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tilbage.Location = new System.Drawing.Point(78, 39);
            this.btn_Tilbage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Tilbage.Name = "btn_Tilbage";
            this.btn_Tilbage.Size = new System.Drawing.Size(153, 84);
            this.btn_Tilbage.TabIndex = 7;
            this.btn_Tilbage.Text = "Tilbage";
            this.btn_Tilbage.UseVisualStyleBackColor = true;
            this.btn_Tilbage.Click += new System.EventHandler(this.btn_Tilbage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(372, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "hvilket klokkeslet vil du gerne spille";
            // 
            // Bookingside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgB.Properties.Resources.børn_spiller_sport;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Tilbage);
            this.Controls.Add(this.cmb_Tidspunkt);
            this.Controls.Add(this.dtp_booking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_vælg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bookingside";
            this.Text = "Bookingside";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_vælg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_booking;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ComboBox cmb_Tidspunkt;
        private System.Windows.Forms.Button btn_Tilbage;
        private System.Windows.Forms.Label label3;
    }
}