public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>(); // hash map para adicionar valores e comparar

        int i = 0;
        
        for(i = 0; i < nums.Length; i++) // loop para ler todo o array e poder comparar os valores
        {
            var comp = target - nums[i]; // cria um valor de comparação

            if (!dic.ContainsKey(comp)) // se o valor não está no hash map -> adiciona
            {
                dic.TryAdd(nums[i], i); // adiciona valor com TryAdd -- para não travar a execução
            }
            else
            {
                return new int[] {dic[comp], i}; // se estiver no hash map, encontrou a solução
            }
        }

        return new int[0]; // retorno aleatorio para o c# nn encher o saco
    }
}