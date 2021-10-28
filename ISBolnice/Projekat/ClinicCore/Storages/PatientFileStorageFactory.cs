using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicCore.Storages
{
    public class PatientFileStorageFactory : IStorageFactory<PatientFileStorage>
    {
        public PatientFileStorageFactory()
        {
        }

        public PatientFileStorage GetStorage()
        {
            return new PatientFileStorage(); 
        }
    }
}
