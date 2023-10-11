namespace BasicFluidFlowCalculator
{
    partial class FrmMain
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
            this.txtbAtmero = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.cmbFluids = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbAtmero
            // 
            this.txtbAtmero.Location = new System.Drawing.Point(34, 43);
            this.txtbAtmero.Name = "txtbAtmero";
            this.txtbAtmero.Size = new System.Drawing.Size(200, 20);
            this.txtbAtmero.TabIndex = 0;
            this.txtbAtmero.Text = "5";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(254, 43);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(200, 20);
            this.txtLength.TabIndex = 0;
            this.txtLength.Text = "10";
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(489, 43);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(200, 20);
            this.txtPressure.TabIndex = 0;
            this.txtPressure.Text = "30";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(254, 327);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(200, 20);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Átmérő(d)(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cső hossz (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nyomáskülönbség (P)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Eredmény (ml)";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(254, 393);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(200, 23);
            this.btnSzamol.TabIndex = 2;
            this.btnSzamol.Text = "Számolás!";
            this.btnSzamol.UseVisualStyleBackColor = true;
            // 
            // cmbFluids
            // 
            this.cmbFluids.FormattingEnabled = true;
            this.cmbFluids.Location = new System.Drawing.Point(291, 115);
            this.cmbFluids.Name = "cmbFluids";
            this.cmbFluids.Size = new System.Drawing.Size(121, 21);
            this.cmbFluids.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eltelt idő";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(489, 327);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 566);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFluids);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtbAtmero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbAtmero;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.ComboBox cmbFluids;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTime;
    }
}

