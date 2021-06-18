using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using CsvHelper.Configuration;

namespace BoxTI.DirectTreasuryOperation.API.Models.DTO
{
    public class DirectTreasuryOperationsDTO : ClassMap<DirectTreasuryOperations>
    {
        public DirectTreasuryOperationsDTO()
        {
            Map(x => x.InvestorCode).Name("Codigo do Investidor");
            Map(x => x.OperationDate).Name("Data da Operacao");
            Map(x => x.TitleType).Name("Tipo Titulo");
            Map(x => x.TitleMaturityDate).Name("Vencimento do Titulo");
            Map(x => x.Quantity).Name("Quantidade");
            Map(x => x.TitleAmount).Name("Valor do Titulo");
            Map(x => x.OperationAmount).Name("Valor da Operacao");
        }
    }
}
