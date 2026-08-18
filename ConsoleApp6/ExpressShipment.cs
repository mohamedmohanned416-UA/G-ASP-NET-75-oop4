using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; } = 30m;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public override decimal EstimatedCost => DeliveryFee + ExtraFee; 

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP\n");
            
        }

        public override string GetTrackingStatus() => $"Shipment {TrackingCode} is Out for Delivery.";

        public override decimal CalculateInsurance() => EstimatedCost * 0.08m;
    }
}
