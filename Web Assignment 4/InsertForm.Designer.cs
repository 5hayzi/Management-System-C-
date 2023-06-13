namespace Web_Assignment_4
{
    partial class InsertForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBookName
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(50, 50);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(67, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name:";

            // lblBookId
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(50, 100);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(51, 13);
            this.lblBookId.TabIndex = 1;
            this.lblBookId.Text = "Book ID:";

            // lblBookGenre
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Location = new System.Drawing.Point(50, 150);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(70, 13);
            this.lblBookGenre.TabIndex = 2;
            this.lblBookGenre.Text = "Book Genre:";

            // txtBookName
            this.txtBookName.Location = new System.Drawing.Point(150, 50);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(200, 20);
            this.txtBookName.TabIndex = 3;

            // txtBookId
            this.txtBookId.Location = new System.Drawing.Point(150, 100);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(200, 20);
            this.txtBookId.TabIndex = 4;

            // txtBookGenre
            this.txtBookGenre.Location = new System.Drawing.Point(150, 150);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(200, 20);
            this.txtBookGenre.TabIndex = 5;

            // btnInsert
            this.btnInsert.Location = new System.Drawing.Point(150, 200);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 30);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

            // InsertForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtBookGenre);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookGenre);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblBookName);
            this.Name = "InsertForm";
            this.Text = "Insert Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.Button btnInsert;
    }
}