using Microsoft.EntityFrameworkCore;
using PONTO.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DAO.CargasImportacao
{
    public class ImportacaoCliente
    {
        
        public async Task CadastroEmLoteAsync(Cliente cliente)
        {
            var db = new appDbContext();
            try
            {
                await Task.Run(() =>
                {
                    var excl = db.Clientes.Where(a => a.CPF == cliente.CPF).FirstOrDefault();

                    if (excl == null)
                    {
                        db.Clientes.Add(cliente);
                        db.SaveChanges();
                    }
                });
            }
            catch (Exception)
            {

            }
            
        }

       
    }
}
