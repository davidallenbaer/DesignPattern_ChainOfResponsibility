namespace DesignPattern_ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler rsHandler;
        public void nextHandler(Handler rsHandler)
        {
            this.rsHandler = rsHandler;
        }

        public abstract void dispatchRs(long requestedAmount);
    }
}