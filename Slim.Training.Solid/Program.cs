// See https://aka.ms/new-console-template for more information

using Slim.Training.Solid.Solid._1_SingleResponsibility;
using Slim.Training.Solid.Solid._2_OpenClosed;
using Slim.Training.Solid.Solid._3_LiskovSubstitution;
using Slim.Training.Solid.Solid._4_InterfaceSegregation;
using Slim.Training.Solid.Solid._5_DependencyInversion;

try
{
    SingleResponsibilityExample.RunBadImplementation();
    SingleResponsibilityExample.RunGoodImplementation();
    
    OpenClosedPrincipeExample.RunBadImplementation();
    OpenClosedPrincipeExample.RunGoodImplementation();
    
    LiskovSubstitutionExample.RunBadImplementation();
    LiskovSubstitutionExample.RunGoodImplementation();
    
    InterfaceSegregationExample.RunBadImplementation();
    InterfaceSegregationExample.RunGoodImplementation();
    
    DependencyInversionExample.RunBadImplementation();
    DependencyInversionExample.RunGoodImplementation();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}