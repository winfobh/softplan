using Xunit;
using softplan.Controllers;

namespace softplan
{
  public class TestAPI2
  {
    [Theory]
    [InlineData(100,5,"105,10")]
    public void ReturnCalculeTaxas(int x, int y, string resultado)
    {
      var result = new CalculaJuros();
      Assert.Equal(resultado, result.GetCalcRate(x,y));
    }

  }
}