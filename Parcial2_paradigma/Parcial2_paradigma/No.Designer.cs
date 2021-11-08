
namespace Parcial2_paradigma
{
    partial class No
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
            this.BtnParquearNo = new System.Windows.Forms.Button();
            this.NombreNo = new System.Windows.Forms.RichTextBox();
            this.CedulaNo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlacaNo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnParquearNo
            // 
            this.BtnParquearNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnParquearNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnParquearNo.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnParquearNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnParquearNo.Location = new System.Drawing.Point(118, 339);
            this.BtnParquearNo.Name = "BtnParquearNo";
            this.BtnParquearNo.Size = new System.Drawing.Size(227, 74);
            this.BtnParquearNo.TabIndex = 12;
            this.BtnParquearNo.Text = "Parquear";
            this.BtnParquearNo.UseVisualStyleBackColor = false;
            // 
            // NombreNo
            // 
            this.NombreNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NombreNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreNo.Location = new System.Drawing.Point(185, 206);
            this.NombreNo.Name = "NombreNo";
            this.NombreNo.Size = new System.Drawing.Size(234, 31);
            this.NombreNo.TabIndex = 11;
            this.NombreNo.Text = "";
            // 
            // CedulaNo
            // 
            this.CedulaNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CedulaNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CedulaNo.Location = new System.Drawing.Point(170, 140);
            this.CedulaNo.Name = "CedulaNo";
            this.CedulaNo.Size = new System.Drawing.Size(234, 31);
            this.CedulaNo.TabIndex = 10;
            this.CedulaNo.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(54, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(54, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cedula:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Original ParkinLot";
            // 
            // PlacaNo
            // 
            this.PlacaNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlacaNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlacaNo.Location = new System.Drawing.Point(146, 261);
            this.PlacaNo.Name = "PlacaNo";
            this.PlacaNo.Size = new System.Drawing.Size(234, 31);
            this.PlacaNo.TabIndex = 14;
            this.PlacaNo.Text = "";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(54, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Placa:";
            // 
            // No
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.PlacaNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnParquearNo);
            this.Controls.Add(this.NombreNo);
            this.Controls.Add(this.CedulaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "No";
            this.Text = "No";
            this.Load += new System.EventHandler(this.No_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnParquearNo;
        private System.Windows.Forms.RichTextBox NombreNo;
        private System.Windows.Forms.RichTextBox CedulaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox PlacaNo;
        private System.Windows.Forms.Label label4;
    }
}