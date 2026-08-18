using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public override decimal EstimatedCost => DeliveryFee;

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public override string GetTrackingStatus() => $"Shipment {TrackingCode} is Ready.";

        public override decimal CalculateInsurance() => EstimatedCost * 0.05m;
    }

    
}
