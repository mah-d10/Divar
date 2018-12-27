namespace Divar
{
    public class AdSpec
    {
        //properties
        private bool IsUrgent;
        private bool HasImage;
        private City City;
        private Vicinity Vicinity;
        private Category Category;


        //constructor
        public AdSpec(bool isUrgent, bool hasImage, City city, Vicinity vicinity, Category category)
        {
            IsUrgent = isUrgent;
            HasImage = hasImage;
            City = city;
            Vicinity = vicinity;
            Category = category;
        }


        //methods
        public bool GetIsUrgent() => IsUrgent;
        public bool GetHasImage() => HasImage;
        public City GetCity() => City;
        public Vicinity GetVicinity() => Vicinity;
        public Category GetCategory() => Category;

        public bool Matches(AdSpec otherSpec)
        {
            if (IsUrgent == false && otherSpec.IsUrgent == true)
                return false;

            if (HasImage == false && otherSpec.HasImage == true)
                return false;

            if (City != otherSpec.City)
                return false;

            if (Vicinity != otherSpec.Vicinity)
                return false;

            if (Category.Equals(otherSpec.Category))
                return false;

            return true;
        }
    }
}
