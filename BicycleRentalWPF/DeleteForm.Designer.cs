namespace BicycleRentalWPF
{
    partial class DeleteForm
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
      this.FormTitle = new System.Windows.Forms.Label();
      this.ID = new System.Windows.Forms.Label();
      this.IdTextBox = new System.Windows.Forms.TextBox();
      this.SubmitButton = new System.Windows.Forms.Button();
      this.BackButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // FormTitle
      // 
      this.FormTitle.AutoSize = true;
      this.FormTitle.BackColor = System.Drawing.Color.Transparent;
      this.FormTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormTitle.ForeColor = System.Drawing.Color.Black;
      this.FormTitle.Location = new System.Drawing.Point(125, 50);
      this.FormTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.FormTitle.Name = "FormTitle";
      this.FormTitle.Size = new System.Drawing.Size(283, 22);
      this.FormTitle.TabIndex = 0;
      this.FormTitle.Text = "Enter ID of Object to be Deleted";
      // 
      // ID
      // 
      this.ID.AutoSize = true;
      this.ID.BackColor = System.Drawing.Color.Transparent;
      this.ID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ID.ForeColor = System.Drawing.Color.Black;
      this.ID.Location = new System.Drawing.Point(125, 117);
      this.ID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.ID.Name = "ID";
      this.ID.Size = new System.Drawing.Size(35, 22);
      this.ID.TabIndex = 1;
      this.ID.Text = "ID:";
      // 
      // IdTextBox
      // 
      this.IdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
      this.IdTextBox.Location = new System.Drawing.Point(218, 113);
      this.IdTextBox.Margin = new System.Windows.Forms.Padding(6);
      this.IdTextBox.Name = "IdTextBox";
      this.IdTextBox.Size = new System.Drawing.Size(200, 29);
      this.IdTextBox.TabIndex = 2;
      // 
      // SubmitButton
      // 
      this.SubmitButton.BackColor = System.Drawing.Color.Transparent;
      this.SubmitButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SubmitButton.ForeColor = System.Drawing.Color.Black;
      this.SubmitButton.Location = new System.Drawing.Point(293, 184);
      this.SubmitButton.Margin = new System.Windows.Forms.Padding(6);
      this.SubmitButton.Name = "SubmitButton";
      this.SubmitButton.Size = new System.Drawing.Size(138, 42);
      this.SubmitButton.TabIndex = 3;
      this.SubmitButton.Text = "SUBMIT";
      this.SubmitButton.UseVisualStyleBackColor = false;
      this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
      // 
      // BackButton
      // 
      this.BackButton.BackColor = System.Drawing.Color.Transparent;
      this.BackButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BackButton.ForeColor = System.Drawing.Color.Black;
      this.BackButton.Location = new System.Drawing.Point(77, 184);
      this.BackButton.Margin = new System.Windows.Forms.Padding(6);
      this.BackButton.Name = "BackButton";
      this.BackButton.Size = new System.Drawing.Size(138, 42);
      this.BackButton.TabIndex = 4;
      this.BackButton.Text = "BACK";
      this.BackButton.UseVisualStyleBackColor = false;
      this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
      // 
      // DeleteForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(541, 280);
      this.Controls.Add(this.BackButton);
      this.Controls.Add(this.SubmitButton);
      this.Controls.Add(this.IdTextBox);
      this.Controls.Add(this.ID);
      this.Controls.Add(this.FormTitle);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "DeleteForm";
      this.Text = "DeleteForm";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;
    }
}