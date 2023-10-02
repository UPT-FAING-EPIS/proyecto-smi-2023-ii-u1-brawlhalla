using equipo_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipo_app.Services;

public class EquiposServices : IEquipos
{
    private readonly SQLLiteHelper<EquiposModels> db;
    public EquiposServices()
    => db = new();

    public Task<int> DeleteEquipo(EquiposModels A)
     => Task.FromResult(db.Delete(A));

    public Task<List<EquiposModels>> GetAll()
     => Task.FromResult(db.GetAllData());

    public Task<EquiposModels> GetById(int id)
    => Task.FromResult(db.Get(id));

    public Task<int> InsertEquipo(EquiposModels A)
   => Task.FromResult(db.Add(A));
    

    public Task<int> UpdateEquipo(EquiposModels A)
    => Task.FromResult(db.Update(A));

}
