
namespace AvigilonProject.BuisnessLayer.Model
{
    public class AlarmSite
    {
        #region Private variables
        private string _alarm;
        private string _site;
        #endregion

        #region Public variables
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
