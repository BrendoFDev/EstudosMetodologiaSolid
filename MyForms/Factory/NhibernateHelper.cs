using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Automapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;
using MyForms.Mapping;

namespace MyForms.Factory
{
    public class NhibernateHelper : INhibernateHelper
    {
        private ISessionFactory? _sessionFactory;

        public NhibernateHelper()
        {

        }

        public ISessionFactory CreateSessionFactory()
        {
            try
            {
                return Fluently.Configure()
                 .Database(PostgreSQLConfiguration.Standard.ConnectionString(c =>
                 c.Host("Localhost")
                 .Username("postgres")
                 .Port(5432)
                 .Database("Teste")
                 .Password("brendo")))
                 .Mappings(m => m.AutoMappings.Add(AutoMap.Assembly(Assembly.GetExecutingAssembly())
                 .Where(t => t.Namespace == "MyForms.Entity")
                 .UseOverridesFromAssemblyOf<UserMapping>()))
                 .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                 .BuildSessionFactory();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = CreateSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }
    }
    public interface INhibernateHelper
    {
        ISessionFactory CreateSessionFactory();
        ISession OpenSession();
    }
}
