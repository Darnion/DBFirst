namespace DBFirst.UI
{
    partial class OrganizerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFullname = new System.Windows.Forms.Label();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonParticipants = new System.Windows.Forms.Button();
            this.buttonJuries = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Окно организатора";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 2;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(335, 84);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(132, 24);
            this.labelHello.TabIndex = 3;
            this.labelHello.Text = "Доброй ночи!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBFirst.UI.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(44, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullname.Location = new System.Drawing.Point(252, 118);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(128, 24);
            this.labelFullname.TabIndex = 5;
            this.labelFullname.Text = "Мистер ФИО";
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(277, 146);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(247, 80);
            this.buttonEvents.TabIndex = 6;
            this.buttonEvents.Text = "Мероприятия";
            this.buttonEvents.UseVisualStyleBackColor = true;
            // 
            // buttonParticipants
            // 
            this.buttonParticipants.Location = new System.Drawing.Point(277, 232);
            this.buttonParticipants.Name = "buttonParticipants";
            this.buttonParticipants.Size = new System.Drawing.Size(247, 80);
            this.buttonParticipants.TabIndex = 7;
            this.buttonParticipants.Text = "Участники";
            this.buttonParticipants.UseVisualStyleBackColor = true;
            // 
            // buttonJuries
            // 
            this.buttonJuries.Location = new System.Drawing.Point(277, 318);
            this.buttonJuries.Name = "buttonJuries";
            this.buttonJuries.Size = new System.Drawing.Size(247, 80);
            this.buttonJuries.TabIndex = 8;
            this.buttonJuries.Text = "Жюри";
            this.buttonJuries.UseVisualStyleBackColor = true;
            this.buttonJuries.Click += new System.EventHandler(this.buttonJuries_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(24, 318);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(175, 80);
            this.buttonProfile.TabIndex = 9;
            this.buttonProfile.Text = "Мой профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonJuries);
            this.Controls.Add(this.buttonParticipants);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrganizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно организатора";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonParticipants;
        private System.Windows.Forms.Button buttonJuries;
        private System.Windows.Forms.Button buttonProfile;
    }
}