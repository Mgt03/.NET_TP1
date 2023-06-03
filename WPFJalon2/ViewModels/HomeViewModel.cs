namespace WPFJalon2.ViewModels
{
    public class HomeViewModel
    {
        #region Variables

        private ListOffreVM _listeOffreVM = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listeOffreVM = new ListOffreVM();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListeProduitViewModel
        /// </summary>
        public ListOffreVM ListeOffreVM
        {
            get { return _listeOffreVM; }
            set { _listeOffreVM = value; }
        }

        #endregion
    }
}