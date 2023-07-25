// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите длину массива: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] array = new string[a];
FillArray(array);
string[] newArray = new string[a];
NewArray(array,newArray);
PrintArray(array);
PrintArray(newArray);


void FillArray(string[] array){
    for(int i = 0; i<array.Length;i++){
        Console.WriteLine($"Введите {i} элемент массива: ");
        array[i]=Console.ReadLine();
    }
}

void NewArray(string[] array,string[] newArray){
    for(int i = 0;i<array.Length;i++){
        if(array[i].Length>=3){
            newArray[i]=array[i];
        }
    }
}

void PrintArray(string[] array){
    Console.Write("[");
    for(int i = 0;i<array.Length-1;i++){
        if(!String.IsNullOrEmpty(array[i])){
            Console.Write($"{array[i]}, ");
        }
    }
    if(!String.IsNullOrEmpty(array[array.Length-1])){
            Console.Write($"{array[array.Length-1]}]");
    }
    else{
        Console.Write("]");
    }
    Console.WriteLine();
}
