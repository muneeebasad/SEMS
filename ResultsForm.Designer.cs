namespace SEMS
{
    partial class ResultsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.rdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sportscombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt1P = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.txt2P = new System.Windows.Forms.TextBox();
            this.txt3P = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rdataGridView
            // 
            this.rdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.rdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rdataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.rdataGridView.Location = new System.Drawing.Point(40, 286);
            this.rdataGridView.Name = "rdataGridView";
            this.rdataGridView.ReadOnly = true;
            this.rdataGridView.RowHeadersWidth = 62;
            this.rdataGridView.RowTemplate.Height = 33;
            this.rdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rdataGridView.Size = new System.Drawing.Size(878, 248);
            this.rdataGridView.TabIndex = 5;
            this.rdataGridView.TabStop = false;
            this.rdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rdataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(408, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Results\r\n";
            // 
            // sportscombobox
            // 
            this.sportscombobox.BackColor = System.Drawing.Color.White;
            this.sportscombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sportscombobox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sportscombobox.FormattingEnabled = true;
            this.sportscombobox.Items.AddRange(new object[] {
            "",
            "Cricket",
            "Football",
            "Volleyball",
            "Badminton",
            "Swimming",
            "Running"});
            this.sportscombobox.Location = new System.Drawing.Point(225, 196);
            this.sportscombobox.Name = "sportscombobox";
            this.sportscombobox.Size = new System.Drawing.Size(275, 33);
            this.sportscombobox.TabIndex = 8;
            this.sportscombobox.Tag = "";
            this.sportscombobox.SelectedIndexChanged += new System.EventHandler(this.sportscombobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(152, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sports";
            // 
            // txt1P
            // 
            this.txt1P.Location = new System.Drawing.Point(225, 75);
            this.txt1P.Name = "txt1P";
            this.txt1P.PlaceholderText = "1st Position";
            this.txt1P.Size = new System.Drawing.Size(275, 31);
            this.txt1P.TabIndex = 10;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Teal;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(772, 83);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 60);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Olive;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.refreshButton.Location = new System.Drawing.Point(772, 170);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(146, 60);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "CLEAR";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(905, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 40);
            this.exitButton.TabIndex = 25;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // txt2P
            // 
            this.txt2P.Location = new System.Drawing.Point(225, 112);
            this.txt2P.Name = "txt2P";
            this.txt2P.PlaceholderText = "2nd Positon";
            this.txt2P.Size = new System.Drawing.Size(275, 31);
            this.txt2P.TabIndex = 10;
            // 
            // txt3P
            // 
            this.txt3P.Location = new System.Drawing.Point(225, 149);
            this.txt3P.Name = "txt3P";
            this.txt3P.PlaceholderText = "3rd Postion";
            this.txt3P.Size = new System.Drawing.Size(275, 31);
            this.txt3P.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(107, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(81, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Second Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(98, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Third Position";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 588);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.txt3P);
            this.Controls.Add(this.txt2P);
            this.Controls.Add(this.txt1P);
            this.Controls.Add(this.sportscombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView rdataGridView;
        private Label label1;
        private ComboBox sportscombobox;
        private Label label6;
        private TextBox txt1P;
        private Button updateButton;
        private Button refreshButton;
        private Button exitButton;
        private TextBox txt2P;
        private TextBox txt3P;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}