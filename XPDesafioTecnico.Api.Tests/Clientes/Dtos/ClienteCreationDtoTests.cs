using System.ComponentModel.DataAnnotations;
using XPDesafioTecnico.DTOs;
using Xunit;

namespace XPDesafioTecnico.Api.Tests.Clientes.Dtos
{
    public class ClienteCreationDtoTests
    {
        [Fact]
        public void ValidModel_ShouldNotHaveValidationErrors()
        {
            // Arrange
            var dto = new ClienteCreationDto
            {
                NomeCompleto = "John Doe",
                Telefone = "123-456-7890",
                Email = "john@example.com",
                Rua = "123 Main St",
                Cidade = "City",
                Estado = "State",
                CEP = "12345"
            };

            // Act
            var context = new ValidationContext(dto, null, null);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(dto, context, results, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(results);
        }

        [Fact]
        public void InvalidModel_ShouldHaveValidationErrors_When_EmailIsInvalid()
        {
            // Arrange
            var dto = new ClienteCreationDto
            {
                NomeCompleto = "John Doe",
                Telefone = "1999738883",
                Email = "johnexample.com",
                Rua = "123 Main St",
                Cidade = "City",
                Estado = "State",
                CEP = "12345"
            };

            // Act
            var context = new ValidationContext(dto, null, null);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(dto, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.NotEmpty(results);
        }

        [Fact]
        public void InvalidModel_ShouldHaveValidationErrors_When_TelephoneIsInvalid()
        {
            // Arrange
            var dto = new ClienteCreationDto
            {
                NomeCompleto = "John Doe",
                Telefone = "123-45",
                Email = "johne@xample.com",
                Rua = "123 Main St",
                Cidade = "City",
                Estado = "State",
                CEP = "12345"
            };

            // Act
            var context = new ValidationContext(dto, null, null);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(dto, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.NotEmpty(results);
        }

        [Fact]
        public void InvalidModel_ShouldHaveValidationErrors()
        {
            // Arrange
            var dto = new ClienteCreationDto(); // Dto sem dados

            // Act
            var context = new ValidationContext(dto, null, null);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(dto, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.NotEmpty(results);
        }
    }
}
