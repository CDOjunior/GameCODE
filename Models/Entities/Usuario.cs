namespace GameCODE.Models.Entities
{
    public class Usuario
    {
        public Usuario(string nome, string email, string senha, string tipo, string atuacao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Tipo = tipo;
            Atuacao = atuacao;
            Insignias = new List<Insignia>(); // ter a possibilidade de ter insignias
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public string Atuacao { get; set; }
        public List<Insignia> Insignias { get; set; }

    }
}
