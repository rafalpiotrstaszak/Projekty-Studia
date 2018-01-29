namespace Kalkulator_Dopasowań
{
    partial class menu
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
            this.b_exit = new System.Windows.Forms.Button();
            this.b_instrukcja = new System.Windows.Forms.Button();
            this.b_edytor = new System.Windows.Forms.Button();
            this.b_kalkulator = new System.Windows.Forms.Button();
            this.version_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.LightCoral;
            this.b_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_exit.Location = new System.Drawing.Point(12, 269);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(260, 50);
            this.b_exit.TabIndex = 0;
            this.b_exit.Text = "WYJŚCIE";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_instrukcja
            // 
            this.b_instrukcja.BackColor = System.Drawing.Color.Thistle;
            this.b_instrukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_instrukcja.Location = new System.Drawing.Point(12, 213);
            this.b_instrukcja.Name = "b_instrukcja";
            this.b_instrukcja.Size = new System.Drawing.Size(260, 50);
            this.b_instrukcja.TabIndex = 1;
            this.b_instrukcja.Text = "INSTRUKCJA / O AUTORZE";
            this.b_instrukcja.UseVisualStyleBackColor = false;
            this.b_instrukcja.Click += new System.EventHandler(this.b_instrukcja_Click);
            // 
            // b_edytor
            // 
            this.b_edytor.BackColor = System.Drawing.Color.Khaki;
            this.b_edytor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_edytor.Location = new System.Drawing.Point(12, 157);
            this.b_edytor.Name = "b_edytor";
            this.b_edytor.Size = new System.Drawing.Size(260, 50);
            this.b_edytor.TabIndex = 2;
            this.b_edytor.Text = "EDYTOR CECH";
            this.b_edytor.UseVisualStyleBackColor = false;
            this.b_edytor.Click += new System.EventHandler(this.b_edytor_Click);
            // 
            // b_kalkulator
            // 
            this.b_kalkulator.BackColor = System.Drawing.Color.PaleGreen;
            this.b_kalkulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_kalkulator.Location = new System.Drawing.Point(12, 101);
            this.b_kalkulator.Name = "b_kalkulator";
            this.b_kalkulator.Size = new System.Drawing.Size(260, 50);
            this.b_kalkulator.TabIndex = 3;
            this.b_kalkulator.Text = "KALKULATOR";
            this.b_kalkulator.UseVisualStyleBackColor = false;
            this.b_kalkulator.Click += new System.EventHandler(this.b_kalkulator_Click);
            // 
            // version_info
            // 
            this.version_info.AutoSize = true;
            this.version_info.Location = new System.Drawing.Point(220, 340);
            this.version_info.Name = "version_info";
            this.version_info.Size = new System.Drawing.Size(52, 13);
            this.version_info.TabIndex = 4;
            this.version_info.Text = "ver. 0.2.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kalkulator dopasowań";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.version_info);
            this.Controls.Add(this.b_kalkulator);
            this.Controls.Add(this.b_edytor);
            this.Controls.Add(this.b_instrukcja);
            this.Controls.Add(this.b_exit);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator dopasowań";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_instrukcja;
        private System.Windows.Forms.Button b_edytor;
        private System.Windows.Forms.Button b_kalkulator;
        private System.Windows.Forms.Label version_info;
        private System.Windows.Forms.Label label1;
    }
}

