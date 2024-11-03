using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionProduits
    {

        /// <summary>
        /// Retourne la liste de tous les produits
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("select nom AS 'produit', prix, description from produit", "TousLesProduits");
        }

        /// <summary>
        /// Retourne la liste de tous les produits en fonction de la recherche
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesByRecherche( string txtRecherche)
        {
            return GestionBoutique.getTuplesRequeteSelect("select nom AS 'produit', prix, description from produit where nom LIKE '" + txtRecherche + "%'", "TousLesProduitsParRecherche");
        }

    }
}
