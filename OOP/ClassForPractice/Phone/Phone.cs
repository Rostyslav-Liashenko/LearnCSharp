using System;

namespace ConsoleApp5
{
    public class Phone
    {
        private string _number;
        private string _model;
        private double _weight; // kg

        public Phone()
        {
            _number = "?";
            _model = "?";
            _weight = 0;
        }
        
        public Phone(string number, string model)
        {
            this._number = number;
            this._model = model;
        }
        public Phone(string number, string model, double weight) : this(number, model)
        {
            this._weight = weight;
        }
        
        public string GetNumber()
        {
            return _number;
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine("Receive call... name: " + name);
        }

        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine("Receive call... name: " + name + " number phone: " + number);
        }

        public void SendMessage(params string[] phonesNumber)
        {
            foreach(string phone in phonesNumber)
                Console.WriteLine(this._number + " send message " + phone);
        }

        public void PrintAllInfo()
        {
            Console.WriteLine("number:" + this._number);
            Console.WriteLine("model:" + this._model);
            Console.WriteLine("weight:" + this._weight);
        }
    }
}
