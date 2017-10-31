using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.UI.Model
{
    public class AvigilonModel
    {
        #region Private variables
        private string _alarm;
        private string _site;
        #endregion

        #region Public variable
        public string Alarm
        {
            get { return _alarm; }
            set { _alarm = value; }
        }

        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }
        #endregion


    }
  
}
