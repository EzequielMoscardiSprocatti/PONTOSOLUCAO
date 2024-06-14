using PONTO.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DAO.Funcao
{
    public class EnvioAcaoMkt
    {
        public EnvioAcaoMkt() { }

        appDbContext db = new();
        public async Task<DisparosAcaoMkt> InsertDados(DisparosAcaoMkt disparosAcao)
        {

            db.disparosAcaos.Add(disparosAcao);
            db.SaveChanges();

            return disparosAcao;
        }
    }
}
