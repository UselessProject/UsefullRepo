using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dreamlines.DAL;
using Dreamlines.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Dreamlines.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyMDBController<TEntity, TRepository> : ControllerBase
         where TEntity : class, IEntity
         where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public MyMDBController(TRepository repository)
        {
            this.repository = repository;
        }
    }
}
