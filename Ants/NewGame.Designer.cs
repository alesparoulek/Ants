namespace Ants
{
    partial class NewGame
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
            this.singlePlayerButton = new System.Windows.Forms.RadioButton();
            this.multiPlayerButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1NameBox = new System.Windows.Forms.TextBox();
            this.player2NameBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singlePlayerButton
            // 
            this.singlePlayerButton.AutoSize = true;
            this.singlePlayerButton.Location = new System.Drawing.Point(30, 25);
            this.singlePlayerButton.Name = "singlePlayerButton";
            this.singlePlayerButton.Size = new System.Drawing.Size(55, 17);
            this.singlePlayerButton.TabIndex = 0;
            this.singlePlayerButton.TabStop = true;
            this.singlePlayerButton.Text = "1 hráč";
            this.singlePlayerButton.UseVisualStyleBackColor = true;
            // 
            // multiPlayerButton
            // 
            this.multiPlayerButton.AutoSize = true;
            this.multiPlayerButton.Location = new System.Drawing.Point(30, 48);
            this.multiPlayerButton.Name = "multiPlayerButton";
            this.multiPlayerButton.Size = new System.Drawing.Size(57, 17);
            this.multiPlayerButton.TabIndex = 1;
            this.multiPlayerButton.TabStop = true;
            this.multiPlayerButton.Text = "2 hráči";
            this.multiPlayerButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zvolte typ hry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jméno hráče č.1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jméno hráče č.2:";
            // 
            // player1NameBox
            // 
            this.player1NameBox.Location = new System.Drawing.Point(126, 72);
            this.player1NameBox.MaxLength = 10;
            this.player1NameBox.Name = "player1NameBox";
            this.player1NameBox.Size = new System.Drawing.Size(86, 20);
            this.player1NameBox.TabIndex = 5;
            this.player1NameBox.Text = "černí";
            // 
            // player2NameBox
            // 
            this.player2NameBox.Location = new System.Drawing.Point(126, 99);
            this.player2NameBox.MaxLength = 10;
            this.player2NameBox.Name = "player2NameBox";
            this.player2NameBox.Size = new System.Drawing.Size(86, 20);
            this.player2NameBox.TabIndex = 6;
            this.player2NameBox.Text = "červení";
            // 
            // startButton
            // 
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startButton.Location = new System.Drawing.Point(237, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.exitButton.Location = new System.Drawing.Point(237, 82);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Konec";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(237, 54);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Nápověda";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 151);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.player2NameBox);
            this.Controls.Add(this.player1NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiPlayerButton);
            this.Controls.Add(this.singlePlayerButton);
            this.Name = "NewGame";
            this.Text = "Nová hra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton singlePlayerButton;
        private System.Windows.Forms.RadioButton multiPlayerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox player1NameBox;
        private System.Windows.Forms.TextBox player2NameBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
    }
}