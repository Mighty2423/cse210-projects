class NegativeGoal : Goal
{
    private int penalty;
    private bool isFailed;

    public NegativeGoal(string name, string description, int points, int penalty)
        : base(name, description, points)
    {
        this.penalty = penalty;
        this.isFailed = false;
    }

    public override void RecordProgress()
    {
        isFailed = true; 
    }

    public override bool IsComplete()
    {
        return isFailed; 
    }

    public override string GetSaveString()
    {
        return $"NegativeGoal|{Name}|{Description}|{Points}|{penalty}|{isFailed}";
    }

    public int GetPenalty() 
    {
        return penalty;
    }

    public void SetPenalty(int value) 
    {
        penalty = value;
    }

    public bool IsFailed() 
    {
        return isFailed;
    }
}

