namespace Login_screen
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passButton = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passShow = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.Black;
            this.passBox.Location = new System.Drawing.Point(265, 201);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(232, 42);
            this.passBox.TabIndex = 14;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged_1);
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.Color.Black;
            this.userBox.Location = new System.Drawing.Point(265, 117);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(232, 42);
            this.userBox.TabIndex = 13;
            // 
            // passButton
            // 
            this.passButton.AutoSize = true;
            this.passButton.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.passButton.Location = new System.Drawing.Point(81, 204);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(151, 33);
            this.passButton.TabIndex = 12;
            this.passButton.Text = "Password:";
            // 
            // userButton
            // 
            this.userButton.AutoSize = true;
            this.userButton.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.userButton.Location = new System.Drawing.Point(72, 126);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(149, 33);
            this.userButton.TabIndex = 11;
            this.userButton.Text = "Username:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Maroon;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.loginButton.Location = new System.Drawing.Point(265, 357);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(199, 101);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passShow
            // 
            this.passShow.AutoSize = true;
            this.passShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passShow.Location = new System.Drawing.Point(265, 41);
            this.passShow.Name = "passShow";
            this.passShow.Size = new System.Drawing.Size(0, 20);
            this.passShow.TabIndex = 15;
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.wrongLabel.Location = new System.Drawing.Point(132, 527);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(0, 33);
            this.wrongLabel.TabIndex = 16;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.passShow);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.loginButton);
            this.Name = "login";
            this.Size = new System.Drawing.Size(700, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label passButton;
        private System.Windows.Forms.Label userButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passShow;
        private System.Windows.Forms.Label wrongLabel;
    }
}
