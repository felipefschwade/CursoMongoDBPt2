using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetoBlog.Models
{
    public class AcessoMongoDB
    {

        const string BANCO_DE_DADOS = "Blog";
        const string USUARIOS = "Usuarios";
        const string PUBLICACOES = "Publicacaoes";
        public const string ConnectionString = "mongodb://localhost:27017";

        public static IMongoCollection<Usuario> UsuariosCollection { get { return BancoDeDados.GetCollection<Usuario>(USUARIOS); } }

        public static IMongoCollection<Publicacao> PublicacoesCollection { get { return BancoDeDados.GetCollection<Publicacao>(PUBLICACOES); } }

        public static IMongoClient Client = new MongoClient(ConnectionString);

        public static IMongoDatabase BancoDeDados = Client.GetDatabase(BANCO_DE_DADOS);

    }
}
