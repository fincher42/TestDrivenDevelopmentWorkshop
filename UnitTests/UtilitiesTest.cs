using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;

namespace TestDrivenDevelopmentUnitTests
{
    /*    5 Workshop tasks: 
         Your job is to incrementally build and test a method called "BuildUrl"
         that will iteratively pass the following tests.  
         One person should write the test, another make it pass.  
         With 5 tasks, 10 people can participate.
     1. Passing a single, simple name-value pair:
        string url = BuildUrl(host, "location","Africa");
     2. Name-value pair with non-url friendly characters:
        string url = BuildUrl(host, "animal pen","#16"); //(note: # in hex is 23)
     3. Multiple name-value pairs
        string url = BuildUrl(host, "type","mammal","continent","Africa","size","small","food appetite","carnivore","animal pen","#16");
       code error conditions:
     4. Check for bad number of parameters
        string url = BuildUrl(host, "type","mammal","continent");
     5. Check for bad host value
    */
    [TestClass]
    public class UtilitiesTest
    {
        //example for task 1.
        [TestMethod]
        public void BuildUrl_SimpleUrl_Good_Input()
        {
            // Arrange
            string host = "https://www.WeBoughtAZoo.com/api";
            string name = "location";
            string value = "Africa";

            // Act
            var url = Utilities.BuildUrl(host, name, value);

            // Assert
            url.ShouldBeEquivalentTo($"{host}?{name}={value}");
        }
    }
}
