using Task2.Models;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();
((Car)car).Drive();
((MotorBike)motorBike).Wheelie();
((Boat)boat).Sail();
((Airplane)plane).Fly();

Console.ReadLine();

