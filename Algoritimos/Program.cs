// See https://aka.ms/new-console-template for more information

  var a = TwoSum(new int[] { 8, 5, 7 }, 12);


            Console.WriteLine("Array {8,5,7} valor da soma 12, posições correspondentes para a soma " + a[0]+" e "+ a[1]);
            Console.ReadKey();

             int[] TwoSum(int[] nums, int target)
            {
                // Crie um dicionário para armazenar números vistos e seus índices
                Dictionary<int, int> numDict = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    // Calcule o complemento do número atual
                    int complement = target - nums[i];

                    // Se o complemento existir no dicionário, retorne seu índice e o índice atual
                    if (numDict.ContainsKey(complement))
                    {
                        return new int[] { numDict[complement], i };
                    }

                    // Caso contrário, armazene o número atual e seu índice no dicionário
                    numDict[nums[i]] = i;
                }

                // Se nenhuma solução for encontrada, retorne um array vazio ou manipule-o conforme necessário.
                return new int[0];
            }
              Console.ReadKey();
