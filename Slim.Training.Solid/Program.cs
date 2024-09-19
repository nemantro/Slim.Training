// See https://aka.ms/new-console-template for more information

using Slim.Training.Solid;

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