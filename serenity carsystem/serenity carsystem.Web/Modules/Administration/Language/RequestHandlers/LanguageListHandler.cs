using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<serenity_carsystem.Administration.LanguageRow>;
using MyRow = serenity_carsystem.Administration.LanguageRow;


namespace serenity_carsystem.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}