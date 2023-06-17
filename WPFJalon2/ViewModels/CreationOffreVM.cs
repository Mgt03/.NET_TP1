using Bibliotheque.Entity;
using Cours2_ExempleMVVM.ViewModels.Common;
using System.Collections.ObjectModel;
using System;
using WPFJalon2.Mapper;
using System.Windows.Input;
using System.Data.Entity.Core.Common.EntitySql;
using BusinessLogicLayer;
using System.Collections.Generic;

namespace WPFJalon2.ViewModels
{
    public class CreationOffreVM
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

        public CreationOffreVM(OffreVM o)
        {
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
            Manager manager = Manager.Instance();
            Offre offre = new Offre();
            offre.Intitule = _intitule;
            offre.Description = _description;
            offre.Date = DateTime.Now;
            offre.Salaire = _salaire;
            offre.Responsable = _Responsable;
            offre.StatutId = _statutId;
            offre.Postulations = new HashSet<Postulation>(PostulationMapper.ToModels(_postulation));
            manager.AddOffre(offre);
        }
    }
}