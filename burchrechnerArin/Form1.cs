using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burchrechnerArin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            try         //Try Function to catch all Exceptions
            {
                int fInteger = Convert.ToInt32(firstInteger.Text);      //Input of the varibel (Standard Setting to 0
                int fCounter = Convert.ToInt32(counterOne.Text);
                int fDeno = Convert.ToInt32(firstDenominator.Text);

                int sInteger = Convert.ToInt32(secondInteger.Text);
                int sCounter = Convert.ToInt32(secondConter.Text);
                int sDeno = Convert.ToInt32(secondDenominator.Text);


                        //If statemens to proof what needs to Calculate
                        // if the radio button is true the following function will Calculate
                if (plus.Checked == true)
                {
                    Add(fInteger,fCounter,fDeno,sInteger,sCounter,sDeno);   // Jump to the Add function with the named Parameter
                }
                else if (minus.Checked == true)
                {
                    Minus(fInteger, fCounter, fDeno, sInteger, sCounter, sDeno);    // Jump to the Minus function with the named Parameter
                }
                else if (times.Checked == true)
                {
                    Times(fInteger, fCounter, fDeno, sInteger, sCounter, sDeno);    // Jump to the Times function with the named Parameter
                }
                else if (divide.Checked == true)
                {
                    Divided(fInteger, fCounter, fDeno, sInteger, sCounter, sDeno);  // // Jump to the Divided function with the named Parameter
                }
                else if (carrotTwo.Checked == true)
                {
                    Square(fInteger, fCounter, fDeno);  // Jump to the Square function with the named Parameter
                }
                else if (root.Checked == true)
                {
                    double counter = fInteger * fDeno + fCounter;       //creating a counter of the first fraction
                    double fraction = counter / fDeno;                  // making the whole fraction to decimal number
                    MessageBox.Show(Convert.ToString(fraction));        //Print the Fraction decimal
                    MessageBox.Show(Convert.ToString(Root(fraction)));  //Jump to Root dunction with fraction as parameter
                }
                else
                    MessageBox.Show("Wählen sie eine Rechenart aus");   //if no radio button is selected
            }
            catch (Exception)   // catch all exceptions
            {
                MessageBox.Show("Geben sie Gültige werte an");          //exception error message
            }
        }

        public void Add(int fInteger, int fCounter, int fDeno, int sInteger, int sCounter, int sDeno)
        {
            int fractionDeno = fDeno * sDeno;                                                                           // is making the Denomation(nenner)
            int fractionCounter = (((fInteger * fDeno + fCounter) * sDeno) + ((sInteger * sDeno + sCounter) * fDeno));  //Algorithm to calculate fraction add
            int fractionInteger = fractionCounter / fractionDeno;                                                       //calculating the integer of the Function

            //Output of the raw fraction
            FRCounter.Text = Convert.ToString(fractionCounter);
            fRDenominator.Text = Convert.ToString(fractionDeno);

            // Jumping to the Shorting function
            Shorting(fractionCounter, fractionInteger, fractionDeno);
        }

        public void Minus(int fInteger, int fCounter, int fDeno, int sInteger, int sCounter, int sDeno)
        {
            int fractionDeno = fDeno * sDeno;                                                                           // is making the Denomation(nenner)
            int fractionCounter = (((fInteger * fDeno + fCounter) * sDeno) - ((sInteger * sDeno + sCounter) * fDeno));  //Algorithm to calculate fraction minus
            int fractionInteger = fractionCounter / fractionDeno;                                                       //calculating the integer of the Function

            //Output of the raw fraction
            FRCounter.Text = Convert.ToString(fractionCounter);
            fRDenominator.Text = Convert.ToString(fractionDeno);

            // Jumping to the Shorting function
            Shorting(fractionCounter, fractionInteger, fractionDeno);
        }

        public void Times(int fInteger, int fCounter, int fDeno, int sInteger, int sCounter, int sDeno)
        {
            int fractionCounter = (fInteger * fDeno + fCounter) * (sInteger * sDeno + sCounter);    //Algorithm to calculate fraction multiply
            int fractionDeno = fDeno * sDeno;                                                       // is making the Denomation(nenner)
            int fractionInteger = fractionCounter / fractionDeno;                                   //calculating the integer of the Function

            //Output of the raw fraction
            FRCounter.Text = Convert.ToString(fractionCounter);
            fRDenominator.Text = Convert.ToString(fractionDeno);

            // Jumping to the Shorting function
            Shorting(fractionCounter, fractionInteger, fractionDeno);
        }

        public void Divided(int fInteger, int fCounter, int fDeno, int sInteger, int sCounter, int sDeno)
        {
            int fractionCounter = (fInteger * fDeno + fCounter) * sDeno;    //taking the reciprocal(Kehrwert) and multiplay
            int fractionDeno    = (sInteger * sDeno + sCounter) * fDeno;    //same as above
            int fractionInteger = fractionCounter / fractionDeno;           //calculating the integer of the Function

            //Output of the raw fraction
            fRDenominator.Text = Convert.ToString(fractionDeno);
            FRCounter.Text = Convert.ToString(fractionCounter);

            // Jumping to the Shorting function
            Shorting(fractionCounter, fractionInteger, fractionDeno);
        }

        public void Square(int fInteger, int fCounter, int fDeno)
        {
            int fractionCounter = (fInteger * fDeno + fCounter) * (fInteger * fDeno + fCounter);    //Algorithm to calculate fraction multiply
            int fractionDeno = fDeno * fDeno;                                                       // is making the Denomation(nenner)
            int fractionInteger = fractionCounter / fractionDeno;                                   //calculating the integer of the Function

            //Output of the raw fraction
            FRCounter.Text = Convert.ToString(fractionCounter);
            fRDenominator.Text = Convert.ToString(fractionDeno);

            // Jumping to the Shorting function
            Shorting(fractionCounter, fractionInteger, fractionDeno);
        }

        public static double Root(double calc)      //Binary numeral system Algorithm (Thanks Github now you are dead)
        {
            double precision = 0.00001;     //the precision of the root
            double low = 0;                 //the low point
            double high = calc;             //the user input is high
            double mid = 0;                 //the mid point
            while ((high - low) > precision)    //while this parameter
            {
                mid = (double)((low + high) / 2);

                //if tree that runs as long mid is smaler mid*mid then mid - precision and mid is greater then precision plus mid
                if ((mid - precision) >= mid * mid && mid * mid <= (precision + mid))                
                    break;//it to the limit
                
                else if (mid * mid < calc)    
                    low = mid;
                
                else                
                    high = mid;
            }
            return mid;
        }

        public void Shorting(int fractionCounter, int fractionInteger, int fractionDeno)
        {
            int Rest = fractionCounter - fractionInteger * fractionDeno;
            int ggt = berechneGgt(Rest, fractionDeno);

            //Output of the raw fraction
            sRInteger.Text = Convert.ToString(fractionInteger);
            sRCounter.Text = Convert.ToString(Kürze(Rest, ggt));
            sRDenominator.Text = Convert.ToString(Kürze(fractionDeno, ggt));
        }
        public int berechneGgt(int Zaehler, int Nenner) //Euklidischer Algorithmus
        {
            int zahl1 = Zaehler;
            int zahl2 = Nenner;
            int temp = 0;
            int ggt = 0;                 

            while (zahl1 % zahl2 != 0)
            {
                temp = zahl1 % zahl2;
                zahl1 = zahl2;
                zahl2 = temp;
            }
            ggt = zahl2;

            return ggt;
        }
        public int Kürze(int Zahl, int ggt)
        {
            int ZahlRef = Zahl;
            int ggtRef = ggt;

            int Ergebniss = ZahlRef / ggtRef;

            return Ergebniss;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //The Help box is a Message Box (wie Intiligent ¯\_(ツ)_/¯)
            MessageBox.Show
                ("Hilfecenter\n\n\n" +
                "Auswahl Menüs\n" +
                "+  : Addiert zwei Brüche.\n" +
                "-   : Subtrahiert zwei Brüche.\n" +
                "*   : Multipliziert zwei Brüche.\n" +
                "/   : Dividiert zwei Brüche.\n" +
                "√  : Nimmt die Wurzel aus den 1. Bruch.\n" +
                "x² : Quadriert die erste Zahl"+
                "\n\n" +
                "Box vor dem Bruchstrich:\n Ganzzahl.\n"+
                "Box über den Bruchstrich:\n Zähler.\n"+
                "Box unter den Bruchstrich:\n Nenner.\n\n" +
                "1. Ergebnis ungekürzt\n"+
                "2. Ergebnis gekürzt\n\n"+
                "Credits: Arin\n" +
                "Lines of Code: 252\n"+
                "(づ｡◕‿‿◕｡)づ"
                );
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstInteger_TextChanged(object sender, EventArgs e)
        {
        }

        private void FRCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //Clearing all inputs
            firstInteger.Text = "0";
            counterOne.Text = "0";
            firstDenominator.Text = "0";
            secondConter.Text = "0";
            secondDenominator.Text = "0";
            secondInteger.Text = "0";
        }
    }
}
