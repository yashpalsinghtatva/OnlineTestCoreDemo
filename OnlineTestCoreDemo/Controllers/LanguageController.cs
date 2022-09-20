using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineTestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LanguageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetAllLanguages()
        {
            try
            {
                var allLanguages = _unitOfWork.Languages.GetAll();
                return Ok(allLanguages);
            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = "Error Occurred"
                };
                return NotFound(resp) ;
            }
        }
    }
}
