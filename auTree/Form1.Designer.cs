namespace auTree
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTreeJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relationsOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambiguityOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.saveTreeJPGToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.startToolStripMenuItem.Text = "Построить";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // saveTreeJPGToolStripMenuItem
            // 
            this.saveTreeJPGToolStripMenuItem.Name = "saveTreeJPGToolStripMenuItem";
            this.saveTreeJPGToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.saveTreeJPGToolStripMenuItem.Text = "Сохранить древо в JPG";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relationsOptionsToolStripMenuItem,
            this.ambiguityOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.optionsToolStripMenuItem.Text = "Настройки";
            // 
            // relationsOptionsToolStripMenuItem
            // 
            this.relationsOptionsToolStripMenuItem.Name = "relationsOptionsToolStripMenuItem";
            this.relationsOptionsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.relationsOptionsToolStripMenuItem.Text = "Настройки отношений";
            this.relationsOptionsToolStripMenuItem.Click += new System.EventHandler(this.relationsOptionsToolStripMenuItem_Click);
            // 
            // ambiguityOptionsToolStripMenuItem
            // 
            this.ambiguityOptionsToolStripMenuItem.Name = "ambiguityOptionsToolStripMenuItem";
            this.ambiguityOptionsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ambiguityOptionsToolStripMenuItem.Text = "Настройки неопределенностей";
            this.ambiguityOptionsToolStripMenuItem.Click += new System.EventHandler(this.ambiguityOptionsToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 700);
            this.Name = "Form1";
            this.Text = "auTree";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relationsOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambiguityOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTreeJPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

    }
}

