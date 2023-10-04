namespace NguyenTranTuanHuy_2001210642
{
    partial class Form1
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
            this.txtGiatri = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGiatri
            // 
            this.txtGiatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatri.Location = new System.Drawing.Point(363, 186);
            this.txtGiatri.Name = "txtGiatri";
            this.txtGiatri.Size = new System.Drawing.Size(184, 29);
            this.txtGiatri.TabIndex = 0;
            this.txtGiatri.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(163, 303);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(425, 303);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(657, 303);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 3;
            this.btnL.Text = "Leave";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 521);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.txtGiatri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiatri;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnL;
    }
}

