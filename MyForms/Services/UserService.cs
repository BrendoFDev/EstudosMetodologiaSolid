using MyForms.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyForms.Factory;
using NHibernate;
using System.Transactions;
using FluentNHibernate.Cfg.Db;
using Newtonsoft.Json;

namespace MyForms.Services
{
    public class UserService : IUserService
    {
        private readonly INhibernateHelper SessionFactory;

        public UserService(INhibernateHelper nhibernateHelper)
        {
            this.SessionFactory = nhibernateHelper;
        }
        
        public void Save(User user)
        {
            using (ISession persistence = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = persistence.BeginTransaction())
                {
                    transaction.Begin();
                    persistence.Clear();

                    persistence.Save(user);

                    transaction.Commit();
                    persistence.Disconnect();
                }
            }
        }

        public void Update(User user)
        {
            using(ISession persistence = SessionFactory.OpenSession())
            {
                using(ITransaction transaction = persistence.BeginTransaction())
                {
                    transaction.Begin();
                    persistence.Clear();

                    persistence.Update(user);

                    transaction.Commit();
                    persistence.Disconnect();
                }
            }
        }

        public void Delete(User user)
        {
            using(ISession persistence = SessionFactory.OpenSession())
            {
                using(ITransaction transaction = persistence.BeginTransaction())
                {
                    transaction.Begin();
                    persistence.Clear();

                    persistence.Delete(user);

                    transaction.Commit();
                    persistence.Disconnect();
                }
            }
        }

        public string LoadQuery(string Query)
        {
            using (ISession persistence = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = persistence.BeginTransaction())
                {
                    transaction.Begin();
                    persistence.Clear();

                    IQuery query = persistence.CreateQuery(Query);

                    transaction.Commit();
                    persistence.Disconnect();
                    return JsonConvert.SerializeObject(query.List<User>());
                }
            }
        }

    }

    public interface IUserService
    {
        void Save(User user);
        void Update(User user);
        void Delete(User user);
        string LoadQuery(string query);
    }

}
