using Cours2_ExempleMVVM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using Bibliotheque.Entity;
using System.Windows.Controls;

namespace WPFJalon2.ViewModels
{
    public class ListOffreVM : BaseViewModel
    {
        private ObservableCollection<DetailOffreVM> _offre = null;
        private DetailOffreVM _selectedOffre;
        private ObservableCollection<Statut> _statusAvailable;
        private Statut _statutSelected;

        public ListOffreVM()
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
            _offre = new ObservableCollection<DetailOffreVM>();
            foreach(Offre o in Manager.Instance().GetAllOffres())
            {
                 _offre.Add(new DetailOffreVM(o));
            }
            if(_offre != null && _offre.Count > 0)
            {
                _selectedOffre = _offre.ElementAt(0);
                FiltrerOffres();
            }
        }
        public ObservableCollection<DetailOffreVM> Offres
        {
            get { return _offre; }
            set
            {
                _offre = value;
                OnPropertyChanged("Offres");
            }
        }
        public DetailOffreVM SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }

        public Statut StatutSelected
        {
            get { return _statutSelected; }
            set
            {
                _statutSelected = value;
                FiltrerOffres();
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

        private ObservableCollection<DetailOffreVM> _offresFiltrees;
        public ObservableCollection<DetailOffreVM> OffresFiltrees
        {
            get { return _offresFiltrees; }
            set
            {
                _offresFiltrees = value;
                OnPropertyChanged("OffresFiltrees");
            }
        }
        public void FiltrerOffres()
        {
            if (StatutSelected != null)
            {
                OffresFiltrees = new ObservableCollection<DetailOffreVM>(
                    Offres.Where(o => o.Statut.Id == StatutSelected.Id)
                );
            }
            else
            {
                OffresFiltrees = new ObservableCollection<DetailOffreVM>(Offres);
            }
        }
        


    }
}
