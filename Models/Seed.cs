using System;
using System.Collections.Generic;
using System.Linq;

namespace carpoolapp.Models {
    public static class Seed {
        public static Employee[] Employees = new Employee[] {
            new Employee {
            Id = 1,
            FirstName = "Xenia",
            LastName = "Pass",
            IsDriver = true
            },
            new Employee {
            Id = 2,
            FirstName = "Angela",
            LastName = "Wolter",
            IsDriver = false
            },
            new Employee {
            Id = 3,
            FirstName = "Isis",
            LastName = "Booe",
            IsDriver = true
            },
            new Employee {
            Id = 4,
            FirstName = "Wendie",
            LastName = "Jacquet",
            IsDriver = true
            },
            new Employee {
            Id = 5,
            FirstName = "Dorene",
            LastName = "Rudnick",
            IsDriver = true
            },
            new Employee {
            Id = 6,
            FirstName = "Robby",
            LastName = "Nehls",
            IsDriver = true
            },
            new Employee {
            Id = 7,
            FirstName = "Mauricio",
            LastName = "Tung",
            IsDriver = true
            },
            new Employee {
            Id = 8,
            FirstName = "Keren",
            LastName = "Jacobo",
            IsDriver = true
            },
            new Employee {
            Id = 9,
            FirstName = "Micki",
            LastName = "Bustillos",
            IsDriver = false
            },
            new Employee {
            Id = 10,
            FirstName = "Kathey",
            LastName = "Hogue",
            IsDriver = true
            },
            new Employee {
            Id = 11,
            FirstName = "Darell",
            LastName = "Wetherby",
            IsDriver = true
            },
            new Employee {
            Id = 12,
            FirstName = "Dylan",
            LastName = "Kaczmarski",
            IsDriver = true
            },
            new Employee {
            Id = 13,
            FirstName = "Helen",
            LastName = "Marcello",
            IsDriver = true
            },
            new Employee {
            Id = 14,
            FirstName = "Tatum",
            LastName = "Branton",
            IsDriver = true
            },
            new Employee {
            Id = 15,
            FirstName = "Lakisha",
            LastName = "Julius",
            IsDriver = false
            },
            new Employee {
            Id = 16,
            FirstName = "Lionel",
            LastName = "Botelho",
            IsDriver = false
            },
            new Employee {
            Id = 17,
            FirstName = "Shala",
            LastName = "Kimbrough",
            IsDriver = true
            },
            new Employee {
            Id = 18,
            FirstName = "Xenia",
            LastName = "Pass",
            IsDriver = false
            },
            new Employee {
            Id = 19,
            FirstName = "Tod",
            LastName = "Messineo",
            IsDriver = false
            },
            new Employee {
            Id = 20,
            FirstName = "Janis",
            LastName = "Kingery",
            IsDriver = true
            },
            new Employee {
            Id = 21,
            FirstName = "Perry",
            LastName = "HuberPass",
            IsDriver = true
            },
            new Employee {
            Id = 22,
            FirstName = "Samantha",
            LastName = "Beauford",
            IsDriver = true
            },
            new Employee {
            Id = 23,
            FirstName = "Johnna",
            LastName = "Clem",
            IsDriver = true
            },
            new Employee {
            Id = 24,
            FirstName = "Elfriede",
            LastName = "Mcbee",
            IsDriver = true
            },
            new Employee {
            Id = 25,
            FirstName = "Elliott",
            LastName = "Pass",
            IsDriver = true
            },
            new Employee {
            Id = 26,
            FirstName = "Annemarie",
            LastName = "Mook",
            IsDriver = true
            },
            new Employee {
            Id = 27,
            FirstName = "Edwardo",
            LastName = "Broadwater",
            IsDriver = true
            },
        };

        public static Car[] Cars = new Car[] {
            new Car { LicensePlate = "DA000PA", Name = "Ford Mondeo", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA001PA", Name = "Ford Focus", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA002PA", Name = "Ferrari", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 2, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA003PA", Name = "Renault Clio", CarType = "Compact", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA004PA", Name = "Toyota Yaris", CarType = "Compact", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA005PA", Name = "Ford Mondeo", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA006PA", Name = "Ford Mondeo", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA007PA", Name = "Ford Mondeo", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA008PA", Name = "Ford Mondeo", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
            new Car { LicensePlate = "DA009PA", Name = "Ford Mondeo", CarType = "Limousine", Color = "Metalic", NumberOfSeats = 4, CurrentLocation = "Zagreb" },
        };

        public static Travel[] Travels = new Travel[] {
            new Travel {
            ID = 1,
            StartLocation = "Zagreb",
            EndLocation = "Pula",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddHours (4),
            CarLicensePlate = "DA000PA"
            }
        };
        public static TravelEmployees[] TravelEmployees => Employees.Take(4).Select(x => new TravelEmployees { EmployeeId = x.Id, TravelId = 1 }).ToArray();

    }
}