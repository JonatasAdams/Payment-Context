using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
          var subscription = new Subscription(null);
          var student = new Student("Jonatas", "Adams", "12345678912", "teste.2020@gmail.com");
          student.AddSubscription(subscription);
        }
    }
}