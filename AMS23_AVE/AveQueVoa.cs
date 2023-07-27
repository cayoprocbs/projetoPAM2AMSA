using System;
namespace AMS23_AVE{
public class AveQueVoa: Ave{
 public AveQueVoa(string id, string name){ 
   this.Id= id;
  this.Name = name;
  }
      public void voa(){

Console.WriteLine("id: " +Id);
Console.WriteLine("name: "+ Name);
Console.WriteLine("essa ave voa");
}
}
}