﻿using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.Interfaces;

namespace QuickBuy.Repositorio.Repos
{
    public class UserRepos : BaseRepos<User>, IUserRepos
    {
        public UserRepos()
        {

        }
    }
}
