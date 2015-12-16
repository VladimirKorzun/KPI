namespace laba5.Forms
{
    partial class AnimalIndivid
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
            this.AnimalNameLabel = new System.Windows.Forms.Label();
            this.AnimalCommentForm = new System.Windows.Forms.Label();
            this.animalNameTextBox = new System.Windows.Forms.TextBox();
            this.animalCommentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AnimalNameLabel
            // 
            this.AnimalNameLabel.AutoSize = true;
            this.AnimalNameLabel.Location = new System.Drawing.Point(13, 20);
            this.AnimalNameLabel.Name = "AnimalNameLabel";
            this.AnimalNameLabel.Size = new System.Drawing.Size(69, 13);
            this.AnimalNameLabel.TabIndex = 0;
            this.AnimalNameLabel.Text = "Animal Name";
            // 
            // AnimalCommentForm
            // 
            this.AnimalCommentForm.AutoSize = true;
            this.AnimalCommentForm.Location = new System.Drawing.Point(12, 100);
            this.AnimalCommentForm.Name = "AnimalCommentForm";
            this.AnimalCommentForm.Size = new System.Drawing.Size(85, 13);
            this.AnimalCommentForm.TabIndex = 1;
            this.AnimalCommentForm.Text = "Animal Comment";
            // 
            // animalNameTextBox
            // 
            this.animalNameTextBox.Location = new System.Drawing.Point(99, 17);
            this.animalNameTextBox.Name = "animalNameTextBox";
            this.animalNameTextBox.ReadOnly = true;
            this.animalNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.animalNameTextBox.TabIndex = 2;
            // 
            // animalCommentBox
            // 
            this.animalCommentBox.Location = new System.Drawing.Point(99, 51);
            this.animalCommentBox.Multiline = true;
            this.animalCommentBox.Name = "animalCommentBox";
            this.animalCommentBox.ReadOnly = true;
            this.animalCommentBox.Size = new System.Drawing.Size(194, 114);
            this.animalCommentBox.TabIndex = 3;
            // 
            // AnimalIndivid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 180);
            this.Controls.Add(this.animalCommentBox);
            this.Controls.Add(this.animalNameTextBox);
            this.Controls.Add(this.AnimalCommentForm);
            this.Controls.Add(this.AnimalNameLabel);
            this.Name = "AnimalIndivid";
            this.Text = "AnimalIndivid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnimalNameLabel;
        private System.Windows.Forms.Label AnimalCommentForm;
        private System.Windows.Forms.TextBox animalNameTextBox;
        private System.Windows.Forms.TextBox animalCommentBox;
    }
}