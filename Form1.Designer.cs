namespace C_sharp_Lab5
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jKNNJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dFSFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fSDFSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDFSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveModifiedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(800, 208);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jKNNJToolStripMenuItem,
            this.fSDFSDToolStripMenuItem,
            this.saveModifiedFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jKNNJToolStripMenuItem
            // 
            this.jKNNJToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dFSFSToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.jKNNJToolStripMenuItem.Name = "jKNNJToolStripMenuItem";
            this.jKNNJToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.jKNNJToolStripMenuItem.Text = "File";
            // 
            // dFSFSToolStripMenuItem
            // 
            this.dFSFSToolStripMenuItem.Name = "dFSFSToolStripMenuItem";
            this.dFSFSToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dFSFSToolStripMenuItem.Text = "Новый файл";
            this.dFSFSToolStripMenuItem.Click += new System.EventHandler(this.NewFIleToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // fSDFSDToolStripMenuItem
            // 
            this.fSDFSDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sDFSDToolStripMenuItem,
            this.очиститьРезультатToolStripMenuItem});
            this.fSDFSDToolStripMenuItem.Name = "fSDFSDToolStripMenuItem";
            this.fSDFSDToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fSDFSDToolStripMenuItem.Text = "Edit";
            // 
            // sDFSDToolStripMenuItem
            // 
            this.sDFSDToolStripMenuItem.Name = "sDFSDToolStripMenuItem";
            this.sDFSDToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sDFSDToolStripMenuItem.Text = "Обработать файл";
            this.sDFSDToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // очиститьРезультатToolStripMenuItem
            // 
            this.очиститьРезультатToolStripMenuItem.Name = "очиститьРезультатToolStripMenuItem";
            this.очиститьРезультатToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.очиститьРезультатToolStripMenuItem.Text = "Очистить результат";
            this.очиститьРезультатToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 226);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(800, 228);
            this.textBox2.TabIndex = 2;
            // 
            // saveModifiedFileToolStripMenuItem
            // 
            this.saveModifiedFileToolStripMenuItem.Name = "saveModifiedFileToolStripMenuItem";
            this.saveModifiedFileToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.saveModifiedFileToolStripMenuItem.Text = "Save modified file";
            this.saveModifiedFileToolStripMenuItem.Click += new System.EventHandler(this.saveModifiedFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jKNNJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dFSFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fSDFSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDFSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьРезультатToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem saveModifiedFileToolStripMenuItem;
    }
}

