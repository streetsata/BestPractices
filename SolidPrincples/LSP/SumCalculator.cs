using System.Linq;

namespace SolidPrincples.LSP
{
    internal abstract class Calculator
    {
        protected readonly int[] numbers;
        protected Calculator(int[] numbers)
        {
            this.numbers = numbers;
        }
        public abstract int Calculate();
    }

    internal class SumCalculator : Calculator
    {
        //protected readonly int[] numbers;

        public SumCalculator(int[] numbers)
            : base(numbers)
        {
            //this.numbers = numbers;
        }

        //public int Calculate() => numbers.Sum();
        //public virtual int Calculate() => numbers.Sum();
        public override int Calculate() => numbers.Sum();
    }

    internal class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        //public new int Calculate() => numbers.Where(x => x % 2 == 0).Sum();        
        public override int Calculate() => numbers.Where(x => x % 2 == 0).Sum();
    }
}
