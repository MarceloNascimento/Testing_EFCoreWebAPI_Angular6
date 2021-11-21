

namespace Examples.Charge.API.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;
    using Examples.Charge.Application.Interfaces;
    using Examples.Charge.Application.Messages.Request;
    using Examples.Charge.Application.Messages.Response;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : BaseController
    {
        private IPersonFacade _facade;


        //IPersonPhone
        public PersonController(IPersonFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonResponse>> Get() => Response(await _facade.FindAllAsync());



        [HttpGet("{id}")]
        public async Task<ActionResult<PersonResponse>> GetAsync(int id)
        {
            var response = await _facade.FindByIdAsync(id);
            return Response(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ExampleRequest request)
        {
            return Response(0, null);
        }
    }
}
