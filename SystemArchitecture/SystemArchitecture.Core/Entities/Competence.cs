using Force.Ddd;

namespace SystemArchitecture.Core.Entities
{
    public class Competence : HasIdBase<int>
    {
        
        public string Title { get; protected set; }

        protected Competence()
        {
            
        }

        public Competence(string title)
        {
            Title = title;
        }
    }
}