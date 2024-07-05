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
    public class NhibernateHelper
    {
        private ISessionFactory? _sessionFactory;

        private ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                 .Database(PostgreSQLConfiguration.Standard.ConnectionString(c =>
                 c.Host("Localhost")
                 .Username("postgres")
                 .Port(5432)
                 .Database("Teste")
                 .Password("softlog")))
                 .Mappings(m => m.AutoMappings.Add(AutoMap.Assembly(Assembly.GetExecutingAssembly())
                 .Where(t => t.Namespace == "MyForms.Mapping")
                 .UseOverridesFromAssemblyOf<UserMapping>()))
                 .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, true))
                 .BuildSessionFactory();
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
}
