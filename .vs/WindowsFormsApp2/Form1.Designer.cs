namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.Label();
            this.cmb_shirtnbr = new System.Windows.Forms.Label();
            this.cmb_team = new System.Windows.Forms.Label();
            this.Text_id = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.comboBox_shirtnbr = new System.Windows.Forms.ComboBox();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dtp_birthday.Size = new System.Drawing.Size(59, 17);
            this.dtp_birthday.TabIndex = 2;
            this.dtp_birthday.Text = "birthday";
            // 
            // cmb_shirtnbr
            // 
            this.cmb_shirtnbr.AutoSize = true;
            this.cmb_shirtnbr.Location = new System.Drawing.Point(47, 152);
            this.cmb_shirtnbr.Name = "cmb_shirtnbr";
            this.cmb_shirtnbr.Size = new System.Drawing.Size(69, 17);
            this.cmb_shirtnbr.TabIndex = 3;
            this.cmb_shirtnbr.Text = "t-shirt nbr";
            // 
            // cmb_team
            // 
            this.cmb_team.AutoSize = true;
            this.cmb_team.Location = new System.Drawing.Point(57, 189);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(39, 17);
            this.cmb_team.TabIndex = 4;
            this.cmb_team.Text = "team";
            // 
            // Text_id
            // 
            this.Text_id.Location = new System.Drawing.Point(211, 39);
            this.Text_id.Name = "Text_id";
            this.Text_id.Size = new System.Drawing.Size(100, 22);
            this.Text_id.TabIndex = 5;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(211, 76);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 22);
            this.text_name.TabIndex = 6;
            // 
            // comboBox_shirtnbr
            // 
            this.comboBox_shirtnbr.FormattingEnabled = true;
            this.comboBox_shirtnbr.Location = new System.Drawing.Point(224, 149);
            this.comboBox_shirtnbr.Name = "comboBox_shirtnbr";
            this.comboBox_shirtnbr.Size = new System.Drawing.Size(121, 24);
            this.comboBox_shirtnbr.TabIndex = 7;
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(224, 182);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(121, 24);
            this.comboBox_team.TabIndex = 8;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(174, 113);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_birthday.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Text_id);
            this.groupBox1.Controls.Add(this.comboBox_team);
            this.groupBox1.Controls.Add(this.dateTimePicker_birthday);
            this.groupBox1.Controls.Add(this.cmb_team);
            this.groupBox1.Controls.Add(this.comboBox_shirtnbr);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Controls.Add(this.cmb_shirtnbr);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.dtp_birthday);
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "player info";
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(470, 382);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(84, 33);
            this.bt_close.TabIndex = 11;
            this.bt_close.Text = "close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(356, 382);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 33);
            this.bt_add.TabIndex = 12;
            this.bt_add.Text = "add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label dtp_birthday;
        private System.Windows.Forms.Label cmb_shirtnbr;
        private System.Windows.Forms.Label cmb_team;
        private System.Windows.Forms.TextBox Text_id;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.ComboBox comboBox_shirtnbr;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_add;
    }
}

