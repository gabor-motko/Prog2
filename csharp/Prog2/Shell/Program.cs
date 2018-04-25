using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShellDLL;

namespace ShellTest
{
    class ExitCommand : Command
    {
        private Shell sender;
        public ExitCommand(Shell sender) : base("exit")
        {
            this.sender = (CalculatorShell)sender;
        }

        public override bool Execute(params string[] args)
        {
            sender.Exit(0);
            return true;
        }

    }

    class PlusCommand : Command
    {
        private CalculatorShell sender;
        public PlusCommand(Shell sender) : base("+")
        {
            this.sender = (CalculatorShell)sender;
        }

        public override bool Execute(params string[] args)
        {
            float val;
            if (args.Length <= 0 || !float.TryParse(args[0], out val))
            {
                return false;
            }
            sender.Value += val;
            sender.Format(sender.ToString());
            return true;
        }
    }

    class MinusCommand : Command
    {
        private CalculatorShell sender;
        public MinusCommand(Shell sender) : base("-")
        {
            this.sender = (CalculatorShell)sender;
        }

        public override bool Execute(params string[] args)
        {
            float val;
            if (args.Length <= 0 || !float.TryParse(args[0], out val))
            {
                return false;
            }
            sender.Value -= val;
            sender.Format(sender.ToString());
            return true;
        }
    }

    class CalculatorShell : Shell
    {
        public float Value { get; set; }
        public override string ToString()
        {
            return string.Format($"{this.Value:F2}");
        }

        protected override void Init()
        {
            base.Init();
            this.Value = 0.0f;
            this.AddCommand(new ExitCommand(this));
            this.AddCommand(new PlusCommand(this));
            this.AddCommand(new MinusCommand(this));
            Format(this.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shell sh = new CalculatorShell();
            sh.ReadEvalPrint();
        }
    }
}
