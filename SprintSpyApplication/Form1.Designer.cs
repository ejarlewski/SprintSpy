namespace SprintSpyApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShowNotificationButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storyNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprintItemsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintItemsDataSet = new SprintSpyApplication.SprintItemsDataSet();
            this.storyTableAdapter = new SprintSpyApplication.SprintItemsDataSetTableAdapters.StoryTableAdapter();
            this.TestAddRowButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintItemsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintItemsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowNotificationButton
            // 
            this.ShowNotificationButton.Location = new System.Drawing.Point(12, 12);
            this.ShowNotificationButton.Name = "ShowNotificationButton";
            this.ShowNotificationButton.Size = new System.Drawing.Size(121, 23);
            this.ShowNotificationButton.TabIndex = 0;
            this.ShowNotificationButton.Text = "Show  Notification";
            this.ShowNotificationButton.UseVisualStyleBackColor = true;
            this.ShowNotificationButton.Click += new System.EventHandler(this.ShowNotificationButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SprintSpy";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 48);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storyNumberDataGridViewTextBoxColumn,
            this.storyTitleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 383);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // storyBindingSource
            // 
            this.storyBindingSource.DataMember = "Story";
            this.storyBindingSource.DataSource = this.sprintItemsDataSetBindingSource;
            // 
            // storyNumberDataGridViewTextBoxColumn
            // 
            this.storyNumberDataGridViewTextBoxColumn.DataPropertyName = "StoryNumber";
            this.storyNumberDataGridViewTextBoxColumn.HeaderText = "StoryNumber";
            this.storyNumberDataGridViewTextBoxColumn.Name = "storyNumberDataGridViewTextBoxColumn";
            this.storyNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storyTitleDataGridViewTextBoxColumn
            // 
            this.storyTitleDataGridViewTextBoxColumn.DataPropertyName = "StoryTitle";
            this.storyTitleDataGridViewTextBoxColumn.HeaderText = "StoryTitle";
            this.storyTitleDataGridViewTextBoxColumn.Name = "storyTitleDataGridViewTextBoxColumn";
            this.storyTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sprintItemsDataSetBindingSource
            // 
            this.sprintItemsDataSetBindingSource.DataSource = this.sprintItemsDataSet;
            this.sprintItemsDataSetBindingSource.Position = 0;
            // 
            // sprintItemsDataSet
            // 
            this.sprintItemsDataSet.DataSetName = "SprintItemsDataSet";
            this.sprintItemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storyTableAdapter
            // 
            this.storyTableAdapter.ClearBeforeFill = true;
            // 
            // TestAddRowButton
            // 
            this.TestAddRowButton.Location = new System.Drawing.Point(139, 12);
            this.TestAddRowButton.Name = "TestAddRowButton";
            this.TestAddRowButton.Size = new System.Drawing.Size(145, 23);
            this.TestAddRowButton.TabIndex = 2;
            this.TestAddRowButton.Text = "Add a test row";
            this.TestAddRowButton.UseVisualStyleBackColor = true;
            this.TestAddRowButton.Click += new System.EventHandler(this.TestAddRowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestAddRowButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowNotificationButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sprint Spy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintItemsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintItemsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowNotificationButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sprintItemsDataSetBindingSource;
        private SprintItemsDataSet sprintItemsDataSet;
        private System.Windows.Forms.BindingSource storyBindingSource;
        private SprintItemsDataSetTableAdapters.StoryTableAdapter storyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button TestAddRowButton;
    }
}

