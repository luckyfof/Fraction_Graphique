using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Graphique
{
    class Fraction
    {
        private int _numerateur;
        private int _denominateur;

        public Fraction(int unNumerateur, int unDenominateur)
        {
            _numerateur = unNumerateur;
            _denominateur = unDenominateur;
        }

        public Fraction()
        {
            _numerateur = 1;
            _denominateur = 1;
        }

        public Fraction(int unNumerateur)
        {
            _numerateur = unNumerateur;
            _denominateur = 1;
        }

        public Fraction(double unNombreReel)
        {
            _denominateur = 1;
            string chaine = Convert.ToString(unNombreReel);
            int nbDecimale = chaine.Length - 3 - chaine.IndexOf('.');
            for (int i = 0; i < nbDecimale; i++)
            {
                unNombreReel *= 10;
                _denominateur *= 10;
            }
            _numerateur = (int)Math.Round(unNombreReel);
        }

        public int Numerateur { get => _numerateur; set => _numerateur = value; }
        public int Denominateur { get => _denominateur; set => _denominateur = value; }

        public String Affichage() => $"{_numerateur} / {_denominateur}";

        public override string ToString() => $"{_numerateur} / {_denominateur}";

        private int Pgcd()
        {
            int temp = 0;
            int a = _numerateur;
            int b = _denominateur;
            while (b != 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }

        public void Simplifier()
        {
            int pgcd = Pgcd();
            _numerateur /= pgcd;
            _denominateur /= pgcd;
        }

        public Fraction Additionner(Fraction frac)
        {
            return this + frac;
        }

        public Fraction Soustraire(Fraction frac)
        {
            return this - frac;
        }

        public Fraction Multiplier(Fraction frac)
        {
            return new Fraction(this._numerateur * frac._numerateur, this._denominateur * frac._denominateur);
        }

        public Fraction Inverser()
        {
            return new Fraction(this._denominateur, this._numerateur);
        }

        public Fraction Diviser(Fraction frac)
        {
            return new Fraction(this._numerateur * frac._denominateur, this._denominateur * frac._numerateur);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._numerateur * f2._denominateur + f2._numerateur * f1._denominateur, f1._denominateur * f2._denominateur);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._numerateur * f2._denominateur - f2._numerateur * f1._denominateur, f1._denominateur * f2._denominateur);
        }
    }
}
