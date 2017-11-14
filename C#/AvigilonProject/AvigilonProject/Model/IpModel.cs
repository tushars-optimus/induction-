﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.UI.Model
{
    public class IpModel
    {
        #region Private variables
        private string _ip;
        private string _version;
        private string _status;
        #endregion

        #region Public variables
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }
               

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion


    }
}
