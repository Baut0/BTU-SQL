
namespace BTU_SQL
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.databaseView = new System.Windows.Forms.DataGridView();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.TablesLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseView
            // 
            this.databaseView.AllowUserToAddRows = false;
            this.databaseView.AllowUserToDeleteRows = false;
            this.databaseView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.databaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseView.Location = new System.Drawing.Point(12, 44);
            this.databaseView.Name = "databaseView";
            this.databaseView.ReadOnly = true;
            this.databaseView.Size = new System.Drawing.Size(286, 180);
            this.databaseView.TabIndex = 0;
            this.databaseView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databaseView_CellClick);
            // 
            // tableView
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(815, 44);
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.Size = new System.Drawing.Size(286, 180);
            this.tableView.TabIndex = 1;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DatabaseLabel.Location = new System.Drawing.Point(12, 23);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(85, 18);
            this.DatabaseLabel.TabIndex = 2;
            this.DatabaseLabel.Text = "Databases";
            // 
            // TablesLabel
            // 
            this.TablesLabel.AutoSize = true;
            this.TablesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TablesLabel.Location = new System.Drawing.Point(812, 23);
            this.TablesLabel.Name = "TablesLabel";
            this.TablesLabel.Size = new System.Drawing.Size(53, 18);
            this.TablesLabel.TabIndex = 3;
            this.TablesLabel.Text = "Tables";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(320, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 433);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 671);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TablesLabel);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.databaseView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "BTU-SQL";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView databaseView;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label TablesLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}