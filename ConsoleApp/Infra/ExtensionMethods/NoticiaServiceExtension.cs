using Data;

namespace ConsoleApp.Infra.ExtensionMethods
{
    public static class NoticiaServiceExtension
    {
        public static int TotalNoticias(this IList<Noticia> noticias)
        {
            return noticias.Count();
        }

        public static IList<Noticia> TituloComPrimeiraLetraMaiscula(this IList<Noticia> noticias)
        {
            foreach (var item in noticias)
            {
                item.Titulo = DeixarPrimeiraLetraMaiscula(item.Titulo);
            }

            return noticias;
        }

        private static string DeixarPrimeiraLetraMaiscula(string str)
        {
            if (str is null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}
