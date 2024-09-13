﻿namespace AssembleAssist
{
    partial class main_win
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.load_bom_butt = new System.Windows.Forms.Button();
            this.load_pnp_butt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_bom_lines_loaded = new System.Windows.Forms.Label();
            this.label_pnp_lines_loaded = new System.Windows.Forms.Label();
            this.load_asd_butt = new System.Windows.Forms.Button();
            this.pictureBox_asd_image = new System.Windows.Forms.PictureBox();
            this.butt_set_up_asd_origin_dimension = new System.Windows.Forms.Button();
            this.butt_start_assembly = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butt_next_bom_line = new System.Windows.Forms.Button();
            this.butt_previous_bom_line = new System.Windows.Forms.Button();
            this.label_bom_line = new System.Windows.Forms.Label();
            this.label_param2 = new System.Windows.Forms.Label();
            this.label_param1 = new System.Windows.Forms.Label();
            this.label_current_component = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_cnt_in_bom_line = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_asd_image)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_bom_butt
            // 
            this.load_bom_butt.Location = new System.Drawing.Point(12, 12);
            this.load_bom_butt.Name = "load_bom_butt";
            this.load_bom_butt.Size = new System.Drawing.Size(113, 48);
            this.load_bom_butt.TabIndex = 0;
            this.load_bom_butt.Text = "Load BoM";
            this.load_bom_butt.UseVisualStyleBackColor = true;
            this.load_bom_butt.Click += new System.EventHandler(this.load_bom_butt_Click);
            // 
            // load_pnp_butt
            // 
            this.load_pnp_butt.Location = new System.Drawing.Point(151, 12);
            this.load_pnp_butt.Name = "load_pnp_butt";
            this.load_pnp_butt.Size = new System.Drawing.Size(129, 48);
            this.load_pnp_butt.TabIndex = 1;
            this.load_pnp_butt.Text = "Load Pick and Place";
            this.load_pnp_butt.UseVisualStyleBackColor = true;
            this.load_pnp_butt.Click += new System.EventHandler(this.load_pnp_butt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(978, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_bom_lines_loaded
            // 
            this.label_bom_lines_loaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bom_lines_loaded.ForeColor = System.Drawing.Color.Red;
            this.label_bom_lines_loaded.Location = new System.Drawing.Point(12, 68);
            this.label_bom_lines_loaded.Name = "label_bom_lines_loaded";
            this.label_bom_lines_loaded.Size = new System.Drawing.Size(113, 16);
            this.label_bom_lines_loaded.TabIndex = 3;
            this.label_bom_lines_loaded.Text = "0";
            this.label_bom_lines_loaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pnp_lines_loaded
            // 
            this.label_pnp_lines_loaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pnp_lines_loaded.ForeColor = System.Drawing.Color.Red;
            this.label_pnp_lines_loaded.Location = new System.Drawing.Point(151, 68);
            this.label_pnp_lines_loaded.Name = "label_pnp_lines_loaded";
            this.label_pnp_lines_loaded.Size = new System.Drawing.Size(129, 16);
            this.label_pnp_lines_loaded.TabIndex = 4;
            this.label_pnp_lines_loaded.Text = "0";
            this.label_pnp_lines_loaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // load_asd_butt
            // 
            this.load_asd_butt.Location = new System.Drawing.Point(304, 12);
            this.load_asd_butt.Name = "load_asd_butt";
            this.load_asd_butt.Size = new System.Drawing.Size(129, 48);
            this.load_asd_butt.TabIndex = 5;
            this.load_asd_butt.Text = "Load Assembly Drawing";
            this.load_asd_butt.UseVisualStyleBackColor = true;
            this.load_asd_butt.Click += new System.EventHandler(this.load_asd_butt_Click);
            // 
            // pictureBox_asd_image
            // 
            this.pictureBox_asd_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_asd_image.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox_asd_image.Location = new System.Drawing.Point(12, 103);
            this.pictureBox_asd_image.Name = "pictureBox_asd_image";
            this.pictureBox_asd_image.Size = new System.Drawing.Size(1401, 749);
            this.pictureBox_asd_image.TabIndex = 6;
            this.pictureBox_asd_image.TabStop = false;
            this.pictureBox_asd_image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_asd_image_Click);
            // 
            // butt_set_up_asd_origin_dimension
            // 
            this.butt_set_up_asd_origin_dimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butt_set_up_asd_origin_dimension.Location = new System.Drawing.Point(304, 66);
            this.butt_set_up_asd_origin_dimension.Name = "butt_set_up_asd_origin_dimension";
            this.butt_set_up_asd_origin_dimension.Size = new System.Drawing.Size(129, 23);
            this.butt_set_up_asd_origin_dimension.TabIndex = 7;
            this.butt_set_up_asd_origin_dimension.Text = "Set up";
            this.butt_set_up_asd_origin_dimension.UseVisualStyleBackColor = false;
            this.butt_set_up_asd_origin_dimension.Click += new System.EventHandler(this.butt_set_up_asd_origin_dimension_Click);
            // 
            // butt_start_assembly
            // 
            this.butt_start_assembly.Location = new System.Drawing.Point(1434, 273);
            this.butt_start_assembly.Name = "butt_start_assembly";
            this.butt_start_assembly.Size = new System.Drawing.Size(245, 23);
            this.butt_start_assembly.TabIndex = 8;
            this.butt_start_assembly.Text = "Start Assembly";
            this.butt_start_assembly.UseVisualStyleBackColor = true;
            this.butt_start_assembly.Click += new System.EventHandler(this.butt_start_assembly_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butt_next_bom_line);
            this.groupBox1.Controls.Add(this.butt_previous_bom_line);
            this.groupBox1.Controls.Add(this.label_bom_line);
            this.groupBox1.Controls.Add(this.label_param2);
            this.groupBox1.Controls.Add(this.label_param1);
            this.groupBox1.Controls.Add(this.label_current_component);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_cnt_in_bom_line);
            this.groupBox1.Location = new System.Drawing.Point(1434, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 238);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // butt_next_bom_line
            // 
            this.butt_next_bom_line.Enabled = false;
            this.butt_next_bom_line.Location = new System.Drawing.Point(78, 173);
            this.butt_next_bom_line.Name = "butt_next_bom_line";
            this.butt_next_bom_line.Size = new System.Drawing.Size(41, 23);
            this.butt_next_bom_line.TabIndex = 7;
            this.butt_next_bom_line.Text = "->";
            this.butt_next_bom_line.UseVisualStyleBackColor = true;
            this.butt_next_bom_line.Click += new System.EventHandler(this.butt_next_bom_line_Click);
            // 
            // butt_previous_bom_line
            // 
            this.butt_previous_bom_line.Enabled = false;
            this.butt_previous_bom_line.Location = new System.Drawing.Point(9, 173);
            this.butt_previous_bom_line.Name = "butt_previous_bom_line";
            this.butt_previous_bom_line.Size = new System.Drawing.Size(41, 23);
            this.butt_previous_bom_line.TabIndex = 6;
            this.butt_previous_bom_line.Text = "<-";
            this.butt_previous_bom_line.UseVisualStyleBackColor = true;
            this.butt_previous_bom_line.Click += new System.EventHandler(this.butt_previous_bom_line_Click);
            // 
            // label_bom_line
            // 
            this.label_bom_line.AutoSize = true;
            this.label_bom_line.Location = new System.Drawing.Point(76, 147);
            this.label_bom_line.Name = "label_bom_line";
            this.label_bom_line.Size = new System.Drawing.Size(12, 13);
            this.label_bom_line.TabIndex = 5;
            this.label_bom_line.Text = "/";
            // 
            // label_param2
            // 
            this.label_param2.AutoSize = true;
            this.label_param2.Location = new System.Drawing.Point(6, 91);
            this.label_param2.Name = "label_param2";
            this.label_param2.Size = new System.Drawing.Size(10, 13);
            this.label_param2.TabIndex = 4;
            this.label_param2.Text = "-";
            // 
            // label_param1
            // 
            this.label_param1.AutoSize = true;
            this.label_param1.Location = new System.Drawing.Point(6, 64);
            this.label_param1.Name = "label_param1";
            this.label_param1.Size = new System.Drawing.Size(10, 13);
            this.label_param1.TabIndex = 3;
            this.label_param1.Text = "-";
            // 
            // label_current_component
            // 
            this.label_current_component.AutoSize = true;
            this.label_current_component.Location = new System.Drawing.Point(75, 35);
            this.label_current_component.Name = "label_current_component";
            this.label_current_component.Size = new System.Drawing.Size(13, 13);
            this.label_current_component.TabIndex = 2;
            this.label_current_component.Text = " -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "component:";
            // 
            // label_cnt_in_bom_line
            // 
            this.label_cnt_in_bom_line.AutoSize = true;
            this.label_cnt_in_bom_line.Location = new System.Drawing.Point(113, 35);
            this.label_cnt_in_bom_line.Name = "label_cnt_in_bom_line";
            this.label_cnt_in_bom_line.Size = new System.Drawing.Size(12, 13);
            this.label_cnt_in_bom_line.TabIndex = 0;
            this.label_cnt_in_bom_line.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "BoM line";
            // 
            // main_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 864);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butt_start_assembly);
            this.Controls.Add(this.butt_set_up_asd_origin_dimension);
            this.Controls.Add(this.pictureBox_asd_image);
            this.Controls.Add(this.load_asd_butt);
            this.Controls.Add(this.label_pnp_lines_loaded);
            this.Controls.Add(this.label_bom_lines_loaded);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.load_pnp_butt);
            this.Controls.Add(this.load_bom_butt);
            this.KeyPreview = true;
            this.Name = "main_win";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_asd_image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_bom_butt;
        private System.Windows.Forms.Button load_pnp_butt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_bom_lines_loaded;
        private System.Windows.Forms.Label label_pnp_lines_loaded;
        private System.Windows.Forms.Button load_asd_butt;
        private System.Windows.Forms.PictureBox pictureBox_asd_image;
        private System.Windows.Forms.Button butt_set_up_asd_origin_dimension;
        private System.Windows.Forms.Button butt_start_assembly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_param1;
        private System.Windows.Forms.Label label_current_component;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_cnt_in_bom_line;
        private System.Windows.Forms.Button butt_next_bom_line;
        private System.Windows.Forms.Button butt_previous_bom_line;
        private System.Windows.Forms.Label label_bom_line;
        private System.Windows.Forms.Label label_param2;
        private System.Windows.Forms.Label label2;
    }
}

