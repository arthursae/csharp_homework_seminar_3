// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] aPoint = new int[3];
int[] bPoint = new int[3];
string[] axisNames = new string[] {"X","Y","Z"};

int[] CollectUserData(string pointName) {

    int[] point = new int[3];
    
    for (int i = 0; i < 3; i++) {

        Console.Write("Введите " + axisNames[i] + "-координату точки " + pointName + ": ");
        int result = int.Parse(Console.ReadLine());
        point[i] = result;

    }
    
    return point;
    
}

double GetDistanceBetweenTwoPoints(int[] firstPoint, int[] secondPoint) {

    double sum = 0;
    double subCalc = 0;

    for (int i = 0; i < 3; i++) {

        subCalc = Math.Pow(firstPoint[i] - secondPoint[i], 2);
        sum += subCalc;
    
    }

    double dist = Math.Sqrt(sum);
    return dist;

}

Console.Clear();

aPoint = CollectUserData("A");
bPoint = CollectUserData("B");
double distance = GetDistanceBetweenTwoPoints(aPoint, bPoint);
string distanceTruncated = distance.ToString("0.00"); // round off to two decimal places
Console.WriteLine("Расстояние между точками А и B равно = " + distanceTruncated);
