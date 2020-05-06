using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests
{
  [TestClass]
  public class CreateBoletoSubscriptionTests
  {
    [TestMethod]
    public void Should_Return_Error_When_Name_Is_Invalid()
    {
      var command = new CreateBoletoSubscriptionCommand();
      command.FirstName = "";

      command.Validate();
      Assert.AreEqual(false, command.Valid);
    }
  }
}