
namespace BTU_SQL
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginPanelLeft = new System.Windows.Forms.Panel();
            this.LoginPanelLeftLabel = new System.Windows.Forms.Label();
            this.LoginPanelLabelLeft2 = new System.Windows.Forms.Label();
            this.LoginServerIPBox = new System.Windows.Forms.TextBox();
            this.LoginUsernameBox = new System.Windows.Forms.TextBox();
            this.LoginPassBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanelLeft
            // 
            this.LoginPanelLeft.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginPanelLeft.Controls.Add(this.pictureBox1);
            this.LoginPanelLeft.Controls.Add(this.LoginPanelLabelLeft2);
            this.LoginPanelLeft.Controls.Add(this.LoginPanelLeftLabel);
            this.LoginPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.LoginPanelLeft.Name = "LoginPanelLeft";
            this.LoginPanelLeft.Size = new System.Drawing.Size(291, 464);
            this.LoginPanelLeft.TabIndex = 0;
            // 
            // LoginPanelLeftLabel
            // 
            this.LoginPanelLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPanelLeftLabel.AutoSize = true;
            this.LoginPanelLeftLabel.Font = new System.Drawing.Font("JetBrains Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelLeftLabel.Location = new System.Drawing.Point(12, 81);
            this.LoginPanelLeftLabel.Name = "LoginPanelLeftLabel";
            this.LoginPanelLeftLabel.Size = new System.Drawing.Size(127, 36);
            this.LoginPanelLeftLabel.TabIndex = 0;
            this.LoginPanelLeftLabel.Text = "BTU-SQL";
            // 
            // LoginPanelLabelLeft2
            // 
            this.LoginPanelLabelLeft2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPanelLabelLeft2.AutoSize = true;
            this.LoginPanelLabelLeft2.Font = new System.Drawing.Font("JetBrains Mono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelLabelLeft2.Location = new System.Drawing.Point(39, 130);
            this.LoginPanelLabelLeft2.Name = "LoginPanelLabelLeft2";
            this.LoginPanelLabelLeft2.Size = new System.Drawing.Size(240, 26);
            this.LoginPanelLabelLeft2.TabIndex = 1;
            this.LoginPanelLabelLeft2.Text = "Database Controller";
            // 
            // LoginServerIPBox
            // 
            this.LoginServerIPBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginServerIPBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.LoginServerIPBox.Location = new System.Drawing.Point(405, 136);
            this.LoginServerIPBox.Multiline = true;
            this.LoginServerIPBox.Name = "LoginServerIPBox";
            this.LoginServerIPBox.Size = new System.Drawing.Size(196, 35);
            this.LoginServerIPBox.TabIndex = 1;
            this.LoginServerIPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginUsernameBox
            // 
            this.LoginUsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginUsernameBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.LoginUsernameBox.Location = new System.Drawing.Point(405, 194);
            this.LoginUsernameBox.Multiline = true;
            this.LoginUsernameBox.Name = "LoginUsernameBox";
            this.LoginUsernameBox.Size = new System.Drawing.Size(196, 35);
            this.LoginUsernameBox.TabIndex = 2;
            this.LoginUsernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginPassBox
            // 
            this.LoginPassBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPassBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.LoginPassBox.Location = new System.Drawing.Point(405, 252);
            this.LoginPassBox.Multiline = true;
            this.LoginPassBox.Name = "LoginPassBox";
            this.LoginPassBox.Size = new System.Drawing.Size(196, 35);
            this.LoginPassBox.TabIndex = 3;
            this.LoginPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("JetBrains Mono", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginBtn.Location = new System.Drawing.Point(443, 316);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(114, 39);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Connect";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BTU_SQL.Properties.Resources.padlock;
            this.pictureBox4.Location = new System.Drawing.Point(362, 252);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BTU_SQL.Properties.Resources.profile;
            this.pictureBox3.Location = new System.Drawing.Point(362, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BTU_SQL.Properties.Resources.database;
            this.pictureBox2.Location = new System.Drawing.Point(362, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::BTU_SQL.Properties.Resources.btu;
            this.pictureBox1.Location = new System.Drawing.Point(55, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(709, 464);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginPassBox);
            this.Controls.Add(this.LoginUsernameBox);
            this.Controls.Add(this.LoginServerIPBox);
            this.Controls.Add(this.LoginPanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTU-SQL";
            this.LoginPanelLeft.ResumeLayout(false);
            this.LoginPanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginPanelLabelLeft2;
        private System.Windows.Forms.Label LoginPanelLeftLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox LoginServerIPBox;
        public System.Windows.Forms.TextBox LoginUsernameBox;
        public System.Windows.Forms.TextBox LoginPassBox;
        public System.Windows.Forms.Button LoginBtn;
    }
}

