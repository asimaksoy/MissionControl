namespace MissionControl
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datetimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.datetimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlToDo = new System.Windows.Forms.Panel();
            this.pnlInProgress = new System.Windows.Forms.Panel();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.cntxtRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cntxtRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlMenu.Controls.Add(this.grpFilter);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnAddWork);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1120, 109);
            this.pnlMenu.TabIndex = 1;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cbxType);
            this.grpFilter.Controls.Add(this.label7);
            this.grpFilter.Controls.Add(this.datetimeEnd);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.txtName);
            this.grpFilter.Controls.Add(this.datetimeStart);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Location = new System.Drawing.Point(6, 9);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(788, 84);
            this.grpFilter.TabIndex = 14;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(60, 20);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 24);
            this.cbxType.TabIndex = 4;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.ApplyFilterOnChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date End";
            // 
            // datetimeEnd
            // 
            this.datetimeEnd.Location = new System.Drawing.Point(374, 46);
            this.datetimeEnd.Name = "datetimeEnd";
            this.datetimeEnd.Size = new System.Drawing.Size(201, 22);
            this.datetimeEnd.TabIndex = 10;
            this.datetimeEnd.ValueChanged += new System.EventHandler(this.ApplyFilterOnChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 22);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.ApplyFilterOnChange);
            // 
            // datetimeStart
            // 
            this.datetimeStart.Location = new System.Drawing.Point(374, 18);
            this.datetimeStart.Name = "datetimeStart";
            this.datetimeStart.Size = new System.Drawing.Size(201, 22);
            this.datetimeStart.TabIndex = 9;
            this.datetimeStart.ValueChanged += new System.EventHandler(this.ApplyFilterOnChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(905, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Done List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(482, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "In Progress List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ToDo List";
            // 
            // btnAddWork
            // 
            this.btnAddWork.Location = new System.Drawing.Point(964, 12);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(144, 41);
            this.btnAddWork.TabIndex = 0;
            this.btnAddWork.Text = "Add New Work";
            this.btnAddWork.UseVisualStyleBackColor = true;
            this.btnAddWork.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlAction.Controls.Add(this.btnEdit);
            this.pnlAction.Controls.Add(this.btnDetails);
            this.pnlAction.Controls.Add(this.btnArchive);
            this.pnlAction.Controls.Add(this.btnNext);
            this.pnlAction.Controls.Add(this.btnPrev);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 514);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(1120, 100);
            this.pnlAction.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(553, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Enabled = false;
            this.btnDetails.Location = new System.Drawing.Point(424, 37);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(123, 35);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetailsClick);
            // 
            // btnArchive
            // 
            this.btnArchive.Enabled = false;
            this.btnArchive.Location = new System.Drawing.Point(295, 37);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(123, 35);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(166, 37);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(37, 37);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(123, 35);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tableLayoutPanel1);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 109);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1120, 505);
            this.pnlList.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.16732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.83268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.tableLayoutPanel1.Controls.Add(this.pnlToDo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlInProgress, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDone, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlToDo
            // 
            this.pnlToDo.AllowDrop = true;
            this.pnlToDo.AutoScroll = true;
            this.pnlToDo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToDo.Location = new System.Drawing.Point(3, 3);
            this.pnlToDo.Name = "pnlToDo";
            this.pnlToDo.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.pnlToDo.Size = new System.Drawing.Size(341, 499);
            this.pnlToDo.TabIndex = 0;
            this.pnlToDo.Tag = "dddd";
            this.pnlToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_DragDrop);
            this.pnlToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragEnter);
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.AllowDrop = true;
            this.pnlInProgress.AutoScroll = true;
            this.pnlInProgress.BackColor = System.Drawing.Color.LightGreen;
            this.pnlInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInProgress.Location = new System.Drawing.Point(350, 3);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(382, 499);
            this.pnlInProgress.TabIndex = 1;
            this.pnlInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_DragDrop);
            this.pnlInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragEnter);
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.AutoScroll = true;
            this.pnlDone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDone.Location = new System.Drawing.Point(738, 3);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(379, 499);
            this.pnlDone.TabIndex = 2;
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_DragDrop);
            this.pnlDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragEnter);
            // 
            // cntxtRightClickMenu
            // 
            this.cntxtRightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.editToolStripMenuItem});
            this.cntxtRightClickMenu.Name = "cntxtRightClickMenu";
            this.cntxtRightClickMenu.Size = new System.Drawing.Size(134, 124);
            this.cntxtRightClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtRightClickMenu_Opening);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 614);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form1";
            this.Text = "Work List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cntxtRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnAddWork;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlToDo;
        private System.Windows.Forms.Panel pnlInProgress;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.ContextMenuStrip cntxtRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetimeEnd;
        private System.Windows.Forms.DateTimePicker datetimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpFilter;
    }
}

