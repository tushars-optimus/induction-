using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvigilonProject.Model;
using System.Collections.ObjectModel;
using AvigilonProject.BuisnessLayer;
using System.Windows.Input;
using AvigilonProject.Model.Commands;

namespace AvigilonProject.ViewModel
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

        AvigilonProjecyBl Blobject = new AvigilonProjecyBl();
        
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
            AvigilonReadOnly();
            VelocityReadOnly();
            AlarmMappingVm();

        }
        private ObservableCollection<AvigilonModel> _avigilonInstance;
        /// <summary>
        /// TO store value from bl to Avigilons list 
        /// </summary>
        public void AvigilonReadOnly()
        {
            var Avi = Blobject.ReadAvigilons();
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
        public void VelocityReadOnly()
        {
            var Vel = Blobject.ReadVelocity();
            Velocitys.Clear();
            foreach (var item in Vel)
            {
                Velocitys.Add(new VelocityModel { Description = item.Description });
            }
            _velocityInstance = new ObservableCollection<VelocityModel>(Velocitys);

        }
        private ObservableCollection<AlarmMappingModel> Mapping;
        /// <summary>
        /// TO store value in Alarm Mapping 
        /// </summary>
        public void AlarmMappingVm()
        {
            var Alarmm = Blobject.ReadAlarmMapping();
            AlarmMappingModel.Clear();
            foreach (var item in Alarmm)
            {
                AlarmMappingModel.Add(new AlarmMappingModel { Alarm = item.AlarmBl, Site = item.SiteBl, Description = item.DescriptionBl });
            }
            Mapping = new ObservableCollection<AlarmMappingModel>(AlarmMappingModel);
        }
        private AvigilonModel _selectesavigilon;
        /// <summary>
        /// To create binding for selected item for Avigilon
        /// </summary>
        public AvigilonModel SelectedAvigilons
        {
            get
            {
                return _selectesavigilon;
            }
            set
            {
                _selectesavigilon = value;
                _selectedAlarm = new AlarmMappingModel();
                OnPropertyChanged("SelectedAvigilons");
            }
        }
        private VelocityModel _selectedvelocity;
        /// <summary>
        /// To create binding for selected item for Velocity
        /// </summary>

        public VelocityModel SelectedVelocity
        {
            get
            {
                return _selectedvelocity;
            }
            set
            {
                _selectedvelocity = value;
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
                _selectedvelocity = new VelocityModel();
                _selectesavigilon=new AvigilonModel();
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

                return new RelayCommand(Select, CanSubmitExecutes);
            }

        }
        public bool CanSubmitExecutes(object parameter)
        {
            if (string.IsNullOrEmpty(SelectedAvigilons.Alarm) || string.IsNullOrEmpty(SelectedVelocity.Description))
                return false;
            else
                return true;
        }

        public void Select(object parameter)
        {
            Blobject.Selects(SelectedAvigilons.Alarm, SelectedAvigilons.Site, SelectedVelocity.Description);
            AlarmMappingVm();
        }
        
        /// <summary>
        /// TO delete the Alarm mapping
        /// </summary>
        public ICommand Delete
        {
            get
            {

                return new RelayCommand(Deselect, CanSubmitExecuted);
            }

        }
        public bool CanSubmitExecuted(object parameter)
        {
           
            if (string.IsNullOrEmpty(SelectedAlarmMappingModel.Alarm))
                return false;
            else
                return true;
        }

        public void Deselect(object parameter)
        {
            Blobject.Deletes(SelectedAlarmMappingModel.Alarm, SelectedAlarmMappingModel.Description);
            AlarmMappingVm();
            SelectedAlarmMappingModel = new AlarmMappingModel();


        }
        
        private string _searchavigilon;
        /// <summary>
        /// To search for value in Avigilon
        /// </summary>
        public string SearchAvigilon
        {
            get
            {
                return _searchavigilon;
            }
            set
            {
                _searchavigilon = value;
                OnPropertyChanged("SearchAvigilon");
                FilterCollectionAvigilon();
            }
        }

        public void FilterCollectionAvigilon()
        {
            if (String.IsNullOrEmpty(SearchAvigilon))
            {

                AvigilonReadOnly();
            }
            else
            {
                
                var AvigilonsFilter = (_avigilonInstance.Where(alarm => alarm.Alarm.Contains(SearchAvigilon)));
                ObservableCollection<AvigilonModel> Avigilon2 = new ObservableCollection<AvigilonModel>(AvigilonsFilter);
                Avigilons = Avigilon2;

            }
        }


        private string _searchvelocity;
        /// <summary>
        /// To search for value in Velocity
        /// </summary>
        public string SearchVelocity
        {
            get
            {
                return _searchvelocity;
            }
            set
            {
                _searchvelocity = value;
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

                VelocityReadOnly();
            }
            else
            {

                var VelocityFilter = (_velocityInstance.Where(description => description.Description.Contains(SearchVelocity)));
                ObservableCollection<VelocityModel> Velocity2 = new ObservableCollection<VelocityModel>(VelocityFilter);
                Velocitys = Velocity2;

            }
        }


        private string _searchmapping;
        /// <summary>
        /// To search for value in Avigilon Mapping
        /// </summary>
        public string SearchMap
        {
            get
            {
                return _searchmapping;
            }
            set
            {
                _searchmapping = value;
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

                AlarmMappingVm();
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
