using System;
using Calculator;
using System.Collections.Generic;
namespace Calculator
{
    public class CalculatorCore
    {
        public CalculatorCore()
        {

        }

        /// <summary>
        /// Elvégzi a kért műveleteket
        /// </summary>
        /// <param name="v">Szöveg formában várja az elvégzendő műveletet.</param>
        /// <returns>Eredménnyel tér vissza</returns>
        public object Feldolgoz(string v)
        {
            if (v == "")
            {
                throw new FormatException();
            }
            else
            {
                if (v.IndexOf('+') > 0)
                {
                    List<int> szamok = SzamValogatas(v,'+');
                    return Sum(szamok);
                }
                if (v.IndexOf('-') > 0) {
                    List<int> szamok = SzamValogatas(v, '-');
                    return Sub(szamok);
                }
                if( v.IndexOf('*') > 0)
                {
                    List<int> szamok = SzamValogatas(v, '*');
                    return Mul(szamok);
                }
                if (v.IndexOf('/') > 0)
                {
                    List<int> szamok = SzamValogatas(v, '/');
                    return Dev(szamok);
                }

            }
            throw new NotImplementedException();

           
        }

        /// <summary>
        /// Kivonást végez egy listán
        /// </summary>
        /// <param name="szamok">Az operandusok listája</param>
        /// <returns>A kivonás eredményével tér vissza</returns>
        private int Sub(List<int> szamok) {
            int eredmeny = szamok[0];
            for (int i = 1; i < szamok.Count; i++)
            {
                eredmeny -= szamok[i];
            }
            return eredmeny;
        }

        /// <summary>
        /// A számok szorzásáért felel
        /// </summary>
        /// <param name="szamok">Az össze szorzandó számok listája</param>
        /// <returns>Szorzás eredményével tér vissza</returns>
        private int Mul(List<int> szamok) {
            int eredmeny = szamok[0];
            for (int i = 1; i < szamok.Count; i++)
            {
                eredmeny *= szamok[i];
            }
            return eredmeny;
        }

        /// <summary>
        /// Elvégzi a listán az osztást
        /// </summary>
        /// <param name="szamok">Az elosztani kívánt számok listája</param>
        /// <returns>Az osztás eredménye</returns>
        private double Dev(List<int> szamok) {
            double eredmeny = Convert.ToDouble(szamok[0]);
            for (int i = 1; i < szamok.Count; i++)
            {
                eredmeny /= Convert.ToDouble(szamok[i]);
            }
            return eredmeny;
        }

        /// <summary>
        /// Tömbbe válogatja a file elemeit
        /// </summary>
        /// <param name="v">Szöveg, ami a műveleteket tartalmazza</param>
        /// <param name="jel">A műveleti jel</param>
        /// <returns>Számokat tartalmazó listával tér vissza</returns>
        public List<int> SzamValogatas(String v, char jel)
        {
            List<int> szamok = new List<int>();
            String[] szamokString = v.Split(jel);
            foreach (string item in szamokString){
                szamok.Add(Int32.Parse(item));
            }

            return szamok;
        }

        /// <summary>
        /// Összeadást végez
        /// </summary>
        /// <param name="szamok">Az összeadni kívánt számok listáját várja</param>
        /// <returns>Összeggel tér vissza</returns>
        public int Sum(List<int> szamok)
        {
            int ered = 0;
            foreach (var item in szamok)
            {
                ered += item;
            }
            return ered;
        }
    }
}
