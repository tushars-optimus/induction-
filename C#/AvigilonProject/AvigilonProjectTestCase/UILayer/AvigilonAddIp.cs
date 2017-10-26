using AvigilonProject.BuisnessLayer.Model;
using AvigilonProject.BuisnessLayer.Service;
using AvigilonProject.UI.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvigilonProjectTestCase.UILayer
{
    [TestClass]
    public class AvigilonAddIp
    {
    AvigilonIpVewModels _repository;
    [TestInitialize]
    public void Setup()
    {
        var Ips = new List<IpModelBl>()
            {
                new IpModelBl(){IP="1.2.41.1",Status="Ready",Version="1.23"},
                new IpModelBl(){IP="1.2.45.1",Status="Ready",Version="1.23"}
            };
        var AvigiloAddnMock = new Mock<AvigilonIpVewModels>();
        AvigiloAddnMock.Setup(r => r.ReadIp()).Returns(Ips);
        _repository = AvigiloAddnMock.Object;
    }
    [TestMethod]
   public void Ips_IpReadOnly_IsPopulated()
    {
        //Arrange
        var AvigilonIpVewModel = new AvigilonIpVewModel();

        //Act
        AvigilonIpVewModel.Read(_repository);

        //Assert
        Assert.IsNotNull(AvigilonIpVewModel.IpModels);
        Assert.AreEqual(AvigilonIpVewModel.IpModels.Count(), 2);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException), "Null value")]
    public void Velocitys_IpReadOnly_IsNull()
    {
        //Arrange
        var AvigilonIpVewModel = new AvigilonIpVewModel();
        //Act
        AvigilonIpVewModel.Read(null);
    }

  
    }
}
