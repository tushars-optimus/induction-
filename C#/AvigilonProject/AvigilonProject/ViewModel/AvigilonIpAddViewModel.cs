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
        AvigilonIpVewModel _avigilonIpVewModel = new AvigilonIpVewModel();
        AvigilonAddIp addIpObject;
        InvalidModel invalidModel;
        AvigilonIpVewModels ipAdd;
        public AvigilonIpAddViewModel()
        {
            addIpObject = new AvigilonAddIp();
            invalidModel = new InvalidModel();
            IPs = new IpAddModel();
            ipAdd = new AvigilonIpVewModels();
            addIpObject.OperationInvalid += InvalidShow;
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
         private DialogueService _dialogueservice ;
        public void Save(object parameter)
         {
            _dialogueservice = new DialogueService();
            addIpObject.Save(IPs.IP); 
            IPs.IP = string.Empty;
            _avigilonIpVewModel.Read(ipAdd);
            
            if (_dialogueservice != null)
                _dialogueservice.CloseIpWindow();
        }
    }
}
