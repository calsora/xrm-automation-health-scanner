namespace XrmAutomationHealthScannerPlugin
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.crmGridView2 = new xrmtb.XrmToolBox.Controls.CRMGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameSearchInput = new XrmToolBox.Controls.TextBoxWithPlaceholder();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bizrulescheckBox = new System.Windows.Forms.CheckBox();
            this.cloudflowscheckBox = new System.Windows.Forms.CheckBox();
            this.workflowscheckBox = new System.Windows.Forms.CheckBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.reportAIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crmGridView2
            // 
            this.crmGridView2.AllowUserToOrderColumns = true;
            this.crmGridView2.AllowUserToResizeRows = false;
            this.crmGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crmGridView2.ColumnOrder = "";
            this.crmGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmGridView2.FilterColumns = "";
            this.crmGridView2.Location = new System.Drawing.Point(0, 0);
            this.crmGridView2.Name = "crmGridView2";
            this.crmGridView2.OrganizationService = null;
            this.crmGridView2.RowHeadersWidth = 51;
            this.crmGridView2.RowTemplate.Height = 24;
            this.crmGridView2.Size = new System.Drawing.Size(782, 347);
            this.crmGridView2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 28);
            this.toolStripButton1.Text = "Close this tool";
            this.toolStripButton1.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(186, 28);
            this.toolStripButton2.Text = "Scan inactive automations";
            this.toolStripButton2.Click += new System.EventHandler(this.scanAutomationsButton1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AccessibleDescription = "hello";
            this.splitContainer2.Panel1.AccessibleName = "Helllo";
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.crmGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(786, 475);
            this.splitContainer2.SplitterDistance = 120;
            this.splitContainer2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameSearchInput);
            this.groupBox2.Location = new System.Drawing.Point(395, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by name";
            // 
            // nameSearchInput
            // 
            this.nameSearchInput.Enabled = false;
            this.nameSearchInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameSearchInput.Location = new System.Drawing.Point(6, 37);
            this.nameSearchInput.Name = "nameSearchInput";
            this.nameSearchInput.Placeholder = "Type to filter";
            this.nameSearchInput.Size = new System.Drawing.Size(152, 22);
            this.nameSearchInput.TabIndex = 1;
            this.nameSearchInput.Tag = true;
            this.nameSearchInput.TextChanged += new System.EventHandler(this.textBoxWithPlaceholder1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bizrulescheckBox);
            this.groupBox1.Controls.Add(this.cloudflowscheckBox);
            this.groupBox1.Controls.Add(this.workflowscheckBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter options";
            // 
            // bizrulescheckBox
            // 
            this.bizrulescheckBox.AutoSize = true;
            this.bizrulescheckBox.Checked = true;
            this.bizrulescheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bizrulescheckBox.Enabled = false;
            this.bizrulescheckBox.Location = new System.Drawing.Point(6, 39);
            this.bizrulescheckBox.Name = "bizrulescheckBox";
            this.bizrulescheckBox.Size = new System.Drawing.Size(116, 20);
            this.bizrulescheckBox.TabIndex = 3;
            this.bizrulescheckBox.Tag = "2";
            this.bizrulescheckBox.Text = "Business rules";
            this.bizrulescheckBox.UseVisualStyleBackColor = true;
            this.bizrulescheckBox.CheckedChanged += new System.EventHandler(this.scanAutomationsButton1_Click);
            // 
            // cloudflowscheckBox
            // 
            this.cloudflowscheckBox.AutoSize = true;
            this.cloudflowscheckBox.Checked = true;
            this.cloudflowscheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cloudflowscheckBox.Enabled = false;
            this.cloudflowscheckBox.Location = new System.Drawing.Point(139, 39);
            this.cloudflowscheckBox.Name = "cloudflowscheckBox";
            this.cloudflowscheckBox.Size = new System.Drawing.Size(97, 20);
            this.cloudflowscheckBox.TabIndex = 2;
            this.cloudflowscheckBox.Tag = "5";
            this.cloudflowscheckBox.Text = "Cloud flows";
            this.cloudflowscheckBox.UseVisualStyleBackColor = true;
            this.cloudflowscheckBox.CheckedChanged += new System.EventHandler(this.scanAutomationsButton1_Click);
            // 
            // workflowscheckBox
            // 
            this.workflowscheckBox.AutoSize = true;
            this.workflowscheckBox.Checked = true;
            this.workflowscheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workflowscheckBox.Enabled = false;
            this.workflowscheckBox.Location = new System.Drawing.Point(242, 39);
            this.workflowscheckBox.Name = "workflowscheckBox";
            this.workflowscheckBox.Size = new System.Drawing.Size(91, 20);
            this.workflowscheckBox.TabIndex = 0;
            this.workflowscheckBox.Tag = "0";
            this.workflowscheckBox.Text = "Workflows";
            this.workflowscheckBox.UseVisualStyleBackColor = true;
            this.workflowscheckBox.CheckedChanged += new System.EventHandler(this.scanAutomationsButton1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAIssueToolStripMenuItem,
            this.readmeToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 28);
            this.toolStripDropDownButton1.Text = "Github";
            // 
            // reportAIssueToolStripMenuItem
            // 
            this.reportAIssueToolStripMenuItem.Name = "reportAIssueToolStripMenuItem";
            this.reportAIssueToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.reportAIssueToolStripMenuItem.Text = "Raise issue / question";
            this.reportAIssueToolStripMenuItem.Click += new System.EventHandler(this.reportAIssueToolStripMenuItem_Click);
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.readmeToolStripMenuItem.Text = "Readme";
            this.readmeToolStripMenuItem.Click += new System.EventHandler(this.readmeToolStripMenuItem_Click);
            // 
            // MyPluginControl
            // 
            this.Controls.Add(this.splitContainer2);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(786, 475);
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl entitiesDropdownControl1;
        private xrmtb.XrmToolBox.Controls.Controls.CDSDataComboBox cdsDataComboBox1;
        private xrmtb.XrmToolBox.Controls.CRMGridView crmGridView1;
        private xrmtb.XrmToolBox.Controls.CRMGridView crmGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cloudflowscheckBox;
        private System.Windows.Forms.CheckBox workflowscheckBox;
        private System.Windows.Forms.CheckBox bizrulescheckBox;
        private XrmToolBox.Controls.TextBoxWithPlaceholder nameSearchInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem reportAIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
    }
}
