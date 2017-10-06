namespace EHRClient
{
    partial class EditTagForm
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
            this.ButtonCloseEditTag = new System.Windows.Forms.Button();
            this.ButtonEditTag = new System.Windows.Forms.Button();
            this.TextBoxEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCloseEditTag
            // 
            this.ButtonCloseEditTag.Location = new System.Drawing.Point(187, 149);
            this.ButtonCloseEditTag.Name = "ButtonCloseEditTag";
            this.ButtonCloseEditTag.Size = new System.Drawing.Size(85, 36);
            this.ButtonCloseEditTag.TabIndex = 5;
            this.ButtonCloseEditTag.Text = "Close";
            this.ButtonCloseEditTag.UseVisualStyleBackColor = true;
            this.ButtonCloseEditTag.Click += new System.EventHandler(this.ButtonCloseEditTag_Click);
            // 
            // ButtonEditTag
            // 
            this.ButtonEditTag.Location = new System.Drawing.Point(12, 149);
            this.ButtonEditTag.Name = "ButtonEditTag";
            this.ButtonEditTag.Size = new System.Drawing.Size(85, 36);
            this.ButtonEditTag.TabIndex = 4;
            this.ButtonEditTag.Text = "Save Edit";
            this.ButtonEditTag.UseVisualStyleBackColor = true;
            this.ButtonEditTag.Click += new System.EventHandler(this.ButtonEditTag_Click);
            // 
            // TextBoxEdit
            // 
            this.TextBoxEdit.Location = new System.Drawing.Point(12, 76);
            this.TextBoxEdit.Name = "TextBoxEdit";
            this.TextBoxEdit.Size = new System.Drawing.Size(260, 20);
            this.TextBoxEdit.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 261);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonCloseEditTag);
            this.Controls.Add(this.ButtonEditTag);
            this.Controls.Add(this.TextBoxEdit);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseEditTag;
        private System.Windows.Forms.Button ButtonEditTag;
        private System.Windows.Forms.TextBox TextBoxEdit;
    }
}