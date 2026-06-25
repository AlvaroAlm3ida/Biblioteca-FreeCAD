namespace BibliotecaFreeCAD.Models
{
    public class Peca
    {
        int Id { get; set; }
        int Nome { get; set; }
        string Descricao { get; set; } = string.Empty;
        string Categoria { get; set; } = string.Empty;  // Ex: "Mecânica", "Decorativa", "Estrutural" 
        string Material { get; set; } = string.Empty; // Ex: "PLA", "Aço", "Madeira"
        double LarguraMm { get; set; } //Dimensão em milímetros
        double AlturaMm { get; set; } //Dimensão em milímetros
        double Profundidade { get; set; }
        double PesoEstimadoG { get; set; } //Peso em gramas (estimado)
        DateTime DataCadastro { get; set; } = DateTime.UtcNow;
    }
}

/*
 Detalhes da documentação:

= string.Empty evita warnings do compilador e garante que o campo sempre comece como texto vazio, não nulo.

DateTime.UtcNow = toda peça já nasce com a data de criação preenchida automaticamente, sem você precisar informar manualmente.
 
 
 */