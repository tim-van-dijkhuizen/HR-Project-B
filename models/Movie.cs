﻿using Project.Base;
using Project.Helpers;
using Project.Records;
using Project.Services;

namespace Project.Models {

    class Movie : Model {

        public int id = -1;
        public string movieName;
        public string movieTime;
        public string genre;
        public bool admin;

        public Movie(MovieRecord record) {
            this.id = record.id;
            this.movieName = record.movieName;
            this.movieTime = record.movieTime;
            this.genre = record.genre;
        }

        public Movie(string movieName, string movieTime, string genre) {
            this.movieName = movieName;
            this.movieTime = movieTime;
            this.genre = genre;
        }

        private Movie(int id, string movieName, string movieTime, string genre) {
            this.id = id;
            this.movieName = movieName;
            this.movieTime = movieTime;
            this.genre = genre;
        }

        public override bool Validate() {
            MovieManager movieManager = Program.GetInstance().GetService<MovieManager>("films");

            if (movieName == null || movieName.Length == 0) {
                this.AddError("fullName", "Volledige naam mag niet leeg zijn.");
                return false;
            }

            if (movieTime == null || movieTime.Length == 0) {
                this.AddError("username", "Username mag niet leeg zijn.");
                return false;
            }

            User existing = movieManager.GetMovieByMoviename(movieName);

            if (existing != null && existing.id != id) {
                this.AddError("moviename", "FIlm is al in gebruik.");
                return false;
            }

            if (genre == null || genre.Length == 0) {
                this.AddError("genre", "Wachtwoord mag niet leeg zijn.");
                return false;
            }

            return true;
        }

    }

}
