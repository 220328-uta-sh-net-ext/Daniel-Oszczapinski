namespace RestaurantInfo
{
    //This will display name, ratings, address, type of resturant, admin access. 
    public class Info
    {
        //Resturant information
        public string Name { get; set; }
        public string Address { get; set; }
        public int AverageRating { get; set; }

        //Resturant has a name, Adress, Rating 

        private List<Restaurant> _items;
        public List<Restaurant> Items { 
            get { return _items; }

            set
            {
                if (value.Count <= 5)
                    _items = value;
                else
                    throw new Exception("Rating can not larger that 5.");
            }
        }

        public Info()
        {
            Name = "Pizza Hut";
            Address = " 123 S Park";
            AverageRating = 0;

        }
        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nAverage Rating: {AverageRating}";
        }
    }
}