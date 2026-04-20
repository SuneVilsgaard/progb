namespace ProgB
{
    partial class SeBanerAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_tilbage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_tilbage
            // 
            this.btn_tilbage.Location = new System.Drawing.Point(56, 12);
            this.btn_tilbage.Name = "btn_tilbage";
            this.btn_tilbage.Size = new System.Drawing.Size(141, 53);
            this.btn_tilbage.TabIndex = 1;
            this.btn_tilbage.Text = "Tilbage";
            this.btn_tilbage.UseVisualStyleBackColor = true;
            this.btn_tilbage.Click += new System.EventHandler(this.btn_tilbage_Click);
            // 
            // SeBanerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tilbage);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeBanerAdmin";
            this.Text = "SeBanerAdmin";
            this.Load += new System.EventHandler(this.SeBanerAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_tilbage;
    }
}