using MyRequest = Serenity.Services.SaveRequest<serenity_carsystem.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = serenity_carsystem.Administration.LanguageRow;


namespace serenity_carsystem.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}