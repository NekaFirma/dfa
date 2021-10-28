using Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ClinicCore.Storages
{
    public class PatientFileStorage : GenericFileStorage<Patient>
    {
        public PatientFileStorage()
        {
            this.fileLocation = "../../../FileStorage/patients.json";
        }

     
    }
}
