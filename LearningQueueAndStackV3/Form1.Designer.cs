namespace LearningQueueAndStackV3
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.lumberjackTextbox = new System.Windows.Forms.TextBox();
            this.addLumberjackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPancakeButton = new System.Windows.Forms.Button();
            this.nextLumberjackButton = new System.Windows.Forms.Button();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.lumberjackEating = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imię drwala:";
            // 
            // lumberjackTextbox
            // 
            this.lumberjackTextbox.Location = new System.Drawing.Point(126, 19);
            this.lumberjackTextbox.Name = "lumberjackTextbox";
            this.lumberjackTextbox.Size = new System.Drawing.Size(100, 20);
            this.lumberjackTextbox.TabIndex = 1;
            // 
            // addLumberjackButton
            // 
            this.addLumberjackButton.Location = new System.Drawing.Point(30, 47);
            this.addLumberjackButton.Name = "addLumberjackButton";
            this.addLumberjackButton.Size = new System.Drawing.Size(196, 23);
            this.addLumberjackButton.TabIndex = 2;
            this.addLumberjackButton.Text = "Dodaj drwala";
            this.addLumberjackButton.UseVisualStyleBackColor = true;
            this.addLumberjackButton.Click += new System.EventHandler(this.addLumberjackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kolejka do śniadania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nakarm drwala";
            // 
            // addPancakeButton
            // 
            this.addPancakeButton.Location = new System.Drawing.Point(155, 241);
            this.addPancakeButton.Name = "addPancakeButton";
            this.addPancakeButton.Size = new System.Drawing.Size(150, 23);
            this.addPancakeButton.TabIndex = 5;
            this.addPancakeButton.Text = "Dodaj naleśniki";
            this.addPancakeButton.UseVisualStyleBackColor = true;
            this.addPancakeButton.Click += new System.EventHandler(this.addPancakeButton_Click);
            // 
            // nextLumberjackButton
            // 
            this.nextLumberjackButton.Location = new System.Drawing.Point(155, 365);
            this.nextLumberjackButton.Name = "nextLumberjackButton";
            this.nextLumberjackButton.Size = new System.Drawing.Size(150, 23);
            this.nextLumberjackButton.TabIndex = 6;
            this.nextLumberjackButton.Text = "Następny drwal";
            this.nextLumberjackButton.UseVisualStyleBackColor = true;
            this.nextLumberjackButton.Click += new System.EventHandler(this.nextLumberjackButton_Click);
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(155, 132);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(79, 17);
            this.crispy.TabIndex = 8;
            this.crispy.TabStop = true;
            this.crispy.Text = "Chrupkiego";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(155, 155);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(79, 17);
            this.soggy.TabIndex = 9;
            this.soggy.TabStop = true;
            this.soggy.Text = "Wilgotnego";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(155, 178);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(79, 17);
            this.browned.TabIndex = 10;
            this.browned.TabStop = true;
            this.browned.Text = "Rumianego";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(155, 201);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(88, 17);
            this.banana.TabIndex = 11;
            this.banana.TabStop = true;
            this.banana.Text = "Bananowego";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(155, 97);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(60, 20);
            this.howMany.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(155, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 104);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // queueListBox
            // 
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.Location = new System.Drawing.Point(12, 98);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(137, 290);
            this.queueListBox.TabIndex = 15;
            // 
            // lumberjackEating
            // 
            this.lumberjackEating.Location = new System.Drawing.Point(155, 270);
            this.lumberjackEating.Multiline = true;
            this.lumberjackEating.Name = "lumberjackEating";
            this.lumberjackEating.ReadOnly = true;
            this.lumberjackEating.Size = new System.Drawing.Size(150, 89);
            this.lumberjackEating.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 393);
            this.Controls.Add(this.lumberjackEating);
            this.Controls.Add(this.queueListBox);
            this.Controls.Add(this.howMany);
            this.Controls.Add(this.banana);
            this.Controls.Add(this.browned);
            this.Controls.Add(this.soggy);
            this.Controls.Add(this.crispy);
            this.Controls.Add(this.nextLumberjackButton);
            this.Controls.Add(this.addPancakeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addLumberjackButton);
            this.Controls.Add(this.lumberjackTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox lumberjackTextbox;
        private System.Windows.Forms.Button addLumberjackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPancakeButton;
        private System.Windows.Forms.Button nextLumberjackButton;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.TextBox lumberjackEating;
    }
}

