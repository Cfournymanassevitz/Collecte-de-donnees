//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace WpfApp1
//{
//    public class CustomerEditViewModel
//    {
//        /// le client à modifier.
//        //public Customer CustomerToEdit { get; set; }

//        /// la commande "d'application des changements"
//        public ICommand ApplyChangesCommand { get; private set; }

//        /// constructeur
//        public CustomerEditViewModel()
//        {
//            //CustomerToEdit = new Customer
//            {
//                Forename = "John",
//                Surname = "Smith"
//            };

//            ApplyChangesCommand = new RelayCommand(
//                o => ExecuteApplyChangesCommand(),
//                //o => CustomerToEdit.IsValid);
//        }

//        // méthode pour exécuter les changements
//        private void ExecuteApplyChangesCommand()
//        {
//            // ex : save customer to database
//        }
//    }
//}
