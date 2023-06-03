using Cours2_ExempleMVVM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using Bibliotheque.Entity;

namespace WPFJalon2.ViewModels
{
    public class ListOffreVM : BaseViewModel
    {
        private ObservableCollection<DetailOffreVM> _offre = null;
        private DetailOffreVM _selectedOffre;

        public ListOffreVM()
        {
            _offre = new ObservableCollection<DetailOffreVM>();
            foreach(Offre o in Manager.Instance().GetAllOffres())
            {
                _offre.Add(new DetailOffreVM(o));
            }
            if(_offre != null && _offre.Count > 0)
            {
                _selectedOffre = _offre.ElementAt(0);
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
    }
}
