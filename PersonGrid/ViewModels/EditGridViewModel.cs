using PersonGrid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using PersonGrid.Managers;
using PersonGrid.Properties;
using PersonGrid.Tools;

namespace PersonGrid.ViewModels
{
    class EditGridViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get => _persons;
            private set
            {
                _persons = value;
                OnPropertyChanged();
            }
        }

        internal EditGridViewModel()
        {
            _persons = new ObservableCollection<Person>(DataManager.PersonList);
        }
        


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
