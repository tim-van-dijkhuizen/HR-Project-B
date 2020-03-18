﻿using System;
using System.Collections.Generic;
using System.Linq;
using Project.Base;
using Project.Data;
using Project.Enums;
using Project.Helpers;
using Project.Models;
using Project.Records;

namespace Project.Services {

    class ShowManager : Service {

        // Database
        private ShowDatabase database;

        // Current user (logged in user)
        private User currentUser;

        public override string getHandle() {
            return "shows";
        }

        public override void Load() {
            database = new ShowDatabase();

            ConsoleHelper.Print(PrintType.Info, "Loading user database...");

            // Try to load
            if (!database.Load()) {
                ConsoleHelper.Print(PrintType.Error, "Failed to load users");
                return;
            }

            ConsoleHelper.Print(PrintType.Info, "Loaded user database.");


        }

        public override void Unload() {
            ConsoleHelper.Print(PrintType.Info, "Saving user database...");

            // Try to save
            if (!database.Save()) {
                ConsoleHelper.Print(PrintType.Error, "Failed to save user database.");
                return;
            }

            ConsoleHelper.Print(PrintType.Info, "Saved user database.");
        }

        // Returns all users
        public List<User> GetUsers() {
            List<User> models = new List<User>();

            foreach(ShowRecord record in database.show){
                models.Add(new User(record));
            }

            return models;
        }

        

        // Saves the specified user
        public bool SaveShow(Show show) {
            bool isNew = show.id == -1;

            // Set id if its a new user
            if (isNew) {
                show.id = database.GetNewId("shows");
            }


            // Find existing record
            ShowRecord record = database.users.SingleOrDefault(i => i.id == Show.id);
            
            // Add if no record exists
            if(record == null) {
                record = new ShowRecord();
                database.shows.Add(record);
            }

            // Update record
            record.id = show.id;
            record.fullName = show.fullName;
            record.username = show.username;
            record.password = show.password;
            record.admin = show.admin;

            return true;
        }
    }

}