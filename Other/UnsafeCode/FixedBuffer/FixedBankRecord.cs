namespace LearnPointer
{
    public unsafe struct FixedBankRecord
    {
        public fixed byte Name[80];
        public double Balance;
        public long ID;
    }
}
