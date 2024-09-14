using System;

namespace AssembleAssist
{
    partial class load_bom_win
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
            this.BoM_Previewer = new System.Windows.Forms.DataGridView();
            this.radio_dot = new System.Windows.Forms.RadioButton();
            this.label_seperator = new System.Windows.Forms.Label();
            this.radio_comma = new System.Windows.Forms.RadioButton();
            this.radio_semicolon = new System.Windows.Forms.RadioButton();
            this.radio_custom = new System.Windows.Forms.RadioButton();
            this.text_custom = new System.Windows.Forms.TextBox();
            this.text_startline = new System.Windows.Forms.TextBox();
            this.label_startline = new System.Windows.Forms.Label();
            this.ok_butt = new System.Windows.Forms.Button();
            this.butt_select_designator = new System.Windows.Forms.Button();
            this.butt_param1 = new System.Windows.Forms.Button();
            this.butt_param2 = new System.Windows.Forms.Button();
            this.label_selected_designator = new System.Windows.Forms.Label();
            this.label_param1 = new System.Windows.Forms.Label();
            this.label_param2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoM_Previewer)).BeginInit();
            this.SuspendLayout();
            // 
            // BoM_Previewer
            // 
            this.BoM_Previewer.AllowUserToAddRows = false;
            this.BoM_Previewer.AllowUserToDeleteRows = false;
            this.BoM_Previewer.AllowUserToResizeColumns = false;
            this.BoM_Previewer.AllowUserToResizeRows = false;
            this.BoM_Previewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoM_Previewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.BoM_Previewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoM_Previewer.ColumnHeadersVisible = false;
            this.BoM_Previewer.Location = new System.Drawing.Point(12, 74);
            this.BoM_Previewer.Name = "BoM_Previewer";
            this.BoM_Previewer.ReadOnly = true;
            this.BoM_Previewer.RowHeadersVisible = false;
            this.BoM_Previewer.RowTemplate.ReadOnly = true;
            this.BoM_Previewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BoM_Previewer.Size = new System.Drawing.Size(660, 233);
            this.BoM_Previewer.TabIndex = 0;
            // 
            // radio_dot
            // 
            this.radio_dot.AutoSize = true;
            this.radio_dot.Location = new System.Drawing.Point(80, 386);
            this.radio_dot.Name = "radio_dot";
            this.radio_dot.Size = new System.Drawing.Size(40, 17);
            this.radio_dot.TabIndex = 1;
            this.radio_dot.Text = "dot";
            this.radio_dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_dot.UseVisualStyleBackColor = true;
            this.radio_dot.CheckedChanged += new System.EventHandler(this.radio_dot_CheckedChanged);
            // 
            // label_seperator
            // 
            this.label_seperator.AutoSize = true;
            this.label_seperator.Location = new System.Drawing.Point(12, 388);
            this.label_seperator.Name = "label_seperator";
            this.label_seperator.Size = new System.Drawing.Size(54, 13);
            this.label_seperator.TabIndex = 2;
            this.label_seperator.Text = "seperator:";
            // 
            // radio_comma
            // 
            this.radio_comma.AutoSize = true;
            this.radio_comma.Location = new System.Drawing.Point(138, 386);
            this.radio_comma.Name = "radio_comma";
            this.radio_comma.Size = new System.Drawing.Size(59, 17);
            this.radio_comma.TabIndex = 3;
            this.radio_comma.Text = "comma";
            this.radio_comma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_comma.UseVisualStyleBackColor = true;
            this.radio_comma.CheckedChanged += new System.EventHandler(this.radio_comma_CheckedChanged);
            // 
            // radio_semicolon
            // 
            this.radio_semicolon.AutoSize = true;
            this.radio_semicolon.Checked = true;
            this.radio_semicolon.Location = new System.Drawing.Point(203, 386);
            this.radio_semicolon.Name = "radio_semicolon";
            this.radio_semicolon.Size = new System.Drawing.Size(72, 17);
            this.radio_semicolon.TabIndex = 4;
            this.radio_semicolon.TabStop = true;
            this.radio_semicolon.Text = "semicolon";
            this.radio_semicolon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_semicolon.UseVisualStyleBackColor = true;
            this.radio_semicolon.CheckedChanged += new System.EventHandler(this.radio_semicolon_CheckedChanged);
            // 
            // radio_custom
            // 
            this.radio_custom.AutoSize = true;
            this.radio_custom.Location = new System.Drawing.Point(281, 386);
            this.radio_custom.Name = "radio_custom";
            this.radio_custom.Size = new System.Drawing.Size(62, 17);
            this.radio_custom.TabIndex = 5;
            this.radio_custom.Text = "custom:";
            this.radio_custom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_custom.UseVisualStyleBackColor = true;
            this.radio_custom.CheckedChanged += new System.EventHandler(this.radio_custom_CheckedChanged);
            // 
            // text_custom
            // 
            this.text_custom.Location = new System.Drawing.Point(341, 386);
            this.text_custom.Name = "text_custom";
            this.text_custom.Size = new System.Drawing.Size(34, 20);
            this.text_custom.TabIndex = 6;
            this.text_custom.TextChanged += new System.EventHandler(this.text_custom_TextChanged);
            // 
            // text_startline
            // 
            this.text_startline.Location = new System.Drawing.Point(116, 342);
            this.text_startline.Name = "text_startline";
            this.text_startline.Size = new System.Drawing.Size(50, 20);
            this.text_startline.TabIndex = 7;
            this.text_startline.Text = "1";
            this.text_startline.TextChanged += new System.EventHandler(this.text_startline_TextChanged);
            // 
            // label_startline
            // 
            this.label_startline.AutoSize = true;
            this.label_startline.Location = new System.Drawing.Point(12, 345);
            this.label_startline.Name = "label_startline";
            this.label_startline.Size = new System.Drawing.Size(98, 13);
            this.label_startline.TabIndex = 8;
            this.label_startline.Text = "starting line number";
            // 
            // ok_butt
            // 
            this.ok_butt.Enabled = false;
            this.ok_butt.Location = new System.Drawing.Point(627, 366);
            this.ok_butt.Name = "ok_butt";
            this.ok_butt.Size = new System.Drawing.Size(45, 45);
            this.ok_butt.TabIndex = 9;
            this.ok_butt.Text = "Ok";
            this.ok_butt.UseVisualStyleBackColor = true;
            this.ok_butt.Click += new System.EventHandler(this.ok_butt_Click);
            // 
            // butt_select_designator
            // 
            this.butt_select_designator.Location = new System.Drawing.Point(216, 340);
            this.butt_select_designator.Name = "butt_select_designator";
            this.butt_select_designator.Size = new System.Drawing.Size(98, 23);
            this.butt_select_designator.TabIndex = 10;
            this.butt_select_designator.Text = "select designator column";
            this.butt_select_designator.UseVisualStyleBackColor = true;
            this.butt_select_designator.Click += new System.EventHandler(this.butt_select_designator_Click);
            // 
            // butt_param1
            // 
            this.butt_param1.Location = new System.Drawing.Point(333, 339);
            this.butt_param1.Name = "butt_param1";
            this.butt_param1.Size = new System.Drawing.Size(111, 23);
            this.butt_param1.TabIndex = 11;
            this.butt_param1.Text = "select parameter 1";
            this.butt_param1.UseVisualStyleBackColor = true;
            this.butt_param1.Click += new System.EventHandler(this.butt_param1_Click);
            // 
            // butt_param2
            // 
            this.butt_param2.Location = new System.Drawing.Point(459, 339);
            this.butt_param2.Name = "butt_param2";
            this.butt_param2.Size = new System.Drawing.Size(111, 23);
            this.butt_param2.TabIndex = 12;
            this.butt_param2.Text = "select parameter 2";
            this.butt_param2.UseVisualStyleBackColor = true;
            this.butt_param2.Click += new System.EventHandler(this.butt_param2_Click);
            // 
            // label_selected_designator
            // 
            this.label_selected_designator.AutoSize = true;
            this.label_selected_designator.Location = new System.Drawing.Point(255, 324);
            this.label_selected_designator.Name = "label_selected_designator";
            this.label_selected_designator.Size = new System.Drawing.Size(10, 13);
            this.label_selected_designator.TabIndex = 13;
            this.label_selected_designator.Text = "-";
            // 
            // label_param1
            // 
            this.label_param1.AutoSize = true;
            this.label_param1.Location = new System.Drawing.Point(380, 323);
            this.label_param1.Name = "label_param1";
            this.label_param1.Size = new System.Drawing.Size(10, 13);
            this.label_param1.TabIndex = 14;
            this.label_param1.Text = "-";
            // 
            // label_param2
            // 
            this.label_param2.AutoSize = true;
            this.label_param2.Location = new System.Drawing.Point(510, 323);
            this.label_param2.Name = "label_param2";
            this.label_param2.Size = new System.Drawing.Size(10, 13);
            this.label_param2.TabIndex = 15;
            this.label_param2.Text = "-";
            // 
            // button2
            // 
            this.button2.Image = global::AssembleAssist.Properties.Resources.help;
            this.button2.Location = new System.Drawing.Point(627, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // load_bom_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_param2);
            this.Controls.Add(this.label_param1);
            this.Controls.Add(this.label_selected_designator);
            this.Controls.Add(this.butt_param2);
            this.Controls.Add(this.butt_param1);
            this.Controls.Add(this.butt_select_designator);
            this.Controls.Add(this.ok_butt);
            this.Controls.Add(this.label_startline);
            this.Controls.Add(this.text_startline);
            this.Controls.Add(this.text_custom);
            this.Controls.Add(this.radio_custom);
            this.Controls.Add(this.radio_semicolon);
            this.Controls.Add(this.radio_comma);
            this.Controls.Add(this.label_seperator);
            this.Controls.Add(this.radio_dot);
            this.Controls.Add(this.BoM_Previewer);
            this.Name = "load_bom_win";
            this.Text = "Load BoM";
            this.Load += new System.EventHandler(this.load_bom_win_Load);
            this.Click += new System.EventHandler(this.butt_select_designator_Click);
            ((System.ComponentModel.ISupportInitialize)(this.BoM_Previewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView BoM_Previewer;
        private System.Windows.Forms.RadioButton radio_dot;
        private System.Windows.Forms.Label label_seperator;
        private System.Windows.Forms.RadioButton radio_semicolon;
        private System.Windows.Forms.RadioButton radio_comma;
        private System.Windows.Forms.RadioButton radio_custom;
        private System.Windows.Forms.TextBox text_custom;
        private System.Windows.Forms.Label label_startline;
        private System.Windows.Forms.TextBox text_startline;
        private System.Windows.Forms.Button ok_butt;
        private System.Windows.Forms.Button butt_select_designator;
        private System.Windows.Forms.Button butt_param1;
        private System.Windows.Forms.Button butt_param2;
        private System.Windows.Forms.Label label_selected_designator;
        private System.Windows.Forms.Label label_param1;
        private System.Windows.Forms.Label label_param2;
        private System.Windows.Forms.Button button2;
    }
}