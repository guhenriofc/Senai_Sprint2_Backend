﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Hroads_WebAPI.Domains
{
    public partial class ClassesHabilidade
    {
        public int? IdClasse { get; set; }
        public int? IdHabilidade { get; set; }

        public virtual Class IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
