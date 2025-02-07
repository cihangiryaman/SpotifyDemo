﻿using SpotifyDemo.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Entities
{
    public class Podcast : IEntity<Podcast> // tüm podcast programı
    {
        public int Id { get; set; }
        public int FK_UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
