﻿using SPMedicalGroup_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroup_WebAPI.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> Listar();
        void Cadastro(Medico novoMedico);
    }
}
