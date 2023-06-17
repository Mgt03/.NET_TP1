using Bibliotheque.Entity;
using BusinessLogicLayer;
using Cours2_ExempleMVVM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFJalon2.Mapper;

namespace WPFJalon2.ViewModels
{
    public class DetailOffreVM
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

        public DetailOffreVM(Offre e)
        {
            _id = e.Id ;
            _intitule = e.Intitule;
            _date = e.Date;
            _salaire = e.Salaire;
            _description = e.Description;
            _Responsable = e.Responsable;
            _statut = e.Statut;
            _statutId = e.StatutId;
            _postulation = PostulationMapper.ToViewModels(e.Postulations);
            Console.WriteLine("TOTO");
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
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        public string Responsable
        {
            get { return _Responsable; }
            set { _Responsable = value; }
        }
        public Statut Statut
        {
            get { return _statut; }
            set { _statut = value; }
        }
        public int StatutId
        {
            get { return _statutId; }
            set { _statutId = value; }
        }

        public ObservableCollection<PostulationVM> Postulations
        {
            get { return _postulation; }
            set { _postulation = value; }
        }


        public ICommand Valider
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.Save());
                return _addOperation;
            }
        }
        private void Save()
        {
            Manager manager = Manager.Instance();
            Offre offre = new Offre();
            offre.Id = _id;
            offre.Intitule = _intitule;
            offre.Description = _description;
            offre.Date = _date;
            offre.Salaire = _salaire;
            offre.Responsable = _Responsable;
            offre.StatutId = _statutId;
            offre.Statut = _statut;
            offre.Postulations = new HashSet<Postulation>(PostulationMapper.ToModels(_postulation));
            manager.UpdateOffre(offre);
        }
    }
}
