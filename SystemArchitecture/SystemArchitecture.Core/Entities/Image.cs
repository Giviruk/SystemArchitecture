using Force.Ddd;

namespace SystemArchitecture.Core.Entities
{
    public class Image : HasIdBase<int>
    {
        public string Title { get; protected set; }
        
        public string Url { get; protected set; }

        protected Image()
        {
            
        }

        public Image(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}