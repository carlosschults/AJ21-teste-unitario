using System;

namespace DemoTesteUnitario.Domain
{
    public struct Distancia : IComparable<Distancia>, IEquatable<Distancia>, IFormattable
    {
        private readonly double metros;
        private const int METROS_POR_KM = 1000;
        private const double METROS_POR_MILHA = 1609.34;
        private const int CENTIMETROS_POR_METRO = 100;

        private Distancia(double metros)
        {
            this.metros = metros;
        }

        public static Distancia EmMetros(double metros)
        {
            if (metros < 0)
                throw new ArgumentException("Valor precisa ser > 0!");
            
            return new Distancia(metros);
        }

        public static Distancia EmQuilometros(double km)
        {
            return new Distancia(km * METROS_POR_KM);
        }

        public static Distancia EmMilhas(double mi)
        {
            return new Distancia(mi * METROS_POR_MILHA);
        }

        public static Distancia EmCentímetros(double cm)
        {
            return new Distancia(cm / CENTIMETROS_POR_METRO);
        }

        public Distancia Mais(Distancia outra)
        {
            return new Distancia(metros + outra.metros);
        }

        public static Distancia operator +(Distancia a, Distancia b)
        {
            return a.Mais(b);
        }

        public Distancia Menos(Distancia outra)
        {
            return new Distancia(metros - outra.metros);
        }

        public static Distancia operator -(Distancia a, Distancia b)
        {
            return a.Menos(b);
        }

        public Distancia Vezes(double fator)
        {
            return new Distancia(metros * fator);
        }

        public static Distancia operator *(Distancia a, double fator)
        {
            return a.Vezes(fator);
        }

        public Distancia DivididoPor(double divisor)
        {
            return new Distancia(metros / divisor);
        }

        public static Distancia operator /(Distancia a, double divisor)
        {
            return a.DivididoPor(divisor);
        }

        public static bool operator == (Distancia a, Distancia b)
        {
            return a.metros == b.metros;
        }

        public static bool operator !=(Distancia a, Distancia b)
        {
            return a.metros != b.metros;
        }

        public static bool operator >(Distancia a, Distancia b)
        {
            return a.metros > b.metros;
        }

        public static bool operator <(Distancia a, Distancia b)
        {
            return a.metros < b.metros;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Distancia))
                return false;

            var outra = (Distancia)obj;

            return outra == this;
        }

        public override int GetHashCode()
        {
            return metros.GetHashCode();
        }

        public int CompareTo(Distancia other)
        {
            if (this < other) return -1;
            if (this > other) return 1;
            return 0;
        }

        public bool Equals(Distancia other)
        {
            return other == this;
        }

        public override string ToString()
        {
            return ToString("G", System.Globalization.CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return metros.ToString(format, formatProvider) + " m";
        }
    }
}
