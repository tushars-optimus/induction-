using System;
using System.Linq;
using AvigilonProject.Model;
using System.Collections.ObjectModel;
using AvigilonProject.BuisnessLayer;
using System.Windows.Input;
using AvigilonProject.UI.Model;
using AvigilonProject.BuisnessLayer.Service;
using AvigilonProject.UI.Commands;

namespace AvigilonProject.UI.ViewModel
{
    public class AvigilonProjectViewModel : AvigilonProjectViewModelBase
    {
        private AvigilonModel _avigilon;
        /// <summary>
        /// To access Avigilon Model
        /// </summary>
        public AvigilonModel Avigilon
        {
            get { return _avigilon; }
            set
            {
                _avigilon = value; OnPropertyChanged("Avigilon");
            }
        }
        /// <summary>
        /// To access Velocity Model
        /// </summary>
        private VelocityModel _velocity;

        public VelocityModel Velocity
        {
            get
            {
                return _velocity; 
            }
            set
            {
                _velocity = value; 
                OnPropertyChanged("Velocity");
            }
        }
        /// <summary>
        /// To create Avigilion List
        /// </summary>
        private ObservableCollection<AvigilonModel> _avigilons;
        public ObservableCollection<AvigilonModel> Avigilons
        {
            get
            {
                return _avigilons;
            }
            set
            {
                _avigilons = value;
                OnPropertyChanged("Avigilons");
            }
        }
        /// <summary>
        /// To create Velocity list 
        /// </summary>
        private ObservableCollection<VelocityModel> _velocitys;
        public ObservableCollection<VelocityModel> Velocitys
        {
            get
            {
                return _velocitys;
            }
            set
            {
                _velocitys = value;
                OnPropertyChanged("Velocitys");
            }
        }
        /// <summary>
        /// To crete Alarm mapping list
        /// </summary>
        private ObservableCollection<AlarmMappingModel> _alarmmapping;

        public ObservableCollection<AlarmMappingModel> AlarmMappingModel
        {
            get 
            { 
                return _alarmmapping; 
            }
            set
            {
                _alarmmapping = value;
                OnPropertyChanged("AlarmMappingModel");
            }
        }

        //AvigilonProjecyBl Blobject = new AvigilonProjecyBl();
        
        public AvigilonProjectViewModel()
        {


            Avigilon = new AvigilonModel();
            Velocity = new VelocityModel();
            Avigilons = new ObservableCollection<AvigilonModel>();
            Velocitys = new ObservableCollection<VelocityModel>();
            AlarmMappingModel = new ObservableCollection<AlarmMappingModel>();
            SelectedAvigilons = new AvigilonModel();
            SelectedVelocity = new VelocityModel();
            SelectedAlarmMappingModel = new AlarmMappingModel();
            AvigilonBl = new AvigilonProjecyBl();
            AlarmReadOnly(AvigilonBl);
            VelocityReadOnly(AvigilonBl);
            AlarmMappingVm(AvigilonBl);

        }
        private IAvigilon AvigilonBl;
        private ObservableCollection<AvigilonModel> _avigilonInstance;
        /// <summary>
        /// TO store value from bl to Avigilons list 
        /// </summary>
        public void AlarmReadOnly(IAvigilon AvigilonBl)
        {
            var Avi = AvigilonBl.ReadAvigilons();
            Avigilons.Clear();
            foreach (var item in Avi)
            {
                Avigilons.Add(new AvigilonModel { Alarm = item.Alarm, Site = item.Site });
            }
            _avigilonInstance = new ObservableCollection<AvigilonModel>(Avigilons);

        }
        private ObservableCollection<VelocityModel> _velocityInstance;
        /// <summary>
        /// TO store value from bl to Velocity list 
        /// </summary>
        
