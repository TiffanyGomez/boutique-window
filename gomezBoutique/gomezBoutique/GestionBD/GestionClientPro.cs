using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionClientPro
    {
        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from clientPro", "TousLesClientsPro");

        }

        public static DataTable getNoms()
        {
            return GestionBoutique.getTuplesRequeteSelect("select nom from clientPro", "TousLesClientsPro");

        }


        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesByNom(string nom)
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from clientPro where nom = '" + nom + "'", "TousLesClientsPro");
        }



        /// <summary>
        /// Retourne la liste des Patronymes de Clients : id et NOM prenom)
        /// </summary>
        /// <returns></returns>
        public static DataTable getPatronymes()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT id, CONCAT(UPPER(nom),' ',prenom) AS Patronyme FROM clientPro", "TousLesPatronymesClientsPro");
        }

        /// <summary>
        /// Retourne le nombre de clientPro
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from clientPro"));
        }

        /// <summary>
        /// Ajoute un clientPro
        /// </summary>
        /// <param name="nom">Nom du clientPro</param>
        /// <param name="prenom">Prénom du clientPro</param>
        /// <param name="rue">Rue du clientPro</param>
        /// <param name="codePostal">Code postal du clientPro</param>
        /// <param name="ville">Ville du clientPro</param>
        /// <param name="tel">Téléphone du clientPro</param>
        /// <param name="email">Email du clientPro</param>
        public static void ajouter(string nom, string prenom, string rue, string codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO clientPro (nom, prenom, rue, codePostal, ville, tel, email) VALUES ('" + nom + "','" + prenom + "', '" + rue + "', '" + codePostal + "' , '" + ville + "', '" + tel + "', '" + email + "')");
        }

        /// <summary>
        /// Modifie les informations d'un clientPro
        /// </summary>
        /// <param name="id">Identifiant du clientPro à modifier</param>
        /// <param name="nom">Nom du clientPro à modifier</param>
        /// <param name="prenom">Prénom du clientPro à modifier</param>
        /// <param name="rue">Rue du clientPro à modifier</param>
        /// <param name="codePostal">Code postal du clientPro à modifier</param>
        /// <param name="ville">Ville du clientPro à modifier</param>
        /// <param name="tel">Téléphone du clientPro à modifier</param>
        /// <param name="email">Email du clientPro à modifier</param>
        public static void modifier(int id, string nom, string prenom, string rue, string codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("UPDATE clientPro SET nom = '" + nom + "',prenom = '" + prenom + "',rue = '" + rue + "',codePostal ='" + codePostal + "',ville='" + ville + "', tel = '" + tel + "', email='" + email + "' WHERE id = " + id);
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM clientPro WHERE id = " + id);
        }
    }
}
