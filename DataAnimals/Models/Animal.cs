﻿using System.ComponentModel.DataAnnotations;

namespace DataAnimals.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Description { get; set; }
        public float AgeAvg { get; set; }
        public int CatergoryAnimal_Id { get; set; }
        public List<AnimalCategory> AnimalCategory { get; set; }
        public int AnimalImage_Id { get; set; }
        public List<AnimalImage> AnimalImage { get; set; }
    }
}