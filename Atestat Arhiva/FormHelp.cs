using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Arhiva
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void UnvisitLinks()
        {
            linkLabelIntro.LinkVisited = false;
            linkLabelAdProb.LinkVisited = false;
            linkLabelModifProb.LinkVisited = false;
            linkLabelEditCateg.LinkVisited = false;
            linkLabelSearch.LinkVisited = false;
            linkLabelDoc.LinkVisited = false;
        }

        private void linkLabelIntro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnvisitLinks();
            linkLabelIntro.LinkVisited = true;

            Bitmap bmp = new Bitmap(global::Atestat_Arhiva.Properties.Resources.ico_main, new Size(pbMain.Width, pbMain.Height));
            pbMain.Image = bmp;
            labelMain.Text = "    Bine ați venit! Arhivex este o aplicație gratuită, creată de Suditu Thomas-Cristian (Buzău,\nRomânia). Aceasta oferă posibilitatea de a salva toate problemele într-un singur loc, utilă\npentru profesori și nu numai.";
        }

        private void linkLabelAdProb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnvisitLinks();
            linkLabelAdProb.LinkVisited = true;

            Bitmap bmp = new Bitmap(global::Atestat_Arhiva.Properties.Resources.help1, new Size(pbMain.Width, pbMain.Height));
            pbMain.Image = bmp;
            labelMain.Text = "    Pentru a adăuga o problemă nouă se apasă pe butonul 'Adaugă problemă' din fereastra \nprincipală. "
                + "Este necesară completarea câmpurilor obligatorii (enunțul problemei și cuvintele \ncheie) și încadrarea problemei într-o subcategorie existentă."
                + "Odată adăugată, fiecare problemă\nva primi un ID unic după care va fi identificată. Acesta nu poate fi schimbat de utilizator.\n"
                + "    Butonul 'Atașează imagine' permite utilizatorului să atașeze o imagine problemei, ce poate fi \nvizualizată dând click pe butonul de atașamente, ce devine vizibil după încarcarea imaginii, \nîn dreapta butonului.\n"
                + "    Butonul 'Resetează' șterge informațiile din toate câmpurile text și șterge atașamentul.\n";
        }

        private void linkLabelModifProb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnvisitLinks();
            linkLabelModifProb.LinkVisited = true;

            Bitmap bmp = new Bitmap(global::Atestat_Arhiva.Properties.Resources.help2, new Size(pbMain.Width, pbMain.Height));
            pbMain.Image = bmp;
            labelMain.Text = "    Odată selectată, o problemă poate fi modificată apăsând butonul 'Modificare problemă'.\nAcest pas este similar cu adăugarea unei noi probleme, doar că aceasta se salvează peste\nproblema selectată.\n"
                + "    Se pot modifica de asemenea subcategoria sau categoria din care face parte problema sau\nse poate schimba / șterge imaginea atașată.\n";
        }

        private void linkLabelEditCateg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnvisitLinks();
            linkLabelEditCateg.LinkVisited = true;

            Bitmap bmp = new Bitmap(global::Atestat_Arhiva.Properties.Resources.help3, new Size(pbMain.Width, pbMain.Height));
            pbMain.Image = bmp;
            labelMain.Text = "    În cutia text se va scrie numele categoriei / subcategoriei pe care doriți să o creați. Prin\napăsarea butonului 'Adaugă categorie' se va creea o nouă categorie. Prin apăsarea butonului\n'Adaugă subcategorie' se va creea o nouă subcategorie, dar aceasta necesită selectarea\nunei categorii (click pe numele unei categorii din cele afișate).\n"
                + "    Prin selectarea unei categorii / subcategorii și apăsarea butonului de ștergere, aceasta va\nfi ștearsă doar dacă nu are conținut.\n";
        }

        private void linkLabelSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnvisitLinks();
            linkLabelSearch.LinkVisited = true;

            Bitmap bmp = new Bitmap(global::Atestat_Arhiva.Properties.Resources.help4, new Size(pbMain.Width, pbMain.Height));
            pbMain.Image = bmp;
            labelMain.Text = "    Utilizând meniul din fereastra principală, se va face click pe 'Fișier', apoi pe 'Căutare\nprobleme', deschizându-se astfel o nouă fereastră.\n"
                + "    Căutarea se realizează prin scrierea in căsuța text a cuvintelor după care se dorește a fi\nfăcută căutarea și alegerea unui criteriu (după cuvinte cheie, după subcategorie, după data\nadăugării).\n"
                + "    Se va apăsa pe butonul 'Caută', deschizând o listă a problemelor ce întrunesc cerințele date\nde utilizator. Prin apăsarea pe o problemă, aceasta va fi selectată, iar prin dublu-click se va\ndeschide in fereastra principală.\n";
        }

        private void linkLabelDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnvisitLinks();
            linkLabelDoc.LinkVisited = true;

            Bitmap bmp = new Bitmap(global::Atestat_Arhiva.Properties.Resources.help5, new Size(pbMain.Width, pbMain.Height));
            pbMain.Image = bmp;
            labelMain.Text = "    Pentru a creea un Document Word (*.docx) se va apăsa butonul 'Creează document nou'.\nOdată ce acesta a fost apăsat și o problemă este selectată, ea poate fi adăugată în document\nprin apăsarea butonului 'Adaugă problemă curentă'.\n"
                + "    Există și opțiunea 'Adaugă problemă aleatoare', care va adăuga in document una dintre\nproblemele care îndeplinesc condițiile utilizatorului (problemele afișate în listă).\n"
                + "    Butonul 'Deschide document curent' va deschide documentul creeat. Dar atenție! Este\nimportant ca documentul să fie închis înainte de a fi modificat din nou, pentru că altfel va\ngenera o eroare.\n";
        }
    }
}
