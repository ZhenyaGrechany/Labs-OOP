using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab7
{
    abstract class ElectricAlappliance : IComparable<ElectricAlappliance>
    {
        protected int power;
        protected double electroMagneticRadiation;
        protected string appliance;
        public abstract int Power { set; get; }
        public abstract double ElectroMagneticRadiation { set; get; }
        public abstract string Model { get; }
        public abstract void TurnOn();
        public abstract void SwitchOf();
        int IComparable<ElectricAlappliance>.CompareTo(ElectricAlappliance other)
        {
            int compare = this.Power.CompareTo(other.Power);
            return compare;
        }
    }

    class TV : ElectricAlappliance
    {
        public TV(int power, double electroMagneticRadiation)
        {
            this.appliance = "TV";
            this.Power = power;
            this.ElectroMagneticRadiation = electroMagneticRadiation;
        }
        public override int Power
        {
            set
            {
                if (value > 0)
                {
                    power = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return power;
            }
        }
        public override double ElectroMagneticRadiation
        {
            set
            {
                if (value > 0)
                {
                    electroMagneticRadiation = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return electroMagneticRadiation;
            }
        }
        public override string Model
        {
            get { return appliance; }
        }
        public override void TurnOn()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
        public override void SwitchOf()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
        public void SwitchChannel()
        {
            Console.WriteLine("Переключили канал");
        }
    }
    class Microwave : ElectricAlappliance
    {
        public Microwave(int power, double electroMagneticRadiation)
        {
            this.appliance = "Microwave";
            this.Power = power;
            this.ElectroMagneticRadiation = electroMagneticRadiation;
        }
        public override int Power
        {
            set
            {
                if (value > 0)
                {
                    power = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return power;
            }
        }
        public override double ElectroMagneticRadiation
        {
            set
            {
                if (value > 0)
                {
                    electroMagneticRadiation = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return electroMagneticRadiation;
            }
        }
        public override string Model
        {
            get { return appliance; }
        }
        public override void TurnOn()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
        public override void SwitchOf()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
    }
    class Computer : ElectricAlappliance
    {
        public Computer(int power, double electroMagneticRadiation)
        {
            this.appliance = "Computer";
            this.Power = power;
            this.ElectroMagneticRadiation = electroMagneticRadiation;
        }
        public override int Power
        {
            set
            {
                if (value > 0)
                {
                    power = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return power;
            }
        }
        public override double ElectroMagneticRadiation
        {
            set
            {
                if (value > 0)
                {
                    electroMagneticRadiation = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return electroMagneticRadiation;
            }
        }
        public override string Model
        {
            get { return appliance; }
        }
        public override void TurnOn()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
        public override void SwitchOf()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
    }
    class Radio : ElectricAlappliance
    {
        public Radio(int power, double electroMagneticRadiation)
        {
            this.appliance = "Radio";
            this.Power = power;
            this.ElectroMagneticRadiation = electroMagneticRadiation;
        }
        public override int Power
        {
            set
            {
                if (value > 0)
                {
                    power = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return power;
            }
        }
        public override double ElectroMagneticRadiation
        {
            set
            {
                if (value > 0)
                {
                    electroMagneticRadiation = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return electroMagneticRadiation;
            }
        }
        public override string Model
        {
            get { return appliance; }
        }
        public override void TurnOn()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
        public override void SwitchOf()
        {
            Console.WriteLine("Включили {0}", appliance);
        }
    }
    class MyCollection : IEnumerable, IEnumerator
    {
        List<ElectricAlappliance> electricAlappliances;
        private int position = 0;
        private double minElectroMagneticRange;
        private double maxElectroMagneticRange;
        public MyCollection(double minElectroMagneticRange, double maxElectroMagneticRange)
        {
            this.minElectroMagneticRange = minElectroMagneticRange;
            this.maxElectroMagneticRange = maxElectroMagneticRange;
            electricAlappliances = new List<ElectricAlappliance>();
        }
        public MyCollection(ElectricAlappliance elec, double minElectroMagneticRange, double maxElectroMagneticRange) :
            this(minElectroMagneticRange, maxElectroMagneticRange)
        {
            electricAlappliances.Add(elec);
        }
        public MyCollection(ElectricAlappliance[] arrayElec, double minElectroMagneticRange, double maxElectroMagneticRange) : 
            this(minElectroMagneticRange, maxElectroMagneticRange)
        {
            electricAlappliances.AddRange(arrayElec);
        }

        public int GetAllPower()
        {
            int power = 0;
            foreach (ElectricAlappliance elec in electricAlappliances)
            {
                power += elec.Power;
            }
            return power;
        }

        public List<ElectricAlappliance> GetSortedListByPower()
        {
            electricAlappliances.Sort();
            return electricAlappliances;
        }
        public List<ElectricAlappliance> GetListRightAppliance()
        {
            List<ElectricAlappliance> retCollection = new List<ElectricAlappliance>();
            foreach (ElectricAlappliance elec in electricAlappliances)
            {
                if (elec.ElectroMagneticRadiation >= minElectroMagneticRange & elec.ElectroMagneticRadiation <= maxElectroMagneticRange)
                {
                    retCollection.Add(elec);
                }
            }
            return retCollection;
        }
        bool IEnumerator.MoveNext()
        {
            if (position < electricAlappliances.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                IEnumerator help = this;
                help.Reset();
                return false;
            }
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get { return electricAlappliances[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ElectricAlappliance[] arrayElectricAlappliances = new ElectricAlappliance[20];
            int startIndex = 0;
            double min = 20.5;
            double max = 141.5;

            Computer[] arrayComp = new Computer[5];
            for (int i = 0; i < arrayComp.Length; i++)
            {
                arrayComp[i] = new Computer(100, 150);
                arrayElectricAlappliances[startIndex] = arrayComp[i];
                startIndex++;
            }

            Radio[] arrayRadio = new Radio[5];
            for (int i = 0; i < arrayRadio.Length; i++)
            {
                arrayRadio[i] = new Radio(40, 50);
                arrayElectricAlappliances[startIndex] = arrayRadio[i];
                startIndex++;
            }

            TV[] arrayTV = new TV[5];
            for (int i = 0; i < arrayTV.Length; i++)
            {
                arrayTV[i] = new TV(80, 110);
                arrayElectricAlappliances[startIndex] = arrayTV[i];
                startIndex++;
            }

            Microwave[] arrayMicrowave = new Microwave[5];
            for (int i = 0; i < arrayMicrowave.Length; i++)
            {
                arrayMicrowave[i] = new Microwave(90, 140);
                arrayElectricAlappliances[startIndex] = arrayMicrowave[i];
                startIndex++;
            }

            MyCollection myCollection = new MyCollection(arrayElectricAlappliances, min, max);

            int allPower = myCollection.GetAllPower();
            Console.WriteLine("Вся мощность - {0},", allPower);

            Console.WriteLine("Сортировка по мощности:");
            List<ElectricAlappliance> sortedListPower = myCollection.GetSortedListByPower();
            foreach (ElectricAlappliance elec in sortedListPower)
            {
                Console.WriteLine("Прибор - {0}, мощность - {1}", elec.Model, elec.Power);
            }

            Console.WriteLine("Приборы, входящие в диапазон:");
            List<ElectricAlappliance> right = myCollection.GetListRightAppliance();
            foreach (ElectricAlappliance elec in right)
            {
                Console.WriteLine("Прибор - {0}, электромагнитное излучение - {1}", elec.Model, elec.ElectroMagneticRadiation);
            }
            Console.ReadKey();
        }
    }
}
