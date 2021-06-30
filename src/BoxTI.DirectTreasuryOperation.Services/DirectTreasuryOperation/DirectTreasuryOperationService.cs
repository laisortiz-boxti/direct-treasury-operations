using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using BoxTI.DirectTreasuryOperation.Services.Extensions;
using System.Collections.Generic;
using CsvHelper;
using System.IO;
using System.Globalization;
using BoxTI.DirectTreasuryOperation.API.Models.DTO;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Services
{
    public class DirectTreasuryOperationService : IDirectTreasuryOperationService
    {
        private readonly string _path = @"~\OperacoesTesouroDireto.csv".ParseHome();
        private readonly IDirectTreasuryRepository _directTreasuryOperationRepository;

        public DirectTreasuryOperationService(IDirectTreasuryRepository repository)
        {
            _directTreasuryOperationRepository = repository;
        }

        public void GetCsvFile()
        {
            using (var streamReader = new StreamReader(_path))
            {
                using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                csvReader.Context.RegisterClassMap<DirectTreasuryOperationsDTO>();
                var results = csvReader.GetRecords<DirectTreasuryOperations>();

                _directTreasuryOperationRepository.AddRangeAsync(results);
            }
        }

        public async Task Add(DirectTreasuryOperations entity)
        {
            await _directTreasuryOperationRepository.AddAsync(entity);
        }

        public IEnumerable<DirectTreasuryOperations> GetAll()
        {
            return _directTreasuryOperationRepository.GetAll();
        }

        public async Task Update(DirectTreasuryOperations entity)
        {
            await _directTreasuryOperationRepository.UpdateAsync(entity);
        }

        public async Task<DirectTreasuryOperations> Get(string id)
        {
            return await _directTreasuryOperationRepository.GetAsync(x => x.Id == id);
        }

        public async Task Delete(string id)
        {
            await _directTreasuryOperationRepository.DeleteAsync(id);
        }
    }
}