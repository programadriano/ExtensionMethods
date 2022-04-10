namespace Data
{
    public interface INoticiaService
    {
        IList<Noticia> Noticias();
    }
    public class NoticiaService : INoticiaService
    {
        public IList<Noticia> Noticias()
        {
            return new List<Noticia>
            {
                new Noticia
                {
                    Titulo = "Noticia 1",
                    Descricao = "Descricao 1"
                },
                new Noticia
                {
                    Titulo = "noticia 2",
                    Descricao = "descricao 2"
                },
                new Noticia
                {
                    Titulo = "noticia 3",
                    Descricao = "descricao 3"
                }
            };
        }
    }
}