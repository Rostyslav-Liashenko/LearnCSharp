namespace LearnEvent
{
    public delegate void EventHandler(int a, int b);
    
    public class NumOp
    {
        public event EventHandler OperationWithNum;

        public void OnOperation(int a, int b)
        {
            OperationWithNum?.Invoke(a, b);
        }
    }
}
