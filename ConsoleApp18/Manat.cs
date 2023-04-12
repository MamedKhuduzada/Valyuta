
namespace ConsoleApp18
{
    internal class Manat
    {
        public double Valyuta { get; set; }
        public Manat(double valyuta)
        {
            Valyuta = valyuta;
        }

        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.Valyuta * 1.7);
        }
        public static implicit operator Manat(Euro euro)
        {
            return new Manat(euro.Valyuta * 2);
        }
    }
}
