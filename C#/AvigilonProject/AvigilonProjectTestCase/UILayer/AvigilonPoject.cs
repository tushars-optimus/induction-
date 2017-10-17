using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvigilonProject.ViewModel;
using Moq;

namespace AvigilonProjectTestCase.UILayer
{
    [TestClass]
    public class AvigilonPoject
    {
        [TestMethod]
        public void AvigilonProjectViewModel_VelocityReadOnly_10()
        {
            //Arrange
            var AvigilonProjectViewModel = new AvigilonProjectViewModel();

            //Act
            AvigilonProjectViewModel.VelocityReadOnly();

            //Assert
            Assert.AreEqual(AvigilonProjectViewModel.Velocitys.Count(), 10);
        }
        [TestMethod]
        public void UoW_InitialCondition_ExpectedResult()
        {
            //Arrange
            
            Mock<AvigilonProjectViewModel> myMock = new Mock<AvigilonProjectViewModel>();
            myMock.Expect(m => m.VelocityReadOnly()).Throws
            //Act


            //Assert

        }
    
    //    [TestMethod]
    //        public void AvigilonProjectViewModel_InitialCondition_4()
    //    {
    ////Arrange
    //var AvigilonProjectViewModel = new AvigilonProjectViewModel();

    ////Act
    //AvigilonProjectViewModel.AvigilonReadOnly();

    ////Assert
    //Assert.AreEqual(AvigilonProjectViewModel.Avigilons.Count(), 4);
    //    }
}
}
