namespace EHRClient
{
    partial class MainForm
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
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonGetToken = new System.Windows.Forms.Button();
            this.LabelUrl = new System.Windows.Forms.Label();
            this.LabelClientId = new System.Windows.Forms.Label();
            this.LabelClientSecret = new System.Windows.Forms.Label();
            this.LabelToken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewTags = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxUrl = new System.Windows.Forms.TextBox();
            this.TextBoxClientId = new System.Windows.Forms.TextBox();
            this.TextBoxClientSecret = new System.Windows.Forms.TextBox();
            this.TextBoxToken = new System.Windows.Forms.TextBox();
            this.TextBoxRefreshToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonGet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxEHRUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTags)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(515, 129);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(79, 27);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(515, 96);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(79, 27);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.Location = new System.Drawing.Point(515, 64);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(79, 26);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonGetToken
            // 
            this.ButtonGetToken.Location = new System.Drawing.Point(420, 23);
            this.ButtonGetToken.Name = "ButtonGetToken";
            this.ButtonGetToken.Size = new System.Drawing.Size(174, 36);
            this.ButtonGetToken.TabIndex = 4;
            this.ButtonGetToken.Text = "Get Token";
            this.ButtonGetToken.UseVisualStyleBackColor = true;
            this.ButtonGetToken.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelUrl
            // 
            this.LabelUrl.AutoSize = true;
            this.LabelUrl.Location = new System.Drawing.Point(6, 16);
            this.LabelUrl.Name = "LabelUrl";
            this.LabelUrl.Size = new System.Drawing.Size(81, 13);
            this.LabelUrl.TabIndex = 14;
            this.LabelUrl.Text = "One Login URL";
            // 
            // LabelClientId
            // 
            this.LabelClientId.AutoSize = true;
            this.LabelClientId.Location = new System.Drawing.Point(6, 63);
            this.LabelClientId.Name = "LabelClientId";
            this.LabelClientId.Size = new System.Drawing.Size(45, 13);
            this.LabelClientId.TabIndex = 15;
            this.LabelClientId.Text = "Client Id";
            // 
            // LabelClientSecret
            // 
            this.LabelClientSecret.AutoSize = true;
            this.LabelClientSecret.Location = new System.Drawing.Point(303, 63);
            this.LabelClientSecret.Name = "LabelClientSecret";
            this.LabelClientSecret.Size = new System.Drawing.Size(67, 13);
            this.LabelClientSecret.TabIndex = 16;
            this.LabelClientSecret.Text = "Client Secret";
            // 
            // LabelToken
            // 
            this.LabelToken.AutoSize = true;
            this.LabelToken.Location = new System.Drawing.Point(6, 107);
            this.LabelToken.Name = "LabelToken";
            this.LabelToken.Size = new System.Drawing.Size(38, 13);
            this.LabelToken.TabIndex = 17;
            this.LabelToken.Text = "Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Refresh Token";
            // 
            // DataGridViewTags
            // 
            this.DataGridViewTags.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.DataGridViewTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tag,
            this.Version});
            this.DataGridViewTags.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewTags.Enabled = false;
            this.DataGridViewTags.Location = new System.Drawing.Point(9, 32);
            this.DataGridViewTags.Name = "DataGridViewTags";
            this.DataGridViewTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTags.Size = new System.Drawing.Size(500, 174);
            this.DataGridViewTags.TabIndex = 19;
            this.DataGridViewTags.SelectionChanged += new System.EventHandler(this.DataGridViewTags_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            // 
            // Version
            // 
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            // 
            // TextBoxUrl
            // 
            this.TextBoxUrl.Enabled = false;
            this.TextBoxUrl.Location = new System.Drawing.Point(9, 32);
            this.TextBoxUrl.Name = "TextBoxUrl";
            this.TextBoxUrl.Size = new System.Drawing.Size(192, 20);
            this.TextBoxUrl.TabIndex = 20;
            // 
            // TextBoxClientId
            // 
            this.TextBoxClientId.Enabled = false;
            this.TextBoxClientId.Location = new System.Drawing.Point(9, 79);
            this.TextBoxClientId.Name = "TextBoxClientId";
            this.TextBoxClientId.Size = new System.Drawing.Size(263, 20);
            this.TextBoxClientId.TabIndex = 21;
            // 
            // TextBoxClientSecret
            // 
            this.TextBoxClientSecret.Enabled = false;
            this.TextBoxClientSecret.Location = new System.Drawing.Point(306, 79);
            this.TextBoxClientSecret.Name = "TextBoxClientSecret";
            this.TextBoxClientSecret.Size = new System.Drawing.Size(288, 20);
            this.TextBoxClientSecret.TabIndex = 22;
            // 
            // TextBoxToken
            // 
            this.TextBoxToken.Enabled = false;
            this.TextBoxToken.Location = new System.Drawing.Point(9, 123);
            this.TextBoxToken.Name = "TextBoxToken";
            this.TextBoxToken.Size = new System.Drawing.Size(585, 20);
            this.TextBoxToken.TabIndex = 23;
            // 
            // TextBoxRefreshToken
            // 
            this.TextBoxRefreshToken.Enabled = false;
            this.TextBoxRefreshToken.Location = new System.Drawing.Point(9, 168);
            this.TextBoxRefreshToken.Name = "TextBoxRefreshToken";
            this.TextBoxRefreshToken.Size = new System.Drawing.Size(585, 20);
            this.TextBoxRefreshToken.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "TAG";
            // 
            // ButtonGet
            // 
            this.ButtonGet.Enabled = false;
            this.ButtonGet.Location = new System.Drawing.Point(515, 32);
            this.ButtonGet.Name = "ButtonGet";
            this.ButtonGet.Size = new System.Drawing.Size(79, 26);
            this.ButtonGet.TabIndex = 26;
            this.ButtonGet.Text = "Get";
            this.ButtonGet.UseVisualStyleBackColor = true;
            this.ButtonGet.Click += new System.EventHandler(this.ButtonGet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxEHRUrl);
            this.groupBox1.Controls.Add(this.LabelUrl);
            this.groupBox1.Controls.Add(this.ButtonGetToken);
            this.groupBox1.Controls.Add(this.LabelClientId);
            this.groupBox1.Controls.Add(this.TextBoxRefreshToken);
            this.groupBox1.Controls.Add(this.LabelClientSecret);
            this.groupBox1.Controls.Add(this.TextBoxToken);
            this.groupBox1.Controls.Add(this.LabelToken);
            this.groupBox1.Controls.Add(this.TextBoxClientSecret);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxClientId);
            this.groupBox1.Controls.Add(this.TextBoxUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 199);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridViewTags);
            this.groupBox2.Controls.Add(this.ButtonDelete);
            this.groupBox2.Controls.Add(this.ButtonGet);
            this.groupBox2.Controls.Add(this.ButtonEdit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ButtonAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 212);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "EHR URL";
            // 
            // TextBoxEHRUrl
            // 
            this.TextBoxEHRUrl.Enabled = false;
            this.TextBoxEHRUrl.Location = new System.Drawing.Point(221, 32);
            this.TextBoxEHRUrl.Name = "TextBoxEHRUrl";
            this.TextBoxEHRUrl.Size = new System.Drawing.Size(182, 20);
            this.TextBoxEHRUrl.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTags)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonGetToken;
        private System.Windows.Forms.Label LabelUrl;
        private System.Windows.Forms.Label LabelClientId;
        private System.Windows.Forms.Label LabelClientSecret;
        private System.Windows.Forms.Label LabelToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewTags;
        private System.Windows.Forms.TextBox TextBoxUrl;
        private System.Windows.Forms.TextBox TextBoxClientId;
        private System.Windows.Forms.TextBox TextBoxClientSecret;
        private System.Windows.Forms.TextBox TextBoxToken;
        private System.Windows.Forms.TextBox TextBoxRefreshToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonGet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxEHRUrl;

    }
}

