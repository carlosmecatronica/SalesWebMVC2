using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} Requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="{0} tamanho , deve ser entre {1} e {2} ")]
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} Requerido")]
        public string Email { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} Requerido")]
        public DateTime DataNacimento { get; set; }
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Required(ErrorMessage = "{0} Requerido")]
        public Double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

        public ICollection<VendasRegistro> Vendas { get; set; } = new List<VendasRegistro>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNacimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNacimento = dataNacimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(VendasRegistro vendasRegistro)
        {
            Vendas.Add(vendasRegistro);
        }

        public void RemoverVendas(VendasRegistro vendasRegistro)
        {
            Vendas.Remove(vendasRegistro);
        }

        public double TotalVendas(DateTime inicio, DateTime fim)
        {
            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= fim).Sum(rv => rv.Quantia);

        }

    }
}
