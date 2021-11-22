

namespace Examples.Charge.Application.Dtos
{

    public class PersonPhoneDto
    {
        public int? Id { get; set; }
        public string PhoneNumber { get; set; }

        public int PhoneNumberTypeID { get; set; }
        public string PhoneNumberTypeName { get; set; }


        public int? PersonID { get; set; }
        public string PersonName { get; set; }
    }
}
