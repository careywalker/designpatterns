using System;
using Composite.Concrete;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            double tipsForTheNight = 177.00;
            Console.WriteLine($"{tipsForTheNight} in tips was received for the night");

            var staffMembers = GetStaffMembers();

            staffMembers.Tips += tipsForTheNight;
            staffMembers.Pay();

            Console.WriteLine($"Total Tips Paid: {staffMembers.Tips}");
            Console.ReadKey();
        }

        private static StaffGroup GetStaffMembers()
        {
            var bob = new Person { Name = "Bob" };
            var dave = new Person { Name = "Dave" };
            var suzie = new Person { Name = "Suzie" };
            var mary = new Person { Name = "Mary" };
            var debbie = new Person { Name = "Debbie" };
            var brian = new Person { Name = "Brian" };
            var rafa = new Person { Name = "Rafa" };
            var roger = new Person { Name = "Roger" };
            var novak = new Person { Name = "Novak" };
            var andy = new Person { Name = "Andy" };
            var steffi = new DeliveryStaff { Person = new Person { Name = "Steffi" } };
            var andre = new DeliveryStaff { Person = new Person { Name = "Andre" } };
            var pete = new DeliveryStaff { Person = new Person { Name = "Pete" } };

            var dishWashers = new StaffGroup { Name = "Dishwashers", Members = { roger, novak, andy } };
            var kitchenStaff = new StaffGroup { Name = "Kitchen Staff", Members = { bob, dave, suzie, dishWashers } };
            var supportStaff = new StaffGroup { Name = "Support Staff", Members = { mary, debbie, brian, rafa } };

            var staffMembers = new StaffGroup { Members = { kitchenStaff, supportStaff, steffi, andre, pete } };
            return staffMembers;
        }
    }
}
