using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    public class Bookinfo
    {
        //properties
        public string Name;
        public string TypeOfBook;
        public int NumberOfPages;
        public float Weight;
        public int Chapters;
        public float Height;
        public float Length;
        public bool IsDigital;
        public string TypeOfCover;
        public bool IsOnSale;
        public bool HasAudioBook;
        public float Price;
        public string Author;
        //end

        //Constructors
        //1
        public Bookinfo()
        {

        }
        //2
        public Bookinfo(string name, string typeOfBook, int numberOfPages, float weight, int chapters, float height, float length, bool isDigital, string typeOfCover, bool isOnSale, bool hasAudioBook, float price, string author)
        {
            Name = name;
            TypeOfBook = typeOfBook;
            NumberOfPages = numberOfPages;
            Weight = weight;
            Chapters = chapters;
            Height = height;
            Length = length;
            IsDigital = isDigital;
            TypeOfCover = typeOfCover;
            IsOnSale = isOnSale;
            HasAudioBook = hasAudioBook;
            Price = price;
            Author = author;
        }

        //Methods
        //1
        public void Describe()
        {
            Console.WriteLine("\n Name of Book:" + Name);
            Console.WriteLine("\n  Authors Name:" + Author);
            Console.WriteLine("\t Type of book:" + TypeOfBook);
            Console.WriteLine("\t Is Digital:" + IsDigital);
            Console.WriteLine("\t Has Audio Version:" + HasAudioBook);
        }

        //2
        public void Sale()
        {

        }
       










    }

    
}
