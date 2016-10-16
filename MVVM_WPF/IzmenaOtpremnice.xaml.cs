using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MVVM_WPF.ServiceReference1;
using MVVM_WPF.ViewModel;
using System.Collections.ObjectModel;

namespace MVVM_WPF
{
    /// <summary>
    /// Interaction logic for EditOtpremnice.xaml
    /// </summary>
    public partial class EditOtpremnice : Window
    {
        public EditOtpremnice(PocetnaOtpremnicaViewModel GridSelectedItem, ObservableCollection<PocetnaOtpremnicaViewModel> AllZaglavlja, ObservableCollection<double> GetSumVerdnostiDokumenata)
        {
            InitializeComponent();

            var dodavanje = new EditujOtpremnicuViewModel(GridSelectedItem, AllZaglavlja, GetSumVerdnostiDokumenata);
            this.DataContext = dodavanje; // ovde se daje DataContext

            if (dodavanje.CloseAction == null)
                dodavanje.CloseAction = new Action(() => this.Close());


        }
    }
}
