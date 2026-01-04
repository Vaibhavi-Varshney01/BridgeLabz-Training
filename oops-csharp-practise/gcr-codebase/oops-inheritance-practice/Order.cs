using System;
class Order{
    public int OrderId;
    public string OrderDate;
}
class ShippedOrder : Order{
    public string TrackingNumber;
}
class DeliveredOrder : ShippedOrder{
    public string DeliveryDate;
    public string GetOrderStatus(){
        return "Delivered";
    }
}
