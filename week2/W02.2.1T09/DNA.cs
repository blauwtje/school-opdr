class DNA
{
    private static Random _rand = new Random(0); //Seeded Random
    //Fields, constructor and Replicate here
    public DNA? Ancestor;
    public string? Seq;
    public DNA(DNA? ancestor, string seq)
    {
        Ancestor = ancestor;
        Seq = seq.ToUpper();

    }
    private string MutateTransition()
    {
        var indexToMutate = _rand.Next(0, Seq.Length);
        var mutatedSeq = Seq[0..indexToMutate] //Left of mutation
            + MutateTransitionTable(Seq[indexToMutate]) //Mutation
            + Seq[(indexToMutate + 1)..Seq.Length]; //Right of mutation
        return mutatedSeq;
    }

    private char MutateTransitionTable(char nucleotide) => nucleotide switch
    {
        'A' => 'G',
        'G' => 'A',
        'C' => 'T',
        'T' => 'C',
        _ => throw new ArgumentOutOfRangeException($"{nucleotide}", $"Unexpected nucleotide value: {nucleotide}"),
    };
    public DNA Replicate()
    {
        DNA newDNA = new DNA(this, Seq);
        newDNA.Seq = MutateTransition();
        return newDNA;
    }
}