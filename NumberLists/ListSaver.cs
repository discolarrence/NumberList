using CodeLouisvilleLibrary.Serialization;
using CodeLouisvilleLibrary;

namespace NumberLists
{
    public class ListSaver : EntitySerializationService<NumberList>
    {
        public ListSaver() : base("UserLists.json")
        {

        }

    }
}
