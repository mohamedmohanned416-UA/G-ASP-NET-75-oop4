using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public abstract class Shipment : ITrackable, IInsurable
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public string Destination { get; set; }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();
        public abstract string GetTrackingStatus();
        public abstract decimal CalculateInsurance();
    }
}
