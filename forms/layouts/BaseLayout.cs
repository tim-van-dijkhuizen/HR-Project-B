﻿using System;
using System.Windows.Forms;
using Project.Base;
using Project.Models;
using Project.Services;
using System.Runtime.InteropServices;
using Project.Forms.Components;

namespace Project.Forms.Layouts {

    public class BaseLayout : BaseScreen {

        private Panel navBar;
        private RoundedButton navLink1;
        private RoundedButton navLink2;
        private RoundedButton navLink3;
        private RoundedButton navLink4;
        private RoundedButton navLink5;
        private TextBox navLoginUsername;
        private TextBox navLoginPassword;
        private Button navLoginButton;

        private string usernameValue;
        private Button navRegisterButton;
        private string passwordValue;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        
        public BaseLayout() {
            InitializeComponent();
        }

        public override void OnShow() {
            UpdateUserControls();
        }

        private void InitializeComponent() {
            this.navBar = new System.Windows.Forms.Panel();
            this.navLink1 = new Project.Forms.Components.RoundedButton();
            this.navLink2 = new Project.Forms.Components.RoundedButton();
            this.navLink3 = new Project.Forms.Components.RoundedButton();
            this.navLink4 = new Project.Forms.Components.RoundedButton();
            this.navLink5 = new Project.Forms.Components.RoundedButton();
            this.navLoginUsername = new System.Windows.Forms.TextBox();
            this.navLoginPassword = new System.Windows.Forms.TextBox();
            this.navLoginButton = new System.Windows.Forms.Button();
            this.navRegisterButton = new System.Windows.Forms.Button();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.Black;
            this.navBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navBar.Controls.Add(this.navLink1);
            this.navBar.Controls.Add(this.navLink2);
            this.navBar.Controls.Add(this.navLink3);
            this.navBar.Controls.Add(this.navLink4);
            this.navBar.Controls.Add(this.navLink5);
            this.navBar.Controls.Add(this.navLoginUsername);
            this.navBar.Controls.Add(this.navLoginPassword);
            this.navBar.Controls.Add(this.navLoginButton);
            this.navBar.Controls.Add(this.navRegisterButton);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(1902, 100);
            this.navBar.TabIndex = 1;
            // 
            // navLink1
            // 
            this.navLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.navLink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navLink1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navLink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navLink1.Location = new System.Drawing.Point(40, 55);
            this.navLink1.Name = "navLink1";
            this.navLink1.Size = new System.Drawing.Size(110, 30);
            this.navLink1.TabIndex = 0;
            this.navLink1.Text = "Movie";
            this.navLink1.UseVisualStyleBackColor = false;
            this.navLink1.Click += new System.EventHandler(this.navLink1_Click);
            // 
            // navLink2
            // 
            this.navLink2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.navLink2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navLink2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navLink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navLink2.Location = new System.Drawing.Point(180, 55);
            this.navLink2.Name = "navLink2";
            this.navLink2.Size = new System.Drawing.Size(110, 30);
            this.navLink2.TabIndex = 1;
            this.navLink2.Text = "Room";
            this.navLink2.UseVisualStyleBackColor = false;
            this.navLink2.Click += new System.EventHandler(this.navLink2_Click);
            // 
            // navLink3
            // 
            this.navLink3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.navLink3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navLink3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navLink3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navLink3.Location = new System.Drawing.Point(320, 55);
            this.navLink3.Name = "navLink3";
            this.navLink3.Size = new System.Drawing.Size(110, 30);
            this.navLink3.TabIndex = 4;
            this.navLink3.UseVisualStyleBackColor = false;
            this.navLink3.Click += new System.EventHandler(this.navLink3_Click);
            // 
            // navLink4
            // 
            this.navLink4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.navLink4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navLink4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navLink4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navLink4.Location = new System.Drawing.Point(460, 55);
            this.navLink4.Name = "navLink4";
            this.navLink4.Size = new System.Drawing.Size(110, 30);
            this.navLink4.TabIndex = 3;
            this.navLink4.UseVisualStyleBackColor = false;
            // 
            // navLink5
            // 
            this.navLink5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.navLink5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navLink5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navLink5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.navLink5.FlatAppearance.BorderSize = 0;
            this.navLink5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navLink5.Location = new System.Drawing.Point(600, 55);
            this.navLink5.Name = "navLink5";
            this.navLink5.Size = new System.Drawing.Size(110, 30);
            this.navLink5.TabIndex = 2;
            this.navLink5.UseVisualStyleBackColor = false;
            this.navLink5.Click += new System.EventHandler(this.navLink5_Click);
            // 
            // navLoginUsername
            // 
            this.navLoginUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.navLoginUsername.Location = new System.Drawing.Point(1642, 16);
            this.navLoginUsername.Name = "navLoginUsername";
            this.navLoginUsername.Size = new System.Drawing.Size(132, 23);
            this.navLoginUsername.TabIndex = 7;
            this.navLoginUsername.Text = "Gebruikersnaam";
            this.navLoginUsername.TextChanged += new System.EventHandler(this.NavLoginUsername_TextChanged);
            this.navLoginUsername.Enter += new System.EventHandler(this.LoginUsernameRemoveText);
            this.navLoginUsername.Leave += new System.EventHandler(this.LoginUsernameAddText);
            // 
            // navLoginPassword
            // 
            this.navLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.navLoginPassword.Location = new System.Drawing.Point(1642, 58);
            this.navLoginPassword.Name = "navLoginPassword";
            this.navLoginPassword.Size = new System.Drawing.Size(132, 23);
            this.navLoginPassword.TabIndex = 8;
            this.navLoginPassword.Text = "Wachtwoord";
            this.navLoginPassword.TextChanged += new System.EventHandler(this.NavLoginPassword_TextChanged);
            this.navLoginPassword.Enter += new System.EventHandler(this.LoginPasswordRemoveText);
            this.navLoginPassword.Leave += new System.EventHandler(this.LoginPasswordAddText);
            // 
            // navLoginButton
            // 
            this.navLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navLoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navLoginButton.BackColor = System.Drawing.Color.White;
            this.navLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.navLoginButton.Location = new System.Drawing.Point(1783, 16);
            this.navLoginButton.Name = "navLoginButton";
            this.navLoginButton.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.navLoginButton.Size = new System.Drawing.Size(99, 30);
            this.navLoginButton.TabIndex = 5;
            this.navLoginButton.Text = "Inloggen";
            this.navLoginButton.UseVisualStyleBackColor = false;
            this.navLoginButton.Click += new System.EventHandler(this.NavLoginButton_Click);
            // 
            // navRegisterButton
            // 
            this.navRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navRegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navRegisterButton.BackColor = System.Drawing.Color.White;
            this.navRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.navRegisterButton.Location = new System.Drawing.Point(1783, 52);
            this.navRegisterButton.Name = "navRegisterButton";
            this.navRegisterButton.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.navRegisterButton.Size = new System.Drawing.Size(99, 30);
            this.navRegisterButton.TabIndex = 10;
            this.navRegisterButton.Text = "Registreren";
            this.navRegisterButton.UseVisualStyleBackColor = false;
            this.navRegisterButton.Click += new System.EventHandler(this.NavRegisterButton_Click);
            // 
            // BaseLayout
            // 
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.navBar);
            this.Name = "BaseLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);

        }

