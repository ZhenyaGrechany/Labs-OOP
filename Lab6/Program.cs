using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class ElectricAlappliance : IComparable<ElectricAlappliance>
    {
        protected int power;
        protected double electroMagneticRadiation;
        protected string appliance;
        public abstract int Power { set; get; }
        public abstract double ElectroMagneticRadiation { set; get; }
        public abstract string Model { get;  }
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
                if(value > 0)
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
    class Socket
    {
        private double minElectroMagneticRange;
        private double maxElectroMagneticRange;
        ElectricAlappliance computer;
        ElectricAlappliance radio;
        ElectricAlappliance tV;
        ElectricAlappliance microwave;
        List<ElectricAlappliance> arrayElectricAlappliance = new List<ElectricAlappliance>();
        public Socket(ElectricAlappliance computer, double minElectroMagneticRange, double maxElectroMagneticRange)
        {
            this.computer = computer;
            this.minElectroMagneticRange = minElectroMagneticRange;
            this.maxElectroMagneticRange = maxElectroMagneticRange;
            arrayElectricAlappliance.Add(computer);
        }
        public Socket(ElectricAlappliance computer, ElectricAlappliance radio, double minElectroMagneticRange, double maxElectroMagneticRange) :
            this(computer, minElectroMagneticRange, maxElectroMagneticRange)
        {
            this.radio = radio;
            arrayElectricAlappliance.Add(radio);
        }
        public Socket(ElectricAlappliance computer, ElectricAlappliance radio, ElectricAlappliance tV, double minElectroMagneticRange, double maxElectroMagneticRange) :
            this(computer, radio, minElectroMagneticRange, maxElectroMagneticRange)
        {
            this.tV = tV;
            arrayElectricAlappliance.Add(tV);
        }
        public Socket(ElectricAlappliance computer, ElectricAlappliance radio, ElectricAlappliance tV, ElectricAlappliance microwave, double minElectroMagneticRange, double maxElectroMagneticRange) :
            this(computer, radio, tV, minElectroMagneticRange, maxElectroMagneticRange)
        {
            this.microwave = microwave;
            arrayElectricAlappliance.Add(microwave);
        }
        public int GetAllPower()
        {
            int power = 0;
            foreach (ElectricAlappliance elec in arrayElectricAlappliance)
            {
                power += elec.Power;
            }
            return power;
        }
        public List<ElectricAlappliance> GetSortedListByPower()
        {
            arrayElectricAlappliance.Sort();
            return arrayElectricAlappliance;
        }
        public List<ElectricAlappliance> GetListRightAppliance()
        {
            List<ElectricAlappliance> retCollection = new List<ElectricAlappliance>();
            foreach (ElectricAlappliance elec in arrayElectricAlappliance)
            {
                if(elec.ElectroMagneticRadiation >= minElectroMagneticRange & elec.ElectroMagneticRadiation <= maxElectroMagneticRange)
                {
                    retCollection.Add(elec);
                }
            }
            return retCollection;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(100, 150);
            Radio radio = new Radio(40, 50);
            TV tV = new TV(80, 110);
            Microwave microwave = new Microwave(90, 140); //не воткнули

            double min = 0;
            double max = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите минимальное излучение:");
                    min = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите максимальное излучение:");
                    max = Convert.ToDouble(Console.ReadLine());
                    break;
                      
                }
                catch (FormatException)
                {
                    Console.WriteLine("Надо ввести число!");
                }
            }

            Socket socket = new Socket(computer, radio, tV, min, max);

            int allPower = socket.GetAllPower();
            Console.WriteLine("Вся мощность - {0}", allPower);

            Console.WriteLine("Сортировка по мощности:");
            List<ElectricAlappliance> sortedListPower = socket.GetSortedListByPower();
            foreach (ElectricAlappliance elec in sortedListPower)
            {
                Console.WriteLine("Прибор - {0}, мощность - {1}",elec.Model, elec.Power);
            }

            Console.WriteLine("Приборы, входящие в диапазон:");
            List<ElectricAlappliance> right = socket.GetListRightAppliance();
            foreach (ElectricAlappliance elec in right)
            {
                Console.WriteLine("Прибор - {0}, электромагнитное излучение - {1}", elec.Model, elec.ElectroMagneticRadiation);
            }

            Console.ReadKey();
        }
    }
}
