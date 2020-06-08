﻿using System;
using System.Windows.Forms;
using Project.Errors;
using Project.Forms.Layouts;
using Project.Helpers;
using Project.Models;
using Project.Services;

namespace Project.Forms {

    public class UserEdit : BaseLayout {

        // Frontend
        private Panel content;

        private Label fullNameLabel;
        private TextBox fullNameInput;

        private TextBox usernameInput;
        private Label usernameLabel;

        private Label adminLabel;
        private CheckBox adminInput;

        private Button saveButton;
        private Button changePasswordButton;
        private Button cancelButton;
        private Button deleteButton;

        // Backend
        private User user;

        public UserEdit() {
            InitializeComponent();
        }

        public override string GetHandle() {
            return "userEdit";
        }

        public override void OnShow() {
            UserService userService = Program.GetInstance().GetService<UserService>("users");
            User currentUser = userService.GetCurrentUser();

            base.OnShow();

            if(user.id != currentUser.id && !currentUser.admin) {
                throw new PermissionException("Je kunt alleen je eigen account bewerken");
            }

            // Show admin/delete if the user is an admin
            adminLabel.Visible = currentUser.admin;
            adminInput.Visible = currentUser.admin;
            cancelButton.Visible = currentUser.admin;
            deleteButton.Visible = currentUser.admin  && currentUser.id != user.id;

            // Set values
            fullNameInput.Text = user.fullName;
            usernameInput.Text = user.username;
            adminInput.Checked = user.admin;
        }

        private void InitializeComponent() {
            this.content = new System.Windows.Forms.Panel();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameInput = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.adminInput = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.deleteButton);
            this.content.Controls.Add(this.cancelButton);
            this.content.Controls.Add(this.changePasswordButton);
            this.content.Controls.Add(this.fullNameLabel);
            this.content.Controls.Add(this.fullNameInput);
            this.content.Controls.Add(this.usernameLabel);
            this.content.Controls.Add(this.usernameInput);
            this.content.Controls.Add(this.adminLabel);
            this.content.Controls.Add(this.adminInput);
            this.content.Controls.Add(this.saveButton);
            this.content.Location = new System.Drawing.Point(180, 127);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(715, 443);
            this.content.TabIndex = 2;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(141, 238);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(140, 23);
            this.changePasswordButton.TabIndex = 14;
            this.changePasswordButton.Text = "Wachtwoord aanpassen";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(137, 84);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(79, 13);
            this.fullNameLabel.TabIndex = 9;
            this.fullNameLabel.Text = "Volledige naam";
            // 
            // fullNameInput
            // 
            this.fullNameInput.Location = new System.Drawing.Point(258, 81);
            this.fullNameInput.Name = "fullNameInput";
            this.fullNameInput.Size = new System.Drawing.Size(272, 20);
            this.fullNameInput.TabIndex = 8;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(137, 123);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Gebruikersnaam";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(258, 120);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(272, 20);
            this.usernameInput.TabIndex = 0;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(137, 161);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(36, 13);
            this.adminLabel.TabIndex = 10;
            this.adminLabel.Text = "Admin";
            // 
            // adminInput
            // 
            this.adminInput.AutoSize = true;
            this.adminInput.Location = new System.Drawing.Point(258, 161);
            this.adminInput.Name = "adminInput";
            this.adminInput.Size = new System.Drawing.Size(15, 14);
            this.adminInput.TabIndex = 11;
            this.adminInput.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(141, 198);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(231, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Annuleren";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(141, 276);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(140, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Verwijderen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UserEdit
            // 
            this.ClientSize = new System.Drawing.Size(1916, 1173);
            this.Controls.Add(this.content);
            this.Name = "UserEdit";
            this.Controls.SetChildIndex(this.content, 0);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        public void SetUser(User user) {
            this.user = user;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Program app = Program.GetInstance();
            UserService userService = app.GetService<UserService>("users");
            User currentUser = userService.GetCurrentUser();

            // Save user
            user.fullName = fullNameInput.Text;
            user.username = usernameInput.Text;
            user.admin = adminInput.Checked;

            if(!userService.SaveUser(user)) {
                GuiHelper.ShowError("Error: " + ValidationHelper.GetErrorList(user));
                return;
            }

            GuiHelper.ShowInfo("Gebruiker succesvol aangepast");
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            UserList userList = Program.GetInstance().GetScreen<UserList>("userList");
            Program.GetInstance().ShowScreen(userList);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            Program app = Program.GetInstance();
            UserChangePassword changePassword = app.GetScreen<UserChangePassword>("userChangePassword");

            changePassword.SetUser(user);
            app.ShowScreen(changePassword);
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            Program app = Program.GetInstance();
            UserService userService = app.GetService<UserService>("users");

            if (userService.DeleteUser(user)) {
                UserList userList = app.GetScreen<UserList>("userList");

                app.ShowScreen(userList);
                GuiHelper.ShowInfo("Gebruiker succesvol verwijderd");
            } else {
                GuiHelper.ShowError("Kon gebruiker niet verwijderen");
            }
        }

    }

}
