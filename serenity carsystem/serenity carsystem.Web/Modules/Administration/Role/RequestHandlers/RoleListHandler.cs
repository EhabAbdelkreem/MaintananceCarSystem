using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<serenity_carsystem.Administration.RoleRow>;
using MyRow = serenity_carsystem.Administration.RoleRow;


namespace serenity_carsystem.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}