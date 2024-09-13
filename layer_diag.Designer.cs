namespace AssembleAssist
{
    partial class layer_diag
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_top_layer = new System.Windows.Forms.TextBox();
            this.text_bot_layer = new System.Windows.Forms.TextBox();
            this.butt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String specifying top layer in pick and place table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "String specifying bot layer in pick and place table:";
            // 
            // text_top_layer
            // 
            this.text_top_layer.Location = new System.Drawing.Point(258, 20);
            this.text_top_layer.Name = "text_top_layer";
            this.text_top_layer.Size = new System.Drawing.Size(132, 20);
            this.text_top_layer.TabIndex = 2;
            // 
            // text_bot_layer
            // 
            this.text_bot_layer.Location = new System.Drawing.Point(258, 46);
            this.text_bot_layer.Name = "text_bot_layer";
            this.text_bot_layer.Size = new System.Drawing.Size(132, 20);
            this.text_bot_layer.TabIndex = 3;
            // 
            // butt_ok
            // 
            this.butt_ok.Location = new System.Drawing.Point(412, 20);
            this.butt_ok.Name = "butt_ok";
            this.butt_ok.Size = new System.Drawing.Size(63, 46);
            this.butt_ok.TabIndex = 4;
            this.butt_ok.Text = "Ok";
            this.butt_ok.UseVisualStyleBackColor = true;
            this.butt_ok.Click += new System.EventHandler(this.butt_ok_Click);
            // 
            // layer_diag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 89);
            this.Controls.Add(this.butt_ok);
            this.Controls.Add(this.text_bot_layer);
            this.Controls.Add(this.text_top_layer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "layer_diag";
            this.Text = "Set Layer Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_top_layer;
        private System.Windows.Forms.TextBox text_bot_layer;
        private System.Windows.Forms.Button butt_ok;
    }
}