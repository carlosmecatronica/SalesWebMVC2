using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.VendasRegistros.Any())
            {
                return; // db ja esta populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronico");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");
           

        
            Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            VendasRegistro r1 = new VendasRegistro(1, new DateTime(2018, 09, 25), 11000.0, VendaStatus.Faturado, s1);
            VendasRegistro r2 = new VendasRegistro(2, new DateTime(2018, 09, 4), 7000.0, VendaStatus.Faturado, s5);
            VendasRegistro r3 = new VendasRegistro(3, new DateTime(2018, 09, 13), 4000.0, VendaStatus.Cancelado, s4);
            VendasRegistro r4 = new VendasRegistro(4, new DateTime(2018, 09, 1), 8000.0, VendaStatus.Faturado, s1);
            VendasRegistro r5 = new VendasRegistro(5, new DateTime(2018, 09, 21), 3000.0, VendaStatus.Faturado, s3);
            VendasRegistro r6 = new VendasRegistro(6, new DateTime(2018, 09, 15), 2000.0, VendaStatus.Faturado, s1);
            VendasRegistro r7 = new VendasRegistro(7, new DateTime(2018, 09, 28), 13000.0, VendaStatus.Faturado, s2);
            VendasRegistro r8 = new VendasRegistro(8, new DateTime(2018, 09, 11), 4000.0, VendaStatus.Faturado, s4);
            VendasRegistro r9 = new VendasRegistro(9, new DateTime(2018, 09, 14), 11000.0, VendaStatus.Pendente, s6);
            VendasRegistro r10 = new VendasRegistro(10, new DateTime(2018, 09, 7), 9000.0, VendaStatus.Faturado, s6);
            VendasRegistro r11 = new VendasRegistro(11, new DateTime(2018, 09, 13), 6000.0, VendaStatus.Faturado, s2);
            VendasRegistro r12 = new VendasRegistro(12, new DateTime(2018, 09, 25), 7000.0, VendaStatus.Pendente, s3);
            VendasRegistro r13 = new VendasRegistro(13, new DateTime(2018, 09, 29), 10000.0, VendaStatus.Faturado, s4);
            VendasRegistro r14 = new VendasRegistro(14, new DateTime(2018, 09, 4), 3000.0, VendaStatus.Faturado, s5);
            VendasRegistro r15 = new VendasRegistro(15, new DateTime(2018, 09, 12), 4000.0, VendaStatus.Faturado, s1);
            VendasRegistro r16 = new VendasRegistro(16, new DateTime(2018, 10, 5), 2000.0, VendaStatus.Faturado, s4);
            VendasRegistro r17 = new VendasRegistro(17, new DateTime(2018, 10, 1), 12000.0, VendaStatus.Faturado, s1);
            VendasRegistro r18 = new VendasRegistro(18, new DateTime(2018, 10, 24), 6000.0, VendaStatus.Faturado, s3);
            VendasRegistro r19 = new VendasRegistro(19, new DateTime(2018, 10, 22), 8000.0, VendaStatus.Faturado, s5);
            VendasRegistro r20 = new VendasRegistro(20, new DateTime(2018, 10, 15), 8000.0, VendaStatus.Faturado, s6);
            VendasRegistro r21 = new VendasRegistro(21, new DateTime(2018, 10, 17), 9000.0, VendaStatus.Faturado, s2);
            VendasRegistro r22 = new VendasRegistro(22, new DateTime(2018, 10, 24), 4000.0, VendaStatus.Faturado, s4);
            VendasRegistro r23 = new VendasRegistro(23, new DateTime(2018, 10, 19), 11000.0, VendaStatus.Cancelado, s2);
            VendasRegistro r24 = new VendasRegistro(24, new DateTime(2018, 10, 12), 8000.0, VendaStatus.Faturado, s5);
            VendasRegistro r25 = new VendasRegistro(25, new DateTime(2018, 10, 31), 7000.0, VendaStatus.Faturado, s3);
            VendasRegistro r26 = new VendasRegistro(26, new DateTime(2018, 10, 6), 5000.0, VendaStatus.Faturado, s4);
            VendasRegistro r27 = new VendasRegistro(27, new DateTime(2018, 10, 13), 9000.0, VendaStatus.Cancelado, s1);
            VendasRegistro r28 = new VendasRegistro(28, new DateTime(2018, 10, 7), 4000.0, VendaStatus.Faturado, s3);
            VendasRegistro r29 = new VendasRegistro(29, new DateTime(2018, 10, 23), 12000.0, VendaStatus.Faturado, s5);
            VendasRegistro r30 = new VendasRegistro(30, new DateTime(2018, 10, 12), 5000.0, VendaStatus.Faturado, s2);


            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(s1,s2, s3, s4, s5, s6);

            _context.VendasRegistros.AddRange(
               r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
               r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
               r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
           );
            _context.SaveChanges();

        }
    }
}
