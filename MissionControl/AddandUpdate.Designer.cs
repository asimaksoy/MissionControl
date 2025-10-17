namespace MissionControl
{
    partial class AddandUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxStatusses = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstimateEffort = new System.Windows.Forms.TextBox();
            this.lblEstimatEffort = new System.Windows.Forms.Label();
            this.cbxSeverity = new System.Windows.Forms.ComboBox();
            this.txtTaskFeatureRating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstBackList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStatusses);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEstimateEffort);
            this.groupBox1.Controls.Add(this.lblEstimatEffort);
            this.groupBox1.Controls.Add(this.cbxSeverity);
            this.groupBox1.Controls.Add(this.txtTaskFeatureRating);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbxStatusses
            // 
            this.cbxStatusses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatusses.FormattingEnabled = true;
            this.cbxStatusses.Location = new System.Drawing.Point(387, 240);
            this.cbxStatusses.Name = "cbxStatusses";
            this.cbxStatusses.Size = new System.Drawing.Size(121, 24);
            this.cbxStatusses.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // txtEstimateEffort
            // 
            this.txtEstimateEffort.Enabled = false;
            this.txtEstimateEffort.Location = new System.Drawing.Point(499, 32);
            this.txtEstimateEffort.Name = "txtEstimateEffort";
            this.txtEstimateEffort.Size = new System.Drawing.Size(100, 22);
            this.txtEstimateEffort.TabIndex = 11;
            this.txtEstimateEffort.Visible = false;
            // 
            // lblEstimatEffort
            // 
            this.lblEstimatEffort.AutoSize = true;
            this.lblEstimatEffort.Location = new System.Drawing.Point(401, 38);
            this.lblEstimatEffort.Name = "lblEstimatEffort";
            this.lblEstimatEffort.Size = new System.Drawing.Size(92, 16);
            this.lblEstimatEffort.TabIndex = 10;
            this.lblEstimatEffort.Text = "Estimate Effort";
            this.lblEstimatEffort.Visible = false;
            // 
            // cbxSeverity
            // 
            this.cbxSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeverity.FormattingEnabled = true;
            this.cbxSeverity.Location = new System.Drawing.Point(143, 240);
            this.cbxSeverity.Name = "cbxSeverity";
            this.cbxSeverity.Size = new System.Drawing.Size(121, 24);
            this.cbxSeverity.TabIndex = 8;
            // 
            // txtTaskFeatureRating
            // 
            this.txtTaskFeatureRating.Location = new System.Drawing.Point(143, 242);
            this.txtTaskFeatureRating.Name = "txtTaskFeatureRating";
            this.txtTaskFeatureRating.Size = new System.Drawing.Size(100, 22);
            this.txtTaskFeatureRating.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(143, 32);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(139, 24);
            this.cbxType.TabIndex = 5;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(143, 116);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(456, 97);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(456, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstBackList
            // 
            this.lstBackList.Location = new System.Drawing.Point(12, 300);
            this.lstBackList.Name = "lstBackList";
            this.lstBackList.Size = new System.Drawing.Size(158, 50);
            this.lstBackList.TabIndex = 2;
            this.lstBackList.Text = "Listeye Dön";
            this.lstBackList.UseVisualStyleBackColor = true;
            this.lstBackList.Click += new System.EventHandler(this.lstBackList_Click);
            // 
            // AddandUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 361);
            this.Controls.Add(this.lstBackList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddandUpdate";
            this.Text = "Add and Update";
            this.Load += new System.EventHandler(this.AddandUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtTaskFeatureRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSeverity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button lstBackList;
        public System.Windows.Forms.TextBox txtEstimateEffort;
        public System.Windows.Forms.Label lblEstimatEffort;
        private System.Windows.Forms.ComboBox cbxStatusses;
        private System.Windows.Forms.Label label5;
    }
}