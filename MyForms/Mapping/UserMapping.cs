using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MyForms.Entity;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace MyForms.Mapping
{
    public class UserMapping : IAutoMappingOverride<User>
    {
        public void Override(AutoMapping<User> _User) 
        {
            _User.Table("t_usuario");
            _User.Id(x => x.Id).Column("id");
            _User.Map(x => x.Name).Column("nome");
            _User.Map(x=> x.Email).Column("email");
            _User.Map(x=> x.Login).Column("login");
            _User.Map(x => x.Password).Column("senha");
        }
    }
}
