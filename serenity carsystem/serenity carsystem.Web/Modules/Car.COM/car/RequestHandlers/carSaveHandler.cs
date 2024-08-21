using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<serenity_carsystem.Car.COM.carRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = serenity_carsystem.Car.COM.carRow;

namespace serenity_carsystem.Car.COM;

public interface IcarSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class carSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IcarSaveHandler
{
    public carSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}