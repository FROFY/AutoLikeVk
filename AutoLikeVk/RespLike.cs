using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLikeVk
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ResponseNew
    {
        public int likes { get; set; }
    }

    public class RootNew
    {
        public ResponseNew response { get; set; }
    }


}
