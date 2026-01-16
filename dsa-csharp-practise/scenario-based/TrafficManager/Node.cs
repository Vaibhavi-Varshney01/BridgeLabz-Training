namespace TrafficManagerApp
{
    class VehicleNode
    {
        public Vehicle Data;
        public VehicleNode Next;

        public VehicleNode(Vehicle data)
        {
            Data = data;
            Next = null;
        }
    }
}
