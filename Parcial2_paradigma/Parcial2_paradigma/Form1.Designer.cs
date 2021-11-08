
namespace Parcial2_paradigma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnParquear = new System.Windows.Forms.Button();
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original ParkinLot";
            // 
            // BtnParquear
            // 
            this.BtnParquear.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnParquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnParquear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnParquear.Location = new System.Drawing.Point(143, 191);
            this.BtnParquear.Name = "BtnParquear";
            this.BtnParquear.Size = new System.Drawing.Size(196, 122);
            this.BtnParquear.TabIndex = 1;
            this.BtnParquear.Text = "Parquear";
            this.BtnParquear.UseVisualStyleBackColor = false;
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnRetirar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRetirar.Location = new System.Drawing.Point(445, 191);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(196, 122);
            this.BtnRetirar.TabIndex = 2;
            this.BtnRetirar.Text = "Retirar";
            this.BtnRetirar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRetirar);
            this.Controls.Add(this.BtnParquear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnParquear;
        private System.Windows.Forms.Button BtnRetirar;
    }
}

