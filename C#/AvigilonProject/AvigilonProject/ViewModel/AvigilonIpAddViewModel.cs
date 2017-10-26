using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvigilonProject.Model;
using System.Windows.Input;
using AvigilonProject.BuisnessLayer;
using AvigilonProject.View;
using AvigilonProject.BuisnessLayer.Service;
using AvigilonProject.UI.Model;
using AvigilonProject.UI.Commands;
using AvigilonProject.UI.Dialogue;

namespace AvigilonProject.UI.ViewModel
{
    public class AvigilonIpAddViewModel: AvigilonProjectViewModelBase
    {
        AvigilonIpVewModel _avigilonipvewmodel = new AvigilonIpVewModel();
        AvigilonAddIp AddIpObject;
        InvalidModel InvalidModel;
        AvigilonIpVewModels IpAdd;
        public AvigilonIpAddViewModel()
        {
            AddIpObject = new AvigilonAddIp();
            InvalidModel = new InvalidModel();
            IPs = new IpAddModel();
            IpAdd = new AvigilonIpVewModels();
            AddIpObject.OperationInvalid += InvalidShow;
        }
        static void InvalidShow(object sender, EventArgs e)
        {
            InvalidModel Invalid = new InvalidModel();
            Invalid.Show();
        }
        /// <summary>
        /// To add Ip in Ip Model
        /// </summary>
        private IpAddModel _ips;

        public IpAddModel IPs
        {
            get 
            {
                return _ips;
            }
            set
            {
                _ips = value;
                OnPropertyChanged("IPs");
            }
        }
        /// <summary>
        /// To store data in database
        /// </summary>
        public ICommand Saves
        {
            get
            {
                return new RelayCommand(Save, CanSubmitExecutes);
            }
            
        }
        public bool CanSubmitExecutes(object parameter)
        {
            if (string.IsNullOrEmpty(IPs.IP))
                return false;
            else
                return true;
        }
         private DialogueService dialogueService ;
        public void Save(object parameter)
         {
            dialogueService = new DialogueService();
            AddIpObject.Save(IPs.IP); 
            IPs.IP = string.Empty;
            _avigilonipvewmodel.Read(IpAdd);
            
            if (dialogueService != null)
                dialogueService.CloseIpWindow();
        }
    }
}
