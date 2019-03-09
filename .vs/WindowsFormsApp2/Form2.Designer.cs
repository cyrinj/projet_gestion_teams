namespace WindowsFormsApp2
{
    partial class Form2
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
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_id = new System.Windows.Forms.TextBox();
            this.dateTimePicker_cr = new System.Windows.Forms.DateTimePicker();
            this.cmb_team = new System.Windows.Forms.Label();
            this.comboBox_nbrj = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.cmb_shirtnbr = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(441, 394);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 33);
            this.bt_add.TabIndex = 15;
            this.bt_add.Text = "add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(555, 394);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(84, 33);
            this.bt_close.TabIndex = 14;
            this.bt_close.Text = "close";
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Text_id);
            this.groupBox1.Controls.Add(this.dateTimePicker_cr);
            this.groupBox1.Controls.Add(this.cmb_team);
            this.groupBox1.Controls.Add(this.comboBox_nbrj);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Controls.Add(this.cmb_shirtnbr);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.dtp_birthday);
            this.groupBox1.Location = new System.Drawing.Point(142, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 347);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "team  info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // Text_id
            // 
            this.Text_id.Location = new System.Drawing.Point(211, 39);
            this.Text_id.Name = "Text_id";
            this.Text_id.Size = new System.Drawing.Size(100, 22);
            this.Text_id.TabIndex = 5;
            // 
            // dateTimePicker_cr
            // 
            this.dateTimePicker_cr.Location = new System.Drawing.Point(174, 113);
            this.dateTimePicker_cr.Name = "dateTimePicker_cr";
            this.dateTimePicker_cr.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_cr.TabIndex = 9;
            // 
            // cmb_team
            // 
            this.cmb_team.AutoSize = true;
            this.cmb_team.Location = new System.Drawing.Point(57, 189);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(0, 17);
            this.cmb_team.TabIndex = 4;
            // 
            // comboBox_nbrj
            // 
            this.comboBox_nbrj.FormattingEnabled = true;
            this.comboBox_nbrj.Location = new System.Drawing.Point(224, 149);
            this.comboBox_nbrj.Name = "comboBox_nbrj";
            this.comboBox_nbrj.Size = new System.Drawing.Size(121, 24);
            this.comboBox_nbrj.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Location = new System.Drawing.Point(61, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(21, 17);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "ID";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(211, 76);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 22);
            this.text_name.TabIndex = 6;
            // 
            // cmb_shirtnbr
            // 
            this.cmb_shirtnbr.AutoSize = true;
            this.cmb_shirtnbr.Location = new System.Drawing.Point(47, 152);
            this.cmb_shirtnbr.Name = "cmb_shirtnbr";
            this.cmb_shirtnbr.Size = new System.Drawing.Size(93, 17);
            this.cmb_shirtnbr.TabIndex = 3;
            this.cmb_shirtnbr.Text = "nbr de joueur";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Location = new System.Drawing.Point(57, 71);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(45, 17);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Name";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.AutoSize = true;
            this.dtp_birthday.Location = new System.Drawing.Point(57, 113);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(111, 17);
            this.dtp_birthday.TabIndex = 2;
            this.dtp_birthday.Text = "date de creation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(676, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 354);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "team players";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "add player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Text_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cr;
        private System.Windows.Forms.Label cmb_team;
        private System.Windows.Forms.ComboBox comboBox_nbrj;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label cmb_shirtnbr;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label dtp_birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}