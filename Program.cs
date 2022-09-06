
            int a, b, c, delta, x1, x2;
            string sinalA = "", sinalB = "+", sinalC = "+";

            Console.Write("Digite o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            if(a == 0){
                Console.WriteLine("Digite um valor diferente de zero.");
                return;
            }

            Console.Write("Digite o valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if(a < 0)
            {
                sinalA = "-";
            }

            if (b < 0)
            {
                sinalB = "-";
            }

            if (c < 0)
            {
                sinalC = "-";
            }

            Console.WriteLine($"{sinalA}{Math.Abs(a)}x²{sinalB}{Math.Abs(b)}x{sinalC}{Math.Abs(c)}=0");

            delta = (b * b) - (4 * a * c);

            if(delta < 0){
                Console.WriteLine("Essa equação não admite solução real.");
            }else{

            x1 = (-b+delta)/(2*a);

            x2 = (-b-delta)/(2*a);

            Console.WriteLine("O delta da equação de 2º grau é: " + delta);

            Console.WriteLine("A primeira raiz da equação é: " + x1);
            Console.WriteLine("A segunda raiz da equação é: " + x2);

            Console.ReadKey();
            }