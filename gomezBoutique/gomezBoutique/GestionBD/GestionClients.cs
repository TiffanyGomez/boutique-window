using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionClients
    {

        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from client", "TousLesClients");

        }


        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesByNom(string nom)
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from client where nom = '"+nom+"'", "TousLesClients");
        }



        /// <summary>
        /// Retourne la liste des Patronymes de Clients : id et NOM prenom)
        /// </summary>
        /// <returns></returns>
        public static DataTable getPatronymes()
        { 
            return GestionBoutique.getTuplesRequeteSelect("SELECT id, CONCAT(UPPER(nom),' ',prenom) AS Patronyme FROM client", "TousLesPatronymesClients");
        }

        /// <summary>
        /// Retourne le nombre de clients
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from client"));
        }

        /// <summary>
        /// Ajoute un client
        /// </summary>
        /// <param name="nom">Nom du client</param>
        /// <param name="prenom">Prénom du client</param>
        /// <param name="rue">Rue du client</param>
        /// <param name="codePostal">Code postal du client</param>
        /// <param name="ville">Ville du client</param>
        /// <param name="tel">Téléphone du client</param>
        /// <param name="email">Email du client</param>
        public static void ajouter(string nom, string prenom, string rue, string codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO client (nom, prenom, rue, codePostal, ville, tel, email) VALUES ('" + nom + "','" + prenom + "', '" + rue + "', '" + codePostal + "' , '" + ville + "', '" + tel + "', '" + email + "')");
        }

        /// <summary>
        /// Modifie les informations d'un client
        /// </summary>
        /// <param name="id">Identifiant du client à modifier</param>
        /// <param name="nom">Nom du client à modifier</param>
        /// <param name="prenom">Prénom du client à modifier</param>
        /// <param name="rue">Rue du client à modifier</param>
        /// <param name="codePostal">Code postal du client à modifier</param>
        /// <param name="ville">Ville du client à modifier</param>
        /// <param name="tel">Téléphone du client à modifier</param>
        /// <param name="email">Email du client à modifier</param>
        public static void modifier(int id, string nom, string prenom, string rue, string codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("UPDATE client SET nom = '" + nom + "',prenom = '" + prenom + "',rue = '" + rue +"',codePostal ='" + codePostal + "',ville='" + ville + "', tel = '" + tel + "', email='" + email + "' WHERE id = " + id) ;
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM client WHERE id = " + id);
        }

    }
}
