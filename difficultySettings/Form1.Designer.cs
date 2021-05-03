
namespace difficultySettings
{
    partial class background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(background));
            this.enterName = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.difficultyText = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.namePrint = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterName.ForeColor = System.Drawing.SystemColors.Control;
            this.enterName.Location = new System.Drawing.Point(12, 24);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(198, 22);
            this.enterName.TabIndex = 0;
            this.enterName.Text = "Enter Your Name Hero:";
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.ForeColor = System.Drawing.SystemColors.MenuText;
            this.userInput.Location = new System.Drawing.Point(216, 22);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(187, 26);
            this.userInput.TabIndex = 1;
            // 
            // difficultyText
            // 
            this.difficultyText.AutoSize = true;
            this.difficultyText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyText.ForeColor = System.Drawing.SystemColors.Control;
            this.difficultyText.Location = new System.Drawing.Point(97, 87);
            this.difficultyText.Name = "difficultyText";
            this.difficultyText.Size = new System.Drawing.Size(231, 22);
            this.difficultyText.TabIndex = 2;
            this.difficultyText.Text = "Select Your Difficulty Level:";
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.easyButton.Location = new System.Drawing.Point(42, 147);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(92, 37);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.SystemColors.Control;
            this.mediumButton.Location = new System.Drawing.Point(186, 147);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(92, 37);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hardButton.Location = new System.Drawing.Point(330, 147);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(92, 37);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.beginButton.Location = new System.Drawing.Point(137, 246);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(191, 37);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // namePrint
            // 
            this.namePrint.BackColor = System.Drawing.SystemColors.ControlText;
            this.namePrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePrint.ForeColor = System.Drawing.SystemColors.Control;
            this.namePrint.Location = new System.Drawing.Point(97, 315);
            this.namePrint.Name = "namePrint";
            this.namePrint.Size = new System.Drawing.Size(272, 23);
            this.namePrint.TabIndex = 7;
            this.namePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.ControlText;
            this.outputText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.SystemColors.Control;
            this.outputText.Location = new System.Drawing.Point(16, 360);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(446, 33);
            this.outputText.TabIndex = 8;
            this.outputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(474, 452);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.namePrint);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.difficultyText);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.enterName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "background";
            this.Text = "Difficulty Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label difficultyText;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label namePrint;
        private System.Windows.Forms.Label outputText;
    }
}

