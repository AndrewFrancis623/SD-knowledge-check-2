using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KnowledgeCheck2
{
    public class Album 
    {
        public Album()
        {
        }

        public Album(int albumId)
        {
            AlbumId = albumId;
        }

        public int Year { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int AlbumId { get; }

        public Album Retrieve(int AlbumId) 
        {
            return new Album();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(Author)) isValid = false;
          

            return isValid;
        }
    }
}