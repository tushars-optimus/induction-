﻿using AvigilonProject.BuisnessLayer;
using AvigilonProject.Model.Commands;
using AvigilonProject.Model;
using System.Collections.ObjectModel;

using System.Windows.Input;

namespace AvigilonProject.ViewModel
{
    public class AvigilonIpVewModel : AvigilonProjectViewModelBase
    {

        public AvigilonIpVewModel()
        {
            IpModel = new IpModel();
            IpModels = new ObservableCollection<IpModel>();
            SelectIpModels = new IpModel();
            Read();
        }
        AvigilonIpVewModelBl AvigilonIpobject = new AvigilonIpVewModelBl();
        private IpModel _ipmodel;
        /// <summary>
        /// To access IpModel  
        /// </summary>
        public IpModel IpModel
        {
            get 
            {
                return _ipmodel;
            }
            set
            {
                _ipmodel = value;
                OnPropertyChanged("IpModel");
            }
        }
        /// <summary>
        /// To store list of IpModel 
        /// </summary>
        private ObservableCollection<IpModel> _ipmodels;
        public ObservableCollection<IpModel> IpModels
        {
            get
            {
                return _ipmodels;
            }
            set
            {
                _ipmodels = value;
                OnPropertyChanged("IpModels");
            }
        }

        private IpModel _selectedpmodel;
        /// <summary>
        /// To select selected item in IPModel table 
        /// </summary>
        public IpModel SelectIpModels
        {
            get
            {
                return _selectedpmodel;
            }
            set
            {
                _selectedpmodel = value;
                OnPropertyChanged("SelectIpModels");
            }
        }
        
        
        public void Read()
        {
            var Ipmode = AvigilonIpobject.ReadIp();
            IpModels.Clear();
            foreach (var item in Ipmode)
            {
                IpModels.Add(new IpModel { IP = item.IP, Status = item.Status, Version = item.Version });
            }
        }
        /// <summary>
        /// To bind Add button
        /// </summary>
        public ICommand Add
        {
            get
            {

                return new RelayCommand(Adds, CanSubmitExecutea);
            }

        }
        public bool CanSubmitExecutea(object parameter)
        {
            return true;
        }
        private DialogueService dialogueService;
        public void Adds(object parameter)
        {
            dialogueService= new DialogueService();
            if (dialogueService != null)
                dialogueService.ShowIpWindow();
            Read();
            
        }
        
        /// <summary>
        /// To bind Remove to Remove button
        /// </summary>
        public ICommand Remove
        {
            get
            {

                return new RelayCommand(Removes, CanSubmitExecuter);
            }

        }
        public bool CanSubmitExecuter(object parameter)
        {
            if (SelectIpModels==null)
            {
                SelectIpModels = new IpModel(); 
            }
            if (string.IsNullOrEmpty(SelectIpModels.IP))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Removes(object parameter)
        {
            AvigilonIpobject.RemoveIp(SelectIpModels.IP);
            Read();
        }
        
    }
}
