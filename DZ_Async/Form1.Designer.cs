namespace DZ_Async
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAsync;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonBegin;
        private System.Windows.Forms.ToolStripButton toolStripButtonAsync;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBegin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAsync = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAsync = new System.Windows.Forms.Button();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginEndToolStripMenuItem,
            this.asyncToolStripMenuItem});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.executeToolStripMenuItem.Text = "Execute";
            // 
            // beginEndToolStripMenuItem
            // 
            this.beginEndToolStripMenuItem.Enabled = false;
            this.beginEndToolStripMenuItem.Name = "beginEndToolStripMenuItem";
            this.beginEndToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beginEndToolStripMenuItem.Text = "Begin-End";
            this.beginEndToolStripMenuItem.ToolTipText = "Execute request through Begin-End method";
            this.beginEndToolStripMenuItem.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // asyncToolStripMenuItem
            // 
            this.asyncToolStripMenuItem.Enabled = false;
            this.asyncToolStripMenuItem.Name = "asyncToolStripMenuItem";
            this.asyncToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asyncToolStripMenuItem.Text = "Async";
            this.asyncToolStripMenuItem.ToolTipText = "Execute request through Async method";
            this.asyncToolStripMenuItem.Click += new System.EventHandler(this.buttonAsync_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBegin,
            this.toolStripButtonAsync,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBegin
            // 
            this.toolStripButtonBegin.Enabled = false;
            this.toolStripButtonBegin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBegin.Name = "toolStripButtonBegin";
            this.toolStripButtonBegin.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonBegin.Text = "Begin-End";
            this.toolStripButtonBegin.ToolTipText = "Execute request through Begin-End method";
            this.toolStripButtonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // toolStripButtonAsync
            // 
            this.toolStripButtonAsync.Enabled = false;
            this.toolStripButtonAsync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAsync.Name = "toolStripButtonAsync";
            this.toolStripButtonAsync.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonAsync.Text = "Async";
            this.toolStripButtonAsync.ToolTipText = "Execute request through Async method";
            this.toolStripButtonAsync.Click += new System.EventHandler(this.buttonAsync_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton1.Text = "Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonAsync);
            this.panel1.Controls.Add(this.buttonBegin);
            this.panel1.Controls.Add(this.textBoxQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 71);
            this.panel1.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(624, 40);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAsync
            // 
            this.buttonAsync.Enabled = false;
            this.buttonAsync.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAsync.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAsync.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsync.Location = new System.Drawing.Point(256, 40);
            this.buttonAsync.Name = "buttonAsync";
            this.buttonAsync.Size = new System.Drawing.Size(75, 23);
            this.buttonAsync.TabIndex = 2;
            this.buttonAsync.Text = "Async";
            this.toolTip1.SetToolTip(this.buttonAsync, "Execute request through Async method");
            this.buttonAsync.UseVisualStyleBackColor = true;
            this.buttonAsync.Click += new System.EventHandler(this.buttonAsync_Click);
            // 
            // buttonBegin
            // 
            this.buttonBegin.Enabled = false;
            this.buttonBegin.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonBegin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBegin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBegin.Location = new System.Drawing.Point(136, 40);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonBegin.TabIndex = 1;
            this.buttonBegin.Text = "Begin-End";
            this.toolTip1.SetToolTip(this.buttonBegin, "Execute request through Begin-End method");
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(16, 8);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(704, 20);
            this.textBoxQuery.TabIndex = 0;
            this.textBoxQuery.Text = "select * from Names; waitfor delay \'0:0:3\';";
            this.toolTip1.SetToolTip(this.textBoxQuery, "Enter query here...");
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 225);
            this.dataGridView1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DZ_Async";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

