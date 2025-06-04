using _166303_projekt_zpo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _166303_projekt_zpo.Services
{
    public class CatalogManager
    {
        public List<MediaItem> Items { get; private set; } = new();

        public void AddItem(MediaItem item)
        {
            if (item != null)
                Items.Add(item);
        }

        public void RemoveItem(MediaItem item)
        {
            if (Items.Contains(item))
                Items.Remove(item);

        }
        public IEnumerable<MediaItem> FilterByGenre(string genre)
        {
            return Items.Where(i => i.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<MediaItem> TopRated(int count = 5)
        {
            return Items.OrderByDescending(i => i.Rating).Take(count);
        }
        public IEnumerable<MediaItem> SearchByTitle(string keyword)
        {
            return Items.Where(i => i.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }
    }
}
