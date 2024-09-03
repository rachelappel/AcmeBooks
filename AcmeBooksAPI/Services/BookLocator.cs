namespace AcmeBooksAPI.Services
{
    public class BookLocator
    { 
        public string LocateBook( string authorLastName, string genre)
        {
            char lastInitial = authorLastName.ToUpper()[0];
            string subsection;

            switch (lastInitial)
            {
                case >= 'A' and <= 'E':
                    subsection = "A-E";
                    break;
                case >= 'F' and <= 'J':
                    subsection = "F-J";
                    break;
                case >= 'K' and <= 'O':
                    subsection = "K-O";
                    break;
                case >= 'P' and <= 'T':
                    subsection = "P-T";
                    break;
                case >= 'U' and <= 'V':
                    subsection = "U-V";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(authorLastName), "Author's last name must start with a letter");
            }

            return genre + " " + subsection;
        }
    }
}