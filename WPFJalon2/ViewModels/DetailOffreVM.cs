using Bibliotheque.Entity;
using Cours2_ExempleMVVM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
        private ICollection<Postulation> _Postulation;
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
            _Postulation = e.Postulations;
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

        public ICollection<Postulation> Postulations
        {
            get { return _Postulation; }
            set { _Postulation = value; }
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
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
            operationWindow.Close();
        }
    }
}
