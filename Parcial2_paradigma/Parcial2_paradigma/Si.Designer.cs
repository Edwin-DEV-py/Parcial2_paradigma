
namespace Parcial2_paradigma
{
    partial class Si
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CedulaSi = new System.Windows.Forms.RichTextBox();
            this.PlacaSi = new System.Windows.Forms.RichTextBox();
            this.BtnParquearSi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original ParkinLot";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(51, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Placa:";
            // 
            // CedulaSi
            // 
            this.CedulaSi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CedulaSi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CedulaSi.Location = new System.Drawing.Point(167, 150);
            this.CedulaSi.Name = "CedulaSi";
            this.CedulaSi.Size = new System.Drawing.Size(234, 31);
            this.CedulaSi.TabIndex = 4;
            this.CedulaSi.Text = "";
            // 
            // PlacaSi
            // 
            this.PlacaSi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlacaSi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlacaSi.Location = new System.Drawing.Point(143, 216);
            this.PlacaSi.Name = "PlacaSi";
            this.PlacaSi.Size = new System.Drawing.Size(234, 31);
            this.PlacaSi.TabIndex = 5;
            this.PlacaSi.Text = "";
            // 
            // BtnParquearSi
            // 
            this.BtnParquearSi.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnParquearSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnParquearSi.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnParquearSi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnParquearSi.Location = new System.Drawing.Point(124, 335);
            this.BtnParquearSi.Name = "BtnParquearSi";
            this.BtnParquearSi.Size = new System.Drawing.Size(227, 74);
            this.BtnParquearSi.TabIndex = 6;
            this.BtnParquearSi.Text = "Parquear";
            this.BtnParquearSi.UseVisualStyleBackColor = false;
            // 
            // Si
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.BtnParquearSi);
            this.Controls.Add(this.PlacaSi);
            this.Controls.Add(this.CedulaSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Si";
            this.Text = "Si";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CedulaSi;
        private System.Windows.Forms.RichTextBox PlacaSi;
        private System.Windows.Forms.Button BtnParquearSi;
    }
}