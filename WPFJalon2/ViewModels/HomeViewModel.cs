namespace WPFJalon2.ViewModels
{
    public class HomeViewModel
    {
        #region Variables

        private ListOffreVM _listOffreVM = null;

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
        public ListOffreVM ListOffreVm
        {
            get { return _listOffreVM; }
            set { _listOffreVM = value; }
        }

        #endregion
    }
}