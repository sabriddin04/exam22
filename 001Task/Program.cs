using _001Task;
using _001Task.Data;
using Microsoft.EntityFrameworkCore;

await using var dataContext = new DataContext();


Console.WriteLine(" Good look 😊😊😊 ");

//1
//Напишите запрос LINQ, чтобы получить всех людей, живущих в городе с населением более 3 милион человек.
//Write a LINQ query to retrieve all the people who live in a city with a population greater than 3 

// var list=dataContext.Peoples.Where(x=>x.City.Population>3000000);

// foreach (var item in list)
// {
//     System.Console.WriteLine(item.FirstName);
// }


//2
//Получите все города со средней численностью населения в соответствующей стране
//Retrieve all cities with their respective country's average population


// var list=dataContext.Cities.Include(t=>t.Country);

// foreach (var item in list)
// {
//     System.Console.WriteLine(item.Name);
//     System.Console.WriteLine(item.Population);
//     System.Console.WriteLine(item.Country.Name);
// }



//3
//Получите города с самым высоким населением в каждой стране
//Retrieve the cities with the highest population in each country


//var list=dataContext.Countries.Select(t=>t.Cities.OrderByDescending(x=>x.Population)).FirstOrDefault();

//4
//Получите среднее население городов в каждой стране
//Retrieve the average population of cities in each country


// var list=dataContext.Countries.Select(t=>new{
//     Country=t.Name,
//     Avg=t.Cities.Average(s=>s.Population)
// });

// foreach (var item in list)
// {
//     System.Console.WriteLine(item.Country);
//     System.Console.WriteLine(item.Avg);
// }



//5
//Получить все города, в которых есть человек по имени "Марк".
//Retrieve all cities that have a person with by name "Mark"
// string a="Mark";
// var list=dataContext.Cities.Where(p=>p.Peoples.Any(y=>y.FirstName==a)).ToList();
// foreach (var item in list)
// {
//     System.Console.WriteLine(item.Name);
// }

//6
//Получить всех людей вместе с соответствующими названиями городов и стран
//Retrieve all people along with their associated city and country names

// var list=dataContext.Peoples.Include(t=>t.City).ThenInclude(a=>a.Country);

// foreach (var item in list)
// {
//     System.Console.WriteLine(item.FirstName);
//     System.Console.WriteLine(item.City.Name);
//     System.Console.WriteLine(item.City.Country.Name);
// }

//7
//Получите все города вместе с соответствующими названиями стран, используя свойство навигации
//Retrieve all cities along with their associated country names using a navigation property

// var list=dataContext.Cities.Include(t=>t.Country);
// foreach (var item in list)
// {
//     System.Console.WriteLine(item.Name);
//     System.Console.WriteLine(item.Country.Name);
// }

//8
//Получить всех людей вместе с связанными с ними городом и страной.
//Retrieve all people along with their associated city and country 
// var list=dataContext.Peoples.Include(t=>t.City).ThenInclude(a=>a.Country);

// foreach (var item in list)
// {
//     System.Console.WriteLine(item.FirstName);
//     System.Console.WriteLine(item.City.Name);
//     System.Console.WriteLine(item.City.Country.Name);
// }


//9
//Получить всех людей, живущих в "USA".
//Retrieve all people living in  "USA".

// var list=dataContext.Countries.Where(x=>x.Name=="USA").Include(t=>t.Cities);
// foreach (var item in list)
// {
//     foreach (var item1 in item.Cities)
//     {
//         System.Console.WriteLine(item1.Name);
//     }
// }


//10
//Получить всех людей вместе с соответствующим населением города и страны
//Retrieve all people along with their associated city and country populations 


// var list=dataContext.Peoples.Include(t=>t.City).ThenInclude(a=>a.Country);

// foreach (var item in list)
// {   System.Console.WriteLine(item.FirstName);
//     System.Console.WriteLine(item.City.Population);
//     System.Console.WriteLine(item.City.Country.Cities.Sum(t=>t.Population));
// }


