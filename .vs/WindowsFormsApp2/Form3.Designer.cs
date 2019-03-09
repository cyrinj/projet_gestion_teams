namespace WindowsFormsApp2
{
    partial class Form3
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
            this.cmbteam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbplayer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labshirt = new System.Windows.Forms.Label();
            this.labnumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "team";
            // 
            // cmbteam
            // 
            this.cmbteam.FormattingEnabled = true;
            this.cmbteam.Location = new System.Drawing.Point(185, 76);
            this.cmbteam.Name = "cmbteam";
            this.cmbteam.Size = new System.Drawing.Size(121, 24);
            this.cmbteam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "id player";
            // 
            // cmbplayer
            // 
            this.cmbplayer.FormattingEnabled = true;
            this.cmbplayer.Location = new System.Drawing.Point(185, 106);
            this.cmbplayer.Name = "cmbplayer";
            this.cmbplayer.Size = new System.Drawing.Size(121, 24);
            this.cmbplayer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "number";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(572, 331);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 6;
            this.bt_delete.Text = "delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(717, 331);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labnumber);
            this.groupBox1.Controls.Add(this.labshirt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(54, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 144);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "player information ";
            // 
            // labshirt
            // 
            this.labshirt.AutoSize = true;
            this.labshirt.Location = new System.Drawing.Point(210, 25);
            this.labshirt.Name = "labshirt";
            this.labshirt.Size = new System.Drawing.Size(46, 17);
            this.labshirt.TabIndex = 6;
            this.labshirt.Text = "label5";
            // 
            // labnumber
            // 
            this.labnumber.AutoSize = true;
            this.labnumber.Location = new System.Drawing.Point(213, 84);
            this.labnumber.Name = "labnumber";
            this.labnumber.Size = new System.Drawing.Size(46, 17);
            this.labnumber.TabIndex = 7;
            this.labnumber.Text = "label6";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.cmbplayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbteam);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbteam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbplayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labnumber;
        private System.Windows.Forms.Label labshirt;
    }
}