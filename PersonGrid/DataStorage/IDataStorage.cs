using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonGrid.Models;

namespace PersonGrid.DataStorage
{
     internal interface IDataStorage
    {
        bool PersonExists(string login);

//        User GetUserByLogin(string login);

        void AddPerson(Person person);
        void DeletePerson(Person person);
        List<Person> PersonList { get; }
    }
}
