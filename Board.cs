// Defining 'class', short for 'classification
class Board {
    // Property describes something about your class
    // type'List<string>' name: 'spaces'
    List<string> spaces = new List<string>();

    // an instance, an object 'Board()'
    // Constructor 'public Board()'
    public Board() {
        for (int i = 1; i <= 9; i += 1)
        {
          spaces.Add(i.ToString());
        }
    }
    
    // creating 'method' of 'print()'
    public void print() {
        {
        Console.WriteLine($"{spaces[0]}|{spaces[1]}|{spaces[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[3]}|{spaces[4]}|{spaces[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[6]}|{spaces[7]}|{spaces[8]}");
    }
    }
}