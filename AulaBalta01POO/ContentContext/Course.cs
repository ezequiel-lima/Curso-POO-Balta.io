﻿using AulaBalta01POO.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaBalta01POO.ContentContext
{
    internal class Course : Content
    {
        public Course(string title, string url) : base(title, url) 
        {
            //sempre iniciar a lista no construtor
            Modules = new List<Module>();        
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }  
}
