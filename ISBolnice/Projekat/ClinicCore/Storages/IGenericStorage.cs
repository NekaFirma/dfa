using ClinicCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicCore.Storages
{
    public interface IGenericStorage<T> where T:Entity
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T newObject);
        void Update(T selectedObject);
        void Delete(T selectedObject);
    }
}