        private void NavLoginUsername_TextChanged(object sender, EventArgs e) {
            usernameValue = navLoginUsername.Text;

        }

        private void NavLoginPassword_TextChanged(object sender, EventArgs e) {
            passwordValue = navLoginPassword.Text;
        }

        private void NavLoginButton_Click(object sender, EventArgs e) {
            UserService userService = Program.GetInstance().GetService<UserService>("users");

            // Find user
            User user = userService.GetUserByUsername(usernameValue);

            // Error if user or password invalid
            if (user == null || !user.Authenticate(passwordValue)) {
                MessageBox.Show("Invalid username or password");
                return;
            }

            // Everything ok, login
            userService.SetCurrentUser(user);
            UpdateUserControls();
            MessageBox.Show("Succesvol ingelogd, welkom " + user.fullName);
        }

        private void NavRegisterButton_Click(object sender, EventArgs e) {
        
        }

        public void LoginUsernameRemoveText(object sender, EventArgs e) {
            if (navLoginUsername.Text == "Gebruikersnaam")
                navLoginUsername.Text = "";
        }

        public void LoginUsernameAddText(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(navLoginUsername.Text))
                navLoginUsername.Text = "Gebruikersnaam";
        }

        public void LoginPasswordRemoveText(object sender, EventArgs e) {
            if (navLoginPassword.Text == "Wachtwoord") {
                navLoginPassword.Text = "";
                navLoginPassword.PasswordChar = '*';
            }
        }

        public void LoginPasswordAddText(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(navLoginPassword.Text)) {
                navLoginPassword.Text = "Wachtwoord";
                navLoginPassword.PasswordChar = '\0';
            }
        }

        private void UpdateUserControls() {
            UserService userService = Program.GetInstance().GetService<UserService>("users");
            bool loggedIn = userService.GetCurrentUser() != null;

            // Update login visibillity
            navLoginUsername.Visible = !loggedIn;
            navLoginPassword.Visible = !loggedIn;
            navLoginButton.Visible = !loggedIn;
            navRegisterButton.Visible = !loggedIn;

            // Update account visibillity

        }

        private void navLink1_Click(object sender, EventArgs e) {
            Program app = Program.GetInstance();
            MovieList newScreen = app.GetScreen<MovieList>("movieList");

            app.ShowScreen(newScreen);
        }

        private void navLink2_Click(object sender, EventArgs e) {
            Program app = Program.GetInstance();
            RoomList newScreen = app.GetScreen<RoomList>("roomList");

            app.ShowScreen(newScreen);
        }

        private void navLink3_Click(object sender, EventArgs e) {
            UserService userService = Program.GetInstance().GetService<UserService>("users");
            User currentUser = userService.GetCurrentUser();
            if (currentUser == null) {
                MessageBox.Show("Er is niemand ingelogd");
                return;
            }
            Program app = Program.GetInstance();
            UserChangePassword userChangePasswordScreen = app.GetScreen<UserChangePassword>("userChangePassword");

            app.ShowScreen(userChangePasswordScreen);
        }

        private void navLink4_Click(object sender, EventArgs e) {

        }

        private void navLink5_Click(object sender, EventArgs e) {
            Program app = Program.GetInstance();
            MovieShowList newScreen = app.GetScreen<MovieShowList>("movieShowList");

            app.ShowScreen(newScreen);
        }

    }

}




        
            
       
    
