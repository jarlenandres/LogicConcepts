string InfixToPostfix(string infix)
{
    Stack<char> operadores = new Stack<char>();
    string postfix = "";
    string num = ""; // acumulador para números de más de un dígito

    foreach (char c in infix)
    {
        if (char.IsDigit(c))
        {
            // acumular dígitos en el número
            num += c;
        }
        else
        {
            // si había un número acumulado, lo agregamos a postfix
            if (num != "")
            {
                postfix += num + " ";
                num = "";
            }

            if (c == '(')
            {
                operadores.Push(c);
            }
            else if (c == ')')
            {
                while (operadores.Count > 0 && operadores.Peek() != '(')
                    postfix += operadores.Pop() + " ";
                operadores.Pop();
            }
            else if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                while (operadores.Count > 0 && Precedencia(operadores.Peek()) >= Precedencia(c))
                    postfix += operadores.Pop() + " ";
                operadores.Push(c);
            }
        }
    }

    // Si quedó algún número pendiente, agregarlo
    if (num != "")
        postfix += num + " ";

    // Vaciar pila de operadores
    while (operadores.Count > 0)
        postfix += operadores.Pop() + " ";

    return postfix.Trim();
}
