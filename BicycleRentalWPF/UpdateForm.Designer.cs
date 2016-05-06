namespace BicycleRentalWPF
{
    partial class UpdateForm
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
            this.Julianne = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Julianne
            // 
            this.Julianne.AutoSize = true;
            this.Julianne.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Julianne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(59)))));
            this.Julianne.Location = new System.Drawing.Point(79, 44);
            this.Julianne.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Julianne.Name = "Julianne";
            this.Julianne.Size = new System.Drawing.Size(367, 23);
            this.Julianne.TabIndex = 0;
            this.Julianne.Text = "Enter ID of Object to be Updated";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(114, 155);
            this.ID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 24);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID:";
            // 
            // IDBox
            // 
            this.IDBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.IDBox.Location = new System.Drawing.Point(215, 151);
            this.IDBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(202, 29);
            this.IDBox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(59)))));
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.SubmitButton.Location = new System.Drawing.Point(288, 288);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(138, 42);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(59)))));
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.BackButton.Location = new System.Drawing.Point(95, 288);
            this.BackButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(138, 42);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(521, 391);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Julianne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Julianne;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;
    }
}