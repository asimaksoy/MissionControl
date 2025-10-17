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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlToDo = new System.Windows.Forms.Panel();
            this.pnlInProgress = new System.Windows.Forms.Panel();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.PapayaWhip;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
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
            this.pnlToDo.Size = new System.Drawing.Size(342, 499);
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
            this.pnlInProgress.Location = new System.Drawing.Point(351, 3);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(384, 499);
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
            this.pnlDone.Location = new System.Drawing.Point(741, 3);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(376, 499);
            this.pnlDone.TabIndex = 2;
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_DragDrop);
            this.pnlDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_DragEnter);
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
            this.pnlAction.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}

