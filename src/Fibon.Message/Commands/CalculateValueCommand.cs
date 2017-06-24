namespace Fibon.Message.Commands{
    public class CalculateValueCommand: ICommand
    {
        protected CalculateValueCommand(){}

        public CalculateValueCommand(int number){
            Number = number;
        }
        public int Number {get; private set;}
    }


}