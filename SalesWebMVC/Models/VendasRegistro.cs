
using System;

namespace SalesWebMVC.Models
{
    public class VendasRegistro
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Double Quantia { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public VendasRegistro()
        {
        }

        public VendasRegistro(int id, DateTime data, double quantia, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
