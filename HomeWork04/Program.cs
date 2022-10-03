
// Есть магазин "Еда"
// В магазине есть охранник
// Охранник ведёт запись всех, кто заходит в магазин
// Охранник ведёт запись всех, кто выходит из магазин
// Зайти и выйти можно в целый час.
// Выяснить в какой промежуток времени было больше всего посетителей
// Данные вводятся парами: приход-уход
// Максимум 100 покупателей
// Входные данные
// 10-12
// 11-13
// 9-12
// Ответ
// 11-12

Console.Clear();
string[] WorkingTime = new string [8]{"9-10","10-11","11-12","12-13","13-14","14-15","15-16","16-17"};
int[] ListOfIncoming = new int[8];
int[] ListOfOutput =   new int[8]; 

int RndPeople(int maxPeople)
{
    
   if(maxPeople<=0) maxPeople = 1;
   int result = new Random().Next(0,maxPeople);
    
    return result;
}

int oldVisitors = 0;
for (int i=0;i<8;i++) 
{  
    ListOfIncoming[i]= RndPeople(99-oldVisitors);
    ListOfOutput[i]= RndPeople(ListOfIncoming[i]+oldVisitors);
    oldVisitors=oldVisitors+(ListOfIncoming[i]-ListOfOutput[i]);
}

int max=0;

int[] NumberOfVisitorsPerHours()
{
    int[] PeopleInShop = new int[8];
    for (int i=0; i<8;i++)
        {
           PeopleInShop[i]= ListOfIncoming[i]-ListOfOutput[i];
           if (i>0) PeopleInShop[i]=PeopleInShop[i]+PeopleInShop[i-1];
        }
    return PeopleInShop;
}

int FindMax(int[] A)
{
    max = A[0];
    int maxIndex=0;
    for(int i=0;i<8;i++)
    {
        if (A[i]>max) 
        {
            max=A[i];
            maxIndex=i;
        }
    }
    return maxIndex;
}

string MaxPeopleTime=WorkingTime[FindMax(NumberOfVisitorsPerHours())];

Console.WriteLine("The largest number of visitors ({0} ppl.) ", max);
Console.WriteLine("Was in the shop for " + MaxPeopleTime + " hours");
Console.WriteLine();
Console.WriteLine(String.Join("|", ListOfIncoming)+ " - visitors came in");
Console.WriteLine(String.Join("|", ListOfOutput) + " - visitors left");