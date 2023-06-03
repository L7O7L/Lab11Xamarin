using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Semana11A2023.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase 
    {

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }


        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorC;
        public int ValorC
        {
            get { return valorC; }
            set
            {
                if (valorC != value)
                {
                    valorC = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorD;
        public int ValorD
        {
            get { return valorD; }
            set
            {
                if (valorD != value)
                {
                    valorD = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorE;
        public int ValorE
        {
            get { return valorE; }
            set
            {
                if (valorE != value)
                {
                    valorE = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorF;
        public int ValorF
        {
            get { return valorF; }
            set
            {
                if (valorF != value)
                {
                    valorF = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorG;
        public int ValorG
        {
            get { return valorG; }
            set
            {
                if (valorG != value)
                {
                    valorG = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorH;
        public int ValorH
        {
            get { return valorH; }
            set
            {
                if (valorH != value)
                {
                    valorH = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoSuma;
        int resultadoResta;
        int resultadoMultiplicacion;
        int resultadoDivision;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ResultadoResta
        {

            get { return resultadoResta; }
            set
            {

                if(resultadoResta != value)
                {

                    resultadoResta = value;
                    OnPropertyChanged();

                }

            }

        }
        public int ResultadoMultiplicacion
        {

            get { return resultadoMultiplicacion; }
            set
            {

                if (resultadoMultiplicacion != value)
                {

                    resultadoMultiplicacion = value;
                    OnPropertyChanged();

                }

            }

        }

        public int ResultadoDivision
        {

            get { return resultadoDivision; }
            set
            {

                if (resultadoDivision != value)
                {

                    resultadoDivision = value;
                    OnPropertyChanged();

                }

            }

        }

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; } 
        public ICommand Dividir { protected set; get; }

        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = ValorA + ValorB;

            });

            Restar = new Command(() =>
            {

                ResultadoResta = ValorC - ValorD;

            });

            Multiplicar = new Command(() =>
            {
                
                ResultadoMultiplicacion = ValorE * ValorF;

            });

            Dividir = new Command(() =>
            {

                ResultadoDivision = ValorG / ValorH;

            });
           

        }

    }
}
