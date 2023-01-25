// rakendus küsib kasutaja nime; programmis ei saa ole sama nimega muutujaid
//käsuga on alati ümmarguste sulgude vahel, programm peab midagi tegema
Console.WriteLine("Sisesta oma nimi:"); //output 
string userName = Console.ReadLine(); //input = sisend, mida sisestame konsooli

//string interpolation; peab lisama dollari märgi
Console.WriteLine($"Hello, {userName}!");

