namespace Pronostico.API.Outils
{
    public class MetierException : Exception
    {
        public string Code { get; set; }

        public MetierException() : base()
        {
        }

        public MetierException(string message)
            : base(message)
        {
            
        }

        public MetierException(string message, string code)
            : base(message)
        {
            Code = code;
        }
    }
}
