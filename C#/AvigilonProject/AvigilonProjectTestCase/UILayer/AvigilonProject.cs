using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using AvigilonProject.BuisnessLayer;
using AvigilonProject.BuisnessLayer.Model;
using AvigilonProject.UI.ViewModel;

namespace AvigilonProjectTestCase.UILayer
{
    [TestClass]
    public class AvigilonProject
    {
        AvigilonProjecyBl _repository;
        [TestInitialize]
        public void Setup()
        {
            var Velocitys = new List<Velocity>()
            {
                new Velocity() {Description="Netwoking mode"},
                new Velocity() {Description="Contoller mode"}
            };

            var Alarms = new List<AlarmSite>()
            {
                new AlarmSite(){Alarm="Gallagar",Site="Acc 1.3"},
                new AlarmSite(){Alarm="Gallagar2",Site="Acc 1.241"}
            };
            var Mappings = new List<AvigilonMapping>()
            {
                new AvigilonMapping(){Alarm="Gallagar", Site="Acc 1.3",Description="Network mode"},
                new AvigilonMapping(){Alarm="Gallagar2", Site="Acc 1.7",Description="Controller mode"}
            };
            var AvigilonMock = new Mock<AvigilonProjecyBl>();
            AvigilonMock.Setup(r => r.ReadVelocity()).Returns(Velocitys);
            AvigilonMock.Setup(a => a.ReadAvigilons()).Returns(Alarms);
            AvigilonMock.Setup(m => m.ReadAlarmMapping()).Returns(Mappings);
            
            _repository = AvigilonMock.Object;

            
        }

        [TestMethod]
        public void Velocitys_ReadVelovity_IsPopulated()
        {
            //Arrange
            
            var AvigilonProjectViewModel = new AvigilonProjectViewModel();

            //Act
            AvigilonProjectViewModel.VelocityReadOnly(_repository);

            //Assert
            Assert.IsNotNull(AvigilonProjectViewModel.Velocitys);
            Assert.AreEqual(AvigilonProjectViewModel.Velocitys.Count(), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),"Null value")]
        public void Velocitys_ReadVelovity_IsNull()
        {
            //Arrange
            var AvigilonProjectViewModel = new AvigilonProjectViewModel();
            AvigilonProjectViewModel.VelocityReadOnly(null);
        }
       
        [TestMethod]
        public void Alarms_ReadAlarms_IsPopulated()
        {
            //Arrange
            
            var AvigilonProjectViewModel = new AvigilonProjectViewModel();

            //Act
            AvigilonProjectViewModel.AlarmReadOnly(_repository);

            //Assert
            Assert.IsNotNull(AvigilonProjectViewModel.Avigilons);
            Assert.AreEqual(AvigilonProjectViewModel.Avigilons.Count(), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Null value")]
        public void Alarms_ReadAlarms_IsNull()
        {
            //Arrange
            var AvigilonProjectViewModel = new AvigilonProjectViewModel();
            AvigilonProjectViewModel.AlarmReadOnly(null);
        }

        [TestMethod]
        public void AlarmMapping_ReadOnly_IsPopulated()
        {
            //Arrange
            var AvigilonProjectViewModel = new AvigilonProjectViewModel();

            //Act
            AvigilonProjectViewModel.AlarmMappingVm(_repository);

            //Assert
            Assert.IsNotNull(AvigilonProjectViewModel.AlarmMappingModel);
            Assert.AreEqual(AvigilonProjectViewModel.AlarmMappingModel.Count(), 2);

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Null value")]
        public void AlarmMapping_ReadOnly_IsNull()
        {
            //Arrange
            var AvigilonProjectViewModel = new AvigilonProjectViewModel();
            AvigilonProjectViewModel.AlarmMappingVm(null);
        }
        }
}
