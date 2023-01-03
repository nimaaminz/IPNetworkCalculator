namespace NetworkExtractor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_cidr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_network_ip = new System.Windows.Forms.Label();
            this.lbl_first_ip = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_last_ip = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_boradcast = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_input_ip = new System.Windows.Forms.TextBox();
            this.txt_input_mask = new System.Windows.Forms.TextBox();
            this.lbl_host_count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_cidr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 250);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A.Aminzadeh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CIDR";
            // 
            // input_cidr
            // 
            this.input_cidr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.input_cidr.Location = new System.Drawing.Point(21, 154);
            this.input_cidr.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.input_cidr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_cidr.Name = "input_cidr";
            this.input_cidr.Size = new System.Drawing.Size(76, 21);
            this.input_cidr.TabIndex = 5;
            this.input_cidr.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.input_cidr.ValueChanged += new System.EventHandler(this.input_cidr_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mask";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Network IP";
            // 
            // lbl_network_ip
            // 
            this.lbl_network_ip.AutoSize = true;
            this.lbl_network_ip.Location = new System.Drawing.Point(289, 35);
            this.lbl_network_ip.Name = "lbl_network_ip";
            this.lbl_network_ip.Size = new System.Drawing.Size(25, 13);
            this.lbl_network_ip.TabIndex = 9;
            this.lbl_network_ip.Text = ". . . ";
            // 
            // lbl_first_ip
            // 
            this.lbl_first_ip.AutoSize = true;
            this.lbl_first_ip.Location = new System.Drawing.Point(289, 85);
            this.lbl_first_ip.Name = "lbl_first_ip";
            this.lbl_first_ip.Size = new System.Drawing.Size(28, 13);
            this.lbl_first_ip.TabIndex = 11;
            this.lbl_first_ip.Text = ". . . .";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "First IP";
            // 
            // lbl_last_ip
            // 
            this.lbl_last_ip.AutoSize = true;
            this.lbl_last_ip.Location = new System.Drawing.Point(288, 136);
            this.lbl_last_ip.Name = "lbl_last_ip";
            this.lbl_last_ip.Size = new System.Drawing.Size(28, 13);
            this.lbl_last_ip.TabIndex = 13;
            this.lbl_last_ip.Text = ". . . .";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Last IP";
            // 
            // lbl_boradcast
            // 
            this.lbl_boradcast.AutoSize = true;
            this.lbl_boradcast.Location = new System.Drawing.Point(287, 186);
            this.lbl_boradcast.Name = "lbl_boradcast";
            this.lbl_boradcast.Size = new System.Drawing.Size(28, 13);
            this.lbl_boradcast.TabIndex = 15;
            this.lbl_boradcast.Text = ". . . .";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Broadcast";
            // 
            // txt_input_ip
            // 
            this.txt_input_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_input_ip.Location = new System.Drawing.Point(22, 52);
            this.txt_input_ip.Name = "txt_input_ip";
            this.txt_input_ip.Size = new System.Drawing.Size(108, 21);
            this.txt_input_ip.TabIndex = 17;
            this.txt_input_ip.Text = "192.168.0.";
            this.txt_input_ip.TextChanged += new System.EventHandler(this.txt_input_ip_TextChanged);
            // 
            // txt_input_mask
            // 
            this.txt_input_mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_input_mask.Location = new System.Drawing.Point(22, 102);
            this.txt_input_mask.Name = "txt_input_mask";
            this.txt_input_mask.Size = new System.Drawing.Size(108, 21);
            this.txt_input_mask.TabIndex = 18;
            this.txt_input_mask.TextChanged += new System.EventHandler(this.txt_input_mask_TextChanged);
            // 
            // lbl_host_count
            // 
            this.lbl_host_count.AutoSize = true;
            this.lbl_host_count.Location = new System.Drawing.Point(289, 232);
            this.lbl_host_count.Name = "lbl_host_count";
            this.lbl_host_count.Size = new System.Drawing.Size(28, 13);
            this.lbl_host_count.TabIndex = 20;
            this.lbl_host_count.Text = ". . . .";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hosts Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NetworkExtractor.Properties.Resources.A;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(465, 267);
            this.Controls.Add(this.lbl_host_count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_input_mask);
            this.Controls.Add(this.txt_input_ip);
            this.Controls.Add(this.lbl_boradcast);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_last_ip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_first_ip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_network_ip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_cidr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_cidr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown input_cidr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_network_ip;
        private System.Windows.Forms.Label lbl_first_ip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_last_ip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_boradcast;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_input_ip;
        private System.Windows.Forms.TextBox txt_input_mask;
        private System.Windows.Forms.Label lbl_host_count;
        private System.Windows.Forms.Label label7;
    }
}

