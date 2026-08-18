using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class InternationalShipment : Shipment
    {
        public string DestinationCountry { get; set; }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry)
            : base(trackingCode, description, weight, deliveryFee, destinationCountry)
        {
            DestinationCountry = destinationCountry;
        }

        public override decimal EstimatedCost => 260m; 

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code      : {TrackingCode}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Estimated Cost     : {EstimatedCost} EGP");
        }

        public override string GetTrackingStatus() => $"Shipment {TrackingCode} has Been Delivered.";

        public override decimal CalculateInsurance() => EstimatedCost * 0.12m;
    }
}
