using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services.Exceptions;

namespace SalesWebMVC.Services
{
    public class VendedorService
    {
        private readonly SalesWebMVCContext _context;
        public VendedorService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }
        public async Task insertAsync(Vendedor obj)
        {
            _context.Add(obj);
           await  _context.SaveChangesAsync();
        }
        public async Task<Vendedor> FindByIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);

        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Vendedor.FindAsync (id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();

        }
        public async Task UpdateAsync(Vendedor obj)
        {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
            {
                throw new NaoEncontradoExceptions("id nao encontrado");

            }
            try
            {
                _context.Update(obj);
               await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new DbConcurrencyException(e.Message);
            }

        }
       

    }
}
