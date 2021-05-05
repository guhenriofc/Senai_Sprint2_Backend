using SPMedicalGroup_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroup_WebAPI.Interfaces
{
    interface ITiposUsuarioRepository
    {
        List<TiposUsuario> Listar();
        void Cadastrar(TiposUsuario novoTipoUsuario);
        void Deletar(int id);
    }
}
