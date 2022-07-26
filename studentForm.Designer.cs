namespace SEMS
{
    partial class studentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentForm));
            this.sdataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.sportscombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.txtSContact = new System.Windows.Forms.TextBox();
            this.txtSD = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sdataGridView
            // 
            this.sdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdataGridView.Location = new System.Drawing.Point(50, 356);
            this.sdataGridView.Name = "sdataGridView";
            this.sdataGridView.ReadOnly = true;
            this.sdataGridView.RowHeadersWidth = 62;
            this.sdataGridView.RowTemplate.Height = 33;
            this.sdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sdataGridView.Size = new System.Drawing.Size(878, 248);
            this.sdataGridView.TabIndex = 21;
            this.sdataGridView.TabStop = false;
            this.sdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdataGridView_CellClick);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Teal;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(538, 258);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(146, 60);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "UPDATE";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Olive;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.refreshButton.Location = new System.Drawing.Point(782, 258);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(146, 60);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "CLEAR";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(294, 258);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(146, 60);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(50, 258);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(146, 60);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sportscombobox
            // 
            this.sportscombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sportscombobox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sportscombobox.FormattingEnabled = true;
            this.sportscombobox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.sportscombobox.Items.AddRange(new object[] {
            "",
            "Cricket",
            "Football",
            "Volleyball",
            "Badminton",
            "Swimming",
            "Running"});
            this.sportscombobox.Location = new System.Drawing.Point(630, 138);
            this.sportscombobox.Name = "sportscombobox";
            this.sportscombobox.Size = new System.Drawing.Size(275, 33);
            this.sportscombobox.TabIndex = 6;
            this.sportscombobox.TabStop = false;
            this.sportscombobox.Tag = "";
            this.sportscombobox.SelectedIndexChanged += new System.EventHandler(this.sportscombobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(557, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(81, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(566, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(514, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contact no.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(119, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Roll no.";
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(630, 88);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(275, 31);
            this.txtSEmail.TabIndex = 5;
            // 
            // txtSContact
            // 
            this.txtSContact.Location = new System.Drawing.Point(630, 41);
            this.txtSContact.Name = "txtSContact";
            this.txtSContact.Size = new System.Drawing.Size(275, 31);
            this.txtSContact.TabIndex = 4;
            // 
            // txtSD
            // 
            this.txtSD.Location = new System.Drawing.Point(202, 135);
            this.txtSD.Name = "txtSD";
            this.txtSD.Size = new System.Drawing.Size(275, 31);
            this.txtSD.TabIndex = 3;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(202, 88);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(275, 31);
            this.txtSname.TabIndex = 2;
            // 
            // txtRollno
            // 
            this.txtRollno.Location = new System.Drawing.Point(202, 41);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(275, 31);
            this.txtRollno.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(927, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 40);
            this.exitButton.TabIndex = 22;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 644);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sdataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sportscombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSEmail);
            this.Controls.Add(this.txtSContact);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtRollno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "studentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentForm";
            this.Load += new System.EventHandler(this.studentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView sdataGridView;
        private Button searchButton;
        private Button refreshButton;
        private Button deleteButton;
        private Button addButton;
        private ComboBox sportscombobox;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtSEmail;
        private TextBox txtSContact;
        private TextBox txtSD;
        private TextBox txtSname;
        private TextBox txtRollno;
        private Button exitButton;
    }
}