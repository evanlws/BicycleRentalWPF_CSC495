namespace BicycleRentalWPF
{
    partial class RentABicycleForm
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
            this.EnterID = new System.Windows.Forms.Label();
            this.BannerIDBox = new System.Windows.Forms.TextBox();
            this.ChooseBicycle = new System.Windows.Forms.Label();
            this.ChooseBicycleComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(59)))));
            this.FormTitle.Location = new System.Drawing.Point(259, 48);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(165, 23);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Rent A Bicycle";
            // 
            // EnterID
            // 
            this.EnterID.AutoSize = true;
            this.EnterID.Location = new System.Drawing.Point(101, 135);
            this.EnterID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EnterID.Name = "EnterID";
            this.EnterID.Size = new System.Drawing.Size(209, 24);
            this.EnterID.TabIndex = 1;
            this.EnterID.Text = "Enter Renter Banner ID:";
            // 
            // BannerIDBox
            // 
            this.BannerIDBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.BannerIDBox.Location = new System.Drawing.Point(365, 131);
            this.BannerIDBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BannerIDBox.Name = "BannerIDBox";
            this.BannerIDBox.Size = new System.Drawing.Size(219, 29);
            this.BannerIDBox.TabIndex = 2;
            this.BannerIDBox.TabStop = false;
            // 
            // ChooseBicycle
            // 
            this.ChooseBicycle.AutoSize = true;
            this.ChooseBicycle.Location = new System.Drawing.Point(101, 207);
            this.ChooseBicycle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ChooseBicycle.Name = "ChooseBicycle";
            this.ChooseBicycle.Size = new System.Drawing.Size(146, 24);
            this.ChooseBicycle.TabIndex = 3;
            this.ChooseBicycle.Text = "Choose Bicycle:";
            // 
            // ChooseBicycleComboBox
            // 
            this.ChooseBicycleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.ChooseBicycleComboBox.FormattingEnabled = true;
            this.ChooseBicycleComboBox.Location = new System.Drawing.Point(365, 203);
            this.ChooseBicycleComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ChooseBicycleComboBox.Name = "ChooseBicycleComboBox";
            this.ChooseBicycleComboBox.Size = new System.Drawing.Size(219, 32);
            this.ChooseBicycleComboBox.TabIndex = 4;
      
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(59)))));
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.BackButton.Location = new System.Drawing.Point(167, 319);
            this.BackButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(138, 42);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(59)))));
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.SubmitButton.Location = new System.Drawing.Point(400, 319);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(138, 42);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RentABicycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(669, 415);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChooseBicycleComboBox);
            this.Controls.Add(this.ChooseBicycle);
            this.Controls.Add(this.BannerIDBox);
            this.Controls.Add(this.EnterID);
            this.Controls.Add(this.FormTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RentABicycleForm";
            this.Text = "RentABicycleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label EnterID;
        private System.Windows.Forms.TextBox BannerIDBox;
        private System.Windows.Forms.Label ChooseBicycle;
        private System.Windows.Forms.ComboBox ChooseBicycleComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}