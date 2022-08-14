using OOP.Classes;
using OOP.Classes.Inheritance;
using OOP.Classes.Interfaces;
using OOP.Classes.Polymorphism;

static void Main(string[] args)
{
    Simple s1 = new Simple();
    Simple s2 = new Simple("Firas", 24);

    PropertySample p = new PropertySample();
    Console.WriteLine(p.Text);
    Console.WriteLine(p.Number);
    p.Func1();

    InheritenceSample baseObj = new InheritenceSample();
    InheritenceSample2 derivedObj = new InheritenceSample2();
    baseObj.Func1();
    baseObj.Func2();
    derivedObj.Func1();
    derivedObj.Func2();
    derivedObj.Func3();
    derivedObj.Func4();

    PolySample polyBase = new PolySample();
    PolyDerived polyDerived = new PolyDerived();

    polyBase.aaa(1,2);
    polyDerived.aaa(3,4);

    InterfaceSample interfaceSample = new InterfaceSample();
    interfaceSample.test1("Function 1");
    interfaceSample.test2("Function 2", "Function 2");
    interfaceSample.test3("Function 3", "Function 3", "Function 3");
}