using Bibliotheque;
using Bibliotheque.Entity;

namespace BusinessLogicLayer.Commands
{
    public class PostulationCommand
    {
        private readonly Context context;
        
        public PostulationCommand(Context context)
        {
            this.context = context;
        }
        
        public int Ajouter(Postulation postulation)
        {
            context.Postulations.Add(postulation);
            return context.SaveChanges();
        }
    }
}