namespace LearnGeneralization
{
    public class PhoneList<T> where T: IPhoneNumber
    {
        private T[] phList;
        private int end;

        public PhoneList()
        {
            phList = new T[10];
            end = 0;
        }

        public bool Add(T newEntry)
        {
            if (end == 10) return false;
            phList[end] = newEntry;
            end++;
            return true;
        }

        public T FindByName(string name)
        {
            for (int i = 0; i < end; i++)
            {
                if (phList[i].Name == name)
                    return phList[i];
            }
            throw new NotFoundException();
        }

        public T FindByNumber(string number)
        {
            for (int i = 0; i < end; i++)
            {
                if (phList[i].Number == number)
                    return phList[i];
            }
            throw new NotFoundException();
        }
        
        
    }
}