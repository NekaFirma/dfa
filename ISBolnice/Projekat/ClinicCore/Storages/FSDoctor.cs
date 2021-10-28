using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ClinicCore.Storages
{
    public class FSDoctor : GenericFileStorage<Doctor>
    {
        public FSDoctor()
        {
            this.fileLocation = "../../../FileStorage/doctors.json";
        }

      
    }
}
