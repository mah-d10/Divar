using System;
using System.Collections.Generic;

namespace Divar
{
    public class Inventory
    {
        //properties
        private List<Ad> Ads;


        //constructor
        public Inventory()
        {
            Ads = new List<Ad>();
        }


        //methods
        public List<Ad> Search(AdSpec searchSpec)
        {
            var res = new List<Ad>();

            foreach (Ad a in Ads)
                if (a.GetSpec().Matches(searchSpec))
                    res.Add(a);

            return res;
        }

        public void AddAd(int id, string title, string description, double price, List<Image> images,
            bool isUrgent, bool hasImage, City city, Vicinity vicinity, Category category,
            DateTime creationTime)
        {
            Ad ad = new Ad(id, title, description, price, images,
             isUrgent, hasImage, city, vicinity, category,
             creationTime);

            Ads.Add(ad);
        }

        public Ad GetAd(int id)
        {
            foreach (var a in Ads)
                if (a.GetID() == id)
                    return a;

            return null;
        }
    }
}
