﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }
        
        public string Cpf { get; set; }
        
        public string Nome { get; set; }
        
        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public string Email { get; set; }
        
        public string Telefone { get; set; }
    }
}