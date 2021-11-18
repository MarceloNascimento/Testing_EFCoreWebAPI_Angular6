namespace Examples.Charge.Application.Messages.Response
{
    using Examples.Charge.Application.Common.Messages;
    using Examples.Charge.Application.Dtos;  
    using System.Collections.Generic;
   
    public class ExampleListResponse: BaseResponse
    {
        public List<ExampleDto> ExampleObjects { get; set; }
    }
}
