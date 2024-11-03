using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBD;
using System.Data;


namespace GestionBD.MySQL
{
    public class GestionCommande
    {
        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from commande", "ToutesLesCommandes");

        }
    }
}
