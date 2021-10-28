using ClinicCore.Storages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicCore.Storages
{
    public interface IStorageFactory<T> where T:class
    {
        T GetStorage();
    }
}
