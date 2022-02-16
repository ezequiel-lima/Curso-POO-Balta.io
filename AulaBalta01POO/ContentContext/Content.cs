﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaBalta01POO.ContentContext
{
    internal abstract class Content
    {
        public Content(string title, string url)
        {
            Id = Guid.NewGuid(); //SPOF Ponto Unico de Falha
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
