using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class DataItemWImage : DataItem
    {
        public string Image { get; set; }

        public DataItemWImage(string topic, string content, string image) : this(topic, content, image, true)
        {
        }

        private DataItemWImage(string topic, string content, string image, bool addQNumberToImage) : base(topic, content)
        {
            if (addQNumberToImage && !string.IsNullOrEmpty(image))
                Image = Number + image;
            else
                Image = image;
        }


        public override string ToString()//file writing format
        {
            return base.ToString() + $";{Image}";
        }

        internal static DataItem CreateFromData(string[] parts)//Creates an object from the file data
        {
            return new DataItemWImage(parts[TopicIndex], parts[ContentIndex], parts[ImageIndex], false);
        }
    }
}
