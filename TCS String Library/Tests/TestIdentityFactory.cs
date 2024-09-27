using System;
using TC.StringLibrary.People;
using UnityEngine;
namespace TC.StringLibrary.Tests {
    public class TestIdentityFactoryMonoBehaviour : MonoBehaviour {
        void Start() {
            TestCreateDefaultIdentity();
            TestCreateCustomIdentity();
            TestCreateTemplateIdentity();
        }

        void TestCreateDefaultIdentity() {
            var identity = IdentityFactory.CreateDefaultIdentity();
            Debug.Log($"Default Identity: Name={identity.Name}, SurName={identity.SurName}, SocialSecurityNumber={identity.SocialSecurityNumber}, DateOfBirth={identity.DateOfBirth}, Gender={identity.Gender}");
        }

        void TestCreateCustomIdentity() {
            const string s = "John";
            const string surName = "Doe";
            const int socialSecurityNumber = 123456789;
            var dateOfBirth = new DateTime(1980, 1, 1);
            const Gender gender = Gender.Male;

            var identity = IdentityFactory.CreateCustomIdentity(s, surName, socialSecurityNumber, dateOfBirth, gender);
            Debug.Log($"Custom Identity: Name={identity.Name}, SurName={identity.SurName}, SocialSecurityNumber={identity.SocialSecurityNumber}, DateOfBirth={identity.DateOfBirth}, Gender={identity.Gender}");
        }

        void TestCreateTemplateIdentity() {
            var studentIdentity = IdentityFactory.CreateTemplateIdentity(ModernPersonType.Student);
            Debug.Log($"Student Identity: Name={studentIdentity.Name}, SurName={studentIdentity.SurName}, SocialSecurityNumber={studentIdentity.SocialSecurityNumber}, DateOfBirth={studentIdentity.DateOfBirth}, Gender={studentIdentity.Gender}");

            var employeeIdentity = IdentityFactory.CreateTemplateIdentity(ModernPersonType.Employee);
            Debug.Log($"Employee Identity: Name={employeeIdentity.Name}, SurName={employeeIdentity.SurName}, SocialSecurityNumber={employeeIdentity.SocialSecurityNumber}, DateOfBirth={employeeIdentity.DateOfBirth}, Gender={employeeIdentity.Gender}");
        }
    }
}