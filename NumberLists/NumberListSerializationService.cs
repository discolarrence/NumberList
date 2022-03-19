using CodeLouisvilleLibrary.Serialization;

namespace NumberLists
{
    class NumberListSerializationService : EntitySerializationService<NumberListContainer>
    {
        public NumberListSerializationService() : base("UserLists.json")
        {

        }

    }
}
