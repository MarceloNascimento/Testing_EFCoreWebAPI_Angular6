namespace Examples.Charge.Application.Messages.Response
{
    using Examples.Charge.Application.Common.Messages;
    using Examples.Charge.Application.Dtos;
    using System.Collections.Generic;
    public class PersonResponse : BaseResponse
    {
        public List<PersonDto> PersonObjects { get; set; }


    }
}
