using System;
public class carro
{
        public string cor { get; set; }

        public string modelo { get; set; }
        public int ano { get; set; }
        public string marca { get; set; }

        public void MostrarDados (string modelo_, string cor_, int ano_ )
        {
            Console.WriteLine(modelo_+ " - " + cor_ + " - " + ano_);
        }

        public void LigarCarro()
        {
            Console.WriteLine("Ligando carro!");
        }

}