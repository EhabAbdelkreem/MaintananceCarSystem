using MyRequest = serenity_carsystem.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<serenity_carsystem.Administration.UserRow>;
using MyRow = serenity_carsystem.Administration.UserRow;

namespace serenity_carsystem.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}