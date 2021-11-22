

namespace Examples.Charge.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;
    using Examples.Charge.Application.Interfaces;
    using Examples.Charge.Application.Messages.Request;
    using Examples.Charge.Application.Messages.Response;
    using System.Threading.Tasks;
    using System;
    using Microsoft.AspNetCore.Cors;

    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<PersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpGet("{personId}/{phoneNumber}")]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<PersonPhoneResponse>> Get(int personId, string phoneNumber)
        {
            try
            {
                var response = await _facade.FindEntityAsync(personId, phoneNumber);
                return Response(response);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<PersonPhoneResponse>> Put([FromBody] PersonPhoneRequest request)
        {
            try
            {
                PersonPhoneResponse response = null;
                if (request.PersonPhoneObjects != null)
                    response = await _facade.UpdateAsync(request.PersonPhoneObjects);

                return Response(response);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
