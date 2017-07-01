namespace Fibon.Message.Events {

    public class ValueCalculatedEvent: IEvent
    {
        protected ValueCalculatedEvent(){

        }

        public ValueCalculatedEvent(int number, int result)
        {
            Number = number;
            Result = result;
        }

        public int Number{get; private set;}
        public int Result{get; private set;}
    }
}