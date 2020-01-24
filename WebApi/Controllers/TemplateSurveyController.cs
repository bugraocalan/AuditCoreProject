using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateSurveyController : ControllerBase
    {
        private ITemplateSurveyDetailService TemplateSurveyDetailService;
        public TemplateSurveyController(ITemplateSurveyDetailService templateSurveyDetailService)
        {
            TemplateSurveyDetailService = templateSurveyDetailService;
        }
        [HttpGet("GetTemplateSurveyDetailsbyMasterId/{id}")]
        public IActionResult GetList(int id)
        {

            var result = TemplateSurveyDetailService.GetListbyMasterId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}