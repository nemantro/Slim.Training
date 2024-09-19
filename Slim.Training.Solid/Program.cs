// See https://aka.ms/new-console-template for more information

using Slim.Training.Solid.Solid._1_SingleResponsibility;
using Slim.Training.Solid.Solid._2_OpenClosed;

try
{
    SingleResponsibilityExample.RunBadImplementation();
    SingleResponsibilityExample.RunGoodImplementation();
    
    OpenClosedPrincipeExample.RunBadImplementation();
    OpenClosedPrincipeExample.RunGoodImplementation();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}