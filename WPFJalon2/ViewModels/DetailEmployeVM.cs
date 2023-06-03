using Bibliotheque.Entity;
using Cours2_ExempleMVVM.ViewModels.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;

namespace WPFJalon2.ViewModels
{
    public class DetailEmployeVM : BaseViewModel
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private DateTime _DateNaissance;
        private int _Anciennete;
        private string _Biographie;
        private ICollection<Formation> _Formation;
        private ICollection<Experience> _Experiences;
        private ICollection<Postulation> _Postulation;
        private RelayCommand _addOperation;

        public DetailEmployeVM(Employe e)
        {
            _id = e.Id;
            _nom = e.Nom;
            _prenom = e.Prenom;
            _DateNaissance = e.DateNaissance;
            _Anciennete = e.Anciennete;
            _Biographie = e.Biographie;
            _Formation = e.Formations;
            _Experiences = e.Experiences;
            _Postulation = e.Postulations;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public DateTime DateNaissance
        {
            get { return _DateNaissance; }
            set { _DateNaissance = value; }
        }

        public int Anciennete
        {
            get { return _Anciennete; }
            set { _Anciennete = value; }
        }

        public string Biographie
        {
            get { return _Biographie; }
            set { _Biographie = value; }
        }

        public ICollection<Formation> Formations
        {
            get { return _Formation; }
            set { _Formation = value; }
        }

        public ICollection<Experience> Experiences
        {
            get { return _Experiences; }
            set { _Experiences = value; }
        }

        public ICollection<Postulation> Postulations
        {
            get { return _Postulation; }
            set { _Postulation = value; }
        }

        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }
        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }
    }
}