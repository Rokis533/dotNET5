using EntityFrameworkProject.Repositories;

namespace EntityFrameworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new EventsContext();
            var eventRepo = new EventRepository(dbContext);

            var program = new EventProgram(eventRepo);

            program.Run();



        }
    }
}
