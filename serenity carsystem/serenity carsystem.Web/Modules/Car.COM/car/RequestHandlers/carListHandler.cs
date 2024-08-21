using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<serenity_carsystem.Car.COM.carRow>;
using MyRow = serenity_carsystem.Car.COM.carRow;

namespace serenity_carsystem.Car.COM;

public interface IcarListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class carListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IcarListHandler
{
    public carListHandler(IRequestContext context)
            : base(context)
    {
    }
}