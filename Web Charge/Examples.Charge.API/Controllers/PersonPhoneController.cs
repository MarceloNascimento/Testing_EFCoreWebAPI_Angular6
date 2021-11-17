

namespace Examples.Charge.API.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Examples.Charge.Application.Interfaces;
    using Examples.Charge.Application.Messages.Request;
    using Examples.Charge.Application.Messages.Response;
    using System.Threading.Tasks;

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
        public async Task<ActionResult<ExampleListResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Response(null);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ExampleRequest request)
        {
            return Response(0, null);
        }
    }
}
