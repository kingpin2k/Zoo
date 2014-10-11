using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoo.ViewModels
{
    public class AnimalViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public string Image { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}