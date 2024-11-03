using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionConnexion
    {
        public static bool VerifConnexion(string login, string mdp)
        {

            GestionBoutique.seConnecter();
            DataTable dtResultat = GestionBoutique.getTuplesRequeteSelect("SELECT * FROM utilisateur WHERE login ='" + login + "' and mdp='" + mdp + "'","VerifConnexion");

            if (dtResultat.Rows.Count == 0)
                return false;
            else
                return true;



        }

   
    }
}
