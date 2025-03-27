using System;
using System.ComponentModel.DataAnnotations;

namespace ShawarmaShop.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Имя покупателя обязательно")]
        [StringLength(100, ErrorMessage = "Имя не должно превышать 100 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Телефон обязателен")]
        [Phone(ErrorMessage = "Некорректный формат телефона")]
        public string Phone { get; set; }

        public DateTime RegisterDate { get; set; }

        public Customer()
        {
            Id = Guid.NewGuid();
            RegisterDate = DateTime.Now;
        }
    }

    public class Seller
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Имя продавца обязательно")]
        [StringLength(100, ErrorMessage = "Имя не должно превышать 100 символов")]
        public string Name { get; set; }

        [Range(18, 100, ErrorMessage = "Возраст должен быть от 18 до 100 лет")]
        public int Age { get; set; }

        public decimal Salary { get; set; }

        public Seller()
        {
            Id = Guid.NewGuid();
        }
    }

    public class Shawarma
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Название шаурмы обязательно")]
        public string Name { get; set; }

        [Range(0, 10000, ErrorMessage = "Цена должна быть в диапазоне от 0 до 10000")]
        public decimal Price { get; set; }

        public bool IsSpicy { get; set; }
        public string Description { get; set; }

        public Shawarma()
        {
            Id = Guid.NewGuid();
        }
    }

    public class Order
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public Guid SellerId { get; set; }
        public List<Guid> ShawarmaIds { get; set; }

        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
            ShawarmaIds = new List<Guid>();
            OrderDate = DateTime.Now;
        }
    }
}
