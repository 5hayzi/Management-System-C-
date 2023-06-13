namespace Web_Assignment_4
{
    partial class UpdateForm
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
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBookName
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(50, 50);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(67, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name:";

            // lblBookGenre
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Location = new System.Drawing.Point(50, 100);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(70, 13);
            this.lblBookGenre.TabIndex = 1;
            this.lblBookGenre.Text = "Book Genre:";

            // txtBookName
            this.txtBookName.Location = new System.Drawing.Point(150, 50);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(200, 20);
            this.txtBookName.TabIndex = 2;

            // txtBookGenre
            this.txtBookGenre.Location = new System.Drawing.Point(150, 100);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(200, 20);
            this.txtBookGenre.TabIndex = 3;

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(150, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // UpdateForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBookGenre);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookGenre);
            this.Controls.Add(this.lblBookName);
            this.Name = "UpdateForm";
            this.Text = "Update Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.Button btnUpdate;
    }
}
