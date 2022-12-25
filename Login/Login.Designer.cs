namespace Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.registercheck = new System.Windows.Forms.CheckBox();
            this.register = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginName
            // 
            this.LoginName.AutoSize = true;
            this.LoginName.Location = new System.Drawing.Point(61, 37);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(64, 13);
            this.LoginName.TabIndex = 0;
            this.LoginName.Text = "Login Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(72, 63);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(131, 34);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 2;
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(131, 60);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(100, 20);
            this.PWBox.TabIndex = 3;
            this.PWBox.UseSystemPasswordChar = true;
            // 
            // registercheck
            // 
            this.registercheck.AutoSize = true;
            this.registercheck.Location = new System.Drawing.Point(131, 87);
            this.registercheck.Name = "registercheck";
            this.registercheck.Size = new System.Drawing.Size(90, 17);
            this.registercheck.TabIndex = 4;
            this.registercheck.Text = "registercheck";
            this.registercheck.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Location = new System.Drawing.Point(79, 87);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(46, 13);
            this.register.TabIndex = 5;
            this.register.Text = "Register";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(64, 111);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(167, 23);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(265, 146);
            this.Controls.Add(this.login);
            this.Controls.Add(this.register);
            this.Controls.Add(this.registercheck);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.CheckBox registercheck;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Button login;
    }
}

