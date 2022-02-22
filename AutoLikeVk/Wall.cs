using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLikeVk
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Size
    {
        public int height { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }

    public class Photo
    {
        public int album_id { get; set; }
        public int date { get; set; }
        public int id { get; set; }
        public int owner_id { get; set; }
        public bool has_tags { get; set; }
        public List<Size> sizes { get; set; }
        public string text { get; set; }
        public int user_id { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string title { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public Photo photo { get; set; }
        public bool is_favorite { get; set; }
    }

    public class Attachment
    {
        public string type { get; set; }
        public Link link { get; set; }
    }

    public class PostSource
    {
        public string type { get; set; }
    }

    public class Comments
    {
        public int count { get; set; }
        public int can_post { get; set; }
        public bool groups_can_post { get; set; }
    }

    public class Likes
    {
        public int count { get; set; }
        public int user_likes { get; set; }
        public int can_like { get; set; }
        public int can_publish { get; set; }
    }

    public class Reposts
    {
        public int count { get; set; }
        public int wall_count { get; set; }
        public int mail_count { get; set; }
        public int user_reposted { get; set; }
    }

    public class Views
    {
        public int count { get; set; }
    }

    public class Donut
    {
        public bool is_donut { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public int from_id { get; set; }
        public int owner_id { get; set; }
        public int date { get; set; }
        public int marked_as_ads { get; set; }
        public string post_type { get; set; }
        public string text { get; set; }
        public int can_delete { get; set; }
        public int can_pin { get; set; }
        public int is_pinned { get; set; }
        public List<Attachment> attachments { get; set; }
        public PostSource post_source { get; set; }
        public Comments comments { get; set; }
        public Likes likes { get; set; }
        public Reposts reposts { get; set; }
        public Views views { get; set; }
        public bool is_favorite { get; set; }
        public Donut donut { get; set; }
        public double short_text_rate { get; set; }
    }

    public class Response
    {
        public int count { get; set; }
        public List<Item> items { get; set; }
    }

    public class Root
    {
        public Response response { get; set; }
    }
}
