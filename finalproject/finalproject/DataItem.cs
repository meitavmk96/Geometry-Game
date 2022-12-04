using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    public class DataItem : IComparable
    {
        static int infoNumber = 0;
        protected const int TopicIndex = 1;
        protected const int ContentIndex = 2;
        protected const int ImageIndex = 3;
        const int NoImageType = 3;
        const int ImageType = 4;

        public DataItem(string topic, string content)
        {
            Number = ++infoNumber;//A unique numbering for the information item
            Topic = topic;
            Content = content;
        }

        protected int Number { get; }
        public string Topic { get; set; }
        public string Content { get; set; }

        public int CompareTo(object obj)//checks if Data item already exists by comparing content field
        {
            if (obj is DataItem)
                return Content.CompareTo(((DataItem)obj).Content);
            throw new Exception("This object is not DataItem type");
        }

        public override string ToString()//File writing format
        {
            return $"{Number};{Topic};{Content}";
        }

        internal static DataItem CreateFromData(string line)// method that turns a line in the data to DataItem
        {
            string[] parts = line.Split(';');
            if (parts.Length == NoImageType)// checks if DataItem has image parts his properties accorrding
                return new DataItem(parts[TopicIndex], parts[ContentIndex]);
            if (parts.Length == ImageType)
                return DataItemWImage.CreateFromData(parts);
            throw new Exception("פורמט פריט המידע יכול להכיל 3 או 4 תכונות בלבד");
        }

        internal static void DecreaseUniqueNumber()//method for descending unique number in case user was added
        {
            infoNumber--;
        }
    }
}
