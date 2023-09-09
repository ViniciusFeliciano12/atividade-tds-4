using Aula04.RazorPages.Models;

namespace Aula04.RazorPages.Data {
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Events!.Any())
            {
                var events = new EventModel[] {
                    new EventModel{
                        Name ="Torneio de truco",
                        Description = "Campeonado acadêmico de CC da UTFPR",
                        Date = DateTime.Parse("2023-04-01")
                    },
                };
                context.AddRange(events);
            }

            if (!context.Alunos!.Any()){
                var alunos = new AlunoModel[]{
                    new AlunoModel{
                        NomeAluno ="Vinicius Feliciano",
                        Email = "viniciusfeliciano12345@hotmail.com",
                        DataInscricao = DateTime.Parse("2023-01-01")
                    }, 
                };
                context.AddRange(alunos);
            }

            if (!context.Cursos!.Any()){
                var curso = new CursoModel[]{
                    new CursoModel{
                        NomeCurso = "Técnologia em Desenvolvimento de Software",
                        Descricao = "Curso de técnologia em desenvolvimento de software",
                        DataInicio = DateTime.Parse("2023-06-01"),
                        DataTérmino = DateTime.Parse("2023-12-31")
                    }, 
                };
                context.AddRange(curso);
            }

            if (!context.Players!.Any())
            {
                var players = new PlayerModel[] {
                    new PlayerModel{
                        Name = "Pelé",
                        Age = 18
                    },
                };
                context.AddRange(players);
            }

            context.SaveChanges();
        }
    }
}