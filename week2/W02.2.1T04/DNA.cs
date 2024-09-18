class DNA
{
    public string Seq;
    public DNA(string seq)
    {
        Seq = seq;
    }
    public DNA Replicate1()
    {
        return new DNA(Seq);
    }
    public DNA Replicate2()
    {
        return this;
    }
    public void Mutate(string new_seq) => Seq = new_seq;
}