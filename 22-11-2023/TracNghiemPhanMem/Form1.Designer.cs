namespace TracNghiemPhanMem
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
            this.lbQ = new System.Windows.Forms.Label();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQ
            // 
            this.lbQ.AutoSize = true;
            this.lbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ.Location = new System.Drawing.Point(53, 110);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(119, 32);
            this.lbQ.TabIndex = 0;
            this.lbQ.Text = "Cau hoi";
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoA.Location = new System.Drawing.Point(190, 186);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(86, 29);
            this.rdoA.TabIndex = 1;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "Cau a";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoB.Location = new System.Drawing.Point(190, 245);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(86, 29);
            this.rdoB.TabIndex = 2;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "Cau b";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoC.Location = new System.Drawing.Point(190, 313);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(85, 29);
            this.rdoC.TabIndex = 3;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "Cau c";
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoD.Location = new System.Drawing.Point(190, 386);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(86, 29);
            this.rdoD.TabIndex = 4;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "Cau d";
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(678, 445);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 36);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 513);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdoD);
            this.Controls.Add(this.rdoC);
            this.Controls.Add(this.rdoB);
            this.Controls.Add(this.rdoA);
            this.Controls.Add(this.lbQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQ;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.Button btnNext;
    }
}

