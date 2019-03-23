using System;
using System.IO;
using System.Windows;
using PersonGrid.Models;
using PersonGrid.Tools;

namespace PersonGrid.Managers
{
    internal static class StationManager
    {
        private static DataManager _dataStorage;
        internal static Person CurrentPerson { get; set; }

        internal static DataManager DataStorage
        {
            get { return _dataStorage; }
        }

        internal static void Initialize(DataManager dataStorage)
        {
            _dataStorage = dataStorage;
        }

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }

        /*  static StationManager()
        {
            DeserializeLastUser();
        }

        private static void DeserializeLastUser()
        {
            Person userCandidate;
            try
            {
                userCandidate = SerializationManager.Deserialize<Person>(Path.Combine(FileFolderHelper.LastUserFilePath));
            }
            catch (Exception ex)
            {
                userCandidate = null;
//                Logger.Log("Failed to Deserialize last user", ex);
            }
            if (userCandidate == null)
            {
//                Logger.Log("User was not deserialized");
                return;
            }
            userCandidate = DBManager.CheckCachedUser(userCandidate);
            if (userCandidate != null)
                CurrentPerson = userCandidate;
            
        }

    */
    }
}
