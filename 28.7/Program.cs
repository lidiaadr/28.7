using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Albergo albergo = new Albergo(); //il contesto
            //prima richiesta
            Prenotazione nuovaPrenotazione = new Prenotazione();
            nuovaPrenotazione.Anno = DateTime.Now.Year;
            Console.WriteLine("Data di Prenotazione: ");
            nuovaPrenotazione.DataPrenotazione = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Periodoo di permanenza: ");
            nuovaPrenotazione.PeriodoPrenotazione = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Caparra versata: ");
            nuovaPrenotazione.Caparra = float.Parse(Console.ReadLine());
            Console.WriteLine("Tariffa: ");
            nuovaPrenotazione.Tariffa = float.Parse(Console.ReadLine());

            albergo.Prenotazioni.Add(nuovaPrenotazione); //aggiungo la nuova prenotazione 

            //seonda richiesta
            foreach(Prenotazione prenotazione in albergo.Prenotazioni)
            {
                Console.WriteLine("inserisci il numero che stai cercando: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci l'anno che stai cercando: ");
                int anno = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    Console.WriteLine(numero);
                }
                else
                    Console.WriteLine("Numero prenotazione inesistente");
                if (anno != 0)
                    Console.WriteLine(anno);
                else
                    Console.WriteLine("Anno della prenotazione inesistente");
            }

            //Per ogni prenotazione spampare una scheda riassuntiva con tutti i dati significativi
            foreach (Prenotazione prenotazione in albergo.Prenotazioni)
            {
                Console.WriteLine(prenotazione.DataPrenotazione);
                Console.WriteLine(prenotazione.Anno);
                Console.WriteLine(prenotazione.PeriodoPrenotazione);
                Console.WriteLine(prenotazione.Servizi);
                Console.WriteLine(albergo.Clienti);
            }
            //Per ogni prenotazione stampa una scheda riassuntiva con i pagamenti effettuati 
            foreach (Prenotazione prenotazione in albergo.Prenotazioni)
            {
                Console.WriteLine(prenotazione.Caparra);
                Console.WriteLine(prenotazione.Tariffa);    
            }
        }
    }
}
