namespace _166303_projekt_zpo
{
    partial class AddMediaForm
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
            comboType = new ComboBox();
            txtTitle = new TextBox();
            numYear = new NumericUpDown();
            numRating = new NumericUpDown();
            btnOk = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // comboType
            // 
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Movie", "Series" });
            comboType.Location = new Point(79, 56);
            comboType.Name = "comboType";
            comboType.Size = new Size(645, 28);
            comboType.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(79, 129);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(645, 27);
            txtTitle.TabIndex = 1;
            // 
            // numYear
            // 
            numYear.Location = new Point(79, 217);
            numYear.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(645, 27);
            numYear.TabIndex = 2;
            numYear.Value = new decimal(new int[] { 1800, 0, 0, 0 });
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numRating.Location = new Point(79, 296);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(645, 27);
            numRating.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(212, 175, 55);
            btnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnOk.ForeColor = Color.FromArgb(30, 30, 30);
            btnOk.Location = new Point(343, 341);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(212, 175, 55);
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCancel.ForeColor = Color.FromArgb(30, 30, 30);
            btnCancel.Location = new Point(343, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 175, 55);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(30, 30, 30);
            label1.Location = new Point(79, 33);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 6;
            label1.Text = "Film czy serial?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(212, 175, 55);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(30, 30, 30);
            label2.Location = new Point(79, 106);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 7;
            label2.Text = "Jaki tytuł?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(212, 175, 55);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(30, 30, 30);
            label3.Location = new Point(79, 194);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 8;
            label3.Text = "Kiedy powstał?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(212, 175, 55);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(30, 30, 30);
            label4.Location = new Point(79, 273);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 9;
            label4.Text = "Jak oceniasz?";
            // 
            // AddMediaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(numRating);
            Controls.Add(numYear);
            Controls.Add(txtTitle);
            Controls.Add(comboType);
            Name = "AddMediaForm";
            Text = "AddMediaForm";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboType;
        private TextBox txtTitle;
        private NumericUpDown numYear;
        private NumericUpDown numRating;
        private Button btnOk;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}