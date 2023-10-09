Console.OutputEncoding = System.Text.Encoding.UTF8;

bool result = false;
int arrayLength;

do {
    Console.Write("Enter length of the array:");
    result = int.TryParse(Console.ReadLine(), out arrayLength);

    if (!result || arrayLength < 1) {
        Console.WriteLine("Wrong input! Value must be > 0");
    }
} while (!result || arrayLength < 1);


int[] myArray = new int[arrayLength];
Console.WriteLine("myArray has length {0} elements", myArray.Length);

for (int i = 0; i < myArray.Length; i++) {
    int input_number;

    do {
        Console.Write("Enter value for element {0}: ", i);
        result = int.TryParse(Console.ReadLine(), out input_number);

        if (!result || input_number < 0) {
            Console.WriteLine("Please, enter only integer numbers greater than or equal to zero!");
        } else {
            myArray[i] = input_number;
        }

    } while (!result || input_number < 0);
}

Dictionary<int, int> occurences = new Dictionary<int, int>();

for (int i = 0; i < myArray.Length; i++) {
    if (occurences.ContainsKey(myArray[i]))
        occurences[myArray[i]]++;
    else
        occurences.Add(myArray[i], 1);
}

foreach (KeyValuePair<int, int> element in occurences) {
    Console.WriteLine("Число: {0}, брой: {1}", element.Key, element.Value);
}