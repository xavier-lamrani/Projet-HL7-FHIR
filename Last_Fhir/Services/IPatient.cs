using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
namespace Last_Fhir.Services
{
   public interface IPatient
    {
        Patient Save(Patient p);
        IEnumerable<Patient> findall();
        IEnumerable<Patient> PatientsParMC(string mc);
        Patient Getone(string ID);
        void Update(Patient p);
        void Delete(string ID);
    }
}
