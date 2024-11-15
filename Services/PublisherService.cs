using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Livraria_Projeto.Database;
using Livraria_Projeto.Interfaces;
using Livraria_Projeto.Models;
using Livraria_Projeto.Repositories;

namespace Livraria_Projeto.Services
{
    /// <summary>
    /// Serviço pra concretizar as operações CRUD de editoras.
    /// </summary>
    public class PublisherService : IPublisherRepository
    {
        private readonly IPublisherRepository _repository;

        /// <summary>
        /// Construtor do serviço de editoras.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public PublisherService(AppDbContext context)
        {
            _repository = new PublisherRepository(context);
        }

        /// <GetAll />
        public async Task<List<Publisher>> GetAll()
        {
            return await _repository.GetAll();
        }

        /// <GetById />
        public async Task<Publisher> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        /// <Insert />
        public async Task<Publisher> Add(Publisher publisher)
        {
            if (publisher == null)
                throw new ArgumentNullException(nameof(publisher));

            return await _repository.Add(publisher);
        }

        /// <Put />
        public async Task<Publisher> Update(Publisher publisher)
        {
            if (publisher == null)
                throw new ArgumentNullException(nameof(publisher));

            return await _repository.Update(publisher);
        }

        /// <Delete />
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}