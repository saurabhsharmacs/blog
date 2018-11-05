﻿namespace Wordpress.Api
{
    internal class Category
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public int post_count { get; set; }
        public string feed_url { get; set; }
        public int parent { get; set; }
        public Meta meta { get; set; }
    }
}