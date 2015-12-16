namespace laba5.Forms
{
    partial class AnimalControllForm
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
            this.AnimalFormLabel = new System.Windows.Forms.Label();
            this.AnimalListBox = new System.Windows.Forms.ListBox();
            this.AnimalAdd = new System.Windows.Forms.Button();
            this.AnimalDelete = new System.Windows.Forms.Button();
            this.CountText = new System.Windows.Forms.Label();
            this.ZooName = new System.Windows.Forms.Label();
            this.ZoosCountTextBox = new System.Windows.Forms.TextBox();
            this.ZooNameTextBox = new System.Windows.Forms.TextBox();
            this.AnimalShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimalFormLabel
            // 
            this.AnimalFormLabel.AutoSize = true;
            this.AnimalFormLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalFormLabel.Location = new System.Drawing.Point(137, 9);
            this.AnimalFormLabel.Name = "AnimalFormLabel";
            this.AnimalFormLabel.Size = new System.Drawing.Size(348, 34);
            this.AnimalFormLabel.TabIndex = 0;
            this.AnimalFormLabel.Text = "Animal Controll System";
            // 
            // AnimalListBox
            // 
            this.AnimalListBox.FormattingEnabled = true;
            this.AnimalListBox.Location = new System.Drawing.Point(12, 146);
            this.AnimalListBox.Name = "AnimalListBox";
            this.AnimalListBox.Size = new System.Drawing.Size(396, 121);
            this.AnimalListBox.TabIndex = 1;
            this.AnimalListBox.SelectedIndexChanged += new System.EventHandler(this.AnimalListBox_SelectedIndexChanged);
            // 
            // AnimalAdd
            // 
            this.AnimalAdd.Location = new System.Drawing.Point(414, 146);
            this.AnimalAdd.Name = "AnimalAdd";
            this.AnimalAdd.Size = new System.Drawing.Size(173, 31);
            this.AnimalAdd.TabIndex = 2;
            this.AnimalAdd.Text = "Add an animal";
            this.AnimalAdd.UseVisualStyleBackColor = true;
            this.AnimalAdd.Click += new System.EventHandler(this.AnimalAdd_Click);
            // 
            // AnimalDelete
            // 
            this.AnimalDelete.Location = new System.Drawing.Point(414, 183);
            this.AnimalDelete.Name = "AnimalDelete";
            this.AnimalDelete.Size = new System.Drawing.Size(173, 31);
            this.AnimalDelete.TabIndex = 3;
            this.AnimalDelete.Text = "Delete an animal";
            this.AnimalDelete.UseVisualStyleBackColor = true;
            this.AnimalDelete.Click += new System.EventHandler(this.AnimalDelete_Click);
            // 
            // CountText
            // 
            this.CountText.AutoSize = true;
            this.CountText.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountText.Location = new System.Drawing.Point(12, 56);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(193, 24);
            this.CountText.TabIndex = 4;
            this.CountText.Text = "Total count of zoos:";
            // 
            // ZooName
            // 
            this.ZooName.AutoSize = true;
            this.ZooName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZooName.Location = new System.Drawing.Point(12, 101);
            this.ZooName.Name = "ZooName";
            this.ZooName.Size = new System.Drawing.Size(206, 24);
            this.ZooName.TabIndex = 5;
            this.ZooName.Text = "The name of the zoo:";
            // 
            // ZoosCountTextBox
            // 
            this.ZoosCountTextBox.Location = new System.Drawing.Point(236, 61);
            this.ZoosCountTextBox.Name = "ZoosCountTextBox";
            this.ZoosCountTextBox.ReadOnly = true;
            this.ZoosCountTextBox.Size = new System.Drawing.Size(351, 20);
            this.ZoosCountTextBox.TabIndex = 6;
            // 
            // ZooNameTextBox
            // 
            this.ZooNameTextBox.Location = new System.Drawing.Point(236, 101);
            this.ZooNameTextBox.Name = "ZooNameTextBox";
            this.ZooNameTextBox.ReadOnly = true;
            this.ZooNameTextBox.ShortcutsEnabled = false;
            this.ZooNameTextBox.Size = new System.Drawing.Size(351, 20);
            this.ZooNameTextBox.TabIndex = 7;
            // 
            // AnimalShowButton
            // 
            this.AnimalShowButton.Location = new System.Drawing.Point(414, 220);
            this.AnimalShowButton.Name = "AnimalShowButton";
            this.AnimalShowButton.Size = new System.Drawing.Size(173, 47);
            this.AnimalShowButton.TabIndex = 8;
            this.AnimalShowButton.Text = "Show the animal";
            this.AnimalShowButton.UseVisualStyleBackColor = true;
            this.AnimalShowButton.Click += new System.EventHandler(this.AnimalShowButton_Click);
            // 
            // AnimalControllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 279);
            this.Controls.Add(this.AnimalShowButton);
            this.Controls.Add(this.ZooNameTextBox);
            this.Controls.Add(this.ZoosCountTextBox);
            this.Controls.Add(this.ZooName);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.AnimalDelete);
            this.Controls.Add(this.AnimalAdd);
            this.Controls.Add(this.AnimalListBox);
            this.Controls.Add(this.AnimalFormLabel);
            this.Name = "AnimalControllForm";
            this.Text = "AnimalControllForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnimalFormLabel;
        private System.Windows.Forms.ListBox AnimalListBox;
        private System.Windows.Forms.Button AnimalAdd;
        private System.Windows.Forms.Button AnimalDelete;
        private System.Windows.Forms.Label CountText;
        private System.Windows.Forms.Label ZooName;
        private System.Windows.Forms.TextBox ZoosCountTextBox;
        private System.Windows.Forms.TextBox ZooNameTextBox;
        private System.Windows.Forms.Button AnimalShowButton;
    }
}