namespace Engine.Utils
{
    partial class DebugWindow
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
			this.label2 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.checkBoxHideStatic = new System.Windows.Forms.CheckBox();
			this.buttonSaveMap = new System.Windows.Forms.Button();
			this.checkBoxTransparent = new System.Windows.Forms.CheckBox();
			this.buttonUP = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.entityList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.checkbox_advanced = new System.Windows.Forms.CheckBox();
			this.propEditor = new System.Windows.Forms.PropertyGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxLive = new System.Windows.Forms.CheckBox();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Watcher = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.console = new System.Windows.Forms.TextBox();
			this.consoleLog = new System.Windows.Forms.TextBox();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.buttonSaveType = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.typeEditor = new System.Windows.Forms.PropertyGrid();
			this.WatcherViever = new System.Windows.Forms.PropertyGrid();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(670, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Entity";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.checkBoxHideStatic);
			this.splitContainer1.Panel1.Controls.Add(this.buttonSaveMap);
			this.splitContainer1.Panel1.Controls.Add(this.checkBoxTransparent);
			this.splitContainer1.Panel1.Controls.Add(this.buttonUP);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxFilter);
			this.splitContainer1.Panel1.Controls.Add(this.entityList);
			this.splitContainer1.Panel1.Controls.Add(this.checkBoxTopMost);
			this.splitContainer1.Panel1.Controls.Add(this.buttonRefresh);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(952, 674);
			this.splitContainer1.SplitterDistance = 327;
			this.splitContainer1.TabIndex = 10;
			// 
			// checkBoxHideStatic
			// 
			this.checkBoxHideStatic.AutoSize = true;
			this.checkBoxHideStatic.Checked = true;
			this.checkBoxHideStatic.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxHideStatic.Location = new System.Drawing.Point(135, 629);
			this.checkBoxHideStatic.Name = "checkBoxHideStatic";
			this.checkBoxHideStatic.Size = new System.Drawing.Size(115, 17);
			this.checkBoxHideStatic.TabIndex = 14;
			this.checkBoxHideStatic.Text = "Hide StaticMeshes";
			this.checkBoxHideStatic.UseVisualStyleBackColor = true;
			this.checkBoxHideStatic.CheckedChanged += new System.EventHandler(this.checkBoxShowStatic_CheckedChanged);
			// 
			// buttonSaveMap
			// 
			this.buttonSaveMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveMap.Location = new System.Drawing.Point(251, 0);
			this.buttonSaveMap.Name = "buttonSaveMap";
			this.buttonSaveMap.Size = new System.Drawing.Size(73, 24);
			this.buttonSaveMap.TabIndex = 13;
			this.buttonSaveMap.Text = "Save Map";
			this.buttonSaveMap.UseVisualStyleBackColor = true;
			this.buttonSaveMap.Visible = false;
			// 
			// checkBoxTransparent
			// 
			this.checkBoxTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxTransparent.AutoSize = true;
			this.checkBoxTransparent.Location = new System.Drawing.Point(15, 629);
			this.checkBoxTransparent.Name = "checkBoxTransparent";
			this.checkBoxTransparent.Size = new System.Drawing.Size(109, 17);
			this.checkBoxTransparent.TabIndex = 12;
			this.checkBoxTransparent.Text = "Semi-Transparent";
			this.checkBoxTransparent.UseVisualStyleBackColor = true;
			this.checkBoxTransparent.CheckedChanged += new System.EventHandler(this.checkBoxTransparent_CheckedChanged);
			// 
			// buttonUP
			// 
			this.buttonUP.Location = new System.Drawing.Point(3, 3);
			this.buttonUP.Name = "buttonUP";
			this.buttonUP.Size = new System.Drawing.Size(32, 21);
			this.buttonUP.TabIndex = 11;
			this.buttonUP.Text = "UP";
			this.buttonUP.UseVisualStyleBackColor = true;
			this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(132, 649);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Filter";
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFilter.Location = new System.Drawing.Point(167, 646);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(89, 20);
			this.textBoxFilter.TabIndex = 7;
			this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
			this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
			// 
			// entityList
			// 
			this.entityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.entityList.AutoArrange = false;
			this.entityList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.entityList.FullRowSelect = true;
			this.entityList.GridLines = true;
			this.entityList.HideSelection = false;
			this.entityList.Location = new System.Drawing.Point(0, 29);
			this.entityList.Name = "entityList";
			this.entityList.Size = new System.Drawing.Size(321, 594);
			this.entityList.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.entityList.TabIndex = 4;
			this.entityList.UseCompatibleStateImageBehavior = false;
			this.entityList.View = System.Windows.Forms.View.Details;
			this.entityList.SelectedIndexChanged += new System.EventHandler(this.entityList_SelectedIndexChanged);
			this.entityList.DoubleClick += new System.EventHandler(this.entityList_DoubleClick);
			this.entityList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entityList_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Entity Name";
			this.columnHeader1.Width = 149;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Entity Type";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Children";
			this.columnHeader3.Width = 57;
			// 
			// checkBoxTopMost
			// 
			this.checkBoxTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxTopMost.AutoSize = true;
			this.checkBoxTopMost.Location = new System.Drawing.Point(15, 652);
			this.checkBoxTopMost.Name = "checkBoxTopMost";
			this.checkBoxTopMost.Size = new System.Drawing.Size(71, 17);
			this.checkBoxTopMost.TabIndex = 6;
			this.checkBoxTopMost.Text = "Top Most";
			this.checkBoxTopMost.UseVisualStyleBackColor = true;
			this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRefresh.Location = new System.Drawing.Point(262, 643);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(59, 25);
			this.buttonRefresh.TabIndex = 5;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
			this.splitContainer2.Size = new System.Drawing.Size(621, 674);
			this.splitContainer2.SplitterDistance = 315;
			this.splitContainer2.TabIndex = 0;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.checkbox_advanced);
			this.splitContainer3.Panel1.Controls.Add(this.propEditor);
			this.splitContainer3.Panel1.Controls.Add(this.label3);
			this.splitContainer3.Panel1.Controls.Add(this.checkBoxLive);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
			this.splitContainer3.Size = new System.Drawing.Size(315, 674);
			this.splitContainer3.SplitterDistance = 339;
			this.splitContainer3.TabIndex = 12;
			// 
			// checkbox_advanced
			// 
			this.checkbox_advanced.AutoSize = true;
			this.checkbox_advanced.Checked = true;
			this.checkbox_advanced.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkbox_advanced.Location = new System.Drawing.Point(237, 3);
			this.checkbox_advanced.Name = "checkbox_advanced";
			this.checkbox_advanced.Size = new System.Drawing.Size(75, 17);
			this.checkbox_advanced.TabIndex = 13;
			this.checkbox_advanced.Text = "Advanced";
			this.checkbox_advanced.UseVisualStyleBackColor = true;
			this.checkbox_advanced.CheckedChanged += new System.EventHandler(this.checkbox_advanced_CheckedChanged);
			// 
			// propEditor
			// 
			this.propEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propEditor.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.propEditor.Location = new System.Drawing.Point(6, 30);
			this.propEditor.Name = "propEditor";
			this.propEditor.Size = new System.Drawing.Size(306, 297);
			this.propEditor.TabIndex = 10;
			this.propEditor.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propEditor_SelectedGridItemChanged);
			this.propEditor.Click += new System.EventHandler(this.propEditor_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "Object properties";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBoxLive
			// 
			this.checkBoxLive.AutoSize = true;
			this.checkBoxLive.Location = new System.Drawing.Point(185, 3);
			this.checkBoxLive.Name = "checkBoxLive";
			this.checkBoxLive.Size = new System.Drawing.Size(46, 17);
			this.checkBoxLive.TabIndex = 12;
			this.checkBoxLive.Text = "Live";
			this.checkBoxLive.UseVisualStyleBackColor = true;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.dataGridView1);
			this.splitContainer4.Panel1MinSize = 50;
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.console);
			this.splitContainer4.Panel2.Controls.Add(this.consoleLog);
			this.splitContainer4.Panel2MinSize = 50;
			this.splitContainer4.Size = new System.Drawing.Size(315, 331);
			this.splitContainer4.SplitterDistance = 245;
			this.splitContainer4.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Watcher,
            this.Data});
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.dataGridView1.Location = new System.Drawing.Point(3, 4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 10;
			this.dataGridView1.Size = new System.Drawing.Size(309, 238);
			this.dataGridView1.TabIndex = 14;
			// 
			// Watcher
			// 
			this.Watcher.HeaderText = "Watcher";
			this.Watcher.Name = "Watcher";
			this.Watcher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Data
			// 
			this.Data.HeaderText = "Data";
			this.Data.Name = "Data";
			this.Data.ReadOnly = true;
			this.Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// console
			// 
			this.console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.console.Location = new System.Drawing.Point(3, 60);
			this.console.Name = "console";
			this.console.Size = new System.Drawing.Size(312, 20);
			this.console.TabIndex = 15;
			this.console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.console_KeyDown);
			// 
			// consoleLog
			// 
			this.consoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.consoleLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.consoleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consoleLog.Location = new System.Drawing.Point(3, 3);
			this.consoleLog.Multiline = true;
			this.consoleLog.Name = "consoleLog";
			this.consoleLog.ReadOnly = true;
			this.consoleLog.Size = new System.Drawing.Size(312, 54);
			this.consoleLog.TabIndex = 16;
			this.consoleLog.Text = "Type console entry ex : this.UIN";
			this.consoleLog.WordWrap = false;
			// 
			// splitContainer5
			// 
			this.splitContainer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.buttonSaveType);
			this.splitContainer5.Panel1.Controls.Add(this.label4);
			this.splitContainer5.Panel1.Controls.Add(this.typeEditor);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.WatcherViever);
			this.splitContainer5.Size = new System.Drawing.Size(302, 674);
			this.splitContainer5.SplitterDistance = 372;
			this.splitContainer5.TabIndex = 0;
			// 
			// buttonSaveType
			// 
			this.buttonSaveType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveType.Location = new System.Drawing.Point(226, 3);
			this.buttonSaveType.Name = "buttonSaveType";
			this.buttonSaveType.Size = new System.Drawing.Size(73, 24);
			this.buttonSaveType.TabIndex = 11;
			this.buttonSaveType.Text = "Save Type";
			this.buttonSaveType.UseVisualStyleBackColor = true;
			this.buttonSaveType.Click += new System.EventHandler(this.buttonSaveType_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 24);
			this.label4.TabIndex = 13;
			this.label4.Text = "Type properties";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// typeEditor
			// 
			this.typeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.typeEditor.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.typeEditor.Location = new System.Drawing.Point(6, 31);
			this.typeEditor.Name = "typeEditor";
			this.typeEditor.Size = new System.Drawing.Size(293, 329);
			this.typeEditor.TabIndex = 12;
			// 
			// WatcherViever
			// 
			this.WatcherViever.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WatcherViever.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.WatcherViever.Location = new System.Drawing.Point(2, 3);
			this.WatcherViever.Name = "WatcherViever";
			this.WatcherViever.Size = new System.Drawing.Size(297, 293);
			this.WatcherViever.TabIndex = 14;
			// 
			// DebugWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(976, 698);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DebugWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Debug Window";
			this.Activated += new System.EventHandler(this.DebugWindow_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugWindow_FormClosing);
			this.Load += new System.EventHandler(this.DebugForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DebugWindow_KeyDown);
			this.MouseLeave += new System.EventHandler(this.DebugWindow_MouseLeave);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			this.splitContainer4.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListView entityList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propEditor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid typeEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonSaveType;
        private System.Windows.Forms.CheckBox checkBoxTransparent;
        private System.Windows.Forms.Button buttonSaveMap;
		private System.Windows.Forms.CheckBox checkBoxLive;
		private System.Windows.Forms.CheckBox checkbox_advanced;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Watcher;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data;
		private System.Windows.Forms.TextBox consoleLog;
		private System.Windows.Forms.TextBox console;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.PropertyGrid WatcherViever;
		private System.Windows.Forms.CheckBox checkBoxHideStatic;
    }
}