namespace AssembleAssist
{
    partial class load_pnp_win
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
            this.butt_y_coor = new System.Windows.Forms.Button();
            this.butt_x_coor = new System.Windows.Forms.Button();
            this.butt_select_designator = new System.Windows.Forms.Button();
            this.ok_butt = new System.Windows.Forms.Button();
            this.label_startline = new System.Windows.Forms.Label();
            this.text_startline = new System.Windows.Forms.TextBox();
            this.text_custom = new System.Windows.Forms.TextBox();
            this.radio_custom = new System.Windows.Forms.RadioButton();
            this.radio_semicolon = new System.Windows.Forms.RadioButton();
            this.radio_comma = new System.Windows.Forms.RadioButton();
            this.label_seperator = new System.Windows.Forms.Label();
            this.radio_dot = new System.Windows.Forms.RadioButton();
            this.PnP_Previewer = new System.Windows.Forms.DataGridView();
            this.label_y_coor = new System.Windows.Forms.Label();
            this.label_x_coor = new System.Windows.Forms.Label();
            this.label_selected_designator = new System.Windows.Forms.Label();
            this.but_select_layer = new System.Windows.Forms.Button();
            this.label_layer = new System.Windows.Forms.Label();
            this.comboBox_selected_layer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_decimal_sep_comma = new System.Windows.Forms.RadioButton();
            this.radio_decimal_sep_dot = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PnP_Previewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // butt_y_coor
            // 
            this.butt_y_coor.Location = new System.Drawing.Point(243, 42);
            this.butt_y_coor.Name = "butt_y_coor";
            this.butt_y_coor.Size = new System.Drawing.Size(114, 23);
            this.butt_y_coor.TabIndex = 25;
            this.butt_y_coor.Text = "select y coordinate";
            this.butt_y_coor.UseVisualStyleBackColor = true;
            this.butt_y_coor.Click += new System.EventHandler(this.butt_y_coor_Click);
            // 
            // butt_x_coor
            // 
            this.butt_x_coor.Location = new System.Drawing.Point(121, 42);
            this.butt_x_coor.Name = "butt_x_coor";
            this.butt_x_coor.Size = new System.Drawing.Size(114, 23);
            this.butt_x_coor.TabIndex = 24;
            this.butt_x_coor.Text = "select x coordinate";
            this.butt_x_coor.UseVisualStyleBackColor = true;
            this.butt_x_coor.Click += new System.EventHandler(this.butt_x_coor_Click);
            // 
            // butt_select_designator
            // 
            this.butt_select_designator.Location = new System.Drawing.Point(17, 42);
            this.butt_select_designator.Name = "butt_select_designator";
            this.butt_select_designator.Size = new System.Drawing.Size(98, 23);
            this.butt_select_designator.TabIndex = 23;
            this.butt_select_designator.Text = "select designator column";
            this.butt_select_designator.UseVisualStyleBackColor = true;
            this.butt_select_designator.Click += new System.EventHandler(this.butt_select_designator_Click);
            // 
            // ok_butt
            // 
            this.ok_butt.Enabled = false;
            this.ok_butt.Location = new System.Drawing.Point(978, 409);
            this.ok_butt.Name = "ok_butt";
            this.ok_butt.Size = new System.Drawing.Size(45, 45);
            this.ok_butt.TabIndex = 22;
            this.ok_butt.Text = "Ok";
            this.ok_butt.UseVisualStyleBackColor = true;
            this.ok_butt.Click += new System.EventHandler(this.ok_butt_Click);
            // 
            // label_startline
            // 
            this.label_startline.AutoSize = true;
            this.label_startline.Location = new System.Drawing.Point(13, 35);
            this.label_startline.Name = "label_startline";
            this.label_startline.Size = new System.Drawing.Size(101, 13);
            this.label_startline.TabIndex = 21;
            this.label_startline.Text = "starting line number:";
            // 
            // text_startline
            // 
            this.text_startline.Location = new System.Drawing.Point(117, 32);
            this.text_startline.Name = "text_startline";
            this.text_startline.Size = new System.Drawing.Size(50, 20);
            this.text_startline.TabIndex = 20;
            this.text_startline.Text = "1";
            this.text_startline.TextChanged += new System.EventHandler(this.text_startline_TextChanged);
            // 
            // text_custom
            // 
            this.text_custom.Location = new System.Drawing.Point(140, 104);
            this.text_custom.Name = "text_custom";
            this.text_custom.Size = new System.Drawing.Size(34, 20);
            this.text_custom.TabIndex = 19;
            this.text_custom.TextChanged += new System.EventHandler(this.text_custom_TextChanged);
            // 
            // radio_custom
            // 
            this.radio_custom.AutoSize = true;
            this.radio_custom.Location = new System.Drawing.Point(77, 105);
            this.radio_custom.Name = "radio_custom";
            this.radio_custom.Size = new System.Drawing.Size(62, 17);
            this.radio_custom.TabIndex = 18;
            this.radio_custom.Text = "custom:";
            this.radio_custom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_custom.UseVisualStyleBackColor = true;
            this.radio_custom.CheckedChanged += new System.EventHandler(this.radio_custom_CheckedChanged);
            // 
            // radio_semicolon
            // 
            this.radio_semicolon.AutoSize = true;
            this.radio_semicolon.Checked = true;
            this.radio_semicolon.Location = new System.Drawing.Point(200, 74);
            this.radio_semicolon.Name = "radio_semicolon";
            this.radio_semicolon.Size = new System.Drawing.Size(72, 17);
            this.radio_semicolon.TabIndex = 17;
            this.radio_semicolon.TabStop = true;
            this.radio_semicolon.Text = "semicolon";
            this.radio_semicolon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_semicolon.UseVisualStyleBackColor = true;
            this.radio_semicolon.CheckedChanged += new System.EventHandler(this.radio_semicolon_CheckedChanged);
            // 
            // radio_comma
            // 
            this.radio_comma.AutoSize = true;
            this.radio_comma.Location = new System.Drawing.Point(135, 74);
            this.radio_comma.Name = "radio_comma";
            this.radio_comma.Size = new System.Drawing.Size(59, 17);
            this.radio_comma.TabIndex = 16;
            this.radio_comma.Text = "comma";
            this.radio_comma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_comma.UseVisualStyleBackColor = true;
            this.radio_comma.CheckedChanged += new System.EventHandler(this.radio_comma_CheckedChanged);
            // 
            // label_seperator
            // 
            this.label_seperator.AutoSize = true;
            this.label_seperator.Location = new System.Drawing.Point(13, 76);
            this.label_seperator.Name = "label_seperator";
            this.label_seperator.Size = new System.Drawing.Size(54, 13);
            this.label_seperator.TabIndex = 15;
            this.label_seperator.Text = "seperator:";
            // 
            // radio_dot
            // 
            this.radio_dot.AutoSize = true;
            this.radio_dot.Location = new System.Drawing.Point(77, 74);
            this.radio_dot.Name = "radio_dot";
            this.radio_dot.Size = new System.Drawing.Size(40, 17);
            this.radio_dot.TabIndex = 14;
            this.radio_dot.Text = "dot";
            this.radio_dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radio_dot.UseVisualStyleBackColor = true;
            this.radio_dot.CheckedChanged += new System.EventHandler(this.radio_dot_CheckedChanged);
            // 
            // PnP_Previewer
            // 
            this.PnP_Previewer.AllowUserToAddRows = false;
            this.PnP_Previewer.AllowUserToDeleteRows = false;
            this.PnP_Previewer.AllowUserToResizeColumns = false;
            this.PnP_Previewer.AllowUserToResizeRows = false;
            this.PnP_Previewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PnP_Previewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.PnP_Previewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PnP_Previewer.ColumnHeadersVisible = false;
            this.PnP_Previewer.Location = new System.Drawing.Point(12, 73);
            this.PnP_Previewer.Name = "PnP_Previewer";
            this.PnP_Previewer.ReadOnly = true;
            this.PnP_Previewer.RowHeadersVisible = false;
            this.PnP_Previewer.RowTemplate.ReadOnly = true;
            this.PnP_Previewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PnP_Previewer.Size = new System.Drawing.Size(1011, 233);
            this.PnP_Previewer.TabIndex = 13;
            // 
            // label_y_coor
            // 
            this.label_y_coor.AutoSize = true;
            this.label_y_coor.Location = new System.Drawing.Point(285, 26);
            this.label_y_coor.Name = "label_y_coor";
            this.label_y_coor.Size = new System.Drawing.Size(10, 13);
            this.label_y_coor.TabIndex = 28;
            this.label_y_coor.Text = "-";
            // 
            // label_x_coor
            // 
            this.label_x_coor.AutoSize = true;
            this.label_x_coor.Location = new System.Drawing.Point(170, 26);
            this.label_x_coor.Name = "label_x_coor";
            this.label_x_coor.Size = new System.Drawing.Size(10, 13);
            this.label_x_coor.TabIndex = 27;
            this.label_x_coor.Text = "-";
            // 
            // label_selected_designator
            // 
            this.label_selected_designator.AutoSize = true;
            this.label_selected_designator.Location = new System.Drawing.Point(55, 26);
            this.label_selected_designator.Name = "label_selected_designator";
            this.label_selected_designator.Size = new System.Drawing.Size(10, 13);
            this.label_selected_designator.TabIndex = 26;
            this.label_selected_designator.Text = "-";
            // 
            // but_select_layer
            // 
            this.but_select_layer.Location = new System.Drawing.Point(135, 42);
            this.but_select_layer.Name = "but_select_layer";
            this.but_select_layer.Size = new System.Drawing.Size(111, 23);
            this.but_select_layer.TabIndex = 29;
            this.but_select_layer.Text = "select Layer";
            this.but_select_layer.UseVisualStyleBackColor = true;
            this.but_select_layer.Click += new System.EventHandler(this.but_select_layer_Click);
            // 
            // label_layer
            // 
            this.label_layer.AutoSize = true;
            this.label_layer.Location = new System.Drawing.Point(185, 26);
            this.label_layer.Name = "label_layer";
            this.label_layer.Size = new System.Drawing.Size(10, 13);
            this.label_layer.TabIndex = 30;
            this.label_layer.Text = "-";
            // 
            // comboBox_selected_layer
            // 
            this.comboBox_selected_layer.FormattingEnabled = true;
            this.comboBox_selected_layer.Location = new System.Drawing.Point(135, 97);
            this.comboBox_selected_layer.Name = "comboBox_selected_layer";
            this.comboBox_selected_layer.Size = new System.Drawing.Size(111, 21);
            this.comboBox_selected_layer.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "layer to assemble:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_startline);
            this.groupBox1.Controls.Add(this.radio_dot);
            this.groupBox1.Controls.Add(this.label_seperator);
            this.groupBox1.Controls.Add(this.radio_comma);
            this.groupBox1.Controls.Add(this.radio_semicolon);
            this.groupBox1.Controls.Add(this.radio_custom);
            this.groupBox1.Controls.Add(this.text_custom);
            this.groupBox1.Controls.Add(this.text_startline);
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 131);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_decimal_sep_comma);
            this.groupBox2.Controls.Add(this.radio_decimal_sep_dot);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_x_coor);
            this.groupBox2.Controls.Add(this.butt_x_coor);
            this.groupBox2.Controls.Add(this.label_y_coor);
            this.groupBox2.Controls.Add(this.butt_y_coor);
            this.groupBox2.Controls.Add(this.butt_select_designator);
            this.groupBox2.Controls.Add(this.label_selected_designator);
            this.groupBox2.Location = new System.Drawing.Point(303, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 131);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Designator / Coordinates";
            // 
            // radio_decimal_sep_comma
            // 
            this.radio_decimal_sep_comma.AutoSize = true;
            this.radio_decimal_sep_comma.Location = new System.Drawing.Point(261, 98);
            this.radio_decimal_sep_comma.Name = "radio_decimal_sep_comma";
            this.radio_decimal_sep_comma.Size = new System.Drawing.Size(40, 17);
            this.radio_decimal_sep_comma.TabIndex = 33;
            this.radio_decimal_sep_comma.TabStop = true;
            this.radio_decimal_sep_comma.Text = "dot";
            this.radio_decimal_sep_comma.UseVisualStyleBackColor = true;
            // 
            // radio_decimal_sep_dot
            // 
            this.radio_decimal_sep_dot.AutoSize = true;
            this.radio_decimal_sep_dot.Checked = true;
            this.radio_decimal_sep_dot.Location = new System.Drawing.Point(215, 98);
            this.radio_decimal_sep_dot.Name = "radio_decimal_sep_dot";
            this.radio_decimal_sep_dot.Size = new System.Drawing.Size(40, 17);
            this.radio_decimal_sep_dot.TabIndex = 32;
            this.radio_decimal_sep_dot.TabStop = true;
            this.radio_decimal_sep_dot.Text = "dot";
            this.radio_decimal_sep_dot.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "decimal separator: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_select_layer);
            this.groupBox3.Controls.Add(this.comboBox_selected_layer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label_layer);
            this.groupBox3.Location = new System.Drawing.Point(693, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 131);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assemble Board Side";
            // 
            // button1
            // 
            this.button1.Image = global::AssembleAssist.Properties.Resources.help;
            this.button1.Location = new System.Drawing.Point(978, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // load_pnp_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ok_butt);
            this.Controls.Add(this.PnP_Previewer);
            this.Name = "load_pnp_win";
            this.Text = "Load Pick and Place";
            this.Load += new System.EventHandler(this.load_pnp_win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PnP_Previewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butt_y_coor;
        private System.Windows.Forms.Button butt_x_coor;
        private System.Windows.Forms.Button butt_select_designator;
        private System.Windows.Forms.Button ok_butt;
        private System.Windows.Forms.Label label_startline;
        private System.Windows.Forms.TextBox text_startline;
        private System.Windows.Forms.TextBox text_custom;
        private System.Windows.Forms.RadioButton radio_custom;
        private System.Windows.Forms.RadioButton radio_semicolon;
        private System.Windows.Forms.RadioButton radio_comma;
        private System.Windows.Forms.Label label_seperator;
        private System.Windows.Forms.RadioButton radio_dot;
        private System.Windows.Forms.DataGridView PnP_Previewer;
        private System.Windows.Forms.Label label_y_coor;
        private System.Windows.Forms.Label label_x_coor;
        private System.Windows.Forms.Label label_selected_designator;
        private System.Windows.Forms.Button but_select_layer;
        private System.Windows.Forms.Label label_layer;
        private System.Windows.Forms.ComboBox comboBox_selected_layer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_decimal_sep_comma;
        private System.Windows.Forms.RadioButton radio_decimal_sep_dot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}