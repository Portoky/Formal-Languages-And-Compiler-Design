// See https://aka.ms/new-console-template for more information
using Lab02;

Console.WriteLine("Hello, World!");
SymbolTable symbolTable = new SymbolTable(5);

// Add terms to the symbol table
symbolTable.add("1");
Console.WriteLine(symbolTable.findPosByValue("1").key);

symbolTable.add("6");
Console.WriteLine(symbolTable.findPosByValue("6").key);

symbolTable.add("5");
Console.WriteLine(symbolTable.findPosByValue("5").key);
Console.WriteLine(symbolTable.add("5"));

// Print the entire hash table
Console.WriteLine(symbolTable.getSymbolTable());