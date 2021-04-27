using Hroads_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads_WebAPI.Interfaces
{
    interface IUsuarioRepository
    {
        //CRUD

        /// <summary>
        /// Lista os usuarios
        /// </summary>
        /// <returns></returns>
        List<Usuario> Listar();
        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="NovoUsuario"></param>
        void Cadastro(Usuario NovoUsuario);
        /// <summary>
        /// Deleta um usuario pelo id
        /// </summary>
        /// <param name="id"></param>
        void Deletar(int id);
        /// <summary>
        /// Faz uma alteração no usuario buscado pelo id
        /// </summary>
        /// <param name="UsuarioAtualizado"></param>
        /// <param name="id"></param>
        void Atualizar(Usuario UsuarioAtualizado, int id);
        /// <summary>
        /// Busca um usuario pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Usuario BuscarPorId(int id);

    }
}
