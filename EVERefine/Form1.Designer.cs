﻿namespace EVERefine
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
            this.label1 = new System.Windows.Forms.Label();
            this.KeyIDTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vCodeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.characterTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GetAssetsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KeyID";
            // 
            // KeyIDTxt
            // 
            this.KeyIDTxt.Location = new System.Drawing.Point(850, 25);
            this.KeyIDTxt.Name = "KeyIDTxt";
            this.KeyIDTxt.Size = new System.Drawing.Size(180, 20);
            this.KeyIDTxt.TabIndex = 1;
            this.KeyIDTxt.Text = "176111";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 575);
            this.dataGridView1.TabIndex = 2;
            // 
            // vCodeTxt
            // 
            this.vCodeTxt.Location = new System.Drawing.Point(850, 78);
            this.vCodeTxt.Name = "vCodeTxt";
            this.vCodeTxt.Size = new System.Drawing.Size(180, 20);
            this.vCodeTxt.TabIndex = 4;
            this.vCodeTxt.Text = "HjWMdixe3irh5hPuUhoDlbcUlJjGoGhYSfAQeC4iWbOl2PrrM520J5S2SZMaOjBb";
            this.vCodeTxt.TextChanged += new System.EventHandler(this.vCodeTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "vCode";
            // 
            // characterTxt
            // 
            this.characterTxt.Location = new System.Drawing.Point(850, 132);
            this.characterTxt.Name = "characterTxt";
            this.characterTxt.Size = new System.Drawing.Size(180, 20);
            this.characterTxt.TabIndex = 6;
            this.characterTxt.Text = "1143759521";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Character Name";
            // 
            // GetAssetsBtn
            // 
            this.GetAssetsBtn.Location = new System.Drawing.Point(856, 175);
            this.GetAssetsBtn.Name = "GetAssetsBtn";
            this.GetAssetsBtn.Size = new System.Drawing.Size(75, 23);
            this.GetAssetsBtn.TabIndex = 7;
            this.GetAssetsBtn.Text = "Get Assets";
            this.GetAssetsBtn.UseVisualStyleBackColor = true;
            this.GetAssetsBtn.Click += new System.EventHandler(this.GetAssetsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 593);
            this.Controls.Add(this.GetAssetsBtn);
            this.Controls.Add(this.characterTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vCodeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KeyIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyIDTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox vCodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox characterTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetAssetsBtn;
    }
}

