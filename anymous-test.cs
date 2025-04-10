using System;
using System.Collections.Generic;
using System.Linq;

namespace finalcial_app
{
    class Product
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
    }
    public class Anmous
    {
        public void Execute()
        {
            // 제품 리스트 생성
            var products = new List<Product>
        {
            new Product { Name = "Apple", Category = "Fruit", Price = 1.2m },
            new Product { Name = "Carrot", Category = "Vegetable", Price = 0.8m },
            new Product { Name = "Banana", Category = "Fruit", Price = 1.0m }
        };

        // LINQ 쿼리를 사용하여 특정 속성만 포함하는 익명 형식 생성
        var productQuery = from p in products
                           where p.Price > 1.0m // 가격 필터링
                           select new { p.Name, p.Price }; // 필요한 속성만 선택

         Console.WriteLine("productQueary : " + productQuery);
        // 익명 형식 결과 출력
        Console.WriteLine("Expensive Products:");
        foreach (var product in productQuery)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }

        // 기존 익명 형식을 수정하여 새로운 객체 생성 (with 키워드 사용)
        var apple = new { Item = "Apple", Price = 1.35m };
        var onSaleApple = apple with { Price = 0.99m }; // 가격 변경

        Console.WriteLine("\nOriginal and Modified Anonymous Types:");
        Console.WriteLine($"Original: {apple}");
        Console.WriteLine($"On Sale: {onSaleApple}");

        // 기본 데이터 타입
        var basicData = new { Name = "John", Age = 30, Price = 19.99m };

        // 복합 데이터 타입
        var complexData = new { 
            Id = 1, 
            Details = new { 
                FirstName = "John", 
                LastName = "Doe"
            },
            Tags = new[] { "tag1", "tag2" }
        };

        // 메서드 호출 결과
        var methodResult = new { 
            CurrentTime = DateTime.Now,
            IsWeekend = DateTime.Now.DayOfWeek == DayOfWeek.Saturday || 
                       DateTime.Now.DayOfWeek == DayOfWeek.Sunday
        };

        // LINQ 쿼리 예시 (기존 코드와 함께)
        var productQuery2 = from p in products
                           where p.Price > 1.0m
                           select new { 
                               p.Name, 
                               p.Price,
                               DiscountedPrice = p.Price * 0.9m,
                               Category = p.Category
                           };

        Console.WriteLine("\nProduct Query with Discounted Price:");
        foreach (var product in productQuery2)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Discounted Price: {product.DiscountedPrice}, Category: {product.Category}");
        }

        Console.WriteLine("\nBasic Data:");
        Console.WriteLine($"Name: {basicData.Name}, Age: {basicData.Age}, Price: {basicData.Price}");

        Console.WriteLine("\nComplex Data:");
        Console.WriteLine($"Id: {complexData.Id}, FirstName: {complexData.Details.FirstName}, LastName: {complexData.Details.LastName}, Tags: {string.Join(", ", complexData.Tags)}");

        Console.WriteLine("\nMethod Result:");
        Console.WriteLine($"Current Time: {methodResult.CurrentTime}, Is Weekend: {methodResult.IsWeekend}");
    }
}
}
