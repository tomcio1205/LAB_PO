namespace WebApplication3.Services.LAB4
{
    public class Polish : Langugage, ILanguage
    {
        public Polish(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string getLang()
        {
            return "pl";
        }

        public string GetLanguageName()
        {
            return Name;
        }
    }
}
