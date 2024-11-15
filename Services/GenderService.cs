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
    /// Serviço pra concretizar as operações CRUD de gêneros.
    /// </summary>
    public class GenderService : IGenderRepository
    {
        private readonly IGenderRepository _repository;

        /// <summary>
        /// Construtor do serviço de gêneros.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public GenderService(AppDbContext context)
        {
            _repository = new GenderRepository(context);
        }

        /// <GetAll />
        public async Task<List<Gender>> GetAll()
        {
            return await _repository.GetAll();
        }

        /// <GetById />
        public async Task<Gender> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        /// <Insert />
        public async Task<Gender> Add(Gender gender)
        {
            if (gender == null)
                throw new ArgumentNullException(nameof(gender));

            return await _repository.Add(gender);
        }

        /// <Put />
        public async Task<Gender> Update(Gender gender)
        {
            if (gender == null)
                throw new ArgumentNullException(nameof(gender));

            return await _repository.Update(gender);
        }

        /// <Delete />
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}