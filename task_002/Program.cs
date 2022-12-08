// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int CollectUserData(string message) {

    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
    
}

double GetDistanceBetweenTwoPoints() {
    
    int aX = CollectUserData("Введите X-координату точки А: ");
    int aY = CollectUserData("Введите Y-координату точки А: ");
    int aZ = CollectUserData("Введите Z-координату точки А: ");
    
    int bX = CollectUserData("Введите X-координату точки B: ");
    int bY = CollectUserData("Введите Y-координату точки B: ");
    int bZ = CollectUserData("Введите Z-координату точки B: ");

    double dist = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2));
    
    return dist;
    
}

Console.Clear();

double distance = GetDistanceBetweenTwoPoints();
string distanceTruncated = distance.ToString("0.00"); // round off to two decimal places

Console.WriteLine("Расстояние между точками А и B равно = " + distanceTruncated);
