using System;
using PersonGrid.Models;

namespace PersonGrid.Tools
{
    class Adapter
    {
        internal static Person CreatePerson(string firstName, string lastName, string email, DateTime birthDate)
        {
            return new Person(firstName, lastName, email, birthDate);
        }
    }
}
