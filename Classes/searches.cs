using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISS.Warning.Classes
{
    class searches
    {
        
        
        
        public List<Pessoa> pessoas(string idpessoa)
        {

            List<Pessoa> pessoa = new List<Pessoa>();
            using (var db= new DBIS_PRE_PRODEntities () )
            {
               
                var pessoadados = db.Pessoa.Where(r => r.IdPessoa == idpessoa).ToList();

                pessoa = pessoadados;
            }


            return pessoa;
        }

        public List<Contacto> ContactoPessoa(string idpessoa) 
        {
            List<ContactoPessoa> ContactoPessoas = new List<ContactoPessoa>();
            List<Contacto> contactos1 = new List<Contacto>();
            string contact = "";


            using (var db = new DBIS_PRE_PRODEntities())
            {
                var ContactoPessoa = db.ContactoPessoa.Where(d => d.IdContactoPessoa == idpessoa).ToList();
                ContactoPessoas = ContactoPessoa;

                foreach (var item in ContactoPessoas)
                {
                    contact = item.ContactoID;
                }

                var contactos = db.Contacto.Where(r => r.IdContacto == contact).ToList();
                contactos1 = contactos;
               

            }

            return contactos1;
        }

        public List<Pessoa> allpessoa() 
        {
            List<Pessoa> allPessoas = new List<Pessoa>();
            using (var db = new DBIS_PRE_PRODEntities())
            {
                var ContactoPessoa = db.Pessoa.OrderBy(b => b.IdPessoa).ToList();
                allPessoas = ContactoPessoa;
            }
            return allPessoas;
        }

        public List<string> DadosEmpresa() 
        {
            List<string> vs = new List<string>();
            using (var db = new DBIS_PRE_PRODEntities())
            {
                var DadosEmpresa = db.Database.SqlQuery<Empresa>("EXECUTE dbo.Sp_empresa")
                    .ToList();
                foreach (var item in DadosEmpresa)
                {
                    //vs = item.
                }
            }

            return vs;
        }


        public List<Apolice> buscar_apolice() 
        {
            List<Apolice> Apolice = new List<Apolice>();

            using (var db = new DBIS_PRE_PRODEntities())
            {
                var _Apolice = db.Apolice.OrderBy(e => e.IdApolice).ToList();
                Apolice = _Apolice;
            }

            return Apolice;
        }

        






        

    }
}



/*var pessoa = db.Pessoa.OrderBy(b => b.IdPessoa).ToList();

var teste = db.Pessoa.Join(db.ContactoPessoa,

    pessoas => pessoas.IdPessoa,

    contacto => contacto.IdContactoPessoa,
    (pessoas, contacto) => new
    {
        PessoaId = pessoas.IdPessoa,
        CpId = contacto.IdContactoPessoa
    }
    ).ToList();

foreach (var item in teste)
{

}*/
