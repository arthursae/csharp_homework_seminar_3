// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int startFrom = 1;
int toPower = 3;

int GetUserInputData(string message) {

    Console.Write(message);
    int userInputData = int.Parse(Console.ReadLine());
    return userInputData;

}

int PowInt(int num, int pow) {

    if (pow == 0) {

        int specNum = 1;
        return specNum;

    } 
    
    else {

        int i = 1;
        int storedNum = num;

        while (i < pow) {

            num = num * storedNum;
            i++;

        }

        return num;

    }    

}

int[] CollectNumbersListIntoArray(int userNumber) {

    int[] numbers = new int[userNumber];

    for (int i = startFrom; i <= userNumber; i++) {

        numbers[i-1] = PowInt(i, toPower);

    }

    return numbers;

}

Console.Clear();

int userNumber = GetUserInputData("Введите целое положительное число: ");
int[] numbers = CollectNumbersListIntoArray(userNumber);
Console.Write("Таблица кубов чисел от " + startFrom + " до " + userNumber + " -> ");

foreach(int num in numbers) {

    Console.Write(num + ", ");

}

