<<<<<<< HEAD
﻿public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user.ToString());
=======
﻿public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data.ToString());
>>>>>>> generic-class
    }
}

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        HaloGeneric halo = new HaloGeneric();
        string nama = "Kamal";
        halo.SapaUser(nama);
    }   
=======
        DataGeneric<string> data = new DataGeneric<string>("1302210032");
        data.PrintData();
    }
>>>>>>> generic-class
}