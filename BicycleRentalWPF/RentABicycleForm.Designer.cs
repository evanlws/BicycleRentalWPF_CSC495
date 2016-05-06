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
      this.EnterIdLabel = new System.Windows.Forms.Label();
      this.BannerIDBox = new System.Windows.Forms.TextBox();
      this.ChooseBicycleLabel = new System.Windows.Forms.Label();
      this.ChooseBicycleComboBox = new System.Windows.Forms.ComboBox();
      this.BackButton = new System.Windows.Forms.Button();
      this.SubmitButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // FormTitle
      // 
      this.FormTitle.AutoSize = true;
      this.FormTitle.BackColor = System.Drawing.Color.Transparent;
      this.FormTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormTitle.ForeColor = System.Drawing.Color.Black;
      this.FormTitle.Location = new System.Drawing.Point(15, 32);
      this.FormTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.FormTitle.Name = "FormTitle";
      this.FormTitle.Size = new System.Drawing.Size(141, 22);
      this.FormTitle.TabIndex = 0;
      this.FormTitle.Text = "Rent A Bicycle";
      // 
      // EnterIdLabel
      // 
      this.EnterIdLabel.AutoSize = true;
      this.EnterIdLabel.BackColor = System.Drawing.Color.Transparent;
      this.EnterIdLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EnterIdLabel.ForeColor = System.Drawing.Color.Black;
      this.EnterIdLabel.Location = new System.Drawing.Point(49, 81);
      this.EnterIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.EnterIdLabel.Name = "EnterIdLabel";
      this.EnterIdLabel.Size = new System.Drawing.Size(212, 22);
      this.EnterIdLabel.TabIndex = 1;
      this.EnterIdLabel.Text = "Enter Renter Banner ID:";
      // 
      // BannerIDBox
      // 
      this.BannerIDBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
      this.BannerIDBox.Location = new System.Drawing.Point(313, 77);
      this.BannerIDBox.Margin = new System.Windows.Forms.Padding(6);
      this.BannerIDBox.Name = "BannerIDBox";
      this.BannerIDBox.Size = new System.Drawing.Size(219, 29);
      this.BannerIDBox.TabIndex = 2;
      this.BannerIDBox.TabStop = false;
      // 
      // ChooseBicycleLabel
      // 
      this.ChooseBicycleLabel.AutoSize = true;
      this.ChooseBicycleLabel.BackColor = System.Drawing.Color.Transparent;
      this.ChooseBicycleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ChooseBicycleLabel.ForeColor = System.Drawing.Color.Black;
      this.ChooseBicycleLabel.Location = new System.Drawing.Point(49, 153);
      this.ChooseBicycleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.ChooseBicycleLabel.Name = "ChooseBicycleLabel";
      this.ChooseBicycleLabel.Size = new System.Drawing.Size(148, 22);
      this.ChooseBicycleLabel.TabIndex = 3;
      this.ChooseBicycleLabel.Text = "Choose Bicycle:";
      // 
      // ChooseBicycleComboBox
      // 
      this.ChooseBicycleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(18)))));
      this.ChooseBicycleComboBox.FormattingEnabled = true;
      this.ChooseBicycleComboBox.Location = new System.Drawing.Point(313, 149);
      this.ChooseBicycleComboBox.Margin = new System.Windows.Forms.Padding(6);
      this.ChooseBicycleComboBox.Name = "ChooseBicycleComboBox";
      this.ChooseBicycleComboBox.Size = new System.Drawing.Size(219, 32);
      this.ChooseBicycleComboBox.TabIndex = 4;
      // 
      // BackButton
      // 
      this.BackButton.BackColor = System.Drawing.Color.Transparent;
      this.BackButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BackButton.ForeColor = System.Drawing.Color.Black;
      this.BackButton.Location = new System.Drawing.Point(113, 223);
      this.BackButton.Margin = new System.Windows.Forms.Padding(6);
      this.BackButton.Name = "BackButton";
      this.BackButton.Size = new System.Drawing.Size(138, 42);
      this.BackButton.TabIndex = 5;
      this.BackButton.Text = "BACK";
      this.BackButton.UseVisualStyleBackColor = false;
      this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
      // 
      // SubmitButton
      // 
      this.SubmitButton.BackColor = System.Drawing.Color.Transparent;
      this.SubmitButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SubmitButton.ForeColor = System.Drawing.Color.Black;
      this.SubmitButton.Location = new System.Drawing.Point(346, 223);
      this.SubmitButton.Margin = new System.Windows.Forms.Padding(6);
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
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(589, 301);
      this.Controls.Add(this.SubmitButton);
      this.Controls.Add(this.BackButton);
      this.Controls.Add(this.ChooseBicycleComboBox);
      this.Controls.Add(this.ChooseBicycleLabel);
      this.Controls.Add(this.BannerIDBox);
      this.Controls.Add(this.EnterIdLabel);
      this.Controls.Add(this.FormTitle);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "RentABicycleForm";
      this.Text = "RentABicycleForm";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label EnterIdLabel;
        private System.Windows.Forms.TextBox BannerIDBox;
        private System.Windows.Forms.Label ChooseBicycleLabel;
        private System.Windows.Forms.ComboBox ChooseBicycleComboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}