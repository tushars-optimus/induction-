
namespace AvigilonProject.UI.Model
{
    public class AlarmMappingModel
    {
        #region Private variable
        private string _alarm;
        private string _site;
        private string _description;
        #endregion
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
    }
}
