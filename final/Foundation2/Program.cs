using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA)
        addresses[0] = new Address("1207 White Water Drive", "Island Park", "Idaho", "USA");
        customers[0] =  new Customer("Miss Lannie Brown",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Crochet Dinosaur","B222",35.00f,6));
        productsLists[0].Add(new Product("Crochet blanket","B111",100.00f,3));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("52 Rue Des Fleurs", "Libourne", "Nouvelle-Aquitaine", "France");
        customers[1] =  new Customer("Jean ValJean",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Crochet pillows", "B333",25.99f,3));
        productsLists[1].Add(new Product("Crochet Sweater","B444",99.95f,1));
        productsLists[1].Add(new Product("Crochet mini octopus","B555",9.99f,2));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N°{i+1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{orders[i].GetPackingLabel()}"); 
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}