using InterfaceNameClash;

Console.WriteLine("*** Interface Name Clashes ***");
Octagon oct = new Octagon();

// We must use casting to access the Draw() members.
IDrawToForm itfForm = (IDrawToForm)oct;
itfForm.Draw();

// shorthand notation if we don't need the variable for later use
((IDrawToPrinter)oct).Draw();

if (oct is IDrawToMemory dtm)
{
    dtm.Draw();
}
else
{
    Console.WriteLine("Not an IDrawToMemory.");
}