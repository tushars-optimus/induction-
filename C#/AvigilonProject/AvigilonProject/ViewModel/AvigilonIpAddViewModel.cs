using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvigilonProject.Model;
using System.Windows.Input;
using AvigilonProject.BuisnessLayer;
using AvigilonProject.Model.Commands;
using AvigilonProject.View;

namespace AvigilonProject.ViewModel
{
    public class AvigilonIpAddViewModel: AvigilonProjectViewModelBase
    {
        AvigilonIpVewModel AvigilonIpVewModel = new AvigilonIpVewModel();
        AvigilonAddIp AddIpObject;
        InvalidModel InvalidModel;
        AvigilonIpVewModelBl IpAdd;
        public AvigilonIpAddViewModel()
        {
            AddIpObject = new AvigilonAddIp();
            InvalidModel = new InvalidModel();
            IPs = new IpAddModel();
            IpAdd = new AvigilonIpVewModelBl();
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
        private IpAddModel _IPs;

        public IpAddModel IPs
        {
            get 
            {
                return _IPs;
            }
            set
            {
                _IPs = value;
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
            AvigilonIpVewModel.Read(IpAdd);
            
            if (dialogueService != null)
                dialogueService.CloseIpWindow();
        }
    }
}
