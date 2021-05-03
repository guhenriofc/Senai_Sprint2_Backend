﻿using Projeto_InLock_WebAPI.Domains;
using Projeto_InLock_WebAPI.Interfaces;
using System;
using System.Data.SqlClient;

namespace Projeto_InLock_WebAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source = DESKTOP-SL5KKOH; initial catalog = InlockGames; integrated security = true";

        public UsuarioDomain BuscarPorEmail(string Email, string Senha)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                string QueryBuscarEmail = ("SELECT IdUsuario, Email, Senha, IdTipoUsuario FROM Usuarios WHERE Email = @email AND Senha = @senha");

                SqlDataReader rdr;

                using (SqlCommand comando = new SqlCommand(QueryBuscarEmail, conexao))
                {
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", Senha);

                    conexao.Open();

                    rdr = comando.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuarioBuscado = new UsuarioDomain
                        {
                            IdUsuario    = Convert.ToInt32(rdr[0]),
                            Email        = rdr[1].ToString(),
                            Senha        = rdr[2].ToString(),
                            IdTpoUsuario = Convert.ToInt32(rdr[3])

                 
                        };

                        return usuarioBuscado;
                    }


                    return null;
                } 

            }

        }

        public void CadastrarUsuario(UsuarioDomain NovoUsuario)
        {
            using (SqlConnection conexao = new SqlConnection (stringConexao))
            {
                string QueryCadastrar = ("INSERT INTO Usuarios (Email, Senha, IdTipoUsuario) VALUES ('@email', '@senha', @id)");

                using (SqlCommand comando = new SqlCommand (QueryCadastrar, conexao))
                {
                    comando.Parameters.AddWithValue("@email", NovoUsuario.Email);
                    comando.Parameters.AddWithValue("@senha", NovoUsuario.Senha);
                    comando.Parameters.AddWithValue("@id", NovoUsuario.IdTpoUsuario);

                    conexao.Open();

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
