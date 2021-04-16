using AuthService.Controllers;
using AuthService.Models;
using AuthService.Provider;
using AuthService.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace AuthServiceTest
{
    public class Tests
    {
        private Mock<IConfiguration> _config;
        private Mock<IUserRepository> _mockRepository;
        private Mock<IUserProvider> _mockProvider;
        private UserController _controller;
        private IUserProvider _provider;
        private string _token1;
        private string _token2;
        private Mock<UserDto> _user;
        private UserDto _nullUser;
        User user1;
        User user2;
        [SetUp]
        public void Setup()
        {
            _config = new Mock<IConfiguration>();
            _config.Setup(c => c["Jwt:Key"]).Returns("SecretKeyForMedicineSupply");
            _mockRepository = new Mock<IUserRepository>();
            _mockProvider = new Mock<IUserProvider>();
            _controller = new UserController(_mockProvider.Object);
            _token1 = "safagafszfsj3r3458gfh67gfbyjsdfbjsbdsdbvysuger";
            _token2 = null;
            _nullUser = null;
            _user = new Mock<UserDto>();
            _provider = new UserProvider(_mockRepository.Object, _config.Object);
            user1 = new User()
            {
                UserID = 1,
                UserName = "Ram",
                Password = "ram@123"
            };
            user2 = new User()
            {
                UserID = 2,
                UserName = "Ram",
                Password = "bucky@123"
            };
        }

        [Test]
        public void UserControllerPositiveTest()
        {
            _mockProvider.Setup(s => s.Login(It.IsAny<User>())).Returns(_token1);
            var response = _controller.Login(user1) as OkObjectResult;
            Assert.AreEqual(200, response.StatusCode);
        }

        [Test]
        public void UserControllerNegativeTest()
        {
            _mockProvider.Setup(s => s.Login(It.IsAny<User>())).Returns(_token2);
            try
            {
                var response = _controller.Login(user2) as NotFoundObjectResult;
                Assert.AreEqual(404, response.StatusCode);
            }
            catch
            {
                var response = _controller.Login(user1) as StatusCodeResult;
                Assert.AreEqual(500, response.StatusCode);
            }
        }

        [Test]
        public void UserProviderPositiveTest()
        {
            _mockRepository.Setup(s => s.GetUser(It.IsAny<User>())).Returns(_user.Object);
            var result = _provider.Login(user1);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UserProviderNegativeTest()
        {
            _mockRepository.Setup(s => s.GetUser(It.IsAny<User>())).Returns(_nullUser);
            var result = _provider.Login(user2);
            Assert.IsNull(result);
        }

        [Test]
        public void GenerateTokenPositiveTest()
        {
            _mockRepository.Setup(s => s.GetUser(It.IsAny<User>())).Returns(_user.Object);
            var result = _provider.GenerateJWT(user1);
            Assert.IsNotNull(result);
        }

        [Test]
        public void GenerateTokenNegativeTest()
        {
            _mockRepository.Setup(s => s.GetUser(It.IsAny<User>())).Returns(_nullUser);
            var result = _provider.GenerateJWT(user2);
            Assert.IsNull(result);
        }
    }
}