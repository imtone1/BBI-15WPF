using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BBI_15WPF
{
   
    public partial class MainWindow : Window
    {
        
        Boolean Mies = false;
        Boolean Nainen = false;
        string Uupumusteksti = "";
        string Kyynistyminenteksti = "";
        string Itsetuntoteksti = "";
        string Tyouupumusteksti = "";
        

        public MainWindow()
        {
            InitializeComponent();
           imgTaulukko.Visibility = Visibility.Hidden;
        }

        private void btnLaske_Click(object sender, RoutedEventArgs e)
        {
            int Uupumusyht = 0;
            int Kyynistyminenyht = 0;
            int Itsetuntoyht = 0;
            int Tyouupumusyht = 0;

            try
            {
                Uupumusyht =int.Parse(txt1.Text)+ int.Parse(txt4.Text)+ int.Parse(txt7.Text)+ int.Parse(txt10.Text)+int.Parse(txt13.Text);
                Kyynistyminenyht = int.Parse(txt2.Text) + int.Parse(txt5.Text) + int.Parse(txt8.Text) + int.Parse(txt11.Text) + int.Parse(txt14.Text);
                Itsetuntoyht = int.Parse(txt3.Text) + int.Parse(txt6.Text) + int.Parse(txt9.Text) + int.Parse(txt12.Text) + int.Parse(txt15.Text);
                Tyouupumusyht = Uupumusyht+Kyynistyminenyht+Itsetuntoyht;
            }
            catch (Exception)
            {
                MessageBox.Show("Annathan syötteen numeromuodossa.");
            }
            try {
            if (Mies==true)
            {
                if (int.Parse(txtIka.Text) < 30)
                {
                    //Uupumusasteinen väsyminen mies alle 30
                    if (Uupumusyht <15)
                    {Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                        lblU.Background = new SolidColorBrush(Colors.Green);
                        lblU.Content = Uupumusyht.ToString()+ " Uupumusasteinen väsyminen ei esiinny.";
                    }
                    else if (Uupumusyht >= 15 && Uupumusyht <= 16)
                    {
                        lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                        Uupumusteksti = "uupumusaisteinen väsyminen on lievää";
                        lblU.Content = Uupumusyht.ToString() + "Uupumusaisteinen väsyminen on lievää.";

                    }
                    else if (Uupumusyht >= 17 && Uupumusyht <= 20)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Yellow);
                        Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";

                    }
                    else if (Uupumusyht >= 21 )
                    {
                        lblU.Background = new SolidColorBrush(Colors.Red);
                        Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";
                    }

                    //Kyynistyminen mies alle 30
                    if (Kyynistyminenyht < 12)
                    {
                        lblK .Background = new SolidColorBrush(Colors.Green);
                        Kyynistyminenteksti = "kyynistyminen ei esiinny";
                        lblK.Content = Kyynistyminenyht.ToString()+ " Kyynistyminen ei esiinny.";
                    }
                    else if (Kyynistyminenyht == 12)
                    {
                        lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                        Kyynistyminenteksti = "kyynistyminen lievää";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                    }
                    else if (Kyynistyminenyht >= 13 && Kyynistyminenyht <= 16)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Yellow);
                        Kyynistyminenteksti = "kyynistyminen kohtalaista";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                    }
                    else if (Kyynistyminenyht >= 17)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Red);
                        Kyynistyminenteksti = "kyynistyminen vakavaa";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                    }
                    //Heikentynyt ammatillinen itsetunto mies alle 30

                    if (Itsetuntoyht < 14)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Green);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                    }
                    else if (Itsetuntoyht >= 14 && Itsetuntoyht <= 15)
                    {
                        lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                    }
                    else if (Itsetuntoyht >= 16 && Itsetuntoyht <= 19)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Yellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                    }
                    else if (Itsetuntoyht >= 20)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Red);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                    }
                    //Työuupumus mies alle 30

                    if (Tyouupumusyht < 14)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Green);
                        Tyouupumusteksti = "ei viittaa työuupumukseen.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                    }
                    else if (Tyouupumusyht >= 14 && Tyouupumusyht <= 15)
                    {
                        lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                        Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                    }
                    else if (Tyouupumusyht >= 16 && Tyouupumusyht <= 19)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Yellow);
                        Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                    }
                    else if (Tyouupumusyht >= 20)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Red);
                        Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                    }
                }
                
                if (int.Parse(txtIka.Text) >= 30 && int.Parse(txtIka.Text) <= 39)
                {
                    if (Uupumusyht < 18)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Green);
                        Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                        lblU.Content = Uupumusyht.ToString() + "Uupumusaisteista väsymistä ei esiinny";
                    }
                    else if (Uupumusyht >= 18 && Uupumusyht <= 19)
                    {
                        lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                        Uupumusteksti = "uupumusasteinen väsyminen on lievää";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on lievää.";

                    }
                    else if (Uupumusyht >= 20 && Uupumusyht <= 23)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Yellow);
                        Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";

                    }
                    else if (Uupumusyht >= 24)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Red);
                        Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";
                    }
                    //Kyynistyminen 30-39-vuotias mies 
                    if (Kyynistyminenyht <12 )

                    {
                        lblK.Background = new SolidColorBrush(Colors.Green);
                        Kyynistyminenteksti = "kyynistyminen ei esiinny";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen ei esiinny.";
                    }
                    else if (Kyynistyminenyht >= 12 && Kyynistyminenyht <= 13)
                    {
                        lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                        Kyynistyminenteksti = "kyynistyminen lievää";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                    }
                    else if (Kyynistyminenyht >= 14 && Kyynistyminenyht <= 17)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Yellow);
                        Kyynistyminenteksti = "kyynistyminen kohtalaista";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                    }
                    else if (Kyynistyminenyht >= 18)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Red);
                        Kyynistyminenteksti = "kyynistyminen vakavaa";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                    }
                    //Heikentynyt ammatillinen itsetunto 30-39-vuotias mies 

                    if (Itsetuntoyht < 16)

                    {
                        lblH.Background = new SolidColorBrush(Colors.Green);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                    }
                    else if (Itsetuntoyht >= 16 && Itsetuntoyht <= 17)
                    {
                        lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                    }
                    else if (Itsetuntoyht >= 18 && Itsetuntoyht <= 20)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Yellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                    }
                    else if (Itsetuntoyht >= 21)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Red);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                    }
                    //Työuupumus 30-39-vuotias mies

                    if (Tyouupumusyht < 45)

                    {
                        lblT.Background = new SolidColorBrush(Colors.Green);
                        Tyouupumusteksti = "ei viittaa työuupumukseen.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                    }
                    else if (Tyouupumusyht >= 45 && Tyouupumusyht <= 48)
                    {
                        lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                        Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                    }
                    else if (Tyouupumusyht >= 49 && Tyouupumusyht <= 56)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Yellow);
                        Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                    }
                    else if (Tyouupumusyht >= 57)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Red);
                        Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                    }
                }

                if (int.Parse(txtIka.Text) >= 40 && int.Parse(txtIka.Text) <= 49)
                {
                    if (Uupumusyht < 18)

                    {
                        lblU.Background = new SolidColorBrush(Colors.Green);
                        Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                        lblU.Content = Uupumusyht.ToString() + "Uupumusaisteista väsymistä ei esiinny";
                    }
                    else if (Uupumusyht >= 18 && Uupumusyht <= 19)
                    {
                        lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                        Uupumusteksti = "uupumusasteinen väsyminen on lievää";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on lievää.";

                    }
                    else if (Uupumusyht >= 20 && Uupumusyht <= 23)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Yellow);
                        Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";


                    }
                    else if (Uupumusyht >= 24)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Red);
                        Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";

                    }
                    //Kyynistyminen 40-49-vuotias mies 
                    if (Kyynistyminenyht < 13)


                    {
                        lblK.Background = new SolidColorBrush(Colors.Green);
                        Kyynistyminenteksti = "kyynistyminen ei esiinny";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen ei esiinny.";
                    }
                    else if (Kyynistyminenyht >= 13 && Kyynistyminenyht <= 14)
                    {
                        lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                        Kyynistyminenteksti = "kyynistyminen lievää";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                    }
                    else if (Kyynistyminenyht >= 15 && Kyynistyminenyht <= 18)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Yellow);
                        Kyynistyminenteksti = "kyynistyminen kohtalaista";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                    }
                    else if (Kyynistyminenyht >= 19)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Red);
                        Kyynistyminenteksti = "kyynistyminen vakavaa";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                    }
                    //Heikentynyt ammatillinen itsetunto 40-49-vuotias mies 

                    if (Itsetuntoyht < 17)

                    {
                        lblH.Background = new SolidColorBrush(Colors.Green);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                    }
                    else if (Itsetuntoyht >= 17 && Itsetuntoyht <= 18)
                    {
                        lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                    }
                    else if (Itsetuntoyht >= 19 && Itsetuntoyht <= 22)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Yellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                    }
                    else if (Itsetuntoyht >= 23)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Red);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                    }
                    //Työuupumus 40-49-vuotias mies 

                    if (Tyouupumusyht < 47)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Green);
                        Tyouupumusteksti = "ei viittaa työuupumukseen.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                    }
                    else if (Tyouupumusyht >= 47 && Tyouupumusyht <= 52)
                    {
                        lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                        Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                    }
                    else if (Tyouupumusyht >= 53 && Tyouupumusyht <= 60)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Yellow);
                        Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                    }
                    else if (Tyouupumusyht >= 61)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Red);
                        Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                    }

                }
                if (int.Parse(txtIka.Text) >= 50)
                {
                    if (Uupumusyht < 18)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Green);
                        Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                        lblU.Content = Uupumusyht.ToString() + "Uupumusaisteista väsymistä ei esiinny";
                    }
                    else if (Uupumusyht >= 18 && Uupumusyht <= 19)
                    {
                        lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                        Uupumusteksti = "uupumusasteinen väsyminen on lievää";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on lievää.";

                    }
                    else if (Uupumusyht >= 20 && Uupumusyht <= 22)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Yellow);
                        Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";

                    }
                    else if (Uupumusyht >= 23)
                    {
                        lblU.Background = new SolidColorBrush(Colors.Red);
                        Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                        lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";

                    }
                    //Kyynistyminen yli 50-vuotias mies 
                    if (Kyynistyminenyht < 14)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Green);
                        Kyynistyminenteksti = "kyynistyminen ei esiinny";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen ei esiinny.";
                    }
                    else if (Kyynistyminenyht >= 14 && Kyynistyminenyht <= 15)
                    {
                        lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                        Kyynistyminenteksti = "kyynistyminen lievää";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                    }
                    else if (Kyynistyminenyht >= 16 && Kyynistyminenyht <= 18)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Yellow);
                        Kyynistyminenteksti = "kyynistyminen kohtalaista";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                    }
                    else if (Kyynistyminenyht >= 19)
                    {
                        lblK.Background = new SolidColorBrush(Colors.Red);
                        Kyynistyminenteksti = "kyynistyminen vakavaa";
                        lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                    }
                    //Heikentynyt ammatillinen itsetunto yli 50-vuotias mies 

                    if (Itsetuntoyht < 17)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Green);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                    }
                    else if (Itsetuntoyht >= 17 && Itsetuntoyht <= 18)
                    {
                        lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                    }
                    else if (Itsetuntoyht >= 19 && Itsetuntoyht <= 23)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Yellow);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                    }
                    else if (Itsetuntoyht >= 24)
                    {
                        lblH.Background = new SolidColorBrush(Colors.Red);
                        Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                        lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                    }
                    //Työuupumus yli 50-vuotias mies 

                    if (Tyouupumusyht < 47)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Green);
                        Tyouupumusteksti = "ei viittaa työuupumukseen.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                    }
                    else if (Tyouupumusyht >= 47 && Tyouupumusyht <= 52)
                    {
                        lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                        Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                    }
                    else if (Tyouupumusyht >= 53 && Tyouupumusyht <= 62)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Yellow);
                        Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                    }
                    else if (Tyouupumusyht >= 63)
                    {
                        lblT.Background = new SolidColorBrush(Colors.Red);
                        Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                        lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                    }
                }
               
            }
          
                if (Nainen == true)
                {
                    if (int.Parse(txtIka.Text) < 30)
                    {
                        //Uupumusasteinen väsyminen nainen alle 30
                        if (Uupumusyht < 14)

                        {
                            lblU.Background = new SolidColorBrush(Colors.Green);
                            Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                            lblU.Content = Uupumusyht.ToString() + "Uupumusaisteista väsymistä ei esiinny";

                        }
                        else if (Uupumusyht >= 14 && Uupumusyht <= 15)
                        {

                            lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on lievää";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on lievää.";

                        }
                        else if (Uupumusyht >= 16 && Uupumusyht <= 20)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Yellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";


                        }
                        else if (Uupumusyht >= 21)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Red);
                            Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";

                        }

                        //Kyynistyminen nainen alle 30
                        if (Kyynistyminenyht < 12)

                        {
                            lblK.Background = new SolidColorBrush(Colors.Green);
                            Kyynistyminenteksti = "kyynistyminen ei esiinny";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen ei esiinny.";
                        }
                        else if (Kyynistyminenyht == 12)
                        {
                            lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                            Kyynistyminenteksti = "kyynistyminen lievää";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                        }
                        else if (Kyynistyminenyht >= 13 && Kyynistyminenyht <= 16)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Yellow);
                            Kyynistyminenteksti = "kyynistyminen kohtalaista";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                        }
                        else if (Kyynistyminenyht >= 17)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Red);
                            Kyynistyminenteksti = "kyynistyminen vakavaa";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                        }
                        //Heikentynyt ammatillinen itsetunto nainen alle 30

                        if (Itsetuntoyht < 15)

                        {
                            lblH.Background = new SolidColorBrush(Colors.Green);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                        }
                        else if (Itsetuntoyht == 15)
                        {
                            lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                        }
                        else if (Itsetuntoyht >= 16 && Itsetuntoyht <= 20)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Yellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                        }
                        else if (Itsetuntoyht >= 21)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Red);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                        }
                        //Työuupumus nainen alle 30

                        if (Tyouupumusyht < 39)

                        {
                            lblT.Background = new SolidColorBrush(Colors.Green);
                            Tyouupumusteksti = "ei viittaa työuupumukseen.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                        }
                        else if (Tyouupumusyht >= 39 && Tyouupumusyht <= 42)
                        {
                            lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                            Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                        }
                        else if (Tyouupumusyht >= 43 && Tyouupumusyht <= 52)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Yellow);
                            Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                        }
                        else if (Tyouupumusyht >= 53)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Red);
                            Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                        }
                    }

                    if (int.Parse(txtIka.Text) >= 30 && int.Parse(txtIka.Text) <= 39)
                    {
                        if (Uupumusyht < 18)

                        {
                            lblU.Background = new SolidColorBrush(Colors.Green);
                            Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                            lblU.Content = Uupumusyht.ToString() + "Uupumusaisteista väsymistä ei esiinny";
                        }
                        else if (Uupumusyht >= 18 && Uupumusyht <= 19)
                        {
                            lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on lievää";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on lievää.";

                        }
                        else if (Uupumusyht >= 20 && Uupumusyht <= 23)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Yellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";

                        }
                        else if (Uupumusyht >= 24)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Red);
                            Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";

                        }
                        //Kyynistyminen 30-39-vuotias nainen 
                        if (Kyynistyminenyht < 12)


                        {
                            lblK.Background = new SolidColorBrush(Colors.Green);
                            Kyynistyminenteksti = "kyynistyminen ei esiinny";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen ei esiinny.";
                        }
                        else if (Kyynistyminenyht >= 12 && Kyynistyminenyht <= 13)
                        {
                            lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                            Kyynistyminenteksti = "kyynistyminen lievää";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                        }
                        else if (Kyynistyminenyht >= 14 && Kyynistyminenyht <= 17)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Yellow);
                            Kyynistyminenteksti = "kyynistyminen kohtalaista";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                        }
                        else if (Kyynistyminenyht >= 18)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Red);
                            Kyynistyminenteksti = "kyynistyminen vakavaa";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                        }
                        //Heikentynyt ammatillinen itsetunto 30-39-vuotias nainen

                        if (Itsetuntoyht < 17)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Green);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                        }
                        else if (Itsetuntoyht >= 17 && Itsetuntoyht <= 18)
                        {
                            lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                        }
                        else if (Itsetuntoyht >= 19 && Itsetuntoyht <= 22)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Yellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                        }
                        else if (Itsetuntoyht >= 23)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Red);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                        }
                        //Työuupumus 30-39-vuotias nainen

                        if (Tyouupumusyht < 45)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Green);
                            Tyouupumusteksti = "ei viittaa työuupumukseen.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                        }
                        else if (Tyouupumusyht >= 45 && Tyouupumusyht <= 49)
                        {
                            lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                            Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                        }
                        else if (Tyouupumusyht >= 50 && Tyouupumusyht <= 60)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Yellow);
                            Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                        }
                        else if (Tyouupumusyht >= 61)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Red);
                            Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                        }
                    }

                    if (int.Parse(txtIka.Text) >= 40 && int.Parse(txtIka.Text) <= 49)
                    {
                        if (Uupumusyht < 18)


                        {
                            lblU.Background = new SolidColorBrush(Colors.Green);
                            Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                            lblU.Content = Uupumusyht.ToString() + "Uupumusaisteista väsymistä ei esiinny";
                        }
                        else if (Uupumusyht >= 18 && Uupumusyht <= 19)
                        {
                            lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on lievää";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on lievää.";

                        }
                        else if (Uupumusyht >= 20 && Uupumusyht <= 24)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Yellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";

                        }
                        else if (Uupumusyht >= 25)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Red);
                            Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";

                        }
                        //Kyynistyminen 40-49-vuotias nainen
                        if (Kyynistyminenyht < 12)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Green);
                            Kyynistyminenteksti = "kyynistyminen ei esiinny";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen ei esiinny.";
                        }
                        else if (Kyynistyminenyht >= 12 && Kyynistyminenyht <= 13)
                        {
                            lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                            Kyynistyminenteksti = "kyynistyminen lievää";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                        }
                        else if (Kyynistyminenyht >= 14 && Kyynistyminenyht <= 17)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Yellow);
                            Kyynistyminenteksti = "kyynistyminen kohtalaista";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                        }
                        else if (Kyynistyminenyht >= 18)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Red);
                            Kyynistyminenteksti = "kyynistyminen vakavaa";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                        }
                        //Heikentynyt ammatillinen itsetunto 40-49-vuotias nainen

                        if (Itsetuntoyht < 17)


                        {
                            lblH.Background = new SolidColorBrush(Colors.Green);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                        }
                        else if (Itsetuntoyht >= 17 && Itsetuntoyht <= 18)
                        {
                            lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                        }
                        else if (Itsetuntoyht >= 19 && Itsetuntoyht <= 22)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Yellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                        }
                        else if (Itsetuntoyht >= 23)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Red);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                        }
                        //Työuupumus 40-49-vuotias nainen 

                        if (Tyouupumusyht < 45)

                        {
                            lblT.Background = new SolidColorBrush(Colors.Green);
                            Tyouupumusteksti = "ei viittaa työuupumukseen.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                        }
                        else if (Tyouupumusyht >= 45 && Tyouupumusyht <= 50)
                        {
                            lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                            Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                        }
                        else if (Tyouupumusyht >= 51 && Tyouupumusyht <= 61)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Yellow);
                            Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                        }
                        else if (Tyouupumusyht >= 62)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Red);
                            Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                        }

                    }
                    if (int.Parse(txtIka.Text) >= 50)
                    {
                        if (Uupumusyht < 18)

                        {
                            lblU.Background = new SolidColorBrush(Colors.Green);
                            Uupumusteksti = "uupumusasteista väsymistä ei esiinny";
                            lblU.Content = Uupumusyht.ToString() + "Uupumusaisteista väsymistä ei esiinny";
                        }
                        else if (Uupumusyht >= 18 && Uupumusyht <= 19)
                        {
                            lblU.Background = new SolidColorBrush(Colors.GreenYellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on lievää";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on lievää.";

                        }
                        else if (Uupumusyht >= 20 && Uupumusyht <= 23)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Yellow);
                            Uupumusteksti = "uupumusasteinen väsyminen on kohtalaista";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on kohtalaista.";

                        }
                        else if (Uupumusyht >= 24)
                        {
                            lblU.Background = new SolidColorBrush(Colors.Red);
                            Uupumusteksti = "uupumusasteinen väsyminen on vakavaa";
                            lblU.Content = Uupumusyht.ToString() + " Uupumusasteinen väsyminen on vakavaa.";
                        }
                        //Kyynistyminen yli 50-vuotias nainen
                        if (Kyynistyminenyht < 14)

                        {
                            lblK.Background = new SolidColorBrush(Colors.Green);
                            Kyynistyminenteksti = "kyynistyminen ei esiinny";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen ei esiinny.";
                        }
                        else if (Kyynistyminenyht >= 14 && Kyynistyminenyht <= 15)
                        {
                            lblK.Background = new SolidColorBrush(Colors.GreenYellow);
                            Kyynistyminenteksti = "kyynistyminen lievää";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on lievää.";

                        }
                        else if (Kyynistyminenyht >= 16 && Kyynistyminenyht <= 19)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Yellow);
                            Kyynistyminenteksti = "kyynistyminen kohtalaista";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on kohtalaista.";

                        }
                        else if (Kyynistyminenyht >= 20)
                        {
                            lblK.Background = new SolidColorBrush(Colors.Red);
                            Kyynistyminenteksti = "kyynistyminen vakavaa";
                            lblK.Content = Kyynistyminenyht.ToString() + " Kyynistyminen on vakavaa.";
                        }
                        //Heikentynyt ammatillinen itsetunto yli 50-vuotias nainen 

                        if (Itsetuntoyht < 18)

                        {
                            lblH.Background = new SolidColorBrush(Colors.Green);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen ei esiinny";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto ei esiinny.";
                        }
                        else if (Itsetuntoyht >= 18 && Itsetuntoyht <= 19)
                        {
                            lblH.Background = new SolidColorBrush(Colors.GreenYellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on lievää";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on lievää.";

                        }
                        else if (Itsetuntoyht >= 20 && Itsetuntoyht <= 23)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Yellow);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on kohtalaista";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on kohtalaista.";

                        }
                        else if (Itsetuntoyht >= 24)
                        {
                            lblH.Background = new SolidColorBrush(Colors.Red);
                            Itsetuntoteksti = "ammatillisen itsetunnon heikkeneminen on vakavaa";
                            lblH.Content = Itsetuntoyht.ToString() + " Heikentynyt ammatillinen itsetunto on vakavaa.";
                        }
                        //Työuupumus yli 50-vuotias nainen

                        if (Tyouupumusyht < 48)

                        {
                            lblT.Background = new SolidColorBrush(Colors.Green);
                            Tyouupumusteksti = "ei viittaa työuupumukseen.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus ei esiinny.";
                        }
                        else if (Tyouupumusyht >= 48 && Tyouupumusyht <= 53)
                        {
                            lblT.Background = new SolidColorBrush(Colors.GreenYellow);
                            Tyouupumusteksti = "viittaa lievän työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on lievä.";

                        }
                        else if (Tyouupumusyht >= 54 && Tyouupumusyht <= 63)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Yellow);
                            Tyouupumusteksti = "viittaa kohtalaisen työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on kohtalaista.";

                        }
                        else if (Tyouupumusyht >= 64)
                        {
                            lblT.Background = new SolidColorBrush(Colors.Red);
                            Tyouupumusteksti = "viittaa vakavan työuupumuksen oireisiin.";
                            lblT.Content = Tyouupumusyht.ToString() + " Työuupumus on on vakavaa.";
                        }
                    }
                }
            }
        
            catch (Exception)
            {
                MessageBox.Show("Syötähän iän.");
            }
    txtTeksti.Text = "Työuupumusta arvioivan BBI-15 kyselyn kokonaispistemäärä (T=" +Tyouupumusyht.ToString() +") "+ Tyouupumusteksti+ " Yksittäisistä työuupumusoireasteikoista " + Uupumusteksti+ " (U="+ Uupumusyht.ToString()+ "), " + Kyynistyminenteksti+ " (K=" + Kyynistyminenyht.ToString() +") ja "+ Itsetuntoteksti+" (H="+ Itsetuntoyht.ToString() +").";


        }

        private void rdbtnMies_Checked(object sender, RoutedEventArgs e)
        {
            Mies = true;
        }

        private void rdbtnNainen_Checked(object sender, RoutedEventArgs e)
        {
            Nainen = true;
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        
        private void btnTaulukko_Click(object sender, RoutedEventArgs e)
        {
            if (imgTaulukko.Visibility == Visibility.Hidden)
            {
                imgTaulukko.Visibility = Visibility.Visible;
            }
            else imgTaulukko.Visibility = Visibility.Hidden;
        }
    }
}
