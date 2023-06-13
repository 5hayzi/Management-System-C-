namespace Web_Assignment_4
{
    partial class DeleteForm
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBookName
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(50, 50);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(67, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name:";

            // txtBookName
            this.txtBookName.Location = new System.Drawing.Point(150, 50);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(200, 20);
            this.txtBookName.TabIndex = 1;

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(150, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // DeleteForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Name = "DeleteForm";
            this.Text = "Delete Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnDelete;
    }
}
