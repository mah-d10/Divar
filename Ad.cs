using System;
using System.Collections.Generic;

namespace Divar
{
    public class Ad
    {
        //properties
        private int ID;
        private string Title;
        private string Description;
        private double Price;
        private List<Image> Images;
        private DateTime CreationTime;
        private AdSpec Spec;


        //constructor
        public Ad(int id, string title, string description, double price, List<Image> images,
            bool isUrgent, bool hasImage, City city, Vicinity vicinity, Category category,
            DateTime creationTime)
        {
            ID = id;
            Title = title;
            Description = description;
            Price = price;
            Images = new List<Image>(); Images = images;
            Spec = new AdSpec(isUrgent, hasImage, city, vicinity, category);
            CreationTime = creationTime;
        }


        //methods
        public int GetID() => ID;
        public string GetTitle() => Title;
        public string GetDescription() => Description;
        public double GetPrice() => Price;
        public List<Image> GetImages() => Images;
        public AdSpec GetSpec() => Spec;
        public DateTime GetCreationTime() => CreationTime;
    }
}
