using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PONTO.DAO;
using PONTO.DOMAIN.Entidades;
using PONTO.WEB.Models;

namespace PONTO.WEB.Controllers
{
    public class CadastroClientesController : Controller
    {
        private readonly appDbContext _context;

        public CadastroClientesController(appDbContext context)
        {
            _context = context;
        }

        // GET: CadastroClientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: CadastroClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ClienteViewsModel clienteViews = new ClienteViewsModel();


            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.IdCliente == id);


            if (cliente == null)
            {
                return NotFound();
            }

            clienteViews.Emails = _context.Emails.Where(a => a.CPF == cliente.CPF).ToList();
            clienteViews.Telefones = _context.Telefones.Where(a => a.CPF == cliente.CPF).ToList();
            clienteViews.Enderecos = _context.Enderecos.Where(a =>a.CPF == cliente.CPF).ToList();
            clienteViews.DisparosAcaos = _context.disparosAcaos.Where(a => a.CPF == cliente.CPF).ToList();
            clienteViews.ResultadoBots = _context.resultadoBots.Where(a => a.CPF == cliente.CPF).ToList();


            clienteViews.Cliente = cliente;




            return View(clienteViews);
        }

        // GET: CadastroClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroClientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCliente,Nome,CPF,RG,DataNascimento,Aposentado,NomeMae,NomePai,LocalNasc,StatusCad,DataCadastro")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: CadastroClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ClienteViewsModel clienteViews = new ClienteViewsModel();

            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            clienteViews.Emails = _context.Emails.Where(a => a.CPF == cliente.CPF).ToList();
            clienteViews.Telefones = _context.Telefones.Where(a => a.CPF == cliente.CPF).ToList();
            clienteViews.Enderecos = _context.Enderecos.Where(a => a.CPF == cliente.CPF).ToList();
            clienteViews.DisparosAcaos = _context.disparosAcaos.Where(a => a.CPF == cliente.CPF).ToList();
            clienteViews.ResultadoBots = _context.resultadoBots.Where(a => a.CPF == cliente.CPF).ToList();


            clienteViews.Cliente = cliente;

            return View(clienteViews);
        }

        // POST: CadastroClientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("IdCliente,Nome,CPF,RG,DataNascimento,Aposentado,NomeMae,NomePai,LocalNasc,StatusCad,DataCadastro")] Cliente cliente)
        public async Task<IActionResult> Edit(int id, ClienteViewsModel DadosCliente)
        {
            if (id != DadosCliente.Cliente.IdCliente)
            {
                return NotFound();
            }

            if(DadosCliente.Emails != null)
            {
                try
                {
                    for (int i = 0; i < DadosCliente.Emails.Count; i++)
                    {
                        var email = _context.Emails.FirstOrDefault(e => e.IdEmail == DadosCliente.Emails[i].IdEmail);
                        if (email != null)
                        {
                            email.EmailCliente = DadosCliente.Emails[i].EmailCliente;
                        }
                        _context.Update(email);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (Exception)
                {

                }
            
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(DadosCliente.Cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(DadosCliente.Cliente.IdCliente))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(DadosCliente);
        }

        // GET: CadastroClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: CadastroClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.IdCliente == id);
        }
    }
}
