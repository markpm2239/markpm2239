public class Menu {
public int milk = 10;
public int bread= 5;
public salid = 10;
public friut = 5;
public soda = 2;
public counter = 0;
public choice = true;
public Menu() {
    CustomersSelection();
}

public void CustomersSelection {
    while(choice=="true") {
        do {
Console.WriteLine("Please select from the following item1");
Console.WriteLine("1. Milk $10");
Console.WriteLine("2. bread $5");
Console.WriteLine("3. Salid $10");
Console.WriteLine("4. fruit $5");
Console.WriteLine("5. Soda $2");
Console.ReadLine("Customer Selects?")
if (Console.ReadLine == 1) {
    couter = counter + milk;
}
else if (Console.ReadLine == 2) {
    counter = counter + bread;
} else if(Console.ReadLine == 3) {
    counter = counter + salid;

} else if(Console.ReadLine == 4) {
    counter = counter + fruit;
} else if(Console.ReadLine == 5) {
    counter = counter + soda;
} else if(counter < 1 || counter > 5) {

    choice == false;
    console.WriteLine("Thank you for shoping")
    console.WriteLine("Total is $" + counter)
}
}
        }



    }



}









}