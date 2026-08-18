namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {


            #region q1
            // A-   Abstraction is the process of hiding complex internal details and exposing only the essential features and functions to the user.
            // b-   Encapsulation is the practice of bundling data and methods that operate on that data within a single unit, such as a class, and restricting access to the internal details of that unit. 
            #endregion

            #region q2

            // a- Abstract Class: It can contain variables, and its methods can be either fully defined or abstract. It is used for inheritance among objects that are similar in nature.
            // Interface: It is a contract that defines a set of methods and properties that a class must implement. It is used to achieve polymorphism and allows different classes to be treated as the same type.

            // b- We choose an interface when we want to implement shared functionality across classes that are unrelated within the inheritance hierarchy, or when we need to implement polymorphic behavior for multiple behaviors.

            // c- No, a class can inherit from only one class (Single Inheritance).
            // Yes, a class can implement multiple interfaces simultaneously.

            #endregion

            DeliveryCenter center = new DeliveryCenter();
            var standard = new StandardShipment("SH001", "Laptop", 2.5m, 95m, "Cairo");
            var express = new ExpressShipment("SH002", "Mobile", 0.8m, 70m, "Giza");
            var international = new InternationalShipment("SH003", "Documents", 0.5m, 200m, "Germany");

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

           
            center.PrintAllShipments();
            center.PrintTrackingStatuses();
            center.PrintInsuranceCosts();
        }
    }
}
