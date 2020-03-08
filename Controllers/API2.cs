using Microsoft.AspNetCore.Mvc;
using System.Net;
using softplan.Controllers;
using System;

namespace softplan.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class CalculaJuros
    {
        [HttpGet]
        public string GetCalcRate([FromQuery] double valorInicial, [FromQuery] int meses)
        {
            var taxaJuros = new TaxaJuros().GetRate();
            var math = Math.Pow((1 + taxaJuros),meses);

            var res = valorInicial * math;
            
            return res.ToString("00.00");
        }       
    }


    [ApiController]
    [Route("showmethecode")]
    public class MostreMeOCodigo
    {

        [HttpGet]
        public ContentResult ShowMeTheCode()
        {
            return new ContentResult {
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK,
                Content = "<html><body><a href='https://github.com/winfobh/softplan'>https://github.com/winfobh/softplan</a></html>"};
        }        
    }
}