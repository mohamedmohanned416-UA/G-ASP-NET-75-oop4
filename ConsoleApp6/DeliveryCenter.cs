using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class DeliveryCenter
    {
        private List<Shipment> shipments = new List<Shipment>();

        public void AddShipment(Shipment shipment)
        {
            shipments.Add(shipment);
        }

        public void PrintAllShipments()
        {
         
            foreach (var s in shipments)
            {
                s.PrintShipment();
            }
        }

        public void PrintTrackingStatuses()
        {
           
            foreach (ITrackable t in shipments)
            {
                Console.WriteLine(t.GetTrackingStatus());
            }
        }

        public void PrintInsuranceCosts()
        {
            
            foreach (var s in shipments)
            {
                string typeName = s switch
                {
                    StandardShipment => "Standard Shipment",
                    ExpressShipment => "Express Shipment",
                    InternationalShipment => "International Shipment",
                    _ => "Shipment"
                };
                Console.WriteLine($"{typeName} Insurance : {s.CalculateInsurance():0.00} EGP");
            }
           
        }
    }
}
