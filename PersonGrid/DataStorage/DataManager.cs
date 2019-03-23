using PersonGrid.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PersonGrid.Managers;
using PersonGrid.Tools;

namespace PersonGrid.DataStorage
{
    internal class DataManager
    {
        private static readonly List<Person> _persons;

        static DataManager()
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
        internal static bool PersonExists(string email)
        {
          return _persons.Any(u => u.Email == email);
        }

        internal static Person CreatePerson(string firstName, string lastName, string email, DateTime birthDate)
        {
            Person newPerson = new Person(firstName, lastName, email, birthDate);
            _persons.Add(newPerson);
            return newPerson;
        }
        public static List<Person> PersonList 
        {
            get { return _persons.ToList(); }
        }


        internal static void AddPerson(Person person)
        {
            _persons.Add(person);
            SaveChanges();
        }

        private static void SaveChanges()
        {
            SerializationManager.Serialize(_persons, FileFolderHelper.StorageFilePath);
        }
//        public static void UpdateGrid(List<Person> persons)
//        {
//            SaveChanges();
//        }



        //        
        //
        //        internal static Person GetUserByLogin(string login)
        //        {
        //            return _persons.FirstOrDefault(u => u.Login == login);
        //        }

        //        internal static Person CheckCachedUser(Person userCandidate)
        //        {
        //            var userInStorage = _persons.FirstOrDefault(u => u.Guid == userCandidate.Guid);
        //            if (userInStorage != null && userInStorage.CheckPassword(userCandidate))
        //                return userInStorage;
        //            return null;
        //        }
        //
        //       
    }
}
