using TCC.Enums;

namespace TCC.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string NomeUsuario { get; set; }

        public string Email { get; set; }

        public PerfilEnum Perfil { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualaizacao { get; set; }
    }
}
