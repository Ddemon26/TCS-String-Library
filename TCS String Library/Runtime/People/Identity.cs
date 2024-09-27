using System;
namespace TC.StringLibrary.People {
    public struct Identity {
        public readonly string Name;
        public readonly string SurName;
        public readonly int SocialSecurityNumber;
        public DateTime DateOfBirth;
        public readonly Gender Gender;

        public Identity(string name, string surName, int socialSecurityNumber, DateTime dateOfBirth, Gender gender) {
            Name = name;
            SurName = surName;
            SocialSecurityNumber = socialSecurityNumber;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
    }
}