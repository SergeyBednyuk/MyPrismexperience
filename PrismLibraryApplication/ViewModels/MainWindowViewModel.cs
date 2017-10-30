using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismLibraryApplication.ViewModels
{
    public class MainWindowViewModel
    {
        public LibraryViewModel LibraryViewModel { get; set; }

        public MainWindowViewModel()
        {
            LibraryViewModel = new LibraryViewModel();
        }
    }
}