        public void VelocityReadOnly(IAvigilon AvigilonBl)
        {
            try          
            {
                var vel = AvigilonBl.ReadVelocity();
                Velocitys.Clear();
                foreach (var item in vel)
                {
                    Velocitys.Add(new VelocityModel { Description = item.Description });
                }
                _velocityInstance = new ObservableCollection<VelocityModel>(Velocitys);
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }
        private ObservableCollection<AlarmMappingModel> Mapping;
        /// <summary>
        /// TO store value in Alarm Mapping 
        /// </summary>
        public void AlarmMappingVm(IAvigilon AvigilonBl)
        {
            var alarm = AvigilonBl.ReadAlarmMapping();
            AlarmMappingModel.Clear();
            foreach (var item in alarm)
            {
                AlarmMappingModel.Add(new AlarmMappingModel { Alarm = item.Alarm, Site = item.Site, Description = item.Description });
            }
            Mapping = new ObservableCollection<AlarmMappingModel>(AlarmMappingModel);
        }
        private AvigilonModel _selectesAvigilon;
        /// <summary>
        /// To create binding for selected item for Avigilon
        /// </summary>
        public AvigilonModel SelectedAvigilons
        {
            get
            {
                return _selectesAvigilon;
            }
            set
            {
                _selectesAvigilon = value;
                _selectedAlarm = new AlarmMappingModel();
                OnPropertyChanged("SelectedAvigilons");
            }
        }
        private VelocityModel _selectedVelocity;
        /// <summary>
        /// To create binding for selected item for Velocity
        /// </summary>

        public VelocityModel SelectedVelocity
        {
            get
            {
                return _selectedVelocity;
            }
            set
            {
                _selectedVelocity = value;
                _selectedAlarm = new AlarmMappingModel();
                OnPropertyChanged("SelectedVelocity");
            }
        }
        private AlarmMappingModel _selectedAlarm;
        /// <summary>
        /// To create binding for selected item for Alarm Mapping
        /// </summary>
        public AlarmMappingModel SelectedAlarmMappingModel
        {
            get
            {
                return _selectedAlarm;
            }
            set
            {
                _selectedAlarm = value;
                _selectedVelocity = new VelocityModel();
                _selectesAvigilon=new AvigilonModel();
                OnPropertyChanged("SelectedAlarmMappingModel");
            }
        }
        /// <summary>
        /// TO Bind Avigilon and Velocity to Alarm Mapping
        /// </summary>
        public ICommand Create
        {
            get
            {

                return new RelayCommand(AlarmVelocitySelect, CanSubmitExecutes);
            }

        }
        public bool CanSubmitExecutes(object parameter)
        {
            if (SelectedAvigilons == null)
            {
                SelectedAvigilons = new AvigilonModel();
                return CanSubmitExecutes(parameter);
            }
            else if (SelectedVelocity == null)
            {
                SelectedVelocity = new VelocityModel();
                return CanSubmitExecutes(parameter);
            }
            else
            {
                if (string.IsNullOrEmpty(SelectedAvigilons.Alarm) || string.IsNullOrEmpty(SelectedVelocity.Description))
                    return false;
                else
                    return true;
            }
        }

        public void AlarmVelocitySelect(object parameter)
        {
            AvigilonBl.Selects(SelectedAvigilons.Alarm, SelectedAvigilons.Site, SelectedVelocity.Description);
            AlarmMappingVm(AvigilonBl);
        }
        
        /// <summary>
        /// TO delete the Alarm mapping
        /// </summary>
        public ICommand Delete
        {
            get
            {

                return new RelayCommand(AlarmVelocityDeselect, CanSubmitExecuted);
            }

        }
        public bool CanSubmitExecuted(object parameter)
        {
            if (SelectedAlarmMappingModel == null)
            {
                SelectedAlarmMappingModel = new AlarmMappingModel();
                return CanSubmitExecuted(parameter);
            }
            else
            {
                if (string.IsNullOrEmpty(SelectedAlarmMappingModel.Alarm))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
        }

        public void AlarmVelocityDeselect(object parameter)
        {
            AvigilonBl.Deletes(SelectedAlarmMappingModel.Alarm, SelectedAlarmMappingModel.Description);
            AlarmMappingVm(AvigilonBl);
            SelectedAlarmMappingModel = new AlarmMappingModel();
        }
        
        private string _searchAvigilon;
        /// <summary>
        /// To search for value in Avigilon
        /// </summary>
        public string SearchAvigilon
        {
            get
            {
                return _searchAvigilon;
            }
            set
            {
                _searchAvigilon = value;
                OnPropertyChanged("SearchAvigilon");
                FilterCollectionAvigilon();
            }
        }

        public void FilterCollectionAvigilon()
        {
            if (String.IsNullOrEmpty(SearchAvigilon))
            {

                AlarmReadOnly(AvigilonBl);
            }
            else
            {
                
                var AvigilonsFilter = (_avigilonInstance.Where(alarm => alarm.Alarm.Contains(SearchAvigilon)));
                ObservableCollection<AvigilonModel> Avigilon2 = new ObservableCollection<AvigilonModel>(AvigilonsFilter);
                Avigilons = Avigilon2;

            }
        }


        private string _searchVelocity;
        /// <summary>
        /// To search for value in Velocity
        /// </summary>
        public string SearchVelocity
        {
            get
            {
                return _searchVelocity;
            }
            set
            {
                _searchVelocity = value;
                OnPropertyChanged("SearchVelocity");
                FilterCollectionVelocity();
            }
        }
        /// <summary>
        /// To filter Velocity table
        /// </summary>
        public void FilterCollectionVelocity()
        {
            if (String.IsNullOrEmpty(SearchVelocity))
            {

                VelocityReadOnly(AvigilonBl); 
            }
            else
            {

                var VelocityFilter = (_velocityInstance.Where(description => description.Description.Contains(SearchVelocity)));
                ObservableCollection<VelocityModel> Velocity2 = new ObservableCollection<VelocityModel>(VelocityFilter);
                Velocitys = Velocity2;

            }
        }


        private string _searchMapping;
        /// <summary>
        /// To search for value in Avigilon Mapping
        /// </summary>
        public string SearchMap
        {
            get
            {
                return _searchMapping;
            }
            set
            {
                _searchMapping = value;
                OnPropertyChanged("SearchMap");
                FilterCollectionMapping();
            }
        }
        /// <summary>
        /// To filter Alarm Mapping table
        /// </summary>
        public void FilterCollectionMapping()
        {
            if (String.IsNullOrEmpty(SearchMap))
            {

                AlarmMappingVm(AvigilonBl);
            }
            else
            {

                var MappingFilter = (Mapping.Where(alarm => alarm.Alarm.Contains(SearchMap)));
                ObservableCollection<AlarmMappingModel> Mapping2 = new ObservableCollection<AlarmMappingModel>(MappingFilter);
                AlarmMappingModel = Mapping2;

            }
        }
        /// <summary>
        /// To move to configuration page
        /// </summary>
        public ICommand Config
        {
            get
            {

                return new RelayCommand(Configuration, CanSubmitExecutedc);
            }

        }
        public void Configuration(Object parameter)
        {
            Avigilon Ip = new Avigilon();
            Ip.Show();
        }
        public bool CanSubmitExecutedc(object parameter)
        {
            return true;
        }
    }
}
