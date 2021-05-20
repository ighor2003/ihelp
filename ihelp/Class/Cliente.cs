using ihelp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihelp.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        
        public Cliente() { }

        public Cliente(int id, string nome, string senha, string email)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Email = email;
        }
        public Cliente(string nome, string senha, string email)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
        }
       

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            // recheio...
            var cmd = Banco.Abrir();

            //Buscar registros na Tabela ->
            cmd.CommandText = "select * from cliente";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3)
                ));
            }
            return lista;
        }
        public void BuscarPorId(int id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = $"select * from cliente where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Senha = dr.GetString(2);
                Email = dr.GetString(3);
            }

        }


        public bool Alterar(int id)
        {
            bool alterado = false;

            var cmd = Banco.Abrir();

            cmd.CommandText = $"update cliente set " +
                $"nome = '{Nome}', " +
                $"email = '{Email}', " +
                $"senha = md5('{Senha}') " +
                $"where id = {id}";
            try
            {
                cmd.ExecuteNonQuery();
                alterado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return alterado;
        }
    }
}