using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceTreinamento.Script
{
    public class ScriptDate
    {
        public static string AtualizarDatas => @"INSERT INTO [INT_ADP].[dbo].[zgtempo] (data2)
                                                                        VALUES (GETDATE())
                                                    ";
    }
}
