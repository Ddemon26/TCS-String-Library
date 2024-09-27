using System;
namespace TC.StringLibrary.People {
    public class IdentityBuilder {
        string m_name = "DefaultName";
        string m_surName = "DefaultSurName";
        int m_socialSecurityNumber;
        DateTime m_dateOfBirth = DateTime.MinValue;
        Gender m_gender = Gender.Unknown;

        public IdentityBuilder SetName(string name) {
            m_name = name;
            return this;
        }

        public IdentityBuilder SetSurName(string surName) {
            m_surName = surName;
            return this;
        }

        public IdentityBuilder SetSocialSecurityNumber(int socialSecurityNumber) {
            m_socialSecurityNumber = socialSecurityNumber;
            return this;
        }

        public IdentityBuilder SetDateOfBirth(DateTime dateOfBirth) {
            m_dateOfBirth = dateOfBirth;
            return this;
        }

        public IdentityBuilder SetGender(Gender gender) {
            m_gender = gender;
            return this;
        }

        public Identity Build() {
            return new Identity(m_name, m_surName, m_socialSecurityNumber, m_dateOfBirth, m_gender);
        }
    }
}