namespace GameCODE.Models.Entities
{
    public class Insignia
    {
        public Insignia(string nome, string descricao, string imagem)
        {
            Nome = nome;
            Descricao = descricao;
            Imagem = imagem;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public Usuario Usuario { get; set; } // propriedade para conseguir acessar o usuário através de uma insignia
        public int UsuarioId { get; set; } // propriedade para mapear quem tem uma determinada insignia
    }
}
