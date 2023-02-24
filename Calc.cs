namespace calculator
{
    public class Calc
    {
        public string[] _signs = { "+", "-", "%", "/", "x" };

        public Calc() { }

        public string Operator(string operation)
        {
            if (operation == null ^ operation.Length == 0)
            {
                return "Please enter an operation";
            }
            int count = 0;
            foreach (char c in operation)
            {
                if (char.IsDigit(c) == false)
                {
                    count += 1;
                    if (c == ',')
                    {
                        count -= 1;
                    }
                }
            }
            if (count > 1)
            {
                return "Only one operation please";
            }
            if (operation.Contains(_signs[0]))
            {
                string facteur1 = operation.Split(_signs[0])[0];
                string facteur2 = operation.Split(_signs[0])[1];
                return (double.Parse(facteur1) + double.Parse(facteur2)).ToString();
            }
            if (operation.Contains(_signs[1]))
            {
                string facteur1 = operation.Split(_signs[1])[0];
                string facteur2 = operation.Split(_signs[1])[1];
                return (double.Parse(facteur1) - double.Parse(facteur2)).ToString();
            }
            if (operation.Contains(_signs[2]))
            {
                string facteur1 = operation.Split(_signs[2])[0];
                string facteur2 = operation.Split(_signs[2])[1];
                if (facteur2 == "0")
                {
                    return "Modulo by 0 is IMPOSSIBLE";
                }
                else
                {
                    return (double.Parse(facteur1) % double.Parse(facteur2)).ToString();
                }
            }
            if (operation.Contains(_signs[3]))
            {
                string facteur1 = operation.Split(_signs[3])[0];
                string facteur2 = operation.Split(_signs[3])[1];
                if (facteur2 == "0")
                {
                    return "Division by 0 is IMPOSSIBLE";
                }
                else
                {
                    return (double.Parse(facteur1) % double.Parse(facteur2)).ToString();
                }
            }
            if (operation.Contains(_signs[4]))
            {
                string facteur1 = operation.Split(_signs[4])[0];
                string facteur2 = operation.Split(_signs[4])[1];
                return (double.Parse(facteur1) * double.Parse(facteur2)).ToString();
            }
            return "";
        }

    }
}