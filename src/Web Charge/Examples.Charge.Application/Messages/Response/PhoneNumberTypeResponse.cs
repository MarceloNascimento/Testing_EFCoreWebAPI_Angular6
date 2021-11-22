namespace Examples.Charge.Application.Messages.Response
{
    using Examples.Charge.Application.Common.Messages;
    using Examples.Charge.Application.Dtos;
    using System.Collections.Generic;
    public class PhoneNumberTypeResponse : BaseResponse
    {
        public List<PersonPhoneDto> PersonPhoneObjects { get; set; }

        public List<PhoneNumberTypeDto> PhoneNumberTypeObjects { get; set; }
        
    }
}
