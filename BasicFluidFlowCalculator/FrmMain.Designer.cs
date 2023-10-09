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
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbAtmero
            // 
            this.txtbAtmero.Location = new System.Drawing.Point(34, 186);
            this.txtbAtmero.Name = "txtbAtmero";
            this.txtbAtmero.Size = new System.Drawing.Size(200, 20);
            this.txtbAtmero.TabIndex = 0;
            this.txtbAtmero.Text = "5";
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(254, 186);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(200, 20);
            this.txtVelocity.TabIndex = 0;
            this.txtVelocity.Text = "10";
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.Location = new System.Drawing.Point(489, 186);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.Size = new System.Drawing.Size(200, 20);
            this.txtElapsedTime.TabIndex = 0;
            this.txtElapsedTime.Text = "30";
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
            this.label1.Location = new System.Drawing.Point(34, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Átmérő(d)(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folyási Sebesség (m/s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Idő míg kitöltődik (s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Eredmény (dl)";
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 566);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElapsedTime);
            this.Controls.Add(this.txtVelocity);
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
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.TextBox txtElapsedTime;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSzamol;
    }
}

