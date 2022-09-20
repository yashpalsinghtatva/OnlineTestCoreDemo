using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using OnlineTestWebApi.DTO;
using OnlineTestWebApi.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineTestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CandidateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //GET: api/<CandidateController>
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var allLanguages = _unitOfWork.Languages.GetAll();
        //    var allCandidates = _unitOfWork.Candidates.GetAll();
        //    _unitOfWork.Candidates.Add(new Candidate()
        //    {
        //        candidateGender = 'M',
        //        candidateEmail = "yashpal@gmail.gcom",
        //        candidateName = "yash",
        //        candidiatePhoneNo = "9657657545",
        //        candidatePreferedLanguageId = _unitOfWork.Languages.GetById(1)
        //    });
        //    _unitOfWork.Complete();
        //    return Ok(allCandidates);

        //    return new string[] { "value1", "value2" };
        //}

        [Route("")]
        [HttpPost]
        public IActionResult AddCandidate(CandidateDTO candidate)
        {
            try
            {
                Candidate candidateEntity = candidate.ConvertToCandidate();
                _unitOfWork.Candidates.Add(candidateEntity);
                _unitOfWork.Complete();
                return Ok(candidateEntity.ConvertToCandidateDTO());
            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = "Error Occurred"
                };
                return NotFound(resp);
            }

        }

    }
}
