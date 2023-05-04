﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BanVeXemPhim_MVC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Quan hệ
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}