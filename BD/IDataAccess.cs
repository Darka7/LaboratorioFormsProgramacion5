using Entity;
using System.Collections.Generic;

namespace BD
{
    public interface IDataAccess
    {
        DBEntity Execute(string sp, object Param = null, int? Timeout = null);
        IEnumerable<dynamic> Query(string sp, object Param = null, int? Timeout = null);
        IEnumerable<A> Query<A, B, C, D, E, H, I>(string sp, object Param = null, int? Timeout = null);
        IEnumerable<A> Query<A, B, C, D, E, H>(string sp, object Param = null, int? Timeout = null);
        IEnumerable<A> Query<A, B, C, D, E>(string sp, object Param = null, int? Timeout = null);
        IEnumerable<A> Query<A, B, C, D>(string sp, object Param = null, int? Timeout = null);
        IEnumerable<A> Query<A, B, C>(string sp, object Param = null, int? Timeout = null);
        IEnumerable<A> Query<A, B>(string sp, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T>(string sp, object Param = null, int? Timeout = null);
        T QueryFirst<T>(string sp, object Param = null, int? Timeout = null);
    }
}