using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsameRecuperoDebito_FerrariGiacomo
{
    internal class Persona
    {
        public string nome;
        public string cognome;
        int numeroCarta;
        int passwordCarta;
        string email;
        string passwordEmail;


        class Utente
        {
            int pinUtente;
            // Relativi metodi della classe Utente
        }
        class Amministratore
        {
            string emailAmministratore; // Email aggiuntiva (oltre a quella personale) del sito di compravendita dei mezzi (con relativa password)
            string paswordEmailAmministratore;
            static bool cambiaEmailAmministratore(string emailAmministratore)
            {
                return true;
            }
            // Relativi altri metodi della classe Amministratore
        }
        static bool cambiaPassword(string password)
        {
            return true;
        }
        // Relativi alrti metodi della classe Persona
    }
}
