class Program
{
    static void Main(string[] args)
    {
        List<DNA> dnaList = new List<DNA> { new DNA("ACGT"), new DNA("GCTTAC"), new DNA("CGTTAGCTT"), new DNA("TACA") };
        Console.WriteLine("What is the minimmum sequence length? ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The filtered list: ");
        string filteredList = "";
        foreach (DNA dna in dnaList)
        {
            if (dna.Seq.Length >= length)
            {
                filteredList += dna.Seq + "\n";
            }
        }
        Console.WriteLine(filteredList);
    }
}