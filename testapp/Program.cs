using System;
public class dish {
 
    public String name;
    public String description;
    public double price;
    public int minutes;
    public String contents;
    public dish(String name, String description,
                  int minutes, double price ,String contents)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.minutes = minutes;
        this.contents = contents;
    }
}
public class cook {
 
    public String name;
    public int dishespreparing;
    public int timetotal;
    public cook(String name, int dishespreparing,int timetotal)
    {
        this.name = name;
        this.dishespreparing = dishespreparing;
        this.timetotal = timetotal;
    }
}
public class ingredient {
 
    public String name;
    public double price ;
    public ingredient(String name, double price)
    {
        this.name = name;
        this.price = price;
    }
}
 
public class main{
public static void Main(String[] args)
    {
        string order;
        int ordernumber = 0;
        ingredient[] ing = new ingredient[17];
        ing[0] = new ingredient("Spaghetti",0.5);
        ing[1] = new ingredient("Beef",3.15);
        ing[2] = new ingredient("Tomatoes",0.15);
        ing[3] = new ingredient("Garlic",0.05);
        ing[4] = new ingredient("Parmesan",1.2);
        ing[5] = new ingredient("Eggplants",0.2);
        ing[6] = new ingredient("Noodles",0.6);
        ing[7] = new ingredient("Egg",0.1);
        ing[8] = new ingredient("Chicken Broth",0.2);
        ing[9] = new ingredient("Chicken",2.1);
        ing[10] = new ingredient("Sweet Pepper",0.15);
        ing[11] = new ingredient("Greens",0.3);
        ing[12] = new ingredient("Shrimps",4.5);
        ing[13] = new ingredient("Dough",0.2);
        ing[14] = new ingredient("Apples",0.4);
        ing[15] = new ingredient("Cucumbers",0.5);
        ing[16] = new ingredient("Salad Dressing",0.5);
        dish[] meal = new dish[6];
        meal[0] = new dish("Spaghetti", "The authentic italian taste", 15, (ing[0].price+ing[1].price+ing[2].price+ing[3].price+ing[4].price)*1.2,"Spaghetti,Beef,Tomato,Garlic,Parmesan");
        meal[1] = new dish("Beef steak with vegetables", "A tasty and filling meal", 20, (ing[1].price+ing[2].price+ing[3].price+ing[3].price+ing[5].price)*1.2,"Beef Steak,Grilled Tomatoes,Garlic,Grilled Eggplants");
        meal[2] = new dish("Chicken Ramen", "A refreshing japanese dish", 30, (ing[6].price+ing[7].price+ing[8].price+ing[9].price+ing[10].price+ing[11].price)*1.2,"Noodles,Egg,Chicken Broth,Chicken,Sweet Pepper,Greens");
        meal[3] = new dish("Shrimps", "Waves of gourmet pleasures", 15, (ing[12].price+ing[2].price)*1.2,"Fried Shrimps,Grilled Tomatoes");
        meal[4] = new dish("Apple Pie", "Just like grandma's", 35, (ing[13].price+ing[14].price)*1.2,"Dough,Apples");
        meal[5] = new dish("Caesar Salad", "Great balance of nutrients", 5, (ing[9].price+ing[15].price+ing[2].price+ing[16].price+ing[4].price)*1.2,"Chicken,Cucumbers,Tomatoes,Salad Dressing,Parmesan");
        cook[] chef = new cook[2];
        chef[0] = new cook("Boyardi",0,0);
        chef[1] = new cook("Oliver",0,0);
        Console.WriteLine("Here is the menu :");
        for(int i=0; i<=5;i++)
        {
            Console.WriteLine(meal[i].name);
            Console.WriteLine(meal[i].description);
            Console.WriteLine("Cooking time= "+ meal[i].minutes + " minutes");
            Console.WriteLine("Price= "+meal[i].price+" dollars");
            Console.WriteLine("Ingredients: "+meal[i].contents);
            Console.WriteLine("");
        }
        while(chef[0].dishespreparing<=5 && chef[1].dishespreparing<=4)
        {
        Console.WriteLine("What will you order?");
        order = Console.ReadLine();
        switch(order) 
{
  case "Spaghetti":
    ordernumber = 0;
    break;
  case "Beef steak with vegetables":
    ordernumber=1;
    break;
    case "Chicken Ramen":
    ordernumber = 2;
    break;
  case "Shrimps":
    ordernumber=3;
    break;
    case "Apple Pie":
    ordernumber = 4;
    break;
  case "Caesar Salad":
    ordernumber=5;
    break;
default :
Console.WriteLine("There is no dish with such a name . Maybe try typing it again.");
order = Console.ReadLine();
break;
}
        if(chef[0].dishespreparing<5 && chef[0].dishespreparing<=chef[1].dishespreparing)
        {
            chef[0].dishespreparing++;
            chef[0].timetotal+=meal[ordernumber].minutes;
            Console.WriteLine("Your dish is being made by Chef Boyardi and it will come in "+chef[0].timetotal);
        }
        else
        {
            chef[1].dishespreparing++;
            chef[1].timetotal+=meal[ordernumber].minutes;
            Console.WriteLine("Your dish is being made by Chef Oliver and it will come in "+chef[1].timetotal);
        }
        }
        Console.WriteLine("No cooks available");
        Console.ReadLine();
    }
}