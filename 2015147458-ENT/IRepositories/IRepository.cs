using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2015147458_ENT.IRepositories
{
    public interface IRepository <TEntitie> where TEntitie: class
    {
        //Métodos estándar que todas las tablas deben tener.
        //Se programan de manera generica para no duplicar codigo por cada una.

        //CREATES
        //Agrega un registro al repositorio (SQL Server) a la tabla TEntity
        void Add(TEntitie entity);
        //Agrega un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        void AddRange(IEnumerable<TEntitie> entities);

        //READS
        //Obtiene el Registro con Primary Key = Id de la tabla TEntity
        TEntitie Get(int? Id);
        //Obtiene todos los registros de la tabla TEntity
        IEnumerable<TEntitie> GetAll();

        //Obtiene todos los registros de la tabla TEntity que cumplan con la condición predicate
        //predicate es una expresion lambda que tiene como parametro de entrada a TEntity 
        //y devolverá una expresion booleana. Si esa expresion es True para un registro,
        //entonces dicho registro se agrega a la lista de registros a devolver a la aplicacion.
        IEnumerable<TEntitie> Find(Expression<Func<TEntitie, bool>> predicate);

        //UPDATES
        //Actualiza un registro al repositorio (SQL Server) a la tabla TEntity
        //void Update(TEntity entity);
        //Actualiza un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        //void UpdateRange(IEnumerable<TEntity> entities);

        //DELETES
        //Elimina un registro al repositorio (SQL Server) a la tabla TEntity
        void Delete(TEntitie entity);
        //Elimina un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        void DeleteRange(IEnumerable<TEntitie> entities);
    }
}
