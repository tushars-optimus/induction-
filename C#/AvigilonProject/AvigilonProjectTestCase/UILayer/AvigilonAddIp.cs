using AvigilonProject.BuisnessLayer.Model;
using AvigilonProject.BuisnessLayer.Service;
using AvigilonProject.UI.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using AvigilonProject.ViewModel;

namespace AvigilonProjectTestCase.UILayer
{
    [TestClass]
    public class AvigilonAddIp
    {
    AvigilonIpVewModels _repository;

    [TestInitialize]
    public void Setup()
    {
        var ips = new List<IpModelBl>()
            {
                new IpModelBl(){IP="1.2.41.1",Status="Ready",Version="1.23"},
                new IpModelBl(){IP="1.2.45.1",Status="Ready",Version="1.23"}
            };
        var avigilonAddnMock = new Mock<AvigilonIpVewModels>();
        avigilonAddnMock.Setup(r => r.ReadIp()).Returns(ips);
        _repository = avigilonAddnMock.Object;
    }

    [TestMethod]
   public void Ips_IpReadOnly_IsPopulated()
    {
        //Arrange
        var avigilonIpVewModel = new AvigilonIpVewModel();

        //Act
        avigilonIpVewModel.Read(_repository);

        //Assert
        Assert.IsNotNull(avigilonIpVewModel.IpModels);
        Assert.AreEqual(avigilonIpVewModel.IpModels.Count(), 2);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException), "Null value")]
    public void Ips_IpReadOnly_IsNull()
    {
        //Arrange
        var avigilonIpVewModel = new AvigilonIpVewModel();
        //Act
        avigilonIpVewModel.Read(null);
    }

    [TestMethod]
    public void Remove_RemoveCommand_IsPopulated()
    {
        //Arrange
        FakeAvigilonViewModel addIp = new FakeAvigilonViewModel();
        //Act
        addIp.RemoveIp("1.1.1.1");
        //Assert
        Assert.IsTrue(addIp.FLagIp);
        
    }

    [TestMethod]
    public void Remove_RemoveCommand_IsNull()
    {
        //Arrange
        FakeAvigilonViewModel addIp = new FakeAvigilonViewModel();
        //Act
        addIp.RemoveIp("null");
        //Assert
        Assert.IsFalse(addIp.FLagIp);

    }
    }
}
