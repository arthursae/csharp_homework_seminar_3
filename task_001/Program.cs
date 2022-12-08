// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string RequestUserToEnterData(string message) {

    Console.Write(message);

    string userInput = Console.ReadLine();

    int length = userInput.Length;

    int minLength = 3;          // 1. At least three characters (symbols) are required for the palindrome to be valid.
    int isEven = length % 2;    // 2. The palindrome is valid for odd numbers only.

    if (length < minLength || isEven == 0) {

        string errorMessage = "Количество символов (цифр) должно быть нечётное и не менее " + minLength;
        Console.WriteLine(errorMessage);
        return RequestUserToEnterData(message);

    } 

    else {

        return userInput;

    }
    
}

bool IsPalindrome(string stringToCheck) {

   int length = stringToCheck.Length;

   for (int i = 0; i < length/2; i++) {

        if (stringToCheck[i] != stringToCheck[length - 1 - i]) {
        
            return false;
            break; // if the first occurance is found when there is no need to check it further

        }
        
        else {
            
            return true;

        }

    }

    return true;

}

Console.Clear();

string userData = RequestUserToEnterData("Введите нечётное количество символов (цифр), минимум 3: ");

if (IsPalindrome(userData)) {
    
    Console.WriteLine("Строка \"" + userData + "\" – является палиндромом");

}

else {

    Console.WriteLine("Строка \"" + userData + "\" – не является палиндромом");

}
