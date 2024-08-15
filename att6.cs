namespace att6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Cargo do funcionário: ");
            string cargo = Console.ReadLine();

            Console.Write("Salário do funcionário (Digite zero para usar o valor padrão de 1500.00): ");
            double salario = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, cargo, salario);

            Console.WriteLine("Funcionario");
            Console.WriteLine($"Nome : {funcionario.Nome}");
            Console.WriteLine($"Cargo : {funcionario.Cargo}");
            Console.WriteLine($"Salario : {funcionario.Salario}");

        }
    }

    class Funcionario
    {
        private string nome;
        private string cargo;
        private double salario;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public double Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }

        public Funcionario(string nome, string cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            if(salario == 0)
                this.salario = 1500.00;
            else
            this.salario = salario;
        }
    }
}
