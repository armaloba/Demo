﻿using System;

namespace GitHubDemo.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }   
        public DateTime DOB { get; set; }
    }
}