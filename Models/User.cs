﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg_Sprint1_Test.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }


        //public User(int id, string name, string email, string password)
        //{
        //    Id = id;
        //    Name = name;
        //    Email = email;
        //    Password = password;

    }

        public enum Role
        {
            Foreman,
            ProductionWorker,
            QualityAssurance
        }
    }

    
