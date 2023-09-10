/*
          * Assuming Singleton is created from client 1 class
          * we refer to the GetInstance property from the Singleton class
          */
using SingletonDesignPattern;

Parallel.Invoke(
              () => Client1(),
              () => Client2());
Console.ReadLine();

static void Client1()
{
    /*
     * Assuming Singleton is created from client 1 class
     * we refer to the GetInstance property from the Singleton class
     */
    Singleton client1 = Singleton.GetInstance;
    client1.PrintDetails("From Client 1");
}

static void Client2()
{
    /*
     * Assuming Singleton is created from client 2 class
     * we refer to the GetInstance property from the Singleton class
     */
    Singleton client2 = Singleton.GetInstance;
    client2.PrintDetails("From Client 2");
}