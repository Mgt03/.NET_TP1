namespace WPFJalon2.ViewModels
{
    public class HomeViewModel
    {
        #region Variables

        private ListOffreVM _listOffreVM = null;
        private DetailOffreVM _selectedOffreVM = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listOffreVM = new ListOffreVM();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListeProduitViewModel
        /// </summary>
        public ListOffreVM ListOffreVM
        {
            get { return _listOffreVM; }
            set { _listOffreVM = value; }
        }
        public DetailOffreVM SelectedOffre
        {
            get { return _selectedOffreVM; }
            set { _selectedOffreVM = value; }
        }

        #endregion
    }
}