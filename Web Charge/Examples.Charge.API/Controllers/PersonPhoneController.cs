

namespace Examples.Charge.API.Controllers
{  
    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;   
    using Examples.Charge.Application.Interfaces;
    using Examples.Charge.Application.Messages.Request;
    using Examples.Charge.Application.Messages.Response;
    using System.Threading.Tasks;
    using System;

    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneFacade _facade;

        //IPersonPhone
        public PersonPhoneController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpGet("{personId}/{phoneNumber}")]
        public async Task<ActionResult<PersonPhoneResponse>> Get(int personId, string phoneNumber)
        {
            try
            {
                var response = await _facade.FindEntityAsync(personId, phoneNumber);
                return Response(response);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            

            //return Response(null);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ExampleRequest request)
        {
            return Response(0, null);
        }
    }
}
