using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Base : IBase
    {
        private string connectionString = ConfigurationManager.AppSettings["MySql"];
        public List<IBase> Buscar()
        {
            throw new NotImplementedException();
        }

        public void CriarTabela()
        {
            throw new NotImplementedException();
        }

        public void Exclir()
        {
            throw new NotImplementedException();
        }

        public int Key
        {
            get
            {
                foreach (PropertyInfo pi in this.GetType().GetProperties(
                    BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoes = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoes != null && opcoes.ChavePrimaria)
                    {
                        return Convert.ToInt32(pi.GetValue(this));
                    }
                }
                return 0;
            }
        }

        public void Salvar()
        {
            throw new NotImplementedException();
        }

        public List<IBase> Todos()
        {
            throw new NotImplementedException();
        }
    }
}
