using System;

namespace LivroDeRegistos_v1.gui
{
    public class Livro_L
    {

        public Livro_L(int numeroRegistro, string titulo, string cota, string estado)
        {
            NumeroRegistro = numeroRegistro;
            Titulo = titulo;
            Cota = cota;
            Estado = estado;
        }
        public int NumeroRegistro { get; set;}
        public string Titulo { get; set;}
        public string Cota { get; set;}
        public string Estado { get; set;}

    }
   
    public class Livro
    {
      
        public int NumeroRegistro { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Cota { get; set; }
        public string Aquisicao { get; set; }
        public string Editora { get; set; }
        public string NumeroVolume { get; set; }
        public string Observacoes { get; set; }
        public string Estado { get; set; }
    }
}