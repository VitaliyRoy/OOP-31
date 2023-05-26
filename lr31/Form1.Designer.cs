namespace lr31
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
            this.components = new System.ComponentModel.Container();
            this.processListView = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProcessInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(12, 12);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(450, 426);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.processListView_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProcessInfoToolStripMenuItem,
            this.stopProcessToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exportToFileToolStripMenuItem,
            this.viewThreadsToolStripMenuItem,
            this.viewModulesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(167, 136);
            // 
            // viewProcessInfoToolStripMenuItem
            // 
            this.viewProcessInfoToolStripMenuItem.Name = "viewProcessInfoToolStripMenuItem";
            this.viewProcessInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewProcessInfoToolStripMenuItem.Text = "View Process Info";
            this.viewProcessInfoToolStripMenuItem.Click += new System.EventHandler(this.viewProcessInfoToolStripMenuItem_Click);
            // 
            // stopProcessToolStripMenuItem
            // 
            this.stopProcessToolStripMenuItem.Name = "stopProcessToolStripMenuItem";
            this.stopProcessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopProcessToolStripMenuItem.Text = "Stop Process";
            this.stopProcessToolStripMenuItem.Click += new System.EventHandler(this.stopProcessToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exportToFileToolStripMenuItem
            // 
            this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
            this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToFileToolStripMenuItem.Text = "Export to File";
            this.exportToFileToolStripMenuItem.Click += new System.EventHandler(this.exportToFileToolStripMenuItem_Click);
            // 
            // viewThreadsToolStripMenuItem
            // 
            this.viewThreadsToolStripMenuItem.Name = "viewThreadsToolStripMenuItem";
            this.viewThreadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewThreadsToolStripMenuItem.Text = "View Threads";
            this.viewThreadsToolStripMenuItem.Click += new System.EventHandler(this.viewThreadsToolStripMenuItem_Click);
            // 
            // viewModulesToolStripMenuItem
            // 
            this.viewModulesToolStripMenuItem.Name = "viewModulesToolStripMenuItem";
            this.viewModulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewModulesToolStripMenuItem.Text = "View Modules";
            this.viewModulesToolStripMenuItem.Click += new System.EventHandler(this.viewModulesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.processListView);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 31";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewProcessInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewModulesToolStripMenuItem;
    }
}

