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
using PersonGrid.ViewModels;

namespace PersonGrid.Views
{
    /// <summary>
    /// Interaction logic for PersonGridView.xaml
    /// </summary>
    public partial class PersonGridView : UserControl
    {
        public PersonGridView()
        {
            InitializeComponent();
            DataContext = new EditGridViewModel();

        }
    }
}
