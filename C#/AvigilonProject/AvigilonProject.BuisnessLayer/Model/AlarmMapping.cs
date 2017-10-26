
namespace AvigilonProject.BuisnessLayer.Model
{
    public class AvigilonMapping
    {
        #region Private Variables
        private string _alarm;
        private string _site;
        private string _description;
        #endregion

        #region Public Variables
        
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


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion

    }
}
