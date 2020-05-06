using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void Should_Return_Error_When_CNPJ_Is_Invalid()
        {
          var doc = new Document("123", EDocumentType.CNPJ);
          Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void Should_Return_Success_When_CNPJ_Is_Valid()
        {
          var doc = new Document("15909501000162", EDocumentType.CNPJ);
          Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void Should_Return_Error_When_CPF_Is_Invalid()
        {
          var doc = new Document("123", EDocumentType.CPF);
          Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void Should_Return_Success_When_CPF_Is_Valid()
        {
          var doc = new Document("46876161005", EDocumentType.CPF);
          Assert.IsTrue(doc.Valid);
        }
    }
}
