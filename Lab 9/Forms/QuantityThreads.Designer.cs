﻿namespace XMLGUI.Forms
{
    partial class QuantityThreads
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
            this.paramTxtBox = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paramTxtBox
            // 
            this.paramTxtBox.Location = new System.Drawing.Point(16, 50);
            this.paramTxtBox.Name = "paramTxtBox";
            this.paramTxtBox.Size = new System.Drawing.Size(278, 22);
            this.paramTxtBox.TabIndex = 0;
            this.paramTxtBox.TextChanged += new System.EventHandler(this.paramTxtBox_TextChanged);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.LightGray;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnApply.Location = new System.Drawing.Point(98, 86);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(112, 51);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "ОК";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.OnBtnApplyClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ведите количество участников:";
            // 
            // QuantityThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(313, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.paramTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuantityThreads";
            this.Text = "Количество потоков";
            this.Load += new System.EventHandler(this.QuantityThreads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paramTxtBox;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
    }
}