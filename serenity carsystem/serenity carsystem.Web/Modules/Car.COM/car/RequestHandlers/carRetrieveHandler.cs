using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<serenity_carsystem.Car.COM.carRow>;
using MyRow = serenity_carsystem.Car.COM.carRow;

namespace serenity_carsystem.Car.COM;

public interface IcarRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class carRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IcarRetrieveHandler
{
    public carRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}