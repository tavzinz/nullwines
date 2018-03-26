using System;
namespace nullwines.Models
{
    public class Wine
    {
        public Wine()
        {
        }

        public long ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int UserRating
        {
            get;
            set;
        }

        public int MainRating
        {
            get;
            set;
        }
    }
}
