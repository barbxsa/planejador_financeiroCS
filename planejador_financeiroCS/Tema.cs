using System.Drawing;
using System.Globalization;

namespace planejador_financeiroCS
{
    // Paleta e formatação usadas pelas telas
    internal static class Tema
    {
        public static readonly Color Fundo = Color.FromArgb(243, 244, 246);
        public static readonly Color Superficie = Color.White;
        public static readonly Color Borda = Color.FromArgb(229, 231, 235);
        public static readonly Color Texto = Color.FromArgb(31, 41, 55);
        public static readonly Color TextoSecundario = Color.FromArgb(107, 114, 128);
        public static readonly Color Destaque = Color.FromArgb(37, 99, 235);
        public static readonly Color DestaqueClaro = Color.FromArgb(239, 246, 255);
        public static readonly Color Receita = Color.FromArgb(22, 163, 74);
        public static readonly Color Despesa = Color.FromArgb(220, 38, 38);
        public static readonly Color Domingo = Color.FromArgb(239, 68, 68);

        public static readonly CultureInfo Cultura = CultureInfo.GetCultureInfo("pt-BR");

        public static string Moeda(decimal valor) => valor.ToString("C", Cultura);

        // "+R$ 10,00" / "-R$ 10,00"
        public static string MoedaComSinal(decimal valor) => (valor >= 0 ? "+" : "-") + Moeda(Math.Abs(valor));

        public static Color CorDoValor(decimal valor) => valor >= 0 ? Receita : Despesa;
    }
}
