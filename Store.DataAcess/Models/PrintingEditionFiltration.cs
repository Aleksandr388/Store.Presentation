﻿using Shared.Enums;
using System.Collections.Generic;

namespace Store.DataAcess.Models
{
    public class PrintingEditionFiltration : BasePageSort
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public List<EditionType> Type { get; set; }
        public string NameAuthor { get; set; }
    }
}
