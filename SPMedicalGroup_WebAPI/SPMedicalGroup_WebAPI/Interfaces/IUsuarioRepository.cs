using SPMedicalGroup_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroup_WebAPI.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string Email, string Senha);
        List<Usuario> Listar();
        void Cadastro(Usuario novoUsuario);
    }
}
