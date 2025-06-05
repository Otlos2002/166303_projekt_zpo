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
            SuspendLayout();
            // 
            // listBoxMedia
            // 
            listBoxMedia.FormattingEnabled = true;
            listBoxMedia.Location = new Point(12, 215);
            listBoxMedia.Name = "listBoxMedia";
            listBoxMedia.Size = new Size(776, 224);
            listBoxMedia.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(190, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(631, 56);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Usuń";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(304, 56);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(520, 56);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Wczytaj";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnTop
            // 
            btnTop.Location = new Point(409, 56);
            btnTop.Name = "btnTop";
            btnTop.Size = new Size(94, 29);
            btnTop.TabIndex = 5;
            btnTop.Text = "Top 5";
            btnTop.UseVisualStyleBackColor = true;
            btnTop.Click += btnTop_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(356, 157);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Szukaj";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(304, 124);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(199, 27);
            txtSearch.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnTop);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listBoxMedia);
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
    }
}
