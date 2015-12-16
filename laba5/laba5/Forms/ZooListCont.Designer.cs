namespace laba5
{
    partial class ZooListCont
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
            this.components = new System.ComponentModel.Container();
            this.FormName = new System.Windows.Forms.Label();
            this.ZooList = new System.Windows.Forms.ListBox();
            this.ZooCreator = new System.Windows.Forms.Button();
            this.ZooRemover = new System.Windows.Forms.Button();
            this.ZooName = new System.Windows.Forms.TextBox();
            this.zooNameLabel = new System.Windows.Forms.Label();
            this.ZooOpener = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // FormName
            // 
            this.FormName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormName.AutoSize = true;
            this.FormName.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName.Location = new System.Drawing.Point(161, 9);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(268, 31);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "Zoo Controll System";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ZooList
            // 
            this.ZooList.FormattingEnabled = true;
            this.ZooList.Location = new System.Drawing.Point(12, 49);
            this.ZooList.Name = "ZooList";
            this.ZooList.Size = new System.Drawing.Size(532, 134);
            this.ZooList.TabIndex = 1;
            this.ZooList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ZooCreator
            // 
            this.ZooCreator.Location = new System.Drawing.Point(12, 234);
            this.ZooCreator.Name = "ZooCreator";
            this.ZooCreator.Size = new System.Drawing.Size(175, 41);
            this.ZooCreator.TabIndex = 2;
            this.ZooCreator.Text = "Add a zoo";
            this.ZooCreator.UseVisualStyleBackColor = true;
            this.ZooCreator.Click += new System.EventHandler(this.ZooCreator_Click);
            // 
            // ZooRemover
            // 
            this.ZooRemover.Location = new System.Drawing.Point(193, 234);
            this.ZooRemover.Name = "ZooRemover";
            this.ZooRemover.Size = new System.Drawing.Size(172, 41);
            this.ZooRemover.TabIndex = 3;
            this.ZooRemover.Text = "Destroy a zoo(";
            this.ZooRemover.UseVisualStyleBackColor = true;
            this.ZooRemover.Click += new System.EventHandler(this.ZooRemover_Click);
            // 
            // ZooName
            // 
            this.ZooName.Location = new System.Drawing.Point(12, 208);
            this.ZooName.Name = "ZooName";
            this.ZooName.Size = new System.Drawing.Size(531, 20);
            this.ZooName.TabIndex = 4;
            // 
            // zooNameLabel
            // 
            this.zooNameLabel.AutoSize = true;
            this.zooNameLabel.Location = new System.Drawing.Point(12, 192);
            this.zooNameLabel.Name = "zooNameLabel";
            this.zooNameLabel.Size = new System.Drawing.Size(79, 13);
            this.zooNameLabel.TabIndex = 5;
            this.zooNameLabel.Text = "Enter the name";
            // 
            // ZooOpener
            // 
            this.ZooOpener.Location = new System.Drawing.Point(372, 234);
            this.ZooOpener.Name = "ZooOpener";
            this.ZooOpener.Size = new System.Drawing.Size(172, 41);
            this.ZooOpener.TabIndex = 6;
            this.ZooOpener.Text = "Open the zoo";
            this.ZooOpener.UseVisualStyleBackColor = true;
            this.ZooOpener.Click += new System.EventHandler(this.ZooOpener_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ZooListCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 287);
            this.Controls.Add(this.ZooOpener);
            this.Controls.Add(this.zooNameLabel);
            this.Controls.Add(this.ZooName);
            this.Controls.Add(this.ZooRemover);
            this.Controls.Add(this.ZooCreator);
            this.Controls.Add(this.ZooList);
            this.Controls.Add(this.FormName);
            this.Name = "ZooListCont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.ListBox ZooList;
        private System.Windows.Forms.Button ZooCreator;
        private System.Windows.Forms.Button ZooRemover;
        private System.Windows.Forms.TextBox ZooName;
        private System.Windows.Forms.Label zooNameLabel;
        private System.Windows.Forms.Button ZooOpener;
        private System.Windows.Forms.ImageList imageList1;
    }
}

