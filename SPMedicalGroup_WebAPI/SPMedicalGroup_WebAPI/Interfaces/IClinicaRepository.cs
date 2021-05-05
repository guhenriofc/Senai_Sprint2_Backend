using SPMedicalGroup_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroup_WebAPI.Interfaces
{
    interface IClinicaRepository
    {
        List<Clinica> Listar();
        void Cadastrar(Clinica novaClinica);
    }
}
