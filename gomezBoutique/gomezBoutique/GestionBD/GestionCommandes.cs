using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GestionBD.MySQL
{
    public class GestionCommandes
    {
        /// <summary>
        /// Retourne la liste de toutes les commandes
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from commande", "ToutesLesCommandes");

        }
    }
}
