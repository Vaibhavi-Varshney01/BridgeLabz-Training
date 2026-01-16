namespace TrafficManagerApp
{
    class Vehicle
    {
        public string Number;

        public Vehicle(string number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
