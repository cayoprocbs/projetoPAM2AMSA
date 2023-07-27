using System;
namespace AMS23_AVE{
public class AveNaoVoa: Ave
{
    public AveNaoVoa(string id,string name){
    this.Id= id;
    this.Name= name;
}
    public  void NaoVoa(){
         Console.WriteLine("id: " +Id);
        Console.WriteLine("name: "+ Name);
        Console.WriteLine("essa ave nao voa");
    }
}
}