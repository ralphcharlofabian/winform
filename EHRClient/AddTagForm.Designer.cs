namespace EHRClient
{
    partial class AddTagForm
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
            this.TextBoxAdd = new System.Windows.Forms.TextBox();
            this.ButtonAddTag = new System.Windows.Forms.Button();
            this.ButtonCloseAddTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxAdd
            // 
            this.TextBoxAdd.Location = new System.Drawing.Point(43, 53);
            this.TextBoxAdd.Name = "TextBoxAdd";
            this.TextBoxAdd.Size = new System.Drawing.Size(260, 20);
            this.TextBoxAdd.TabIndex = 0;
            // 
            // ButtonAddTag
            // 
            this.ButtonAddTag.Location = new System.Drawing.Point(43, 126);
            this.ButtonAddTag.Name = "ButtonAddTag";
            this.ButtonAddTag.Size = new System.Drawing.Size(85, 36);
            this.ButtonAddTag.TabIndex = 1;
            this.ButtonAddTag.Text = "Add Tag";
            this.ButtonAddTag.UseVisualStyleBackColor = true;
            this.ButtonAddTag.Click += new System.EventHandler(this.ButtonAddTag_Click);
            // 
            // ButtonCloseAddTag
            // 
            this.ButtonCloseAddTag.Location = new System.Drawing.Point(218, 126);
            this.ButtonCloseAddTag.Name = "ButtonCloseAddTag";
            this.ButtonCloseAddTag.Size = new System.Drawing.Size(85, 36);
            this.ButtonCloseAddTag.TabIndex = 2;
            this.ButtonCloseAddTag.Text = "Close";
            this.ButtonCloseAddTag.UseVisualStyleBackColor = true;
            this.ButtonCloseAddTag.Click += new System.EventHandler(this.ButtonCloseAddTag_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 221);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonCloseAddTag);
            this.Controls.Add(this.ButtonAddTag);
            this.Controls.Add(this.TextBoxAdd);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxAdd;
        private System.Windows.Forms.Button ButtonAddTag;
        private System.Windows.Forms.Button ButtonCloseAddTag;
    }
}