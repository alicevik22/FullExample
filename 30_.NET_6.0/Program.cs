using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_.NET_6._0 {
    class Program {
        static void Main(string[] args) {
            //.NET 6.0
            // C# 10 (2021)

#region DateOnly, TimeOnly
    class Data {
        private void Only() {
            DateOnly data = new(2021, 10, 9);
            data.AddDays(1);
            data.AddMoths(1);
            data.AddYears(1);

            TimeOnly time = new(22,23,10);
            time.AddHours(1);
            time.AddMinutes(1);
            time.IsBetween(TimeOnly, TimeOnly);// проверка входит ли в диапазон
        }
    }
#endregion

#region namespace // убранны лишние скобки
    namespace Servise;
    class noNamespase {
    }
#endregion 

#region import.cs // все using в один файл
    //global using System.Text;
#endregion 

#region приоритет в очереди Queue
    class queue1
	{
    // C#9
        Queue<int> q = new();
        q.Enqueue[1];
        q.Enqueue[5];
    // C#10
        PriorityQueue<string, int> pq = new();
        pq.Enqueue["first",0];
        pq.Enqueue["third",7];
        pq.Enqueue["second",5];
	}
#endregion 

#region MaxBy / MinBy
    class maxBy1
	{
	// C#9
        List<int> list = new{15,7,9};
        List.max();
        class Device {string Name; int Price;}
        List<Device> device = new();
        device.Add(new Device{Name = "Tv", Price = 100});
        device.Add(new Device{Name = "Phone", Price = 50});
        device.Max(d => d.Price);//100
        device.OrderByDescending(d => d.Price).First();//Tv
    // C#10
        List<Device> devices = new();
        devices.Maxby(d => d.Price);
	}
#endregion 

#region IEnumerable.Chunk
    class Chunk1
	{
		List<Chiken> Chikens= new{1,1,2,2,3,3};
        void mChunk(){
            foreach (var item in Chikens.Chunk(2))
            {
                Parallel.ForEach(item, (chik) =>{
                    // обработка конкретного
                });
            }
        }
	}
#endregion 

#region Constant interpolated strings
    class MyClass
	{
		const string name = "ty";
        const string name2 = $"Hello {name}";// изменение строки не пропустит компилятор
	}
#endregion 

#region Extended property patterns
    class MyClass
	{
        public class Book{
            public string Name{get;set;}
        }
        public class Bookshelf
	    {
		    public Book book{get;set;}
	    }
    // C#9
        public string getPrise(Bookshelf bookshelf){
            string prise = bookshelf switch{
                {Book: {Name: "HP"}}=>"5$",
                _ => "Prise not found"
            };
            return price;
        }
    // C#10
        public string getPrise(Bookshelf bookshelf){
            string prise = bookshelf switch{
                {Book.Name: "HP"}=>"5$",
                _ => "Prise not found"
            };
            return price;
        }
	}
#endregion 

#region Null parametr checking
    class Null1
	{
		//вывод эксепшон если null
        public void Process(Book book){
            ArgumentNullException.ThrowIfNull(book);
        }
    }
#endregion 
   

            //
        }
    }
}
