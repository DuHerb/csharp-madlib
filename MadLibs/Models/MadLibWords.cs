namespace MadLib.Models
{
    public class MadLibWords
    {
        private string _verb1;
        private string _noun1;
        private string _adj1;
        private string _verb2;
        private string _noun2;

        public string Verb1 { get => _verb1; set => _verb1 = value; }

        public string Noun1 { get => _noun1; set => _noun1 = value; }

        public string Adj1 { get => _adj1; set => _adj1 = value; }

        public string Verb2 { get => _verb2; set => _verb2 = value; }

        public string Noun2 { get => _noun2; set => _noun2 = value; }
    }
}
