﻿using SPMedicalGroup_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroup_WebAPI.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidade> Listar();
        void Cadastrar(Especialidade novaEspecialidade);
    }
}
