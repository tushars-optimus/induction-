using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.BuisnessLayer.Model
{
    public class AlarmMappingBl
    {
        private string _alarm;

        public string AlarmBl
        {
            get { return _alarm; }
            set { _alarm = value; }
        }

        private string _site;

        public string SiteBl
        {
            get { return _site; }
            set { _site = value; }
        }
        private string _description;

        public string DescriptionBl
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
