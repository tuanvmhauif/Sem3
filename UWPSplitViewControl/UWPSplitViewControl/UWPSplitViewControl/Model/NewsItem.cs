﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSplitViewControl.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    

    public class NewsManager
    {
        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem()
            {
                Id = 1,
                Category = "Financial",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial.png"
            });
            items.Add(new NewsItem()
            {
                Id = 2,
                Category = "Financial",
                Headline = "Etiam ac felis viverra",
                Subhead = "vulputate nisl ac, aliquet nisi",
                DateLine = "tortor porttitor, eu fermentum ante congue",
                Image = "Assets/Financial2.png"
            });
            items.Add(new NewsItem()
            {
                Id = 3,
                Category = "Financial",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 4,
                Category = "Financial",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 5,
                Category = "Financial",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Financial5.png"
            });
            items.Add(new NewsItem()
            {
                Id = 6,
                Category = "Food",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Food1.png"
            });
            items.Add(new NewsItem()
            {
                Id = 7,
                Category = "Food",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Food2.png"
            });
            items.Add(new NewsItem()
            {
                Id = 8,
                Category = "Food",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Food3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 9,
                Category = "Food",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Food4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 10,
                Category = "Food",
                Headline = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Food5.png"
            });

            return items;
        }
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();

            var fillteredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();

            fillteredNewsItems.ForEach(p => newsItems.Add(p));
        }
    }
}
