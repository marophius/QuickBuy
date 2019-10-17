using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Repositorio.Repos;
using QuickBuy.Dominio.Entities;


namespace QuickBuy.Repositorio
{
    public class Client
    {
        public Client()
        {
            var userRepos = new UserRepos();
            var produto = new Product();

            userRepos.Add(new User());
        }
    }
}
