using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class UsuarioDAO
    {
        private FinancasContext _context;
        public UsuarioDAO(FinancasContext context)
        {
            _context = context;
        }
        public void Adiciona(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public IList<Usuario> Lista()
        {
            return _context.Usuarios.ToList();
        }
    }
}