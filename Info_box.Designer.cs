namespace AssembleAssist
{
    partial class Info_box
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
            this.text_HowTo = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // text_HowTo
            // 
            this.text_HowTo.Location = new System.Drawing.Point(12, 12);
            this.text_HowTo.Name = "text_HowTo";
            this.text_HowTo.ReadOnly = true;
            this.text_HowTo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.text_HowTo.Size = new System.Drawing.Size(696, 182);
            this.text_HowTo.TabIndex = 0;
            this.text_HowTo.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Info_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 206);
            this.Controls.Add(this.text_HowTo);
            this.Name = "Info_box";
            this.Text = "How To";
            this.Load += new System.EventHandler(this.Info_box_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_HowTo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}