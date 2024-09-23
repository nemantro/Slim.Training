// See https://aka.ms/new-console-template for more information

using Slim.Training.Solid.Solid._1_SingleResponsibility;
using Slim.Training.Solid.Solid._2_OpenClosed;
using Slim.Training.Solid.Solid._3_LiskovSubstitution;

try
{
    SingleResponsibilityExample.RunBadImplementation();
    SingleResponsibilityExample.RunGoodImplementation();
    
    OpenClosedPrincipeExample.RunBadImplementation();
    OpenClosedPrincipeExample.RunGoodImplementation();
    
    LiskovSubstitutionExample.RunBadImplementation();
    LiskovSubstitutionExample.RunGoodImplementation();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}