namespace _166303_projekt_zpo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxMedia = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnTop = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxMedia
            // 
            listBoxMedia.BackColor = Color.Gray;
            listBoxMedia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listBoxMedia.ForeColor = Color.White;
            listBoxMedia.FormattingEnabled = true;
            listBoxMedia.ItemHeight = 23;
            listBoxMedia.Location = new Point(12, 195);
            listBoxMedia.Name = "listBoxMedia";
            listBoxMedia.Size = new Size(776, 234);
            listBoxMedia.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(212, 175, 55);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAdd.ForeColor = Color.FromArgb(30, 30, 30);
            btnAdd.Location = new Point(31, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(212, 175, 55);
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRemove.ForeColor = Color.FromArgb(30, 30, 30);
            btnRemove.Location = new Point(31, 89);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Usuń";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(212, 175, 55);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSave.ForeColor = Color.FromArgb(30, 30, 30);
            btnSave.Location = new Point(31, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(212, 175, 55);
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLoad.ForeColor = Color.FromArgb(30, 30, 30);
            btnLoad.Location = new Point(31, 54);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Wczytaj";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnTop
            // 
            btnTop.BackColor = Color.FromArgb(212, 175, 55);
            btnTop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnTop.ForeColor = Color.FromArgb(30, 30, 30);
            btnTop.Location = new Point(31, 124);
            btnTop.Name = "btnTop";
            btnTop.Size = new Size(94, 29);
            btnTop.TabIndex = 5;
            btnTop.Text = "Top 5";
            btnTop.UseVisualStyleBackColor = false;
            btnTop.Click += btnTop_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(212, 175, 55);
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSearch.ForeColor = Color.FromArgb(30, 30, 30);
            btnSearch.Location = new Point(355, 159);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Szukaj";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(189, 91);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(427, 27);
            txtSearch.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 175, 55);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(30, 30, 30);
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 38);
            label1.TabIndex = 8;
            label1.Text = "Dodaj swoje ulubione filmy i seriale!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnTop);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listBoxMedia);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMedia;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnSave;
        private Button btnLoad;
        private Button btnTop;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
    }
}
