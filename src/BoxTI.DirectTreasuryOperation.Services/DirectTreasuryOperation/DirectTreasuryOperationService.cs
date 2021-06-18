using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using BoxTI.DirectTreasuryOperation.Services.Extensions;
using System.Collections.Generic;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using BoxTI.DirectTreasuryOperation.API.Models.DTO;

namespace BoxTI.DirectTreasuryOperation.Services
{
    
    public class DirectTreasuryOperationService : IDirectTreasuryOperationService
    {
        private readonly IDirectTreasuryRepository _directTreasuryOperationRepository;

        public DirectTreasuryOperationService(IDirectTreasuryRepository repository)
        {
            _directTreasuryOperationRepository = repository;
        }

        public void GetCsvFileAndSave()
        {
            var path = @"~\OperacoesTesouroDireto.csv".ParseHome();

            using (var streamReader = new StreamReader(path))
            {
                using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                csvReader.Context.RegisterClassMap<DirectTreasuryOperationsDTO>();

                while (csvReader.Read())
                {
                    Add(csvReader.GetRecord<DirectTreasuryOperations>());
                }
            }
        }

        public void Add(DirectTreasuryOperations entity)
        {
            _directTreasuryOperationRepository.Add(entity);
        }

        public IEnumerable<DirectTreasuryOperations> All()
        {
            return _directTreasuryOperationRepository.All();
        }

        public DirectTreasuryOperations Get(string id)
        {
            return _directTreasuryOperationRepository.Get(x => x.Id == id);
        }

        public void Delete(string id)
        {
            var entity = _directTreasuryOperationRepository.Get(x => x.Id == id);
            _directTreasuryOperationRepository.Delete(entity);
        }
    }
}