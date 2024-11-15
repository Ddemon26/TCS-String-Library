using System;

namespace TC.StringLibrary.People {
    public static class IdentityFactory {
        public static Identity CreateDefaultIdentity() {
            return CreateIdentity(
                StringLibrary.GetRandomName(),
                StringLibrary.GetRandomSurname(),
                SocialSecurityNumberGenerator.GenerateUniqueNumber(),
                DateTime.MinValue,
                Gender.Unknown
            );
        }

        public static Identity CreateCustomIdentity(string name, string surName, int socialSecurityNumber, DateTime dateOfBirth, Gender gender) {
            return CreateIdentity(name, surName, socialSecurityNumber, dateOfBirth, gender);
        }

        public static Identity CreateTemplateIdentity(ModernPersonType modernPersonType) {
            return modernPersonType switch {
                ModernPersonType.Student => CreateIdentity(
                    StringLibrary.GetRandomName(),
                    StringLibrary.GetRandomSurname(),
                    SocialSecurityNumberGenerator.GenerateUniqueNumber(),
                    DateOfBirthGenerator.GenerateRandomDateOfBirth(1995, 2005),
                    Gender.Unknown
                ),
                ModernPersonType.Employee => CreateIdentity(
                    StringLibrary.GetRandomName(),
                    StringLibrary.GetRandomSurname(),
                    SocialSecurityNumberGenerator.GenerateUniqueNumber(),
                    DateOfBirthGenerator.GenerateRandomDateOfBirth(1980, 1990),
                    Gender.Unknown
                ),
                _ => CreateDefaultIdentity(),
            };
        }

        static Identity CreateIdentity(string name, string surName, int socialSecurityNumber, DateTime dateOfBirth, Gender gender) {
            return new IdentityBuilder()
                .SetName(name)
                .SetSurName(surName)
                .SetSocialSecurityNumber(socialSecurityNumber)
                .SetDateOfBirth(dateOfBirth)
                .SetGender(gender)
                .Build();
        }
    }
}