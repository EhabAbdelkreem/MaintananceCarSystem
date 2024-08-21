using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = serenity_carsystem.Car.COM.carRow;

namespace serenity_carsystem.Car.COM;

public interface IcarDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class carDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IcarDeleteHandler
{
    public carDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}