using System.Reflection.Metadata.Ecma335;

namespace FilmesApi.Data.Dtos
{
    public class CreateSessaoDto
    {
        public int FilmeId { get; set; }
        public int CinemaId { get; set; }
    }
}
