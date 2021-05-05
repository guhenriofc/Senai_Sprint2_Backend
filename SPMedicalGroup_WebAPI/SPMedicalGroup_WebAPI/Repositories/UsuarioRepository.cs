using SPMedicalGroup_WebAPI.Context;
using SPMedicalGroup_WebAPI.Domains;
using SPMedicalGroup_WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroup_WebAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SPMedicalGroupContext ctx = new SPMedicalGroupContext();
        public void Cadastro(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string Email, string Senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == Email && u.Senha == Senha);
        }
    }
}
