// See https://aka.ms/new-console-template for more information

using Slim.Training.Solid.Solid._1_SingleResponsibility;

try
{
    SingleResponsibilityExample.RunGoodImplementation();
    SingleResponsibilityExample.RunBadImplementation();
    
    
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}