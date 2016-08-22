using System;

namespace Cleaner.Models
{
    public class Cleaner
    {
        public User User
        {
            get;
            set;
        }

        public string Experience
        {
            get;
            set;
        }

        public string Tags
        {
            get;
            set;
        }
        
        public Boolean IsStared
        {
            get;
            set;
        }

        public Cleaner(
            User user,
            string experience,
            string tags,
            Boolean isStared
            )
        {
            User = user;
            Experience = experience;
            Tags = tags;
            IsStared = isStared;
        }
    }
}