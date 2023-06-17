using Bibliotheque.Entity;
using Cours2_ExempleMVVM.ViewModels.Common;
using System.Collections.ObjectModel;
using System;
using WPFJalon2.Mapper;
using System.Windows.Input;
using System.Data.Entity.Core.Common.EntitySql;
using BusinessLogicLayer;
using System.Collections.Generic;
using System.Linq;

namespace WPFJalon2.ViewModels
{
    public class CreationOffreVM : BaseViewModel
    {
        private int _id;
        private string _intitule;
        private DateTime _date;
        private int _salaire;
        private string _description;
        private string _Responsable;
        private Statut _statut;
        private int _statutId;
        private ObservableCollection<PostulationVM> _postulation;
        private RelayCommand _addOperation;
        private ObservableCollection<Statut> _statusAvailable;
        private Statut _statutSelected;
        private string _error;

        public CreationOffreVM(OffreVM o)
        {
            _statusAvailable = new ObservableCollection<Statut>();
            foreach (Statut statut in Manager.Instance().GetAllStatuts())
            {
                _statusAvailable.Add(statut);
            }
            if (_statusAvailable != null && _statusAvailable.Count() > 0)
            {
                _statutSelected = _statusAvailable.ElementAt(0);
            }
            _intitule = o.Intitule;
            _date = o.Date;
            _salaire = o.Salaire;
            _description = o.Description;
            _Responsable = o.Responsable;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Intitule
        {
            get { return _intitule; }
            set { _intitule = value; }
        }

        public DateTime Date {   
            get { return _date; }
            set { _date = value; }
        }

        public int Salaire {             
            get { return _salaire; }
            set { _salaire = value; }
        }
        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Responsable
        {
            get { return _Responsable; }
            set { _Responsable = value; }
        }

        public string Error
        {
            get { return _error; }
            set
            {
                _error = value;
                OnPropertyChanged("Error");
            }
        }

        public Statut StatutSelected
        {
            get { return _statutSelected; }
            set
            {
                _statutSelected = value;
                OnPropertyChanged("StatusSelected");
            }
        }

        public ObservableCollection<Statut> StatusAvailable
        {
            get { return _statusAvailable; }
            set
            {
                _statusAvailable = value;
                OnPropertyChanged("StatusAvailable");
            }
        }

        public ICommand Creer
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.Create());
                return _addOperation;
            }
        }

        private void Create()
        {
            if (_statutSelected == null)
            {
                _error = "Veuillez choisir un statut";
            }
            else
            {
                _error = "";
            }
            Manager manager = Manager.Instance();
            Offre offre = new Offre();
            offre.Intitule = _intitule;
            offre.Description = _description;
            offre.Date = DateTime.Now;
            offre.Salaire = _salaire;
            offre.Responsable = _Responsable;
            offre.Statut = _statutSelected;
            offre.StatutId = _statutSelected.Id;
            offre.Postulations = new HashSet<Postulation>(PostulationMapper.ToModels(new ObservableCollection<PostulationVM>()));
            manager.AddOffre(offre);
        }
    }
}