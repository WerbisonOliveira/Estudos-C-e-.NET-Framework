using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Text;

namespace web_api.Repositories
{
    public class Usuario
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public Usuario(string ConnectionString) 
        {
            conn = new SqlConnection(ConnectionString);

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public async Task<Boolean> RegisterAsync(Models.Usuario usuario)
        {
            int line = 0;

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "insert into usuarios (nome, email, senha) values (@nome, @email, @senha)";

                    cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)).Value = usuario.Nome;

                    cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar)).Value = usuario.Email;

                    cmd.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)).Value = Convert.ToBase64String(Encoding.UTF8.GetBytes(usuario.Senha));

                    line = await cmd.ExecuteNonQueryAsync();

                    return line > 0;
                }
            }
        }

        public async Task<Models.Login> FindUserAsync(string email, string senha)
        {
            Models.Login auth = null;

            using (conn)
            {
                await conn.OpenAsync();

                using (cmd)
                {
                    cmd.CommandText = "select nome, senha from usuarios where email = @email";

                    cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar)).Value = email;

                    SqlDataReader user = await cmd.ExecuteReaderAsync();

                    using (user)
                    {
                        if (await user.ReadAsync())
                        {
                            string Senha = user["senha"].ToString();

                            if (Senha == Convert.ToBase64String(Encoding.UTF8.GetBytes(senha)))
                            {
                                auth = new Models.Login();
                                auth.Nome = user["nome"].ToString();
                                auth.Auth = true;
                            }

                        }
                    }

                }
            }

            return auth;
        }

    }
}