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
    /// Serviço pra concretizar as operações CRUD de movimentos.
    /// </summary>
    public class MovementService : IMovementRepository
    {
        private readonly IMovementRepository _repository;

        /// <summary>
        /// Construtor do serviço de movimentos.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public MovementService(AppDbContext context)
        {
            _repository = new MovementRepository(context);
        }

        /// <GetAll />
        public async Task<List<Movement>> GetAll()
        {
            return await _repository.GetAll();
        }

        /// <GetById />
        public async Task<Movement> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        /// <Insert />
        public async Task<Movement> Add(Movement movement)
        {
            if (movement == null)
                throw new ArgumentNullException(nameof(movement));

            return await _repository.Add(movement);
        }

        /// <Put />
        public async Task<Movement> Update(Movement movement)
        {
            if (movement == null)
                throw new ArgumentNullException(nameof(movement));

            return await _repository.Update(movement);
        }

        /// <Delete />
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}