
      
    int count=0;
    
    string [] arr1= ["Sunday", "Mon", "Tuesday", "Wed", "Thu", "Friday", "Sat"];

for (int i=0; i< arr1.Length; i++){
    if (arr1[i].Length<4){
        count++;
    }
    


}
string [] arr2=new string [count];

count=0;
for (int i=0; i< arr1.Length; i++){
    if (arr1[i].Length<4){
        arr2[count]=arr1[i];
        count++;
    }
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", arr1)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", arr2)}]");




