using System;
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
using WpfBasics.function;

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Matrice matrice1, matrice2;
        Complexe complexe1, complexe2;
        String operation;
        int reel = 0;
        int imaginaire = 0;
        List<int> numberClicked1;
        List<int> numberClicked2;

        String strNumberOne;
        String strNumberTwo;
        /*List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();*/

        public MainWindow()
        {
            InitializeComponent();
            matrice1 = new Matrice(2, 2);
            matrice2 = new Matrice(2, 2);
            complexe1 = new Complexe(reel, imaginaire);
            complexe2 = new Complexe(reel, imaginaire);
            operation = "";
            numberClicked1 = new List<int>();
            numberClicked2 = new List<int>();
            strNumberOne = "";
            strNumberTwo = "";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            if(operation == "")
            {
                strNumberOne += strNumberOne + "1";
                txtDisplay.Text += "1";
            }
            else
            {
                strNumberTwo += "1";
                txtDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "2";
                txtDisplay.Text += "2";
            }
            else
            {
                strNumberTwo += "2";
                txtDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "3";
                txtDisplay.Text += "3";
            }
            else
            {
                strNumberTwo += "3";
                txtDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "4";
                txtDisplay.Text += "4";
            }
            else
            {
                strNumberTwo += "4";
                txtDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "5";
                txtDisplay.Text += "5";
            }
            else
            {
                strNumberTwo += "5";
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "6";
                txtDisplay.Text += "6";
            }
            else
            {
                strNumberTwo += "6";
                txtDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "7";
                txtDisplay.Text += "7";
            }
            else
            {
                strNumberTwo += "7";
                txtDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "8";
                txtDisplay.Text += "8";
            }
            else
            {
                strNumberTwo += "8";
                txtDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "9";
                txtDisplay.Text += "9";
            }
            else
            {
                strNumberTwo += "9";
                txtDisplay.Text += "9";
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                strNumberOne += strNumberOne + "0";
                txtDisplay.Text += "0";
            }
            else
            {
                strNumberTwo += "0";
                txtDisplay.Text += "0";
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            
            txtDisplay.Text = txtDisplay.Text + "\n+\n";
        }

        private static Complexe SommeComplexe(params Complexe[] complexes)
        {
            Complexe resultat = new Complexe(0, 0);

            for (int i = 0; i < complexes.Length; i++)
            {
                resultat.Reel += complexes[i].Reel;
                resultat.Imaginaire += complexes[i].Imaginaire;
            }
            return resultat;
        }

        private static Matrice SommeMatrice(Matrice[] matrices)
        {
            Matrice resultat = new Matrice(2, 2);
            for (int i = 0; i < matrices.Length; i++)
            {
                resultat[0, 0] += (matrices[i])[0, 0];
                resultat[0, 1] += (matrices[i])[0, 1];
                resultat[1, 0] += (matrices[i])[1, 0];
                resultat[1, 1] += (matrices[i])[1, 1];
            }
            return resultat;
        }

        static dynamic Somme<T>(params T[] entites)
        {
            object resultat;
            if (entites as Complexe[] != null)
            {
                Complexe[] complexes = entites as Complexe[];
                resultat = SommeComplexe(complexes);
                return (Complexe)resultat;
            }
            else if (entites as Matrice[] != null)
            {
                Matrice[] matrices = entites as Matrice[];
                resultat = SommeMatrice(matrices);
                return (Matrice)resultat;
            }
            else
                throw new InvalidOperationException("Objets non conformes");
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            /*numberClicked1 = strNumberOne.Split(' ').ToList().Select(nbTemp => Convert.ToInt32(nbTemp)).ToList();
            numberClicked2 = strNumberTwo.Split(' ').ToList().Select(nbTemp => Convert.ToInt32(nbTemp)).ToList();*/

            if (matrice.IsSelected)
            {
                string[] split1 = strNumberOne.Split(' ');
                string[] split2 = strNumberTwo.Split(' ');
                for (int i = 0; i < 4; i++)
                {
                    numberClicked1.Add(int.Parse(split1[i]));
                    numberClicked2.Add(int.Parse(split2[i]));
                }

                matrice1[0, 0] = numberClicked1[0];
                matrice1[0, 1] = numberClicked1[1];
                matrice1[1, 0] = numberClicked2[2];
                matrice1[1, 1] = numberClicked2[3];

                matrice2[0, 0] = numberClicked2[0];
                matrice2[0, 1] = numberClicked2[1];
                matrice2[1, 0] = numberClicked2[2];
                matrice2[1, 1] = numberClicked2[3];

                Matrice resultatMatrice = (Matrice)Somme<Matrice>(matrice1, matrice2);

                txtDisplay.Text +="\n= " + resultatMatrice[0, 0]
                    + " " + resultatMatrice[0, 1] + "\n   " + resultatMatrice[1, 0] + " " + resultatMatrice[1, 1];
            }
            else if (complexe.IsSelected)
            {
                string[] split1 = strNumberOne.Split(' ');
                string[] split2 = strNumberTwo.Split(' ');
                for (int i = 0; i < 2; i++)
                {
                    numberClicked1.Add(int.Parse(split1[i]));
                    numberClicked2.Add(int.Parse(split2[i]));
                }

                complexe1.Reel = numberClicked1[0];
                complexe1.Imaginaire = numberClicked1[1];
                complexe2.Reel = numberClicked2[0];
                complexe2.Imaginaire = numberClicked2[1];

                Complexe resultatComplexe = (Complexe)Somme<Complexe>(complexe1, complexe2);

                txtDisplay.Text +="\n= " + resultatComplexe;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "";
            numberClicked1.Clear();
            numberClicked2.Clear();
            strNumberOne = "";
            strNumberTwo = "";
        }

        private void btnSpace_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                strNumberOne += " ";
                txtDisplay.Text += " ";
            }
            else
            {
                strNumberTwo += " ";
                txtDisplay.Text += " ";
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (matrice.IsSelected)
            {
                txtDisplay.Clear();
                txtDisplay.Text = "";
                numberClicked1.Clear();
                numberClicked2.Clear();
                strNumberOne = "";
                strNumberTwo = "";
            }
            else if (complexe.IsSelected)
            {
                txtDisplay.Clear();
                txtDisplay.Text = "";
                numberClicked1.Clear();
                numberClicked2.Clear();
                strNumberOne = "";
                strNumberTwo = "";

                /*complexe1.Reel = numberClicked1;

                complexe2.Reel = numberClicked2;*/
            }
        }
    }
}
