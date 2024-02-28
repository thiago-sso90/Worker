using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceTreinamento.Repositorio.Interface
{
    public interface IdbConnection
    {
        IDbConnection ConnectionDBase { get; }

    }
}
