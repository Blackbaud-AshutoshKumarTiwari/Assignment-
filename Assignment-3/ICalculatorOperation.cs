interface ICalculatorOperation
{  //Defines operation contract 
    char Symbol { get; }
    //OCP-New operations can be added
   //LSP-All operations can replace the abstraction
    //ISP-Only operation-specific members
    double Execute(
        double firstNumber,
        double secondNumber);
}