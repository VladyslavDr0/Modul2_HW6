﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Book
    {
        private string _name;
        private DateTime _time;
        private int _numberOfPages;
        private Autor _autor;

        public Book(string name, DateTime time, int numberOfPages, Autor autor)
        {
            _name = name;
            _time = time;
            _numberOfPages = numberOfPages;
            _autor = autor;
        }

        public string Name => _name;
        public DateTime Time => _time;
        public int NumberOfPages => _numberOfPages;
        public Autor Autor => _autor;
    }
}
