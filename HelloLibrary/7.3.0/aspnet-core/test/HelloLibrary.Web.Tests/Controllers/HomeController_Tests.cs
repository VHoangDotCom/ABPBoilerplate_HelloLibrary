using System.Threading.Tasks;
using HelloLibrary.Models.TokenAuth;
using HelloLibrary.Web.Controllers;
using Shouldly;
using Xunit;

namespace HelloLibrary.Web.Tests.Controllers
{
    public class HomeController_Tests: HelloLibraryWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}