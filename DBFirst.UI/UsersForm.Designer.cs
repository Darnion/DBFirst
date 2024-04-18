namespace DBFirst.UI
{
    partial class UsersForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.checkBoxDesc = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 365);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(145, 26);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 1;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(145, 54);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRole.TabIndex = 2;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(79, 29);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(92, 57);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "Role";
            // 
            // checkBoxDesc
            // 
            this.checkBoxDesc.AutoSize = true;
            this.checkBoxDesc.Location = new System.Drawing.Point(337, 29);
            this.checkBoxDesc.Name = "checkBoxDesc";
            this.checkBoxDesc.Size = new System.Drawing.Size(130, 17);
            this.checkBoxDesc.TabIndex = 8;
            this.checkBoxDesc.Text = "По убыванию (ФИО)";
            this.checkBoxDesc.UseVisualStyleBackColor = true;
            this.checkBoxDesc.CheckedChanged += new System.EventHandler(this.checkBoxDesc_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(519, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(269, 20);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.checkBoxDesc);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UsersForm";
            this.Text = "Участники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.CheckBox checkBoxDesc;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}