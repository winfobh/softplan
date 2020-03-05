using Microsoft.AspNetCore.Mvc;

namespace softplan.Controllers
{
    [ApiController]
    [Route("taxajuros")]
    public class TaxaJuros
    {
        [HttpGet]
        public double GetRate()
        {
            double dec = 0.01;
            return dec;
        }
    }
}