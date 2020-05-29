namespace XMLGUI
{
    partial class ThreadConstr
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chat = new System.Windows.Forms.RichTextBox();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chat
            // 
            this.chat.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat.Location = new System.Drawing.Point(0, 39);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(800, 410);
            this.chat.TabIndex = 2;
            this.chat.Tag = "";
            this.chat.Text = "";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.AutoSize = false;
            this.filterToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.filterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.filterToolStripMenuItem.Text = "Количество потоков";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // setTimeToolStripMenuItem
            // 
            this.setTimeToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.setTimeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setTimeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.setTimeToolStripMenuItem.Name = "setTimeToolStripMenuItem";
            this.setTimeToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.setTimeToolStripMenuItem.Size = new System.Drawing.Size(155, 32);
            this.setTimeToolStripMenuItem.Text = "Задержка (мс)";
            this.setTimeToolStripMenuItem.Click += new System.EventHandler(this.setTimeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.setTimeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(800, 100);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThreadConstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ThreadConstr";
            this.Text = "Chat Lab 8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox chat;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTimeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

