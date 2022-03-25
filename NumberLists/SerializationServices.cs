using CodeLouisvilleLibrary.Serialization;

namespace NumberLists
{
    class NumberListSerializationService : EntitySerializationService<SaverContainer>
    {
        public NumberListSerializationService() : base("UserLists.json")
        {

        }

    }

    class NumberFactSerializationService : EntitySerializationService<SaverContainer>
    {
        public NumberFactSerializationService() : base("UserFacts.json")
        {

        }

    }
}
