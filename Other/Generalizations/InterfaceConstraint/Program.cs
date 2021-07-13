using System;

namespace LearnGeneralization
{
    class UseBaseClassConstraint
    {
        static void Main()
        {
            PhoneList<Friend> plist = new PhoneList<Friend>();
            plist.Add(new Friend("Tommy", "555-1234", true));
            plist.Add(new Friend("Garry", "555-6756", true));
            plist.Add(new Friend("Matt", "555-9254", false));
            try
            {
                Friend frnd = plist.FindByName("Garry");
                Console.Write(frnd.Name + " " + frnd.Number);
                if (frnd.IsWorkNumber)
                    Console.WriteLine(" (work)");
                else Console.WriteLine();
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Not found");
            }

            PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
            plist2.Add(new Supplier("Company Global", "555-8834"));
            plist2.Add(new Supplier("Company Computer WareHouse", "555-9256"));
            plist2.Add(new Supplier("Company Network city", "555-2564"));
            try
            {
                Supplier sp = plist2.FindByNumber("555-2564");
                Console.WriteLine(sp.Name + " " + sp.Name);
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Not found");
            }
            
        }
    }
}