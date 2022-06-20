using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Threading.Tasks;
using System.Net;
using FluentAssertions;
using Moq;
using Newtonsoft.Json;
using Xunit;
using Capstone.WebApi.Services;
using Capstone.WebApi.Models;
using Capstone.WebApi.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.WebApi.Tests
{
    public class SampleControllerTests
    {
        /*
         * 
         *  Unit test we shall apply AAA patten, which is Arrange, Act and Assert
         * 
         *  Unit test naming conventions: https://dzone.com/articles/7-popular-unit-test-naming
         *  Should_ExpectedBehavior_When_StateUnderTest is more preferred way
         *  
         *  further reading: 
         *  https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
         *  https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
         */


        [Fact]
        public async Task InputNullData_AssertResponse() 
        {
            //arrange

            //we are trying to test the controller - controller method. 
            // arragne - test data ( DTO order) , instance of the controller 
            var mockedService = new Mock<IOrderSubstitutionService>();  // specficnig pre-defined behaviours, 
            var mockedLogger = new Mock<ILogger<OrderSubstitutionController>>();

            var returedData = new SmartSubsReturn[]
            {
                new SmartSubsReturn()
                {
                    productRecommendations = null
                },

                new SmartSubsReturn()
                {
                    productRecommendations = null
                }
            };
            mockedService.Setup(service => service.GetSubstitutionOfOrder(It.IsAny<DTOOrder[]>()))
                            .Returns((Task.FromResult(returedData)));


            //mockedLogger.Setup(Logger => Logger.Log(LogLevel.Information, new EventId(), null, string.Empty, null));
            var Logger = new NullLogger<OrderSubstitutionController>();
            
            OrderSubstitutionController TestController = new OrderSubstitutionController(mockedService.Object, Logger); //mockthose dependices

            //act
            var result = await TestController.Post(null);

            //assert 
            Assert.NotNull(result);
            Assert.IsType<ActionResult<SmartSubsReturn[]>>(result);
            //Assert.True(result.Length > 0);

        }
    }
}