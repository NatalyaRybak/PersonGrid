using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonGrid.Managers;
using PersonGrid.Models;
using PersonGrid.Tools;

namespace PersonGrid.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private readonly List<Person> _persons;

        internal SerializedDataStorage()
        {
            try
            {
                _persons = SerializationManager.Deserialize<List<Person>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _persons = new List<Person>();
                Random rnd = new Random();
                for (int i = 0; i < 5; ++i)
                    _persons.Add(new Person($"{(char)(rnd.Next(65, 90))}", $"{(char)(rnd.Next(65, 90))}", $"user@bb.b", new DateTime(rnd.Next(DateTime.Today.Year - 110, DateTime.Today.Year - 10), rnd.Next(1, 13), rnd.Next(1, 25))));
            }
        }

        public bool PersonExists(string email)
        {
            return _persons.Exists(u => u.Email == email);
        }


       public void AddPerson(Person person)
       {
           _persons.Add(person);
           SaveChanges();
       }

        public List<Person> PersonList
        {
            get { return _persons.ToList(); }
        }

        private void SaveChanges()
        {
            SerializationManager.Serialize(_persons, FileFolderHelper.StorageFilePath);
        }

    }
}
